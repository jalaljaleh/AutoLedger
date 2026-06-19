using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{
    /// <summary>
    /// ModernNumericUpDown: a modern-looking numeric up/down control with rounded corners and typing support.
    /// </summary>
    public class ModernNumericUpDown : Control
    {
        private decimal _value = 0m;
        private decimal _minimum = 0m;
        private decimal _maximum = 100m;
        private decimal _increment = 1m;
        private int _decimalPlaces = 0;

        private Color _accentColor = Color.FromArgb(0, 120, 215);
        private Color _borderColor = Color.FromArgb(200, 200, 200);
        private Color _hoverColor = Color.FromArgb(245, 245, 245);
        private int _cornerRadius = 6;
        private bool _showButtons = true;

        private bool isHovered = false;
        private bool isPressedUp = false;
        private bool isPressedDown = false;
        private bool isEditing = false;

        private TextBox editBox;
        private Timer repeatTimer;
        private int repeatDirection = 0; // +1 up, -1 down

        public event EventHandler ValueChanged;

        public ModernNumericUpDown()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.Selectable, true);

            Size = new Size(120, 28);
            BackColor = Color.White;
            ForeColor = Color.FromArgb(30, 30, 30);

            editBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.Transparent,
                ForeColor = ForeColor,
                TextAlign = HorizontalAlignment.Left
            };
            editBox.Leave += EditBox_Leave;
            editBox.KeyDown += EditBox_KeyDown;
            editBox.KeyPress += EditBox_KeyPress;
            editBox.TextChanged += EditBox_TextChanged;
            Controls.Add(editBox);

            repeatTimer = new Timer { Interval = 250 };
            repeatTimer.Tick += RepeatTimer_Tick;

            UpdateEditText();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repeatTimer?.Dispose();
                editBox?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Properties

        [Category("Behavior"), DefaultValue(0)]
        public decimal Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;
                if (_maximum < _minimum) _maximum = _minimum;
                if (_value < _minimum) Value = _minimum;
                Invalidate();
            }
        }

        [Category("Behavior"), DefaultValue(100)]
        public decimal Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;
                if (_minimum > _maximum) _minimum = _maximum;
                if (_value > _maximum) Value = _maximum;
                Invalidate();
            }
        }

        [Category("Behavior"), DefaultValue(1)]
        public decimal Increment
        {
            get => _increment;
            set { _increment = value <= 0 ? 1 : value; }
        }

        [Category("Behavior"), DefaultValue(0)]
        public int DecimalPlaces
        {
            get => _decimalPlaces;
            set
            {
                _decimalPlaces = Math.Max(0, Math.Min(10, value));
                UpdateEditText();
                Invalidate();
            }
        }

        [Category("Behavior")]
        public decimal Value
        {
            get => _value;
            set
            {
                decimal v = Clamp(value);
                if (v != _value)
                {
                    _value = Decimal.Round(v, _decimalPlaces, MidpointRounding.AwayFromZero);
                    UpdateEditText();
                    OnValueChanged(EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        [Category("Appearance")]
        public Color AccentColor
        {
            get => _accentColor;
            set { _accentColor = value; Invalidate(); }
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

        [Category("Behavior"), DefaultValue(true)]
        public bool ShowButtons
        {
            get => _showButtons;
            set { _showButtons = value; Invalidate(); }
        }

        #endregion

        #region Layout & Painting

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutEditBox();
            Invalidate();
        }

        private void LayoutEditBox()
        {
            int pad = 6;
            int btnWidth = _showButtons ? Math.Max(20, Height) : 0;
            editBox.SetBounds(pad, 2, Math.Max(10, Width - btnWidth - pad * 2), Math.Max(16, Height - 4));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);

            // background
            using (var path = GetRoundedRect(rect, _cornerRadius))
            using (var bg = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(bg, path);
            }

            // hover overlay
            if (isHovered)
            {
                using (var path = GetRoundedRect(rect, _cornerRadius))
                using (var hover = new SolidBrush(_hoverColor))
                {
                    e.Graphics.FillPath(hover, path);
                }
            }

            // border
            using (var pen = new Pen(_showButtons && (isPressedUp || isPressedDown) ? _accentColor : _borderColor, 1.2f))
            using (var path = GetRoundedRect(rect, _cornerRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // draw buttons
            if (_showButtons)
            {
                int btnW = Math.Max(20, Height);
                Rectangle btnRect = new Rectangle(rect.Right - btnW, rect.Top, btnW, rect.Height);
                DrawButtons(e.Graphics, btnRect);
            }
        }

        private void DrawButtons(Graphics g, Rectangle btnRect)
        {
            int half = btnRect.Height / 2;
            Rectangle upRect = new Rectangle(btnRect.Left, btnRect.Top, btnRect.Width, half);
            Rectangle downRect = new Rectangle(btnRect.Left, btnRect.Top + half, btnRect.Width, btnRect.Height - half);

            // background for pressed states
            if (isPressedUp)
                using (var b = new SolidBrush(Color.FromArgb(40, _accentColor)))
                    g.FillRectangle(b, upRect);
            if (isPressedDown)
                using (var b = new SolidBrush(Color.FromArgb(40, _accentColor)))
                    g.FillRectangle(b, downRect);

            // separator line
            using (var pen = new Pen(Color.FromArgb(220, 220, 220)))
                g.DrawLine(pen, btnRect.Left, btnRect.Top + 1, btnRect.Left, btnRect.Bottom - 1);

            // draw arrows
            DrawArrow(g, upRect, true);
            DrawArrow(g, downRect, false);
        }

        private void DrawArrow(Graphics g, Rectangle r, bool up)
        {
            int cx = r.Left + r.Width / 2;
            int cy = r.Top + r.Height / 2;
            int size = Math.Max(6, r.Height / 4);
            Point[] pts;
            if (up)
            {
                pts = new[] { new Point(cx - size, cy + size / 2), new Point(cx + size, cy + size / 2), new Point(cx, cy - size / 2) };
            }
            else
            {
                pts = new[] { new Point(cx - size, cy - size / 2), new Point(cx + size, cy - size / 2), new Point(cx, cy + size / 2) };
            }
            using (var brush = new SolidBrush(ForeColor))
                g.FillPolygon(brush, pts);
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
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

        #region Input Handling

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            isPressedUp = isPressedDown = false;
            repeatTimer.Stop();
            repeatDirection = 0;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!_showButtons) return;

            Rectangle rect = ClientRectangle;
            int btnW = Math.Max(20, Height);
            Rectangle btnRect = new Rectangle(rect.Right - btnW, rect.Top, btnW, rect.Height);
            int half = btnRect.Height / 2;
            Rectangle upRect = new Rectangle(btnRect.Left, btnRect.Top, btnRect.Width, half);
            Rectangle downRect = new Rectangle(btnRect.Left, btnRect.Top + half, btnRect.Width, btnRect.Height - half);

            if (upRect.Contains(e.Location))
            {
                isPressedUp = true;
                StepUp();
                StartRepeat(+1);
            }
            else if (downRect.Contains(e.Location))
            {
                isPressedDown = true;
                StepDown();
                StartRepeat(-1);
            }
            else
            {
                // focus and allow typing
                Focus();
                BeginEdit();
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isPressedUp = isPressedDown = false;
            StopRepeat();
            Invalidate();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (e.Delta > 0) StepUp();
            else StepDown();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            // show caret in edit box
            BeginEdit();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            EndEdit();
        }

        protected override bool IsInputKey(Keys keyData)
        {
            // treat arrows and page keys as input keys
            if ((keyData & Keys.KeyCode) == Keys.Up ||
                (keyData & Keys.KeyCode) == Keys.Down ||
                (keyData & Keys.KeyCode) == Keys.PageUp ||
                (keyData & Keys.KeyCode) == Keys.PageDown ||
                (keyData & Keys.KeyCode) == Keys.Home ||
                (keyData & Keys.KeyCode) == Keys.End)
                return true;
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Up) { StepUp(); e.Handled = true; }
            else if (e.KeyCode == Keys.Down) { StepDown(); e.Handled = true; }
            else if (e.KeyCode == Keys.PageUp) { Value += _increment * 10; e.Handled = true; }
            else if (e.KeyCode == Keys.PageDown) { Value -= _increment * 10; e.Handled = true; }
            else if (e.KeyCode == Keys.Home) { Value = _minimum; e.Handled = true; }
            else if (e.KeyCode == Keys.End) { Value = _maximum; e.Handled = true; }
            else if (e.KeyCode == Keys.Enter) { EndEdit(); e.Handled = true; }
            else if (e.KeyCode == Keys.Escape) { UpdateEditText(); EndEdit(); e.Handled = true; }
        }

        #endregion

        #region EditBox events & helpers

        private void BeginEdit()
        {
            if (isEditing) return;
            isEditing = true;
            editBox.Visible = true;
            editBox.BringToFront();
            editBox.Focus();
            editBox.SelectAll();
        }

        private void EndEdit()
        {
            if (!isEditing) return;
            isEditing = false;
            ParseEditTextAndApply();
            // move focus back to control
            if (!Focused) Focus();
            Invalidate();
        }

        private void EditBox_Leave(object sender, EventArgs e)
        {
            EndEdit();
        }

        private void EditBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { EndEdit(); e.Handled = true; }
            else if (e.KeyCode == Keys.Escape) { UpdateEditText(); EndEdit(); e.Handled = true; }
        }

        private void EditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digits, decimal separator, negative sign, control chars
            char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != dec &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void EditBox_TextChanged(object sender, EventArgs e)
        {
            // live validation optional: do nothing here to avoid flicker
        }

        private void ParseEditTextAndApply()
        {
            string txt = editBox.Text.Trim();
            if (string.IsNullOrEmpty(txt))
            {
                UpdateEditText();
                return;
            }

            if (decimal.TryParse(txt, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal parsed))
            {
                parsed = Decimal.Round(parsed, _decimalPlaces, MidpointRounding.AwayFromZero);
                Value = Clamp(parsed);
            }
            else
            {
                // invalid input -> revert
                UpdateEditText();
            }
        }

        private void UpdateEditText()
        {
            editBox.Text = _value.ToString("N" + _decimalPlaces, CultureInfo.CurrentCulture);
            editBox.SelectionStart = 0;
            editBox.SelectionLength = 0;
        }

        #endregion

        #region Repeat timer (hold buttons)

        private void StartRepeat(int direction)
        {
            repeatDirection = direction;
            repeatTimer.Interval = 350;
            repeatTimer.Start();
        }

        private void StopRepeat()
        {
            repeatTimer.Stop();
            repeatDirection = 0;
        }

        private void RepeatTimer_Tick(object sender, EventArgs e)
        {
            if (repeatDirection > 0) StepUp();
            else if (repeatDirection < 0) StepDown();
            // accelerate
            repeatTimer.Interval = Math.Max(40, repeatTimer.Interval - 20);
        }

        #endregion

        #region Steps & utilities

        private void StepUp()
        {
            Value += _increment;
        }

        private void StepDown()
        {
            Value -= _increment;
        }

        private decimal Clamp(decimal v)
        {
            if (v < _minimum) return _minimum;
            if (v > _maximum) return _maximum;
            return v;
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }

        #endregion
    }

    /// <summary>
    /// ToolStrip host for ModernNumericUpDown so it can be placed inside a ToolStrip.
    /// </summary>
    [ToolboxItem(true)]
    public class ToolStripModernNumericUpDown : ToolStripControlHost
    {
        public ToolStripModernNumericUpDown() : base(CreateControlInstance())
        {
            AutoSize = false;
            Width = 120;
            Height = 28;
        }

        public ToolStripModernNumericUpDown(string name) : this()
        {
            Name = name;
        }

        private static Control CreateControlInstance()
        {
            var n = new ModernNumericUpDown { Dock = DockStyle.Fill };
            return n;
        }

        [Browsable(false)]
        public ModernNumericUpDown NumericUpDownControl => Control as ModernNumericUpDown;

        [Category("Behavior")]
        public decimal Value
        {
            get => NumericUpDownControl?.Value ?? 0m;
            set { if (NumericUpDownControl != null) NumericUpDownControl.Value = value; }
        }

        [Category("Behavior")]
        public decimal Minimum
        {
            get => NumericUpDownControl?.Minimum ?? 0m;
            set { if (NumericUpDownControl != null) NumericUpDownControl.Minimum = value; }
        }

        [Category("Behavior")]
        public decimal Maximum
        {
            get => NumericUpDownControl?.Maximum ?? 100m;
            set { if (NumericUpDownControl != null) NumericUpDownControl.Maximum = value; }
        }

        [Category("Behavior")]
        public decimal Increment
        {
            get => NumericUpDownControl?.Increment ?? 1m;
            set { if (NumericUpDownControl != null) NumericUpDownControl.Increment = value; }
        }

        [Category("Behavior")]
        public int DecimalPlaces
        {
            get => NumericUpDownControl?.DecimalPlaces ?? 0;
            set { if (NumericUpDownControl != null) NumericUpDownControl.DecimalPlaces = value; }
        }

        [Category("Appearance")]
        public Color AccentColor
        {
            get => NumericUpDownControl?.AccentColor ?? Color.FromArgb(0, 120, 215);
            set { if (NumericUpDownControl != null) NumericUpDownControl.AccentColor = value; }
        }

        protected override void OnSubscribeControlEvents(Control c)
        {
            base.OnSubscribeControlEvents(c);
            if (c is ModernNumericUpDown m)
                m.ValueChanged += Hosted_ValueChanged;
        }

        protected override void OnUnsubscribeControlEvents(Control c)
        {
            base.OnUnsubscribeControlEvents(c);
            if (c is ModernNumericUpDown m)
                m.ValueChanged -= Hosted_ValueChanged;
        }

        private void Hosted_ValueChanged(object sender, EventArgs e)
        {
            OnTextChanged(EventArgs.Empty); // notify ToolStrip consumers
        }

        protected override Size DefaultSize => new Size(120, 28);
    }
}
