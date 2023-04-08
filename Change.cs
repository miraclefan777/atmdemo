using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class Change : Form
    {
        public string account;
        public Change()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShow.Checked)
            {
                TxtNewKey.PasswordChar = '\0';
                TxtConfirm.PasswordChar = '\0';
            }
            else
            {
                TxtNewKey.PasswordChar = '*';
                TxtConfirm.PasswordChar = '*';
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            UserAccount UA = new UserAccount();
            Login log = new Login();

            string oldkey = TxtOldKey.Text.Trim();
            string newkey = TxtNewKey.Text.Trim();
            string cfm = TxtConfirm.Text.Trim();
            if (oldkey == newkey)
            {
                MessageBox.Show("新旧密码一样哟！");
            }
            else if (newkey != cfm)
            {
                MessageBox.Show("两次输入新密码不同，请您确认.");
            }
            else
            {
                if (UA.Change(log._account, oldkey, newkey))
                    MessageBox.Show("密码修改成功");
            }
        }
    }
}
