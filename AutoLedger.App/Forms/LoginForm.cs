using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.labelVersion.Text = Program.Version;


            //_ = InitializeAsync();
        }

        //private async Task InitializeAsync()
        //{
        //    bool connected = await Program.InitializeDatabase();

        //    if (connected)
        //        this.DialogResult = DialogResult.OK;
        //    else
        //        this.DialogResult = DialogResult.Cancel;

        //    this.Close();
        //}


    }
}
