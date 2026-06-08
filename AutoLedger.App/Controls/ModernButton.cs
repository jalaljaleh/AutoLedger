using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.App.Controls
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class ModernButton : Button
    {
        #region Fields and Properties

        private int cornerRadius = 6;
        private Color hoverBackColor = Color.LightGray;
        private Color pressedBackColor = Color.DarkGray;
        private Color borderColor = Color.Gray;
        private Color hoverBorderColor = Color.Gray;
        private Color pressedBorderColor = Color.Gray;
        private bool isHovered;
        private bool isPressed;

        [Category("Appearance"), DefaultValue(6)]
        public int CornerRadius
        {
            get => cornerRadius;
            set { cornerRadius = Math.Max(0, value); Invalidate(); }
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
        public Color HoverBorderColor
        {
            get => hoverBorderColor;
            set { hoverBorderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color PressedBorderColor
        {
            get => pressedBorderColor;
            set { pressedBorderColor = value; Invalidate(); }
        }

        #endregion

        public ModernButton()
        {
            // Remove standard button styling
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.Selectable, true);

            BackColor = Color.FromArgb(0, 120, 212);   // Modern blue
            ForeColor = Color.White;
            Size = new Size(120, 40);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            isHovered = false;
            isPressed = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                isPressed = true;
                Invalidate();
            }
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            isPressed = false;
            Invalidate();
            base.OnMouseUp(mevent);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Determine current colours
            Color back = BackColor;
            Color border = BorderColor;
            if (!Enabled)
            {
                back = ControlPaint.Light(BackColor);
                border = SystemColors.InactiveBorder;
            }
            else if (isPressed)
            {
                back = PressedBackColor;
                border = PressedBorderColor;
            }
            else if (isHovered)
            {
                back = HoverBackColor;
                border = HoverBorderColor;
            }

            // Draw background
            using (var brush = new SolidBrush(back))
            using (var path = GetRoundedRect(ClientRectangle, cornerRadius))
            {
                e.Graphics.FillPath(brush, path);

                // Border
                if (border.A > 0)
                    using (var pen = new Pen(border, 1.5f))
                        e.Graphics.DrawPath(pen, path);
            }

            // Draw image and text
            Rectangle contentRect = ClientRectangle;
            contentRect.Inflate(-4, -4); // inner padding

            Image img = Image;
            string txt = Text;
            if (img != null && !string.IsNullOrEmpty(txt))
            {
                // Both image and text
                DrawImageAndText(e.Graphics, img, txt, contentRect, ForeColor, Font,
                                 TextImageRelation, RightToLeft == RightToLeft.Yes);
            }
            else if (img != null)
            {
                // Image only
                DrawImageOnly(e.Graphics, img, contentRect, ForeColor, Enabled);
            }
            else
            {
                // Text only
                DrawTextOnly(e.Graphics, txt, contentRect, ForeColor, Font,
                             TextAlign, RightToLeft == RightToLeft.Yes);
            }

            // Focus rectangle
            if (Focused && ShowFocusCues)
            {
                Rectangle focusRect = ClientRectangle;
                focusRect.Inflate(-4, -4);
                ControlPaint.DrawFocusRectangle(e.Graphics, focusRect);
            }
        }

        #region Drawing Helpers

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
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

        private void DrawTextOnly(Graphics g, string text, Rectangle rect,
                                  Color color, Font font, ContentAlignment align, bool rtl)
        {
            TextFormatFlags flags = GetTextFormatFlags(align, rtl);
            TextRenderer.DrawText(g, text, font, rect, color, flags);
        }

        private void DrawImageOnly(Graphics g, Image img, Rectangle rect,
                                   Color color, bool enabled)
        {
            // Center image
            int x = rect.X + (rect.Width - img.Width) / 2;
            int y = rect.Y + (rect.Height - img.Height) / 2;
            if (!enabled)
                ControlPaint.DrawImageDisabled(g, img, x, y, Color.Transparent);
            else
                g.DrawImage(img, x, y);
        }

        private void DrawImageAndText(Graphics g, Image img, string text,
                                      Rectangle rect, Color color, Font font,
                                      TextImageRelation relation, bool rtl)
        {
            // Measure image and text
            Size imgSize = img.Size;
            Size textSize = TextRenderer.MeasureText(text, font);

            int spacing = 4;
            int totalWidth, totalHeight;

            if (relation == TextImageRelation.ImageBeforeText ||
                relation == TextImageRelation.TextBeforeImage)
            {
                totalWidth = imgSize.Width + spacing + textSize.Width;
                totalHeight = Math.Max(imgSize.Height, textSize.Height);
            }
            else // ImageAboveText, TextAboveImage
            {
                totalWidth = Math.Max(imgSize.Width, textSize.Width);
                totalHeight = imgSize.Height + spacing + textSize.Height;
            }

            int startX = rect.X + (rect.Width - totalWidth) / 2;
            int startY = rect.Y + (rect.Height - totalHeight) / 2;

            Rectangle imgRect, textRect;
            switch (relation)
            {
                case TextImageRelation.ImageBeforeText:
                    imgRect = new Rectangle(startX, rect.Y + (rect.Height - imgSize.Height) / 2,
                                            imgSize.Width, imgSize.Height);
                    textRect = new Rectangle(startX + imgSize.Width + spacing,
                                             rect.Y, textSize.Width, rect.Height);
                    break;
                case TextImageRelation.TextBeforeImage:
                    textRect = new Rectangle(startX, rect.Y, textSize.Width, rect.Height);
                    imgRect = new Rectangle(startX + textSize.Width + spacing,
                                            rect.Y + (rect.Height - imgSize.Height) / 2,
                                            imgSize.Width, imgSize.Height);
                    break;
                case TextImageRelation.ImageAboveText:
                    imgRect = new Rectangle(rect.X + (rect.Width - imgSize.Width) / 2,
                                            startY, imgSize.Width, imgSize.Height);
                    textRect = new Rectangle(rect.X, startY + imgSize.Height + spacing,
                                             rect.Width, textSize.Height);
                    break;
                default: // TextAboveImage
                    textRect = new Rectangle(rect.X, startY, rect.Width, textSize.Height);
                    imgRect = new Rectangle(rect.X + (rect.Width - imgSize.Width) / 2,
                                            startY + textSize.Height + spacing,
                                            imgSize.Width, imgSize.Height);
                    break;
            }

            // Draw image (respect enabled state)
            if (!Enabled)
                ControlPaint.DrawImageDisabled(g, img, imgRect.X, imgRect.Y, Color.Transparent);
            else
                g.DrawImage(img, imgRect);

            // Draw text
            TextFormatFlags flags = GetTextFormatFlags(ContentAlignment.MiddleCenter, rtl);
            TextRenderer.DrawText(g, text, font, textRect, color, flags);
        }

        private TextFormatFlags GetTextFormatFlags(ContentAlignment align, bool rtl)
        {
            TextFormatFlags flags = TextFormatFlags.WordBreak |
                                    TextFormatFlags.NoPrefix |
                                    TextFormatFlags.EndEllipsis;

            // Horizontal
            if (align.ToString().Contains("Left"))
                flags |= TextFormatFlags.Left;
            else if (align.ToString().Contains("Right"))
                flags |= TextFormatFlags.Right;
            else
                flags |= TextFormatFlags.HorizontalCenter;

            // Vertical
            if (align.ToString().Contains("Top"))
                flags |= TextFormatFlags.Top;
            else if (align.ToString().Contains("Bottom"))
                flags |= TextFormatFlags.Bottom;
            else
                flags |= TextFormatFlags.VerticalCenter;

            if (rtl)
                flags |= TextFormatFlags.RightToLeft;

            return flags;
        }

        #endregion
    }
}
