using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnBanHangShop.ORM;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DoAnBanHangShop
{
    public partial class Account : Form
    {
        Model database = new Model();
        public Account()
        {
            InitializeComponent();
        }
        SQLProvider.DataHandle data = new SQLProvider.DataHandle();

        private void Account_Load(object sender, EventArgs e)
        {
            dgv_Account.DataSource = data.LayDuLieu("SELECT * FROM ACCOUNT");
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_ID.Text) &&
                string.IsNullOrWhiteSpace(txb_UserName.Text) &&
                 string.IsNullOrWhiteSpace(txb_Password.Text) &&
                  string.IsNullOrWhiteSpace(txb_Email.Text) &&
                   string.IsNullOrWhiteSpace(txb_Position.Text) &&
                    string.IsNullOrWhiteSpace(ck_Gender.Text) &&
                     string.IsNullOrWhiteSpace(nm_Type.Text)
                )
            {
                MessageBox.Show("Do not leave any information blank !!! ");
            }
            else
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                string Id = txb_ID.Text;
                string username = txb_UserName.Text;
                string password = txb_Password.Text;
                string email = txb_Email.Text;
                DateTime dateCheckin = Convert.ToDateTime(dtp_DOB.Value);
                string convertedDate = dateCheckin.ToString("yyyy-MM-dd");
                string position = txb_Position.Text;
                int Gender = ck_Gender.Checked ? 1 : 0;
                int Type = (int)nm_Type.Value;

                parameters.Add(new SqlParameter("@ID", SqlDbType.NVarChar, 20) { Value = Id });
                parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50) { Value = username });
                parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50) { Value = password });
                parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = email });
                parameters.Add(new SqlParameter("@Date", SqlDbType.Date) { Value = convertedDate });
                parameters.Add(new SqlParameter("@Position", SqlDbType.NVarChar, 50) { Value = position });
                parameters.Add(new SqlParameter("@Gender", SqlDbType.Int) { Value = Gender });
                parameters.Add(new SqlParameter("@Type", SqlDbType.Int) { Value = Type });

                string sql = "Insert into Account Values ( @ID, @UserName, LOWER (CONVERT(Nvarchar(50),HASHBYTES('MD5',@Password),2)), " +
                " @Email, @Date, @Position, @Gender, @Type )";

                try
                {
                    int rowsAffected = data.CapNhatDuLieu(sql, parameters.ToArray());

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Insert Account Complete !.");
                    }
                    else
                    {
                        MessageBox.Show("Insert Account Fail, Please try again !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            ClearAll();


        }
        void ClearAll()
        {
            txb_ID.Clear();
            txb_UserName.Clear();
            txb_Password.Clear();
            txb_Email.Clear();
            txb_Position.Clear();
            
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dgv_Account.DataSource = data.LayDuLieu("SELECT * FROM ACCOUNT");
        }

        private void dgv_Account_SelectionChanged(object sender, EventArgs e)
        {
           
                // Kiểm tra xem có dòng nào được chọn không
                if (dgv_Account.SelectedRows.Count > 0)
                {
                    // Lấy dòng đầu tiên trong các dòng đã chọn (ở đây chọn dòng đầu tiên)
                    DataGridViewRow selectedRow = dgv_Account.SelectedRows[0];

                    // Lấy giá trị từ các ô cột tương ứng và hiển thị lên các TextBox
                    txb_ID.Text = selectedRow.Cells["ID"].Value.ToString();
                    txb_UserName.Text = selectedRow.Cells["UserName"].Value.ToString();
                    txb_Password.Text = selectedRow.Cells["Password"].Value.ToString();
                    txb_Email.Text = selectedRow.Cells["Email"].Value.ToString();
                  txb_Position.Text = selectedRow.Cells["Position"].Value.ToString();

                 }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txb_ID.Clear();
            txb_UserName.Clear();
            txb_Password.Clear();
            txb_Email.Clear();
            txb_Position.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_ID.Text) &&
               string.IsNullOrWhiteSpace(txb_UserName.Text) &&
                string.IsNullOrWhiteSpace(txb_Password.Text) &&
                 string.IsNullOrWhiteSpace(txb_Email.Text) &&
                  string.IsNullOrWhiteSpace(txb_Position.Text) &&
                   string.IsNullOrWhiteSpace(ck_Gender.Text) &&
                    string.IsNullOrWhiteSpace(nm_Type.Text)
               )
            {
                MessageBox.Show("Do not leave any information blank !!! ");
            }
            else
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                string Id = txb_ID.Text;
                string username = txb_UserName.Text;
                string password = txb_Password.Text;
                string email = txb_Email.Text;
                DateTime dateCheckin = Convert.ToDateTime(dtp_DOB.Value);
                string convertedDate = dateCheckin.ToString("yyyy-MM-dd");
                string position = txb_Position.Text;
                int Gender = ck_Gender.Checked ? 1 : 0;
                int Type = (int)nm_Type.Value;

                parameters.Add(new SqlParameter("@ID", SqlDbType.NVarChar, 20) { Value = Id });
                parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50) { Value = username });
                parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50) { Value = password });
                parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = email });
                parameters.Add(new SqlParameter("@Date", SqlDbType.Date) { Value = convertedDate });
                parameters.Add(new SqlParameter("@Position", SqlDbType.NVarChar, 50) { Value = position });
                parameters.Add(new SqlParameter("@Gender", SqlDbType.Int) { Value = Gender });
                parameters.Add(new SqlParameter("@Type", SqlDbType.Int) { Value = Type });

                string sql = "Update Account set ID = @ID, password =  LOWER (CONVERT(Nvarchar(50),HASHBYTES('MD5',@Password),2)), " +
                " Email = @Email, DateOfBirth = @Date, Position = @Position, Gender = @Gender, Type = @Type " +
                " Where ID = @ID";

                try
                {
                    int rowsAffected = data.CapNhatDuLieu(sql, parameters.ToArray());

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update Account Complete !.");
                    }
                    else
                    {
                        MessageBox.Show("Update Account Fail, Please try again !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            ClearAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE From Account Where id = N'"+txb_ID.Text+"'";

            int rowsAffected = data.CapNhatDuLieu(sql);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Delete Account Complete !.");
            }
            else
            {
                MessageBox.Show("Delete Account Fail, Please try again !!!");
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string findUsername = txb_Find.Text;

            string sql = "Select * from Account where UserName like N'%"+findUsername+"%'";

            dgv_Account.DataSource = data.LayDuLieu(sql);

          
        }
    }
}
