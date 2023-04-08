using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            UserAccount ac = new UserAccount();
            string account = TxtAccount.Text.Trim();
            string key = TxtKey.Text.Trim();
            string cfm = TxtConfirm.Text.Trim();
            string id = TxtIdentity.Text.Trim();
            string isfrozen = "no";


            try
            {
                int temp = int.Parse(account);//对account尝试转换为整型，判断是否有字符
                
                
                //判断数据库中是否存在该账号，并注册
                int n = ac.Reg(account, key, cfm, id,isfrozen);
                if (n != 0)
                {
                    MessageBox.Show("用户名已存在！");
                    TxtAccount.Text = "";
                    TxtConfirm.Text = "";
                    TxtKey.Text = "";
                }
                else if (key != cfm)
                {
                    MessageBox.Show("两次输入的密码不一致！\n" +
                        "请重新输入");
                    TxtKey.Text = "";
                    TxtConfirm.Text = "";

                }
                else
                {
                    MessageBox.Show("注册成功");
                    Login log = new Login();
                    log.Show();
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("账号中存在字符", "提示");
            }
         
        }


            private void BtnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShow.Checked)
            {
                TxtKey.PasswordChar = '\0';
                TxtConfirm.PasswordChar = '\0';
            }
            else
            {
                TxtKey.PasswordChar = '*';
                TxtConfirm.PasswordChar = '*';
            }
        }


    }

}
