using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{
    public class ModernButton : Button
    {
        // Appearance
        private int cornerRadius = 8;
        private Color baseBackColor = Color.FromArgb(0, 120, 212);
        private Color hoverBackColor = Color.FromArgb(10, 132, 255);
        private Color pressedBackColor = Color.FromArgb(0, 102, 204);
        private Color borderColor = Color.Transparent;
        private Color disabledBackColor = Color.FromArgb(220, 220, 220);
        private Color disabledForeColor = Color.FromArgb(140, 140, 140);
        private int elevation = 2; // shadow offset
        private int hoverElevation = 6;

        // Animation / ripple
        private Timer animTimer;
        private float hoverProgress = 0f; // 0..1
        private float pressProgress = 0f; // 0..1
        private const float animStep = 0.12f;

        // Ripple effect state
        private Point? rippleCenter = null;
        private float rippleRadius = 0f;
        private float rippleMax = 0f;
        private float rippleOpacity = 0f;

        // Interaction state
        private bool isHovered = false;
        private bool isPressed = false;

        // Icon support
        private Image _icon = null;
        private int _iconSize = 18;
        private int _iconSpacing = 8;

        [Category("Appearance"), DefaultValue(8)]
        public int CornerRadius
        {
            get => cornerRadius;
            set { cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        public Color BaseBackColor
        {
            get => baseBackColor;
            set { baseBackColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color HoverBackColor
        {
            get => hoverBackColor;
            set { hoverBackColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color PressedBackColor
        {
            get => pressedBackColor;
            set { pressedBackColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Image Icon
        {
            get => _icon;
            set { _icon = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(18)]
        public int IconSize
        {
            get => _iconSize;
            set { _iconSize = Math.Max(8, value); Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(8)]
        public int IconSpacing
        {
            get => _iconSpacing;
            set { _iconSpacing = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(2)]
        public int Elevation
        {
            get => elevation;
            set { elevation = Math.Max(0, value); Invalidate(); }
        }

        public ModernButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = baseBackColor;
            ForeColor = Color.White;
            Size = new Size(120, 40);

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint |
                         ControlStyles.ResizeRedraw |
                         ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.Selectable |
                         ControlStyles.SupportsTransparentBackColor, true);

            animTimer = new Timer { Interval = 16 };
            animTimer.Tick += AnimTimer_Tick;
            animTimer.Start();

            // Accessibility defaults
            TabStop = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                animTimer?.Stop();
                animTimer?.Dispose();
                animTimer = null;
            }
            base.Dispose(disposing);
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            // Smooth hover progress
            float targetHover = isHovered ? 1f : 0f;
            if (Math.Abs(hoverProgress - targetHover) > 0.001f)
            {
                hoverProgress += (hoverProgress < targetHover ? animStep : -animStep);
                hoverProgress = Math.Max(0f, Math.Min(1f, hoverProgress));
                Invalidate();
            }

            // Smooth press progress
            float targetPress = isPressed ? 1f : 0f;
            if (Math.Abs(pressProgress - targetPress) > 0.001f)
            {
                pressProgress += (pressProgress < targetPress ? animStep * 1.2f : -animStep * 1.2f);
                pressProgress = Math.Max(0f, Math.Min(1f, pressProgress));
                Invalidate();
            }

            // Ripple expansion
            if (rippleCenter.HasValue)
            {
                rippleRadius += rippleMax * 0.08f;
                rippleOpacity -= 0.06f;
                if (rippleOpacity <= 0f || rippleRadius >= rippleMax)
                {
                    rippleCenter = null;
                    rippleRadius = 0f;
                    rippleOpacity = 0f;
                }
                Invalidate();
            }
        }

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
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left && Enabled)
            {
                isPressed = true;
                // start ripple
                rippleCenter = mevent.Location;
                rippleRadius = 0f;
                rippleMax = Math.Max(Width, Height) * 1.4f;
                rippleOpacity = 0.35f;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                isPressed = false;
                Invalidate();
            }
        }

        protected override void OnKeyDown(KeyEventArgs kevent)
        {
            base.OnKeyDown(kevent);
            if ((kevent.KeyCode == Keys.Space || kevent.KeyCode == Keys.Enter) && Enabled)
            {
                isPressed = true;
                // center ripple for keyboard press
                rippleCenter = new Point(Width / 2, Height / 2);
                rippleRadius = 0f;
                rippleMax = Math.Max(Width, Height) * 1.4f;
                rippleOpacity = 0.35f;
                Invalidate();
            }
        }

        protected override void OnKeyUp(KeyEventArgs kevent)
        {
            base.OnKeyUp(kevent);
            if (kevent.KeyCode == Keys.Space || kevent.KeyCode == Keys.Enter)
            {
                isPressed = false;
                PerformClick();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.Parent != null ? this.Parent.BackColor : this.BackColor);

            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);

            // compute dynamic colors based on state
            Color bg = Enabled ? BlendColors(baseBackColor, hoverBackColor, hoverProgress) : disabledBackColor;
            bg = BlendColors(bg, pressedBackColor, pressProgress * 0.6f);
            Color fg = Enabled ? ForeColor : disabledForeColor;
            Color bdr = BorderColor;

            // elevation shadow
            int currentElevation = (int)Math.Round(Elevation + (hoverElevation - Elevation) * hoverProgress);
            if (currentElevation > 0)
            {
                using (var shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
                {
                    Rectangle shadowRect = new Rectangle(rect.Left, rect.Top + currentElevation, rect.Width, rect.Height);
                    using (var path = GetRoundedRect(shadowRect, cornerRadius))
                        e.Graphics.FillPath(shadowBrush, path);
                }
            }

            // background
            using (var bgBrush = new SolidBrush(bg))
            using (var path = GetRoundedRect(rect, cornerRadius))
            {
                e.Graphics.FillPath(bgBrush, path);

                // border
                if (bdr.A > 0)
                {
                    using (var pen = new Pen(bdr, 1f))
                        e.Graphics.DrawPath(pen, path);
                }
            }

            // ripple
            if (rippleCenter.HasValue && rippleOpacity > 0f)
            {
                using (var rippleBrush = new SolidBrush(Color.FromArgb((int)(rippleOpacity * 255), Color.White)))
                {
                    var rc = rippleCenter.Value;
                    float r = rippleRadius;
                    RectangleF rippleRect = new RectangleF(rc.X - r, rc.Y - r, r * 2, r * 2);
                    using (var gp = new GraphicsPath())
                    {
                        gp.AddEllipse(rippleRect);
                        using (var clip = GetRoundedRect(rect, cornerRadius))
                        {
                            e.Graphics.SetClip(clip);
                            e.Graphics.FillPath(rippleBrush, gp);
                            e.Graphics.ResetClip();
                        }
                    }
                }
            }

            // content layout: icon + text
            Rectangle content = rect;
            content.Inflate(-8, -6);

            // measure text
            Size textSize = TextRenderer.MeasureText(e.Graphics, Text, Font, Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);

            int contentWidth = content.Width;
            int x = content.Left;
            int centerY = content.Top + content.Height / 2;

            if (_icon != null)
            {
                int iconY = centerY - _iconSize / 2;
                Rectangle iconRect = new Rectangle(x, iconY, _iconSize, _iconSize);
                DrawIcon(e.Graphics, _icon, iconRect, Enabled);
                x += _iconSize + _iconSpacing;
                contentWidth -= _iconSize + _iconSpacing;
            }

            // text rectangle
            Rectangle textRect = new Rectangle(x, content.Top, contentWidth, content.Height);

            // draw text centered vertically and horizontally according to TextAlign
            TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis;
            switch (TextAlign)
            {
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.TopLeft:
                case ContentAlignment.BottomLeft:
                    flags |= TextFormatFlags.Left;
                    break;
                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                case ContentAlignment.BottomRight:
                    flags |= TextFormatFlags.Right;
                    break;
                default:
                    flags |= TextFormatFlags.HorizontalCenter;
                    break;
            }

            TextRenderer.DrawText(e.Graphics, Text, Font, textRect, fg, flags);

            // focus rectangle
            if (Focused && ShowFocusCues)
            {
                Rectangle focusRect = rect;
                focusRect.Inflate(-4, -4);
                ControlPaint.DrawFocusRectangle(e.Graphics, focusRect);
            }
        }

        private void DrawIcon(Graphics g, Image img, Rectangle rect, bool enabled)
        {
            if (img == null) return;
            if (!enabled)
                ControlPaint.DrawImageDisabled(g, img, rect.X, rect.Y, Color.Transparent);
            else
                g.DrawImage(img, rect);
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
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

        private Color BlendColors(Color a, Color b, float t)
        {
            t = Math.Max(0f, Math.Min(1f, t));
            int r = (int)(a.R + (b.R - a.R) * t);
            int g = (int)(a.G + (b.G - a.G) * t);
            int bl = (int)(a.B + (b.B - a.B) * t);
            int alpha = (int)(a.A + (b.A - a.A) * t);
            return Color.FromArgb(alpha, r, g, bl);
        }

        // Expose a safe PerformClick wrapper to ensure ripple completes
        public new void PerformClick()
        {
            base.PerformClick();
        }
    }
}
