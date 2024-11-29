using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;

namespace DoAnBanHangShop
{
    public partial class AccountProfile : Form
    {
        private MemoryStream imageStream;

        private string loggedInUsername;

        private SQLProvider.DataHandle dataHandler;

        SQLProvider.DataHandle data = new SQLProvider.DataHandle();

        public AccountProfile(string Username)
        {
            InitializeComponent();

            dataHandler = new SQLProvider.DataHandle();

            this.loggedInUsername = Username;

            LoadProfile();

        


        }
       


        private void btn_Preview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detail Information : \n" +
                "ID : " + txb_ID.Text + "\n" +
                "UserName : " + txb_Username.Text + "\n" +
                "Password :" + txb_Password.Text + "\n" +
                "Date of Birth :" + txb_DOB.Text + "\n" +
                "Gender :" + mn_Genderr.Value
                ); 
        }
        public void LoadProfile()
        {
            string id = loggedInUsername;

            string sql = "SELECT id, Username, Password, Email, DateofBirth, Gender FROM Account WHERE UserName = @UserName";

            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("@UserName", id)
            };

            DataTable dt = dataHandler.LayDuLieu(sql, parameters);

            if (dt != null && dt.Rows.Count > 0)
            {
                
                DataRow row = dt.Rows[0];

                
                txb_ID.Text = row["id"].ToString();
                txb_Username.Text = row["Username"].ToString();
                txb_Email.Text = row["email"].ToString();
                txb_Password.Text = row["Password"].ToString();
                txb_DOB.Text = row["DateofBirth"].ToString();
                mn_Genderr.Value = int.Parse(row["Gender"].ToString());
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản.");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txb_DOB.Clear();
            txb_ID.Clear();
            txb_Password.Clear();
            txb_Username.Clear();
            mn_Genderr.Value.ToString();
        }

        private void btn_ChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;

                    // Đọc dữ liệu từ tập tin hình ảnh và lưu vào MemoryStream
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        imageStream = new MemoryStream();
                        fs.CopyTo(imageStream);
                    }

                    // Hiển thị hình ảnh từ MemoryStream trong PictureBox
                    pb_Employment.Image = Image.FromStream(imageStream);

                    // Để tự động thay đổi kích thước hình ảnh để vừa với PictureBox, sử dụng SizeMode.Zoom
                    pb_Employment.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            
             }
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
        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
           
            string Id = txb_ID.Text;

            string password = "0";



            string sql = "Update Account set Password = @password Where id = @id ";

            string hashedPassword = GetMd5Hash(password.ToString());


            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("@id",Id),
             new SqlParameter("@password",hashedPassword)
            };
            int dt = data.CapNhatDuLieu(sql, parameters);

            if (dt > 0)
            {
                MessageBox.Show("Update Complete !");
                LoadProfile();

            }
            else
            {
                MessageBox.Show("Update Fail !");
            }

        }
      

        private void btn_UpdateAccount_Click(object sender, EventArgs e)
        {
            string Id = txb_ID.Text;

            string Pass = txb_Username.Text;

            string sql = "Update Account set Password = @Password Where id = @id ";

            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("@id",Id),
              new SqlParameter("@Password",Pass)
            };
            int dt = data.CapNhatDuLieu(sql, parameters);

            if (dt > 0)
            {
                MessageBox.Show("Update Complete !");
            }
            else
            {
                MessageBox.Show("Update Fail !");
            }


        }

        private void ck_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Show.Checked==true)
            {
                txb_Password.PasswordChar= '\0';

            }
            else
            {
                txb_Password.PasswordChar = '*';
            }
        }
    }
    
}
