using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            UserDeposit UD = new UserDeposit();
            Login log = new Login();
            try
            {
                float amount = float.Parse(TxtAmount.Text.Trim());
                if (amount < 0)
              {
                    string message = "取款金额不能为负数";
                    DepositException d = new DepositException(message);
                    throw d;
                        }
                if (UD.Withdraw(log._account, amount) == true)
                {
                    MessageBox.Show("取款成功！");
                }
                else
                {
                    MessageBox.Show("余额不足！请查看余额");
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("取款金额中包含字符");
            }
            catch(DepositException d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }


    }
}
