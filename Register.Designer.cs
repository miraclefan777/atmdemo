
namespace ATMDemo
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.ChkShow = new System.Windows.Forms.CheckBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TxtConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKey = new System.Windows.Forms.TextBox();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdentity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkShow
            // 
            this.ChkShow.AutoSize = true;
            this.ChkShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChkShow.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkShow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ChkShow.Location = new System.Drawing.Point(674, 314);
            this.ChkShow.Name = "ChkShow";
            this.ChkShow.Size = new System.Drawing.Size(153, 40);
            this.ChkShow.TabIndex = 22;
            this.ChkShow.Text = "显示密码";
            this.ChkShow.UseVisualStyleBackColor = false;
            this.ChkShow.CheckedChanged += new System.EventHandler(this.ChkShow_CheckedChanged);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnConfirm.Location = new System.Drawing.Point(171, 513);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(140, 46);
            this.BtnConfirm.TabIndex = 21;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TxtConfirm
            // 
            this.TxtConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtConfirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtConfirm.Location = new System.Drawing.Point(412, 354);
            this.TxtConfirm.Name = "TxtConfirm";
            this.TxtConfirm.PasswordChar = '*';
            this.TxtConfirm.Size = new System.Drawing.Size(231, 43);
            this.TxtConfirm.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(181, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 42);
            this.label4.TabIndex = 19;
            this.label4.Text = "确认密码：";
            // 
            // TxtKey
            // 
            this.TxtKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtKey.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKey.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtKey.Location = new System.Drawing.Point(412, 277);
            this.TxtKey.Name = "TxtKey";
            this.TxtKey.PasswordChar = '*';
            this.TxtKey.Size = new System.Drawing.Size(231, 43);
            this.TxtKey.TabIndex = 18;
            // 
            // TxtAccount
            // 
            this.TxtAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAccount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtAccount.Location = new System.Drawing.Point(412, 200);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(231, 43);
            this.TxtAccount.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(213, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(213, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "账户：";
            // 
            // TxtIdentity
            // 
            this.TxtIdentity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtIdentity.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdentity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtIdentity.Location = new System.Drawing.Point(412, 431);
            this.TxtIdentity.Name = "TxtIdentity";
            this.TxtIdentity.Size = new System.Drawing.Size(231, 43);
            this.TxtIdentity.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(181, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 42);
            this.label5.TabIndex = 23;
            this.label5.Text = "证件号码：";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnBack.Location = new System.Drawing.Point(584, 513);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(140, 46);
            this.BtnBack.TabIndex = 25;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 592);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxtIdentity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChkShow);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TxtConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtKey);
            this.Controls.Add(this.TxtAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkShow;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TxtConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKey;
        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdentity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}