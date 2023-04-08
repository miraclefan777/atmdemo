using System;
using System.Windows.Forms;

namespace ATMDemo
{

    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
           
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            float deposit;
            UserDeposit UD = new UserDeposit();
            deposit = UD.Query(log._account);
            TxtDeposit.Text = $"{deposit:C}";
        }
    }
}
