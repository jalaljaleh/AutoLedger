using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{
    public class ModernTextBox : Control
    {
        private string _text = string.Empty;
        private string _placeholder = string.Empty;
        private Color _placeholderColor = Color.Gray;
        private Color _borderColor = Color.LightGray;
        private Color _borderFocusColor = Color.DodgerBlue;
        private int _cornerRadius = 4;
        private int _maxLength = 0;             // 0 = بدون محدودیت
        private bool _numbersOnly = false;

        private int caretPosition = 0;
        private int selectionStart = 0;
        private int selectionLength = 0;
        private bool isFocused = false;

        private Timer caretTimer;
        private bool caretVisible = true;

        private HorizontalAlignment textAlignment = HorizontalAlignment.Left;

        public ModernTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.Selectable, true);

            Size = new Size(200, 35);
            BackColor = Color.White;
            ForeColor = Color.Black;
            Cursor = Cursors.IBeam;
            TabStop = true;

            caretTimer = new Timer { Interval = 500 };
            caretTimer.Tick += CaretTimer_Tick;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (caretTimer != null)
                {
                    caretTimer.Tick -= CaretTimer_Tick;
                    caretTimer.Stop();
                    caretTimer.Dispose();
                    caretTimer = null;
                }
            }
            base.Dispose(disposing);
        }

        private void CaretTimer_Tick(object sender, EventArgs e)
        {
            caretVisible = !caretVisible;
            Invalidate();
        }

        #region Properties

        [Category("Behavior"), DefaultValue(0),
         Description("حداکثر تعداد کاراکتر مجاز. 0 = نامحدود")]
        public int MaxLength
        {
            get => _maxLength;
            set
            {
                _maxLength = Math.Max(0, value);
                // اگر متن فعلی طولانی‌تر از حد جدید باشد کوتاه می‌شود
                if (_maxLength > 0 && _text.Length > _maxLength)
                {
                    _text = _text.Substring(0, _maxLength);
                    caretPosition = Math.Min(caretPosition, _text.Length);
                    ClearSelection();
                }
                Invalidate();
            }
        }

        [Category("Behavior"), DefaultValue(false),
         Description("فقط ورودی عددی (۰-۹) مجاز باشد")]
        public bool NumbersOnly
        {
            get => _numbersOnly;
            set
            {
                _numbersOnly = value;
                if (_numbersOnly)
                {
                    // حذف کاراکترهای غیرعددی از متن فعلی
                    string filtered = new string(_text.Where(char.IsDigit).ToArray());
                    if (filtered != _text)
                    {
                        _text = filtered;
                        caretPosition = Math.Min(caretPosition, _text.Length);
                        ClearSelection();
                    }
                }
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue("")]
        public override string Text
        {
            get => _text;
            set
            {
                string newText = value ?? string.Empty;

                // اعمال فیلتر NumbersOnly
                if (_numbersOnly)
                    newText = new string(newText.Where(char.IsDigit).ToArray());

                // اعمال MaxLength
                if (_maxLength > 0 && newText.Length > _maxLength)
                    newText = newText.Substring(0, _maxLength);

                _text = newText;
                caretPosition = Math.Min(caretPosition, _text.Length);
                ClearSelection();
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue("")]
        public string Placeholder
        {
            get => _placeholder;
            set { _placeholder = value ?? string.Empty; Invalidate(); }
        }

        [Category("Appearance")]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set { _placeholderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderFocusColor
        {
            get => _borderFocusColor;
            set { _borderFocusColor = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(4)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlignment
        {
            get => textAlignment;
            set { textAlignment = value; Invalidate(); }
        }

        #endregion

        #region Focus & Caret

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            isFocused = true;
            caretVisible = true;
            caretTimer?.Start();
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            isFocused = false;
            caretTimer?.Stop();
            caretVisible = false;
            ClearSelection();
            Invalidate();
        }

        #endregion

        #region Painting

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Background with rounded corners
            using (var brush = new SolidBrush(BackColor))
            using (var path = GetRoundedRectPath(ClientRectangle, _cornerRadius))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Prepare text and flags
            bool showPlaceholder = string.IsNullOrEmpty(_text);
            string displayText = showPlaceholder ? _placeholder : _text;
            Color drawColor = showPlaceholder ? _placeholderColor : ForeColor;

            TextFormatFlags flags = GetDrawingFlags();

            int padding = 6;
            Rectangle textRect = new Rectangle(padding, 0, Width - 2 * padding, Height);

            // Draw text
            TextRenderer.DrawText(e.Graphics, displayText, Font, textRect, drawColor, flags);

            // If we have real text, draw selection and caret
            if (!showPlaceholder && (_text.Length > 0 || isFocused))
            {
                // measure full text width once
                int fullWidth = TextRenderer.MeasureText(e.Graphics, _text, Font, Size.Empty, flags).Width;
                int blockLeft = GetBlockLeft(fullWidth, padding);

                // Selection
                if (selectionLength != 0)
                {
                    int selStart = Math.Max(0, Math.Min(selectionStart, _text.Length));
                    int selLen = Math.Max(0, Math.Min(selectionLength, _text.Length - selStart));

                    int x1 = blockLeft + MeasureTextWidth(_text.Substring(0, selStart), flags, e.Graphics);
                    int x2 = blockLeft + MeasureTextWidth(_text.Substring(0, selStart + selLen), flags, e.Graphics);

                    Rectangle selRect = new Rectangle(Math.Min(x1, x2), textRect.Top, Math.Abs(x2 - x1), textRect.Height);
                    using (var selBrush = new SolidBrush(Color.FromArgb(173, 214, 255)))
                        e.Graphics.FillRectangle(selBrush, selRect);

                    // draw selected text over selection
                    Region oldClip = e.Graphics.Clip;
                    e.Graphics.SetClip(selRect);
                    TextRenderer.DrawText(e.Graphics, _text, Font, textRect, ForeColor, flags);
                    e.Graphics.Clip = oldClip;
                }

                // Caret
                if (isFocused && caretVisible && selectionLength == 0)
                {
                    int caretX = blockLeft + MeasureTextWidth(_text.Substring(0, Math.Min(caretPosition, _text.Length)), flags, e.Graphics);
                    int caretHeight = Font.Height;
                    int y = (Height - caretHeight) / 2;
                    using (var pen = new Pen(ForeColor, 1f))
                        e.Graphics.DrawLine(pen, caretX, y, caretX, y + caretHeight);
                }
            }

            // Border
            Color currentBorder = isFocused ? _borderFocusColor : _borderColor;
            using (var pen = new Pen(currentBorder, 1.5f))
            using (var path = GetRoundedRectPath(ClientRectangle, _cornerRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private int MeasureTextWidth(string s, TextFormatFlags flags, Graphics g)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            return TextRenderer.MeasureText(g, s, Font, Size.Empty, flags).Width;
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
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

        private int GetBlockLeft(int totalWidth, int leftPad)
        {
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
                int totalWidth = TextRenderer.MeasureText(g, _text, Font, Size.Empty, flags).Width;
                int blockLeft = GetBlockLeft(totalWidth, 6);

                for (int i = 0; i <= _text.Length; i++)
                {
                    int w = MeasureTextWidth(_text.Substring(0, i), flags, g);
                    int charRight = blockLeft + w;
                    if (x <= charRight) return i;
                }
                return _text.Length;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!Focused) Focus();

            int newPos = GetCaretIndexFromPoint(e.X);
            caretPosition = Math.Max(0, Math.Min(newPos, _text.Length));
            selectionStart = caretPosition;
            selectionLength = 0;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left && isFocused)
            {
                int newPos = GetCaretIndexFromPoint(e.X);
                int pos = Math.Max(0, Math.Min(newPos, _text.Length));
                selectionLength = pos - selectionStart;
                caretPosition = pos;
                Invalidate();
            }
        }

        #endregion

        #region Keyboard input

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // اگر کنترل‌کاراکتر نباشد (مانند Backspace, Delete) و فقط عدد مجاز باشد
            if (!char.IsControl(e.KeyChar))
            {
                // اعمال فیلتر NumbersOnly
                if (_numbersOnly && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;   // کاراکتر غیرمجاز را نادیده بگیر
                    return;
                }

                DeleteSelectionIfAny(); // اول ناحیه انتخاب‌شده حذف می‌شود

                // بررسی MaxLength
                if (_maxLength > 0 && _text.Length >= _maxLength)
                {
                    e.Handled = true;
                    return;
                }

                _text = _text.Insert(caretPosition, e.KeyChar.ToString());
                caretPosition++;
                ClearSelection();
                Invalidate();
                e.Handled = true;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Back)
            {
                if (selectionLength != 0) DeleteSelectionIfAny();
                else if (caretPosition > 0)
                {
                    _text = _text.Remove(caretPosition - 1, 1);
                    caretPosition--;
                }
                ClearSelection();
                Invalidate();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (selectionLength != 0) DeleteSelectionIfAny();
                else if (caretPosition < _text.Length)
                    _text = _text.Remove(caretPosition, 1);

                ClearSelection();
                Invalidate();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (e.Shift)
                {
                    if (selectionLength == 0) selectionStart = caretPosition;
                    caretPosition = Math.Max(0, caretPosition - 1);
                    selectionLength = caretPosition - selectionStart;
                }
                else
                {
                    if (selectionLength != 0)
                        caretPosition = Math.Min(selectionStart, selectionStart + selectionLength);
                    else
                        caretPosition = Math.Max(0, caretPosition - 1);

                    ClearSelection();
                }
                Invalidate();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (e.Shift)
                {
                    if (selectionLength == 0) selectionStart = caretPosition;
                    caretPosition = Math.Min(_text.Length, caretPosition + 1);
                    selectionLength = caretPosition - selectionStart;
                }
                else
                {
                    if (selectionLength != 0)
                        caretPosition = Math.Max(selectionStart, selectionStart + selectionLength);
                    else
                        caretPosition = Math.Min(_text.Length, caretPosition + 1);

                    ClearSelection();
                }
                Invalidate();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                if (selectionLength != 0)
                {
                    int start = Math.Min(selectionStart, selectionStart + selectionLength);
                    int len = Math.Abs(selectionLength);
                    Clipboard.SetText(_text.Substring(start, len));
                }
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string clip = Clipboard.GetText();
                if (!string.IsNullOrEmpty(clip))
                {
                    // فیلتر NumbersOnly روی متن چسبانده‌شده
                    if (_numbersOnly)
                        clip = new string(clip.Where(char.IsDigit).ToArray());

                    if (!string.IsNullOrEmpty(clip))
                    {
                        DeleteSelectionIfAny();

                        // بررسی MaxLength
                        int spaceLeft = (_maxLength > 0) ? _maxLength - _text.Length : int.MaxValue;
                        if (spaceLeft > 0)
                        {
                            if (clip.Length > spaceLeft)
                                clip = clip.Substring(0, spaceLeft);

                            _text = _text.Insert(caretPosition, clip);
                            caretPosition += clip.Length;
                            ClearSelection();
                            Invalidate();
                        }
                    }
                }
                e.Handled = true;
            }
        }

        private void DeleteSelectionIfAny()
        {
            if (selectionLength != 0)
            {
                int start = Math.Min(selectionStart, selectionStart + selectionLength);
                int len = Math.Abs(selectionLength);
                _text = _text.Remove(start, len);
                caretPosition = start;
                ClearSelection();
            }
        }

        private void ClearSelection()
        {
            selectionStart = 0;
            selectionLength = 0;
        }

        #endregion
    }
}