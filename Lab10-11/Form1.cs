using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Lab10_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Password = textBox2.Text;
            string MessageBody = "";
            MailMessage mail = new MailMessage();
            SmtpClient Smtp_Client = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(this.textBox1.Text.Trim());
            mail.To.Add(this.textBox3.Text.Trim());
            mail.Subject = this.textBox4.Text;
            mail.Body = this.richTextBox1.Text;
            mail.IsBodyHtml = false;
            Smtp_Client.Port = 587;
            Smtp_Client.Credentials = new System.Net.NetworkCredential(this.textBox1.Text, Password);
            Smtp_Client.EnableSsl = true;
            try
            {
                Smtp_Client.Send(mail);
            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.Message); }

        }
    }
}
