using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanHangShop
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // Thông tin đăng nhập vào tài khoản email gửi đi
            string emailFrom = "minhtuan7543@gmail.com";
            string emailPassword = "brnftqnwrmtkayam";

            string emailTo ="minhtuan7543@gmail.com";

            string subject = txb_Username.Text;
            string body = "This is Message request Register with Position :" + txb_Position.Text + "\n" +
                "Username :" + txb_Username.Text + "\n Email :" + txb_Email.Text + "\n Date Of Birth :" + txb_DOB.Text + "\n Gender :" + txb_Gender.Text;
                          ;

            try
            {

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;


                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); // SMTP server của Gmail
                smtpClient.Port = 587; // Cổng SMTP của Gmail cho TLS
                smtpClient.Credentials = new NetworkCredential(emailFrom, emailPassword);
                smtpClient.EnableSsl = true; // Sử dụng SSL

                // Gửi email
                smtpClient.Send(mail);

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error message: " + ex.Message);
            }


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
