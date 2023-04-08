using System;
using System.Windows.Forms;

namespace ATMDemo
{

    public partial class Login : Form
    {
        private static string account;
        private static int count = 0;
        private static int[] time = new int[3] { 60, 300, 600 };
        private static int temptime;

        public string _account
        {
            get
            {
                return account;
            }
        }


        public Login()
        {
            InitializeComponent();
        }
        private void BtnLog_Click(object sender, EventArgs e)
        {
            UserAccount ac = new UserAccount();
            account = TxtAccount.Text.Trim();
            
            try
            {
                int temp = int.Parse(account);

                if (count >= 3 && count < 6)
                {
                    //temptime = time[count - 3];
                    temptime = 3;
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                    timer1.Start();
                    BtnLog.Enabled = false;
                    TxtKey.ReadOnly = true;
                }
                if(count>=6)
                {
                    ac.Frozen(account);
                    count = 0;
                }

                int tempnum = ac.Judge(account, TxtKey.Text.Trim());
                if (tempnum == 1)
                {
                    MessageBox.Show("欢迎使用中国银行！");
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                    count = 0;
                }
                else if (tempnum == 0)
                {
                    MessageBox.Show("此账号已冻结");
                }
                else if (tempnum == 2)
                {
                    MessageBox.Show("您输入的密码错误");
                    count++;
                    TxtKey.Clear();
                }
                else
                    MessageBox.Show("账号不存在，请您检查！");

                

            }
            catch (FormatException ex)
            {
                MessageBox.Show("账号中存在包含字符");
            }
        }

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShow.Checked)
                TxtKey.PasswordChar = '\0';
            else
                TxtKey.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FindKey find = new FindKey();
            find.Show();
            this.Hide();
        }

        private void LinkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void LinkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cancellation cancel = new Cancellation();
            cancel.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (temptime == 0)
            {             
                label3.Text = "";
                timer1.Enabled = false;
                BtnLog.Enabled = true;
                TxtKey.ReadOnly = false;
                MessageBox.Show($"倒计时结束，您还有{6 - count}次机会");
            }
            else
            {
                label3.Text = "您还需等待" + temptime + "s才能重新输入";
                temptime--;
               

                
            }
        }
    }






}





