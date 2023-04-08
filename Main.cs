using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class Main : Form
    {
        private Login log = new Login();
        private Query query = new Query();
        private Save save = new Save();
        private Withdraw withdraw = new Withdraw();
        private Transfer transfer = new Transfer();
        private Change change = new Change();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用中国银行!\n" +
               "期待您下次光临");
            Application.Exit();

        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Show();

        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            change.Show();
            this.Close();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            query.Show();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            save.Show();
            this.Close();
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            withdraw.Show();
            this.Close();
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            transfer.Show();
            this.Close();
        }


    }
}
