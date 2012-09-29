namespace SendMail
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Fromlab = new System.Windows.Forms.Label();
            this.Sendlab = new System.Windows.Forms.Label();
            this.Bodylab = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.BodyBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pwdlab = new System.Windows.Forms.Label();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.Sublab = new System.Windows.Forms.Label();
            this.SubBox = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // Fromlab
            // 
            this.Fromlab.AutoSize = true;
            this.Fromlab.Location = new System.Drawing.Point(25, 20);
            this.Fromlab.Name = "Fromlab";
            this.Fromlab.Size = new System.Drawing.Size(47, 12);
            this.Fromlab.TabIndex = 0;
            this.Fromlab.Text = "发件人:";
            // 
            // Sendlab
            // 
            this.Sendlab.AutoSize = true;
            this.Sendlab.Location = new System.Drawing.Point(25, 74);
            this.Sendlab.Name = "Sendlab";
            this.Sendlab.Size = new System.Drawing.Size(47, 12);
            this.Sendlab.TabIndex = 1;
            this.Sendlab.Text = "收件人:";
            // 
            // Bodylab
            // 
            this.Bodylab.AutoSize = true;
            this.Bodylab.Location = new System.Drawing.Point(25, 143);
            this.Bodylab.Name = "Bodylab";
            this.Bodylab.Size = new System.Drawing.Size(47, 12);
            this.Bodylab.TabIndex = 2;
            this.Bodylab.Text = "内  容:";
            // 
            // FromBox
            // 
            this.FromBox.Location = new System.Drawing.Point(78, 17);
            this.FromBox.Name = "FromBox";
            this.FromBox.ReadOnly = true;
            this.FromBox.Size = new System.Drawing.Size(106, 21);
            this.FromBox.TabIndex = 1;
            this.FromBox.Text = "11111111@qq.com";
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(78, 71);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(181, 21);
            this.SendBox.TabIndex = 3;
            // 
            // BodyBox
            // 
            this.BodyBox.Location = new System.Drawing.Point(27, 159);
            this.BodyBox.Multiline = true;
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(232, 138);
            this.BodyBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "发  送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "重  置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pwdlab
            // 
            this.Pwdlab.AutoSize = true;
            this.Pwdlab.Location = new System.Drawing.Point(25, 47);
            this.Pwdlab.Name = "Pwdlab";
            this.Pwdlab.Size = new System.Drawing.Size(47, 12);
            this.Pwdlab.TabIndex = 8;
            this.Pwdlab.Text = "密  码:";
            // 
            // PwdBox
            // 
            this.PwdBox.Location = new System.Drawing.Point(78, 44);
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.PasswordChar = '*';
            this.PwdBox.ReadOnly = true;
            this.PwdBox.Size = new System.Drawing.Size(181, 21);
            this.PwdBox.TabIndex = 2;
            this.PwdBox.Text = "*****";
            // 
            // Sublab
            // 
            this.Sublab.AutoSize = true;
            this.Sublab.Location = new System.Drawing.Point(25, 101);
            this.Sublab.Name = "Sublab";
            this.Sublab.Size = new System.Drawing.Size(47, 12);
            this.Sublab.TabIndex = 10;
            this.Sublab.Text = "主  题:";
            // 
            // SubBox
            // 
            this.SubBox.Location = new System.Drawing.Point(78, 98);
            this.SubBox.Name = "SubBox";
            this.SubBox.Size = new System.Drawing.Size(181, 21);
            this.SubBox.TabIndex = 4;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("@qq.com");
            this.domainUpDown1.Items.Add("@163.com");
            this.domainUpDown1.Items.Add("@126.com");
            this.domainUpDown1.Location = new System.Drawing.Point(190, 17);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(69, 21);
            this.domainUpDown1.TabIndex = 11;
            this.domainUpDown1.Text = "@qq.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 355);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.SubBox);
            this.Controls.Add(this.Sublab);
            this.Controls.Add(this.PwdBox);
            this.Controls.Add(this.Pwdlab);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BodyBox);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.Bodylab);
            this.Controls.Add(this.Sendlab);
            this.Controls.Add(this.Fromlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "邮件发送";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fromlab;
        private System.Windows.Forms.Label Sendlab;
        private System.Windows.Forms.Label Bodylab;
        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.TextBox BodyBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Pwdlab;
        private System.Windows.Forms.TextBox PwdBox;
        private System.Windows.Forms.Label Sublab;
        private System.Windows.Forms.TextBox SubBox;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}

