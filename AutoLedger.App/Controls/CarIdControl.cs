using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.Controls
{
    public partial class CarIdControl : UserControl
    {
        public CarIdControl()
        {
            Intilize();
        }

        public CarIdControl(string plateText)
        {
            Intilize(plateText);
        }

        void Intilize(string plateText = null)
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(plateText))
                SetOrClearPlate(plateText);

            inputSuffixCode.TextChanged += AutoTabTextBox_TextChanged;
            inputSerialNumber.TextChanged += AutoTabTextBox_TextChanged;
            inputProvinceCode.TextChanged += AutoTabTextBox_TextChanged;

            inputSuffixCode.KeyDown += NumberTextBox_KeyDown;
            inputSerialNumber.KeyDown += NumberTextBox_KeyDown;
            inputProvinceCode.KeyDown += NumberTextBox_KeyDown;

            cbLetter.SelectedIndexChanged += OnLetterChanged;

        }

        public string ProvinceCode => inputSuffixCode.Text;
        public string Letter => cbLetter.Text;
        public string SerialNumber => inputSerialNumber.Text;
        public string SuffixCode => inputProvinceCode.Text;


        public event EventHandler<string> OnPlateUpdate;

        private void RaisePlateUpdate()
        {
            string currentPlate = GetPlate();
            OnPlateUpdate?.Invoke(this, currentPlate);
        }

        public string GetPlate()
        {
            return $"{ProvinceCode} {Letter} {SerialNumber} {SuffixCode}";
        }
        public void SetOrClearPlate(string plateText)
        {
            if (string.IsNullOrWhiteSpace(plateText))
            {
                inputSuffixCode.Text = "";
                cbLetter.SelectedIndex = -1;
                inputSerialNumber.Text = "";
                inputProvinceCode.Text = "";
                RaisePlateUpdate();
                return;
            }

            var parts = plateText.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 4)
                throw new FormatException("قالب پلاک باید شامل ۴ بخش باشد: کد استان، حرف، شماره سریال و کد انتهایی. مثال: ۱۲ ب ۳۴۵ ۶۷");

            inputSuffixCode.Text = parts[0];

            if (cbLetter.Items.Contains(parts[1]))
                cbLetter.SelectedItem = parts[1];
            else
                throw new FormatException($"حرف '{parts[1]}' برای پلاک مجاز نیست.");

            inputSerialNumber.Text = parts[2];
            inputProvinceCode.Text = parts[3];

            RaisePlateUpdate();
        }

        private void AutoTabTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            if (input.Text.Length >= input.MaxLength && input.MaxLength > 0)
            {
                this.SelectNextControl(input, true, true, true, true);
            }
            RaisePlateUpdate();
        }

        private void OnLetterChanged(object sender, EventArgs e)
        {
            RaisePlateUpdate();
        }

        private void NumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}