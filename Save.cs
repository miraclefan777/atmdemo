using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {     
            Login log = new Login();
            UserDeposit UD = new UserDeposit();
            try
            {
                float amount = float.Parse(TxtAmount.Text.Trim());
                if (amount < 0)
                {
                    string message = "存款金额为负数！";
                    DepositException d = new DepositException(message);
                    throw d;
                }
                if (UD.Save(log._account, amount) == true)
                {
                    MessageBox.Show($"您成功存入{amount}元");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("存款金额中存在字符！");
            }
            catch (DepositException d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void Save_Load(object sender, EventArgs e)
        {

        }
    }
}
