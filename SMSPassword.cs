using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace DoAnBanHangShop
{
    public partial class SMSPassword : Form
    {
        SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        public SMSPassword()
        {
            InitializeComponent();
        }

        private void btn_SMS_Click(object sender, EventArgs e)
        {
            // Thông tin đăng nhập vào tài khoản email gửi đi
            string emailFrom = "minhtuan7543@gmail.com";
            string emailPassword = "brnftqnwrmtkayam"; 

            string Username = txb_UserName.Text;

            int password;
            Random random = new Random();
            password = random.Next(100000, 999999);


          

            string emailTo = txb_Email.Text;

            string hashedPassword = GetMd5Hash(password.ToString());


            string subject = "TLS Shop"; 
            string body = "This is Message request change Password. Your new password is: " + password;

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

            string Convert_Pass = Convert.ToString(password);

            string Gmail = txb_Email.Text;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50) { Value = hashedPassword });
            parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50) { Value = Username });
            parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = Gmail });



            string sql = "Update Account set Password = @Password" +
                " where Username = @UserName And Email = @Email";

            int rowsAffected = data.CapNhatDuLieu(sql,parameters.ToArray());

            if (rowsAffected > 0)
            {
                MessageBox.Show("Approved account !");
            }
            else
            {
                MessageBox.Show("Account approval failed, please check your username or Email again !!! ");
                
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GetMd5Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                // Convert input sang mảng byte và tính toán hash
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Chuyển mảng byte sang chuỗi hexa
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }
    }
}
