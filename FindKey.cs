using System;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class FindKey : Form
    {
        public FindKey()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            UserAccount UA = new UserAccount();
            string account = TxtAccount.Text.Trim();
            string id = TxtID.Text.Trim();
            string key;
            key = UA.Findkey(account, id);
            if (key == "IDerror")
                MessageBox.Show("证件号输入错误");
            else if (key != ""&&key!="IDerror")
            {
                TxtKey.Text = key;
                MessageBox.Show("您的密码找到了哦！\n" +
                    "下次记得记下密码哟！");
            }
            else
                MessageBox.Show("密码查询不到，请您检查一下账号是否正确。");
        }

        private void BtnUnfreeze_Click(object sender, EventArgs e)
        {
            UserAccount UA = new UserAccount();
            string account = TxtAccount.Text.Trim();
            string id = TxtID.Text.Trim();
            int ReNum = UA.Unfreeze(account, id);
            if (ReNum==0)
            {
                MessageBox.Show("解冻成功！");
            }              
            else if (ReNum==1)
            {
                MessageBox.Show("证件号错误！请核对");
            }
            else
                MessageBox.Show("账号不存在");
        }
    }
}
