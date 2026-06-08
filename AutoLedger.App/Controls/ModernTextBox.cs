using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{
    public class ModernTextBox : Control
    {
        private string text = string.Empty;
        private string placeholder = string.Empty;
        private Color placeholderColor = Color.Gray;
        private Color borderColor = Color.LightGray;
        private Color borderFocusColor = Color.DodgerBlue;
        private int cornerRadius = 4;
        private int caretPosition = 0;
        private int selectionStart = -1;
        private int selectionLength = 0;
        private bool isFocused = false;
        private Timer caretTimer;
        private bool caretVisible = true;
        private int scrollOffset = 0;
        private HorizontalAlignment textAlignment = HorizontalAlignment.Left;

        public ModernTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.Selectable, true);

            this.Size = new Size(200, 35);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Cursor = Cursors.IBeam;
            this.TabStop = true;

            caretTimer = new Timer { Interval = 500 };
            caretTimer.Tick += (s, e) => { caretVisible = !caretVisible; Invalidate(); };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                caretTimer?.Stop();
                caretTimer?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Properties

        [Category("Appearance"), DefaultValue("")]
        public override string Text
        {
            get => text;
            set
            {
                text = value ?? string.Empty;
                caretPosition = Math.Min(caretPosition, text.Length);
                selectionStart = -1;
                selectionLength = 0;
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue("")]
        public string Placeholder
        {
            get => placeholder;
            set { placeholder = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set { placeholderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(4)]
        public int CornerRadius
        {
            get => cornerRadius;
            set { cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(HorizontalAlignment.Left)]
        [Description("Horizontal alignment of the text and placeholder.")]
        public HorizontalAlignment TextAlignment
        {
            get => textAlignment;
            set
            {
                textAlignment = value;
                Invalidate();
            }
        }

        #endregion

        #region Focus & Caret

        protected override void OnGotFocus(EventArgs e)
        {
            isFocused = true;
            caretVisible = true;
            caretTimer.Start();
            Invalidate();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            isFocused = false;
            caretTimer.Stop();
            Invalidate();
            base.OnLostFocus(e);
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
            Invalidate();
        }

        #endregion

        #region Painting

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Background
            using (var brush = new SolidBrush(BackColor))
            using (var path = GetRoundedRectPath(ClientRectangle, cornerRadius))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Determine what to draw
            bool showPlaceholder = string.IsNullOrEmpty(text);
            string displayText = showPlaceholder ? placeholder : text;
            Color textColor = showPlaceholder ? placeholderColor : ForeColor;

            TextFormatFlags flags = GetDrawingFlags();

            int leftPad = 4;
            Rectangle textRect = new Rectangle(leftPad - scrollOffset, 0,
                                               Width - 2 * leftPad, Height);

            TextRenderer.DrawText(e.Graphics, displayText, Font, textRect, textColor, flags);

            if (!showPlaceholder)
            {
                int totalWidth = TextRenderer.MeasureText(e.Graphics, text, Font, Size.Empty, flags).Width;
                int blockLeft = GetBlockLeft(totalWidth);

                // Selection highlight
                if (isFocused && selectionLength != 0)
                {
                    int selStart = Math.Min(selectionStart, selectionStart + selectionLength);
                    int selLen = Math.Abs(selectionLength);
                    int selEnd = selStart + selLen - 1;

                    int x1 = CharLeftEdge(selStart, blockLeft, totalWidth, flags, e.Graphics);
                    int x2 = CharRightEdge(selEnd, blockLeft, totalWidth, flags, e.Graphics);
                    Rectangle selRect = new Rectangle(Math.Min(x1, x2), textRect.Top,
                                                      Math.Abs(x2 - x1), textRect.Height);

                    using (var selBrush = new SolidBrush(Color.FromArgb(173, 214, 255)))
                        e.Graphics.FillRectangle(selBrush, selRect);

                    Region oldClip = e.Graphics.Clip;
                    e.Graphics.SetClip(selRect);
                    TextRenderer.DrawText(e.Graphics, text, Font, textRect, ForeColor, flags);
                    e.Graphics.Clip = oldClip;
                }

                // Caret
                if (isFocused && caretVisible && selectionLength == 0)
                {
                    int caretX;
                    if (RightToLeft == RightToLeft.Yes)
                        caretX = blockLeft + totalWidth - PrefixWidth(caretPosition, flags, e.Graphics);
                    else
                        caretX = blockLeft + PrefixWidth(caretPosition, flags, e.Graphics);

                    int caretHeight = Font.Height;
                    int yCenter = (Height - caretHeight) / 2;
                    using (var pen = new Pen(Color.Black, 1.5f))
                        e.Graphics.DrawLine(pen, caretX, yCenter, caretX, yCenter + caretHeight);
                }
            }

            // Border
            Color currentBorder = isFocused ? borderFocusColor : borderColor;
            using (var pen = new Pen(currentBorder, 1.5f))
            using (var path = GetRoundedRectPath(ClientRectangle, cornerRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
                path.AddRectangle(rect);
            else
            {
                int d = radius * 2;
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
            }
            return path;
        }

        #endregion

        #region Layout helpers

        private int PrefixWidth(int length, TextFormatFlags flags, Graphics g)
        {
            if (length <= 0) return 0;
            return TextRenderer.MeasureText(g, text.Substring(0, Math.Min(length, text.Length)), Font,
                                            Size.Empty, flags).Width;
        }

        private int CharLeftEdge(int charIndex, int blockLeft, int totalWidth,
                                 TextFormatFlags flags, Graphics g)
        {
            if (charIndex >= text.Length)
                return RightToLeft == RightToLeft.Yes ? blockLeft : blockLeft + totalWidth;

            if (RightToLeft == RightToLeft.Yes)
                return blockLeft + totalWidth - PrefixWidth(charIndex + 1, flags, g);
            else
                return blockLeft + PrefixWidth(charIndex, flags, g);
        }

        private int CharRightEdge(int charIndex, int blockLeft, int totalWidth,
                                  TextFormatFlags flags, Graphics g)
        {
            if (charIndex >= text.Length)
                return RightToLeft == RightToLeft.Yes ? blockLeft : blockLeft + totalWidth;

            if (RightToLeft == RightToLeft.Yes)
                return blockLeft + totalWidth - PrefixWidth(charIndex, flags, g);
            else
                return blockLeft + PrefixWidth(charIndex + 1, flags, g);
        }

        private int GetBlockLeft(int totalWidth)
        {
            int leftPad = 4;
            TextFormatFlags flags = GetDrawingFlags();
            if ((flags & TextFormatFlags.Right) != 0)
                return Width - leftPad - totalWidth;
            else if ((flags & TextFormatFlags.HorizontalCenter) != 0)
                return leftPad + (Width - 2 * leftPad - totalWidth) / 2;
            else
                return leftPad;
        }

        private TextFormatFlags GetDrawingFlags()
        {
            TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix;
            if (RightToLeft == RightToLeft.Yes)
            {
                flags |= TextFormatFlags.RightToLeft;
                if (textAlignment == HorizontalAlignment.Left)
                    flags |= TextFormatFlags.Right;
                else if (textAlignment == HorizontalAlignment.Right)
                    flags |= TextFormatFlags.Left;
                else
                    flags |= TextFormatFlags.HorizontalCenter;
            }
            else
            {
                if (textAlignment == HorizontalAlignment.Left)
                    flags |= TextFormatFlags.Left;
                else if (textAlignment == HorizontalAlignment.Right)
                    flags |= TextFormatFlags.Right;
                else
                    flags |= TextFormatFlags.HorizontalCenter;
            }
            return flags;
        }

        #endregion

        #region Mouse input

        private int GetCaretIndexFromPoint(int x)
        {
            using (Graphics g = CreateGraphics())
            {
                TextFormatFlags flags = GetDrawingFlags();
                int totalWidth = TextRenderer.MeasureText(g, text, Font, Size.Empty, flags).Width;
                int blockLeft = GetBlockLeft(totalWidth);

                if (RightToLeft == RightToLeft.Yes)
                {
                    for (int i = 0; i <= text.Length; i++)
                    {
                        int leftEdge = blockLeft + totalWidth - PrefixWidth(i, flags, g);
                        if (x >= leftEdge)
                            return i;
                    }
                    return text.Length;
                }
                else
                {
                    for (int i = 0; i <= text.Length; i++)
                    {
                        int rightEdge = blockLeft + PrefixWidth(i, flags, g);
                        if (x < rightEdge)
                            return i;
                    }
                    return text.Length;
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!this.Focused) this.Focus();

            int newPos = GetCaretIndexFromPoint(e.X + scrollOffset);
            caretPosition = newPos;
            selectionStart = newPos;
            selectionLength = 0;
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newPos = GetCaretIndexFromPoint(e.X + scrollOffset);
                // If selection hasn't been started, start it from the current caret position.
                if (selectionStart == -1)
                    selectionStart = caretPosition;
                caretPosition = newPos;
                selectionLength = newPos - selectionStart;
                Invalidate();
            }
            base.OnMouseMove(e);
        }

        #endregion

        #region Keyboard input

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                DeleteSelection();
                text = text.Insert(caretPosition, e.KeyChar.ToString());
                caretPosition++;
                selectionStart = -1;
                Invalidate();
            }
            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (selectionLength != 0)
                    DeleteSelection();
                else if (caretPosition > 0)
                {
                    text = text.Remove(caretPosition - 1, 1);
                    caretPosition--;
                }
                Invalidate();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (selectionLength != 0)
                    DeleteSelection();
                else if (caretPosition < text.Length)
                    text = text.Remove(caretPosition, 1);
                Invalidate();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (e.Shift)
                {
                    int newPos = Math.Max(0, caretPosition - 1);
                    if (selectionLength == 0) selectionStart = caretPosition;
                    caretPosition = newPos;
                    selectionLength = caretPosition - selectionStart;
                }
                else
                {
                    if (selectionLength != 0)
                    {
                        caretPosition = Math.Min(selectionStart, selectionStart + selectionLength);
                    }
                    else
                    {
                        caretPosition = Math.Max(0, caretPosition - 1);
                    }
                    selectionStart = -1;
                    selectionLength = 0;
                }
                Invalidate();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (e.Shift)
                {
                    int newPos = Math.Min(text.Length, caretPosition + 1);
                    if (selectionLength == 0) selectionStart = caretPosition;
                    caretPosition = newPos;
                    selectionLength = caretPosition - selectionStart;
                }
                else
                {
                    if (selectionLength != 0)
                    {
                        caretPosition = Math.Max(selectionStart, selectionStart + selectionLength);
                    }
                    else
                    {
                        caretPosition = Math.Min(text.Length, caretPosition + 1);
                    }
                    selectionStart = -1;
                    selectionLength = 0;
                }
                Invalidate();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                if (selectionLength != 0)
                {
                    int start = Math.Min(selectionStart, selectionStart + selectionLength);
                    Clipboard.SetText(text.Substring(start, Math.Abs(selectionLength)));
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string clip = Clipboard.GetText();
                if (!string.IsNullOrEmpty(clip))
                {
                    DeleteSelection();
                    text = text.Insert(caretPosition, clip);
                    caretPosition += clip.Length;
                    Invalidate();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        private void DeleteSelection()
        {
            if (selectionLength != 0)
            {
                int start = Math.Min(selectionStart, selectionStart + selectionLength);
                int len = Math.Abs(selectionLength);
                text = text.Remove(start, len);
                caretPosition = start;
                selectionStart = -1;
                selectionLength = 0;
            }
        }

        #endregion
    }
}