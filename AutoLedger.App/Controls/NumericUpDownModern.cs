using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{


    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class NumericUpDownModern : NumericUpDown
    {
        #region Modern appearance properties

        private int cornerRadius = 6;
        private Color borderColor = Color.LightGray;
        private Color hoverBorderColor = Color.Gray;
        private Color focusBorderColor = Color.DodgerBlue;
        private Color buttonBackColor = Color.FromArgb(230, 230, 230);
        private Color buttonHoverColor = Color.FromArgb(210, 210, 210);
        private Color buttonPressedColor = Color.FromArgb(180, 180, 180);
        private Color arrowColor = Color.Black;

        private string placeholder = string.Empty;
        private Color placeholderColor = Color.Gray;

        private bool isHovered = false;
        private bool buttonUpHovered = false;
        private bool buttonDownHovered = false;
        private bool buttonUpPressed = false;
        private bool buttonDownPressed = false;

        private Timer hoverTimer;

        [Category("Appearance"), DefaultValue(6)]
        public int CornerRadius
        {
            get => cornerRadius;
            set { cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color HoverBorderColor
        {
            get => hoverBorderColor;
            set { hoverBorderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color FocusBorderColor
        {
            get => focusBorderColor;
            set { focusBorderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color ButtonBackColor
        {
            get => buttonBackColor;
            set { buttonBackColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color ButtonHoverColor
        {
            get => buttonHoverColor;
            set { buttonHoverColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color ButtonPressedColor
        {
            get => buttonPressedColor;
            set { buttonPressedColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color ArrowColor
        {
            get => arrowColor;
            set { arrowColor = value; Invalidate(); }
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

        #endregion

        #region Constructor

        public NumericUpDownModern()
        {
            // Remove default border and button styling
            this.BorderStyle = BorderStyle.None;
            this.Controls[0].Paint += InternalTextBox_Paint; // internal TextBox
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);

            // Timer to handle hover on spin buttons (no native mouse events for the buttons)
            hoverTimer = new Timer { Interval = 50 };
            hoverTimer.Tick += HoverTimer_Tick;
            this.MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
            this.MouseLeave += (s, e) => { isHovered = false; buttonUpHovered = false; buttonDownHovered = false; Invalidate(); };
            this.GotFocus += (s, e) => Invalidate();
            this.LostFocus += (s, e) => Invalidate();
            this.MouseDown += ModernNumericUpDown_MouseDown;
            this.MouseUp += ModernNumericUpDown_MouseUp;
            this.KeyDown += (s, e) => Invalidate();
            this.KeyUp += (s, e) => Invalidate();
        }

        #endregion

        #region Mouse handling for spin buttons

        private void ModernNumericUpDown_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle upRect, downRect;
            GetButtonRects(out upRect, out downRect);
            if (upRect.Contains(e.Location)) { buttonUpPressed = true; buttonDownPressed = false; }
            else if (downRect.Contains(e.Location)) { buttonDownPressed = true; buttonUpPressed = false; }
            else { buttonUpPressed = false; buttonDownPressed = false; }
            Invalidate();
            hoverTimer.Start();
        }

        private void ModernNumericUpDown_MouseUp(object sender, MouseEventArgs e)
        {
            buttonUpPressed = false;
            buttonDownPressed = false;
            Invalidate();
            hoverTimer.Stop();
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            Point pt = PointToClient(Cursor.Position);
            Rectangle upRect, downRect;
            GetButtonRects(out upRect, out downRect);
            bool upHover = upRect.Contains(pt);
            bool downHover = downRect.Contains(pt);
            if (upHover != buttonUpHovered || downHover != buttonDownHovered)
            {
                buttonUpHovered = upHover;
                buttonDownHovered = downHover;
                Invalidate();
            }
        }

        private void GetButtonRects(out Rectangle upRect, out Rectangle downRect)
        {
            int btnWidth = 16; // typical width of spin buttons
            upRect = new Rectangle(Width - btnWidth - 1, 1, btnWidth, (Height - 2) / 2);
            downRect = new Rectangle(Width - btnWidth - 1, upRect.Bottom, btnWidth, Height - 2 - upRect.Height);
            if (RightToLeft == RightToLeft.Yes)
            {
                upRect.X = 1;
                downRect.X = 1;
            }
        }

        #endregion

        #region Painting

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Determine border color based on state
            Color actualBorder = BorderColor;
            if (Focused) actualBorder = FocusBorderColor;
            else if (isHovered) actualBorder = HoverBorderColor;

            // Draw background
            using (var bgBrush = new SolidBrush(this.BackColor))
            using (var path = GetRoundedRect(ClientRectangle, cornerRadius))
            {
                e.Graphics.FillPath(bgBrush, path);
            }

            // Draw the internal text box area (the number part)
            PaintTextBoxArea(e.Graphics);

            // Draw the spin buttons
            PaintSpinButtons(e.Graphics);

            // Draw border
            using (var pen = new Pen(actualBorder, 1.5f))
            using (var path = GetRoundedRect(ClientRectangle, cornerRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // Draw focus rectangle if needed
            if (Focused && ShowFocusCues)
            {
                Rectangle focusRect = ClientRectangle;
                focusRect.Inflate(-3, -3);
                ControlPaint.DrawFocusRectangle(e.Graphics, focusRect);
            }

            // Placeholder logic: show placeholder if Value == Minimum and no explicit text entered
            // NumericUpDown always shows text, but we can check if the text is the standard minimum representation.
            bool showPlaceholder = (Value == Minimum && string.IsNullOrEmpty(this.Text.Trim())) ||
                                   (Value == Minimum && this.Text == Minimum.ToString()) && !Focused;
            if (showPlaceholder && !string.IsNullOrEmpty(placeholder))
            {
                // Draw placeholder over the text area
                Rectangle textRect = GetTextAreaRect();
                textRect.Inflate(-2, -2);
                TextRenderer.DrawText(e.Graphics, placeholder, this.Font, textRect,
                                      placeholderColor, GetTextFormatFlags());
            }
        }

        private void PaintTextBoxArea(Graphics g)
        {
            // The text box occupies the left (or right for RTL) portion of the control
            Rectangle textRect = GetTextAreaRect();
            // We don't draw the actual text here because the internal TextBox handles it.
            // But we need to paint the background of the text area (it's already filled by the overall background).
            // To avoid double text rendering, we rely on the internal TextBox painting, but we need to suppress its border.
            // The internal TextBox has BorderStyle.None by default in NumericUpDown when BorderStyle is None.
            // So just leave it as is.
        }

        private void PaintSpinButtons(Graphics g)
        {
            Rectangle upRect, downRect;
            GetButtonRects(out upRect, out downRect);

            // Up button
            Color upBack = buttonUpPressed ? ButtonPressedColor :
                           (buttonUpHovered ? ButtonHoverColor : ButtonBackColor);
            using (var brush = new SolidBrush(upBack))
            using (var path = GetRoundedRectTop(upRect, cornerRadius, RightToLeft == RightToLeft.Yes))
            {
                g.FillPath(brush, path);
            }
            DrawArrow(g, upRect, true, ArrowColor);

            // Down button
            Color downBack = buttonDownPressed ? ButtonPressedColor :
                             (buttonDownHovered ? ButtonHoverColor : ButtonBackColor);
            using (var brush = new SolidBrush(downBack))
            using (var path = GetRoundedRectBottom(downRect, cornerRadius, RightToLeft == RightToLeft.Yes))
            {
                g.FillPath(brush, path);
            }
            DrawArrow(g, downRect, false, ArrowColor);
        }

        private void DrawArrow(Graphics g, Rectangle rect, bool up, Color color)
        {
            int cx = rect.X + rect.Width / 2;
            int cy = rect.Y + rect.Height / 2;
            int arrowSize = Math.Min(rect.Width, rect.Height) / 2 - 2;

            Point[] points;
            if (up)
            {
                points = new Point[] {
                new Point(cx - arrowSize, cy + arrowSize / 2),
                new Point(cx, cy - arrowSize / 2),
                new Point(cx + arrowSize, cy + arrowSize / 2)
            };
            }
            else
            {
                points = new Point[] {
                new Point(cx - arrowSize, cy - arrowSize / 2),
                new Point(cx, cy + arrowSize / 2),
                new Point(cx + arrowSize, cy - arrowSize / 2)
            };
            }
            using (var brush = new SolidBrush(color))
                g.FillPolygon(brush, points);
        }

        private Rectangle GetTextAreaRect()
        {
            Rectangle rect = ClientRectangle;
            int btnWidth = 17;
            if (RightToLeft == RightToLeft.Yes)
                return new Rectangle(btnWidth, 1, rect.Width - btnWidth - 2, rect.Height - 2);
            else
                return new Rectangle(1, 1, rect.Width - btnWidth - 2, rect.Height - 2);
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0) { path.AddRectangle(rect); return path; }
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        private GraphicsPath GetRoundedRectTop(Rectangle rect, int radius, bool rtl)
        {
            // Only round the top corners (used for up button)
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0) { path.AddRectangle(rect); return path; }
            if (!rtl)
            {
                path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddLine(rect.X, rect.Y + radius, rect.X, rect.Bottom);
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Y + radius);
            }
            else
            {
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom);
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Y + radius);
            }
            path.CloseFigure();
            return path;
        }

        private GraphicsPath GetRoundedRectBottom(Rectangle rect, int radius, bool rtl)
        {
            // Only round the bottom corners
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0) { path.AddRectangle(rect); return path; }
            if (!rtl)
            {
                path.AddLine(rect.X, rect.Y, rect.X, rect.Bottom - radius);
                path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Bottom - radius);
            }
            else
            {
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Bottom - radius);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.AddLine(rect.X, rect.Y, rect.X, rect.Bottom - radius);
            }
            path.CloseFigure();
            return path;
        }

        private TextFormatFlags GetTextFormatFlags()
        {
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix;
            if (RightToLeft == RightToLeft.Yes) flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
            return flags;
        }

        // Suppress internal TextBox border painting (it already has no border, but just in case)
        private void InternalTextBox_Paint(object sender, PaintEventArgs e)
        {
            // Do nothing, we paint the border ourselves.
            // The internal TextBox still draws its text, which is fine.
        }

        #endregion

        #region Overrides to maintain modern look

        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            // Prevent internal text box from changing size unexpectedly
            base.OnTextBoxResize(source, e);
            Invalidate();
        }

        // Override to ensure the placeholder is cleared when value changes
        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            Invalidate();
        }

        // Override to handle when the text changes (e.g. user types)
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        #endregion
    }
}
