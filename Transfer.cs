using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string toaccount = TxtAccount.Text.Trim();
           
            UserDeposit UD = new UserDeposit();
            Login log = new Login();

            try
            {
                float amount = float.Parse(TxtAmount.Text.Trim());
                if (amount < 0)
                {
                    string message = "转账金额不能为为负数";
                    DepositException d= new DepositException(message);
                    throw d;
                }
                if (MessageBox.Show($"对方账号为:{toaccount}\n转账金额:{amount}", "提醒", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int tempReNum = UD.Transfer(log._account, toaccount, amount);
                    if (tempReNum == 1)
                    {
                        MessageBox.Show("余额不足！");
                    }
                    else if (tempReNum == 0)
                    {
                        MessageBox.Show("转账成功");
                    }
                    else
                        MessageBox.Show("对方账户不存在！");
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("转账金额中包含字符！");
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

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
