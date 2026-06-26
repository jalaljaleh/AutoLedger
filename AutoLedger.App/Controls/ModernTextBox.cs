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
        // Core text storage (keeps compatibility with existing usage)
        private string _text = string.Empty;
        private string _placeholder = string.Empty;

        // Appearance
        private Color _accentColor = Color.FromArgb(0, 120, 215); // modern accent
        private Color _placeholderColor = Color.FromArgb(140, 140, 140);
        private Color _borderColor = Color.FromArgb(200, 200, 200);
        private Color _hoverColor = Color.FromArgb(230, 230, 230);
        private int _cornerRadius = 6;
        private int _padding = 10;
        private int _iconSize = 18;

        // Behavior
        private int _maxLength = 0; // 0 = unlimited
        private bool _numbersOnly = false;
        private char _passwordChar = '\0';
        private bool _showClearButton = true;
        private Image _icon = null;

        // Caret & selection
        private int caretPosition = 0;
        private int selectionStart = 0;
        private int selectionLength = 0;
        private bool isFocused = false;
        private Timer caretTimer;
        private bool caretVisible = true;

        // Floating label animation
        private float labelProgress = 0f; // 0 = placeholder inline, 1 = floating small label
        private Timer animTimer;
        private bool animTargetFloating = false;

        // DPI-aware measurement helper
        private StringFormat stringFormat = new StringFormat(StringFormat.GenericDefault);

        // Text alignment
        private HorizontalAlignment textAlignment = HorizontalAlignment.Left;

        public ModernTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.Selectable, true);

            Size = new Size(260, 40);
            BackColor = Color.White;
            ForeColor = Color.FromArgb(30, 30, 30);
            Cursor = Cursors.IBeam;
            TabStop = true;

            // caret blink
            caretTimer = new Timer { Interval = 500 };
            caretTimer.Tick += (s, e) => { caretVisible = !caretVisible; Invalidate(); };

            // animation timer (smooth)
            animTimer = new Timer { Interval = 15 };
            animTimer.Tick += AnimTimer_Tick;

            // string format for vertical centering
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Near;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                caretTimer?.Dispose();
                animTimer?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            const float step = 0.12f;
            if (animTargetFloating)
            {
                labelProgress = Math.Min(1f, labelProgress + step);
                if (labelProgress >= 1f) animTimer.Stop();
            }
            else
            {
                labelProgress = Math.Max(0f, labelProgress - step);
                if (labelProgress <= 0f) animTimer.Stop();
            }
            Invalidate();
        }

        #region Properties

        [Category("Behavior"), DefaultValue(0),
         Description("Maximum allowed characters. 0 = unlimited")]
        public int MaxLength
        {
            get => _maxLength;
            set
            {
                _maxLength = Math.Max(0, value);
                if (_maxLength > 0 && _text.Length > _maxLength)
                {
                    _text = _text.Substring(0, _maxLength);
                    caretPosition = Math.Min(caretPosition, _text.Length);
                    ClearSelection();
                    OnTextChangedInternal();
                }
                Invalidate();
            }
        }

        [Category("Behavior"), DefaultValue(false),
         Description("Allow only numeric input")]
        public bool NumbersOnly
        {
            get => _numbersOnly;
            set
            {
                _numbersOnly = value;
                if (_numbersOnly)
                {
                    string filtered = new string(_text.Where(char.IsDigit).ToArray());
                    if (filtered != _text)
                    {
                        _text = filtered;
                        caretPosition = Math.Min(caretPosition, _text.Length);
                        ClearSelection();
                        OnTextChangedInternal();
                    }
                }
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color AccentColor
        {
            get => _accentColor;
            set { _accentColor = value; Invalidate(); }
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
        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(6)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Behavior"), DefaultValue('\0'),
         Description("Set to a non-zero char to mask input (password)")]
        public char PasswordChar
        {
            get => _passwordChar;
            set { _passwordChar = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(true)]
        public bool ShowClearButton
        {
            get => _showClearButton;
            set { _showClearButton = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Image Icon
        {
            get => _icon;
            set { _icon = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlignment
        {
            get => textAlignment;
            set { textAlignment = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue("")]
        public override string Text
        {
            get => _text;
            set
            {
                string newText = value ?? string.Empty;
                if (_numbersOnly)
                    newText = new string(newText.Where(char.IsDigit).ToArray());
                if (_maxLength > 0 && newText.Length > _maxLength)
                    newText = newText.Substring(0, _maxLength);

                if (_text != newText)
                {
                    _text = newText;
                    caretPosition = Math.Min(caretPosition, _text.Length);
                    ClearSelection();
                    UpdateFloatingTarget();
                    OnTextChangedInternal();
                    Invalidate();
                }
            }
        }

        [Category("Appearance"), DefaultValue("")]
        public string Placeholder
        {
            get => _placeholder;
            set { _placeholder = value ?? string.Empty; UpdateFloatingTarget(); Invalidate(); }
        }

        #endregion

        #region TextChanged helper

        // Ensure we raise the standard TextChanged event for consumers
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        private void OnTextChangedInternal()
        {
            // call the virtual method so subscribers get the event
            OnTextChanged(EventArgs.Empty);
        }

        #endregion

        #region Focus & Caret

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            isFocused = true;
            caretVisible = true;
            caretTimer?.Start();
            UpdateFloatingTarget();
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            isFocused = false;
            caretTimer?.Stop();
            caretVisible = false;
            ClearSelection();
            UpdateFloatingTarget();
            Invalidate();
        }

        private void UpdateFloatingTarget()
        {
            bool shouldFloat = !string.IsNullOrEmpty(_text) || isFocused;
            if (shouldFloat != animTargetFloating)
            {
                animTargetFloating = shouldFloat;
                animTimer.Start();
            }
        }

        #endregion

        #region Painting

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent?.BackColor ?? SystemColors.Control);

            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);

            // background
            using (var bgBrush = new SolidBrush(BackColor))
            using (var path = GetRoundedRectPath(rect, _cornerRadius))
            {
                e.Graphics.FillPath(bgBrush, path);
            }

            // hover highlight
            if (ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                using (var hoverBrush = new SolidBrush(_hoverColor))
                using (var path = GetRoundedRectPath(rect, _cornerRadius))
                {
                    e.Graphics.FillPath(hoverBrush, path);
                }
            }

            // border (thin)
            Color border = isFocused ? _accentColor : _borderColor;
            using (var pen = new Pen(border, isFocused ? 2f : 1f))
            using (var path = GetRoundedRectPath(rect, _cornerRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // compute inner text area
            int left = rect.Left + _padding;
            int right = rect.Right - _padding;
            int centerY = rect.Top + rect.Height / 2;

            // icon
            if (_icon != null)
            {
                Rectangle iconRect = new Rectangle(left, centerY - _iconSize / 2, _iconSize, _iconSize);
                e.Graphics.DrawImage(_icon, iconRect);
                left += _iconSize + 8;
            }

            // clear button area
            Rectangle clearRect = Rectangle.Empty;
            if (_showClearButton && !string.IsNullOrEmpty(_text))
            {
                clearRect = new Rectangle(right - 18, centerY - 9, 18, 18);
                right -= 18 + 6;
            }

            // text area
            Rectangle textRect = new Rectangle(left, rect.Top, Math.Max(0, right - left), rect.Height);

            // floating placeholder / label
            DrawFloatingLabel(e.Graphics, textRect);

            // draw selection background if any
            if (selectionLength != 0)
            {
                int selStart = Math.Min(selectionStart, selectionStart + selectionLength);
                int selLen = Math.Abs(selectionLength);
                Rectangle selRect = GetSelectionRectangle(e.Graphics, textRect, selStart, selLen);
                if (selRect.Width > 0)
                {
                    using (var selBrush = new SolidBrush(Color.FromArgb(180, _accentColor)))
                        e.Graphics.FillRectangle(selBrush, selRect);
                }
            }

            // draw text (masked if password)
            string displayText = _passwordChar != '\0' ? new string(_passwordChar, _text.Length) : _text;

            // Use consistent flags for drawing and measuring
            var drawFlags = GetTextFormatFlags() | TextFormatFlags.NoPadding;
            TextRenderer.DrawText(e.Graphics, displayText, Font, textRect, ForeColor, drawFlags);

            // caret
            if (isFocused && caretVisible && selectionLength == 0)
            {
                int caretX = GetCaretX(e.Graphics, textRect, caretPosition);
                int caretTop = textRect.Top + (textRect.Height - Font.Height) / 2;
                using (var pen = new Pen(ForeColor, 1f))
                {
                    e.Graphics.DrawLine(pen, caretX, caretTop, caretX, caretTop + Font.Height);
                }
            }

            // clear button icon (simple X)
            if (clearRect != Rectangle.Empty)
            {
                using (var p = new Pen(Color.Gray, 2f))
                {
                    e.Graphics.DrawLine(p, clearRect.Left + 3, clearRect.Top + 3, clearRect.Right - 3, clearRect.Bottom - 3);
                    e.Graphics.DrawLine(p, clearRect.Right - 3, clearRect.Top + 3, clearRect.Left + 3, clearRect.Bottom - 3);
                }
            }
        }

        private void DrawFloatingLabel(Graphics g, Rectangle textRect)
        {
            // label floats up and shrinks when labelProgress -> 1
            float smallScale = 0.75f;
            float scale = 1f - (1f - smallScale) * labelProgress;
            int baseY = textRect.Top + (textRect.Height - Font.Height) / 2;
            int floatOffset = (int)(-(Font.Height + 6) * labelProgress);

            // compute label font
            using (var labelFont = new Font(Font.FontFamily, Font.Size * scale, Font.Style))
            {
                // placeholder text when empty, otherwise small label above
                string label = string.IsNullOrEmpty(_text) ? _placeholder : _placeholder;
                Color labelColor = isFocused ? _accentColor : _placeholderColor;

                // when inline (labelProgress ~ 0) draw at baseY; when floating draw smaller above
                RectangleF labelRect = new RectangleF(textRect.Left, baseY + floatOffset, textRect.Width, Font.Height);
                var drawFlags = GetTextFormatFlags() | TextFormatFlags.NoPadding;
                TextRenderer.DrawText(g, label, labelFont, Rectangle.Round(labelRect), labelColor, drawFlags);
            }
        }

        private Rectangle GetSelectionRectangle(Graphics g, Rectangle textRect, int selStart, int selLen)
        {
            if (selLen <= 0) return Rectangle.Empty;
            string before = _text.Substring(0, selStart);
            string sel = _text.Substring(selStart, selLen);

            int x1 = GetCaretX(g, textRect, before.Length);
            int x2 = GetCaretX(g, textRect, before.Length + sel.Length);
            return new Rectangle(Math.Min(x1, x2), textRect.Top + 2, Math.Abs(x2 - x1), textRect.Height - 4);
        }

        private int GetCaretX(Graphics g, Rectangle textRect, int charIndex)
        {
            string s = _passwordChar != '\0' ? new string(_passwordChar, charIndex) : _text.Substring(0, Math.Max(0, Math.Min(charIndex, _text.Length)));
            var flags = GetTextFormatFlags() | TextFormatFlags.NoPadding;
            Size size = TextRenderer.MeasureText(g, s, Font, Size.Empty, flags);
            int x = textRect.Left + size.Width;
            return x;
        }

        private TextFormatFlags GetTextFormatFlags()
        {
            TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine;
            if (textAlignment == HorizontalAlignment.Left) flags |= TextFormatFlags.Left;
            else if (textAlignment == HorizontalAlignment.Center) flags |= TextFormatFlags.HorizontalCenter;
            else flags |= TextFormatFlags.Right;
            return flags;
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            if (radius <= 0) path.AddRectangle(rect);
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

        #region Mouse input

        private int GetCaretIndexFromPoint(int x)
        {
            using (Graphics g = CreateGraphics())
            {
                Rectangle rect = ClientRectangle;
                rect.Inflate(-1, -1);
                int left = rect.Left + _padding;
                if (_icon != null) left += _iconSize + 8;

                var flags = GetTextFormatFlags() | TextFormatFlags.NoPadding;

                for (int i = 0; i <= _text.Length; i++)
                {
                    string s = _passwordChar != '\0' ? new string(_passwordChar, i) : _text.Substring(0, i);
                    int w = TextRenderer.MeasureText(g, s, Font, Size.Empty, flags).Width;
                    int charRight = left + w;
                    if (x <= charRight) return i;
                }
                return _text.Length;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!Focused) Focus();

            // check clear button click
            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);
            int right = rect.Right - _padding;
            Rectangle clearRect = Rectangle.Empty;
            if (_showClearButton && !string.IsNullOrEmpty(_text))
            {
                clearRect = new Rectangle(right - 18, rect.Top + (rect.Height - 18) / 2, 18, 18);
            }
            if (clearRect != Rectangle.Empty && clearRect.Contains(e.Location))
            {
                // Use the Text property so TextChanged is raised
                Text = string.Empty;
                caretPosition = 0;
                ClearSelection();
                Invalidate();
                return;
            }

            int newPos = GetCaretIndexFromPoint(e.X);
            caretPosition = Math.Max(0, Math.Min(newPos, _text.Length));
            // set selection anchor for drag selection
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
            else
            {
                // change cursor over clear button
                Rectangle rect = ClientRectangle;
                rect.Inflate(-1, -1);
                int right = rect.Right - _padding;
                Rectangle clearRect = Rectangle.Empty;
                if (_showClearButton && !string.IsNullOrEmpty(_text))
                    clearRect = new Rectangle(right - 18, rect.Top + (rect.Height - 18) / 2, 18, 18);

                Cursor = (clearRect != Rectangle.Empty && clearRect.Contains(e.Location)) ? Cursors.Hand : Cursors.IBeam;
            }
        }

        #endregion

        #region Keyboard input

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsControl(e.KeyChar))
            {
                if (_numbersOnly && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }

                DeleteSelectionIfAny();

                if (_maxLength > 0 && _text.Length >= _maxLength)
                {
                    e.Handled = true;
                    return;
                }

                _text = _text.Insert(caretPosition, e.KeyChar.ToString());
                caretPosition++;
                ClearSelection();
                UpdateFloatingTarget();
                OnTextChangedInternal();
                Invalidate();
                e.Handled = true;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Back)
            {
                if (selectionLength != 0) { DeleteSelectionIfAny(); OnTextChangedInternal(); }
                else if (caretPosition > 0)
                {
                    _text = _text.Remove(caretPosition - 1, 1);
                    caretPosition--;
                    OnTextChangedInternal();
                }
                ClearSelection();
                UpdateFloatingTarget();
                Invalidate();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (selectionLength != 0) { DeleteSelectionIfAny(); OnTextChangedInternal(); }
                else if (caretPosition < _text.Length)
                {
                    _text = _text.Remove(caretPosition, 1);
                    OnTextChangedInternal();
                }

                ClearSelection();
                UpdateFloatingTarget();
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
                    if (_numbersOnly)
                        clip = new string(clip.Where(char.IsDigit).ToArray());

                    if (!string.IsNullOrEmpty(clip))
                    {
                        DeleteSelectionIfAny();

                        int spaceLeft = (_maxLength > 0) ? _maxLength - _text.Length : int.MaxValue;
                        if (spaceLeft > 0)
                        {
                            if (clip.Length > spaceLeft)
                                clip = clip.Substring(0, spaceLeft);

                            _text = _text.Insert(caretPosition, clip);
                            caretPosition += clip.Length;
                            ClearSelection();
                            UpdateFloatingTarget();
                            OnTextChangedInternal();
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
            // Keep selectionStart as the anchor; only clear length
            selectionLength = 0;
        }

        #endregion
    }
}
