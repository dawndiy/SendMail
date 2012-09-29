using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace SendMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(FromBox.Text);
            msg.To.Add(new MailAddress(SendBox.Text));
            msg.Subject = SubBox.Text;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = BodyBox.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.qq.com";
            //client.Port = 25;
            client.Credentials = new System.Net.NetworkCredential(FromBox.Text, PwdBox.Text);

            try
            {
                client.Send(msg);
                MessageBox.Show("OK!");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message, "发送邮件出错"); 
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Text);
        }
    }
}
