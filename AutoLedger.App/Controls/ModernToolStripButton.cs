using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{
    /// <summary>
    /// A modern ToolStripButton with extra appearance properties.
    /// Use with ModernToolStripRenderer for the full visual effect.
    /// </summary>
    public class ModernToolStripButton : ToolStripButton
    {
        private Color accentColor = Color.FromArgb(0, 120, 215);
        private Color hoverColor = Color.FromArgb(230, 245, 255);
        private Color pressedColor = Color.FromArgb(200, 230, 255);
        private int cornerRadius = 6;
        private bool showSeparator = false;
        private bool showDropDownArrow = false;

        [Category("Appearance")]
        public Color AccentColor
        {
            get => accentColor;
            set { accentColor = value; InvalidateOwner(); }
        }

        [Category("Appearance")]
        public Color HoverColor
        {
            get => hoverColor;
            set { hoverColor = value; InvalidateOwner(); }
        }

        [Category("Appearance")]
        public Color PressedColor
        {
            get => pressedColor;
            set { pressedColor = value; InvalidateOwner(); }
        }

        [Category("Appearance"), DefaultValue(6)]
        public int CornerRadius
        {
            get => cornerRadius;
            set { cornerRadius = Math.Max(0, value); InvalidateOwner(); }
        }

        [Category("Appearance"), DefaultValue(false)]
        public bool ShowSeparator
        {
            get => showSeparator;
            set { showSeparator = value; InvalidateOwner(); }
        }

        [Category("Behavior"), DefaultValue(false)]
        public bool ShowDropDownArrow
        {
            get => showDropDownArrow;
            set { showDropDownArrow = value; InvalidateOwner(); }
        }

        private void InvalidateOwner()
        {
            if (Owner != null) Owner.Invalidate();
        }
    }

    /// <summary>
    /// Renderer that paints ToolStrip items with a modern rounded style.
    /// It respects ModernToolStripButton properties when present.
    /// Apply to a ToolStrip by setting toolStrip.Renderer = new ModernToolStripRenderer();
    /// </summary>
    public class ModernToolStripRenderer : ToolStripProfessionalRenderer
    {
        public ModernToolStripRenderer() : base(new ModernColorTable()) { }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            // Only custom-draw ToolStripButton items (including ModernToolStripButton)
            if (!(e.Item is ToolStripButton)) { base.OnRenderButtonBackground(e); return; }

            var btn = e.Item as ToolStripButton;
            var modern = e.Item as ModernToolStripButton;

            Rectangle bounds = new Rectangle(Point.Empty, e.Item.ContentRectangle.Size);

            // Determine colors and radius
            Color accent = modern?.AccentColor ?? Color.FromArgb(0, 120, 215);
            Color hover = modern?.HoverColor ?? Color.FromArgb(230, 245, 255);
            Color pressed = modern?.PressedColor ?? Color.FromArgb(200, 230, 255);
            int radius = modern?.CornerRadius ?? 6;

            bool enabled = e.Item.Enabled;
            bool pressedState = btn.Pressed || btn.Checked;
            bool hovered = e.Item.Selected;

            // Background
            Color back = Color.Transparent;
            if (!enabled) back = ControlPaint.Light(SystemColors.Control);
            else if (pressedState) back = pressed;
            else if (hovered) back = hover;
            else back = Color.Transparent;

            using (var path = GetRoundedRectPath(bounds, radius))
            {
                if (back != Color.Transparent)
                {
                    using (var brush = new SolidBrush(back))
                        e.Graphics.FillPath(brush, path);
                }

                // Accent underline when checked
                if (btn.Checked && enabled)
                {
                    using (var pen = new Pen(accent, 2f))
                    {
                        // draw a small accent line at bottom inside the bounds
                        int y = bounds.Bottom - 2;
                        e.Graphics.DrawLine(pen, bounds.Left + 6, y, bounds.Right - 6, y);
                    }
                }
            }

            // Optional separator to the right
            if (modern?.ShowSeparator == true)
            {
                using (var pen = new Pen(Color.FromArgb(200, 200, 200)))
                {
                    int x = bounds.Right - 1;
                    e.Graphics.DrawLine(pen, x, 6, x, bounds.Height - 6);
                }
            }
        }

        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            // Draw image centered vertically with some left padding
            if (e.Image != null)
            {
                var img = e.Image;
                Rectangle r = e.ImageRectangle;
                // adjust to center vertically
                int y = (e.Item.ContentRectangle.Height - img.Height) / 2;
                int x = e.ImageRectangle.Left;
                e.Graphics.DrawImage(img, x, y, img.Width, img.Height);
            }
            else base.OnRenderItemImage(e);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // Use modern font smoothing and color
            e.TextFormat |= TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis;
            var modern = e.Item as ModernToolStripButton;
            Color fore = e.Item.Enabled ? e.Item.ForeColor : SystemColors.GrayText;

            // If checked, use accent color for text optionally
            if (modern != null && (e.Item as ToolStripButton).Checked)
            {
                fore = modern.AccentColor;
            }

            TextRenderer.DrawText(e.Graphics, e.Text, e.TextFont, e.TextRectangle, fore, e.TextFormat);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            // For drop-down style, reuse button background logic
            OnRenderButtonBackground(e);
        }

        // Utility: rounded rectangle path
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

        // Optional: draw the background of the entire ToolStrip with subtle gradient
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            Rectangle r = e.AffectedBounds;
            using (var brush = new LinearGradientBrush(r, Color.FromArgb(250, 250, 250), Color.FromArgb(245, 245, 245), 90f))
            {
                e.Graphics.FillRectangle(brush, r);
            }
        }

        // Provide a simple color table so default separators and grips are subtle
        private class ModernColorTable : ProfessionalColorTable
        {
            public override Color ToolStripGradientBegin => Color.White;
            public override Color ToolStripGradientMiddle => Color.FromArgb(250, 250, 250);
            public override Color ToolStripGradientEnd => Color.FromArgb(245, 245, 245);
            public override Color MenuItemSelected => Color.FromArgb(230, 245, 255);
            public override Color MenuItemBorder => Color.FromArgb(200, 200, 200);
            public override Color ImageMarginGradientBegin => Color.White;
            public override Color ImageMarginGradientMiddle => Color.White;
            public override Color ImageMarginGradientEnd => Color.White;
            public override Color SeparatorDark => Color.FromArgb(220, 220, 220);
            public override Color SeparatorLight => Color.FromArgb(240, 240, 240);
        }
    }
}
