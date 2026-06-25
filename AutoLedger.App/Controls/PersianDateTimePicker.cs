// PersianDateTimePicker.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{
    [DefaultEvent("SelectedDateTimeChanged")]
    public class PersianDateTimePicker : Control
    {
        private readonly PersianCalendar pc = new PersianCalendar();
        private DateTime selected = DateTime.Now;
        private DateTime minDate = new DateTime(1900, 1, 1);
        private DateTime maxDate = new DateTime(9999, 12, 31);
        private bool dropOpen = false;
        private Button btnDrop;
        private PopupCalendar popup;
        private bool showTime = false;
        private TimeSpan timePart = TimeSpan.Zero;

        private Color accentColor = Color.FromArgb(0, 120, 215);
        private Color borderColor = Color.FromArgb(200, 200, 200);
        private int cornerRadius = 6;

        public event EventHandler SelectedDateTimeChanged;

        public PersianDateTimePicker()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.OptimizedDoubleBuffer, true);

            Height = 30;
            BackColor = Color.White;
            ForeColor = Color.FromArgb(30, 30, 30);

            btnDrop = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "▾",
                Width = 30,
                Dock = DockStyle.Right,
                TabStop = false,
                BackColor = Color.Transparent,
                ForeColor = ForeColor
            };
            btnDrop.FlatAppearance.BorderSize = 0;
            btnDrop.Click += (s, e) => TogglePopup();
            Controls.Add(btnDrop);

            popup = new PopupCalendar(this);
            UpdateTimePartFromSelected();
        }

        #region Properties

        [Category("Behavior")]
        public DateTime SelectedDateTime
        {
            get
            {
                DateTime dateOnly = new DateTime(selected.Year, selected.Month, selected.Day);
                return dateOnly.Date + timePart;
            }
            set
            {
                DateTime v = value;
                if (v < MinDate) v = MinDate;
                if (v > MaxDate) v = MaxDate;
                selected = v.Date;
                timePart = v.TimeOfDay;
                UpdateTimePartFromSelected();
                Invalidate();
                SelectedDateTimeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Category("Behavior")]
        public DateTime MinDate
        {
            get => minDate;
            set { minDate = value; if (selected < minDate) SelectedDateTime = minDate; Invalidate(); }
        }

        [Category("Behavior")]
        public DateTime MaxDate
        {
            get => maxDate;
            set { maxDate = value; if (selected > maxDate) SelectedDateTime = maxDate; Invalidate(); }
        }

        [Category("Appearance")]
        public bool ShowTime
        {
            get => showTime;
            set { showTime = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color AccentColor
        {
            get => accentColor;
            set { accentColor = value; Invalidate(); }
        }

        [Category("Appearance"), DefaultValue(6)]
        public int CornerRadius
        {
            get => cornerRadius;
            set { cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        #endregion

        #region Painting

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent?.BackColor ?? SystemColors.Control);

            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);

            using (var path = RoundedRect(rect, cornerRadius))
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (var pen = new Pen(borderColor, 1f))
            using (var path = RoundedRect(rect, cornerRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // draw text: Persian date (and time if requested)
            string persian = ToPersianString(SelectedDateTime);
            if (ShowTime)
            {
                persian += "  " + SelectedDateTime.ToString("HH:mm");
            }

            Rectangle textRect = new Rectangle(8, 0, Width - btnDrop.Width - 16, Height);
            TextRenderer.DrawText(e.Graphics, persian, Font, textRect, ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }

        private string ToPersianString(DateTime dt)
        {
            int y = pc.GetYear(dt), m = pc.GetMonth(dt), d = pc.GetDayOfMonth(dt);
            string monthName = PersianMonthNames[m - 1];
            return $"{d:00} {monthName} {y}";
        }

        private GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var p = new GraphicsPath();
            if (radius <= 0) p.AddRectangle(r);
            else
            {
                int d = radius * 2;
                p.AddArc(r.X, r.Y, d, d, 180, 90);
                p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
                p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
                p.CloseFigure();
            }
            return p;
        }

        #endregion

        #region Popup handling

        private void TogglePopup()
        {
            if (dropOpen) ClosePopup();
            else OpenPopup();
        }

        private void OpenPopup()
        {
            if (dropOpen) return;
            popup.SetDate(SelectedDateTime);
            var p = PointToScreen(new Point(0, Height));
            popup.ShowAt(p);
            popup.DateSelected += Popup_DateSelected;
            if (ShowTime) popup.TimeChanged += Popup_TimeChanged;
            dropOpen = true;
        }

        private void ClosePopup()
        {
            if (!dropOpen) return;
            popup.HidePopup();
            popup.DateSelected -= Popup_DateSelected;
            if (ShowTime) popup.TimeChanged -= Popup_TimeChanged;
            dropOpen = false;
        }

        private void Popup_DateSelected(object sender, DateTime dt)
        {
            // preserve time part
            DateTime newDt = dt.Date + timePart;
            SelectedDateTime = newDt;
            ClosePopup();
        }

        private void Popup_TimeChanged(object sender, TimeSpan t)
        {
            timePart = t;
            SelectedDateTimeChanged?.Invoke(this, EventArgs.Empty);
            Invalidate();
        }

        #endregion

        #region Helpers

        private void UpdateTimePartFromSelected()
        {
            timePart = new TimeSpan(selected.Hour, selected.Minute, selected.Second);
        }

        private static readonly string[] PersianMonthNames = new[]
        {
            "فروردین","اردیبهشت","خرداد","تیر","مرداد","شهریور",
            "مهر","آبان","آذر","دی","بهمن","اسفند"
        };

        #endregion

        #region PopupCalendar inner class

        private class PopupCalendar : Form
        {
            private readonly PersianCalendar pc = new PersianCalendar();
            private readonly PersianDateTimePicker owner;
            private DateTime current;
            private int cellW = 36, cellH = 28;
            private Font smallFont;
            private Button btnPrev, btnNext;
            private NumericUpDown nudHour, nudMinute;

            public event EventHandler<DateTime> DateSelected;
            public event EventHandler<TimeSpan> TimeChanged;

            public PopupCalendar(PersianDateTimePicker owner)
            {
                this.owner = owner ?? throw new ArgumentNullException(nameof(owner));
                FormBorderStyle = FormBorderStyle.None;
                StartPosition = FormStartPosition.Manual;
                ShowInTaskbar = false;
                BackColor = Color.White;
                Width = cellW * 7 + 16;
                Height = cellH * 7 + 24 + 30; // extra for time controls
                smallFont = new Font(owner.Font.FontFamily, Math.Max(8f, owner.Font.Size - 1f));

                btnPrev = new Button { Text = "<", Width = 28, Height = 22, FlatStyle = FlatStyle.Flat };
                btnNext = new Button { Text = ">", Width = 28, Height = 22, FlatStyle = FlatStyle.Flat };
                btnPrev.FlatAppearance.BorderSize = 0;
                btnNext.FlatAppearance.BorderSize = 0;
                btnPrev.Click += (s, e) => { current = pc.AddMonths(current, -1); Invalidate(); };
                btnNext.Click += (s, e) => { current = pc.AddMonths(current, +1); Invalidate(); };

                nudHour = new NumericUpDown { Minimum = 0, Maximum = 23, Width = 50, Value = 0 };
                nudMinute = new NumericUpDown { Minimum = 0, Maximum = 59, Width = 50, Value = 0 };
                nudHour.ValueChanged += (s, e) => RaiseTimeChanged();
                nudMinute.ValueChanged += (s, e) => RaiseTimeChanged();

                Controls.Add(btnPrev);
                Controls.Add(btnNext);
                Controls.Add(nudHour);
                Controls.Add(nudMinute);

                Deactivate += (s, e) => HidePopup();
            }

            public void SetDate(DateTime dt)
            {
                current = dt;
                nudHour.Value = dt.Hour;
                nudMinute.Value = dt.Minute;
                Invalidate();
            }

            public void ShowAt(Point screen)
            {
                var screenBounds = Screen.FromPoint(screen).WorkingArea;
                int x = screen.X;
                int y = screen.Y;
                if (x + Width > screenBounds.Right) x = screenBounds.Right - Width;
                if (y + Height > screenBounds.Bottom) y = screen.Y - Height - owner.Height;
                Location = new Point(Math.Max(screenBounds.Left, x), Math.Max(screenBounds.Top, y));
                Show();
                Activate();
            }

            public void HidePopup() { Hide(); }

            protected override void OnLayout(LayoutEventArgs levent)
            {
                base.OnLayout(levent);
                btnPrev.Location = new Point(8, 6);
                btnNext.Location = new Point(Width - btnNext.Width - 8, 6);
                // time controls bottom-right
                int timeTop = Height - 28;
                nudMinute.Location = new Point(Width - 8 - nudMinute.Width, timeTop);
                nudHour.Location = new Point(nudMinute.Left - 6 - nudHour.Width, timeTop);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                int year = pc.GetYear(current), month = pc.GetMonth(current);
                string header = $"{PersianMonthNames[month - 1]} {year}";
                TextRenderer.DrawText(e.Graphics, header, owner.Font, new Rectangle(8, 4, Width - 16, 20), owner.accentColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                string[] days = new[] { "ش", "ی", "د", "س", "چ", "پ", "ج" };
                for (int c = 0; c < 7; c++)
                {
                    var r = new Rectangle(8 + c * cellW, 28, cellW, cellH);
                    TextRenderer.DrawText(e.Graphics, days[c], smallFont, r, Color.Gray, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }

                DateTime firstOfMonth = new DateTime(year, month, 1, pc);
                int startIndex = ((int)pc.GetDayOfWeek(firstOfMonth) + 1) % 7;
                int daysInMonth = pc.GetDaysInMonth(year, month);
                int day = 1;
                for (int r = 0; r < 6; r++)
                {
                    for (int c = 0; c < 7; c++)
                    {
                        int idx = r * 7 + c;
                        var cell = new Rectangle(8 + c * cellW, 28 + (r + 1) * cellH, cellW, cellH);
                        if (idx >= startIndex && day <= daysInMonth)
                        {
                            bool isSelected = IsSamePersianDate(owner.SelectedDateTime, year, month, day);
                            if (isSelected)
                                e.Graphics.FillRectangle(new SolidBrush(owner.accentColor), cell);
                            TextRenderer.DrawText(e.Graphics, day.ToString(), smallFont, cell, isSelected ? Color.White : owner.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                            day++;
                        }
                    }
                }
            }

            protected override void OnMouseClick(MouseEventArgs e)
            {
                base.OnMouseClick(e);
                int x = e.X - 8;
                int y = e.Y - 28 - cellH;
                if (x < 0 || y < 0) return;
                int c = x / cellW;
                int r = y / cellH;
                int idx = r * 7 + c;
                DateTime firstOfMonth = new DateTime(pc.GetYear(current), pc.GetMonth(current), 1, pc);
                int startIndex = ((int)pc.GetDayOfWeek(firstOfMonth) + 1) % 7;
                int day = idx - startIndex + 1;
                if (day >= 1 && day <= pc.GetDaysInMonth(pc.GetYear(current), pc.GetMonth(current)))
                {
                    int yP = pc.GetYear(current), mP = pc.GetMonth(current), dP = day;
                    DateTime dt = pc.ToDateTime(yP, mP, dP, 0, 0, 0, 0);
                    DateSelected?.Invoke(this, dt);
                }
            }

            private bool IsSamePersianDate(DateTime dt, int y, int m, int d)
            {
                return pc.GetYear(dt) == y && pc.GetMonth(dt) == m && pc.GetDayOfMonth(dt) == d;
            }

            private void RaiseTimeChanged()
            {
                TimeChanged?.Invoke(this, new TimeSpan((int)nudHour.Value, (int)nudMinute.Value, 0));
            }
        }

        #endregion
    }
}
