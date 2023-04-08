using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            string account = TxtAccount.Text.Trim();
            string id = TxtID.Text.Trim();
            UserAccount UA = new UserAccount();
            if (MessageBox.Show("您确定要注册此账户吗", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (UA.Cancellation(account, id) == true)
                    MessageBox.Show("账号已经注销\n期待与您再次相遇！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}
