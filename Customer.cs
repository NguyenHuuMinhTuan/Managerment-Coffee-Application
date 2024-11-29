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

namespace DoAnBanHangShop
{
    public partial class Customer : Form
    {
        SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        public Customer()
        {
            InitializeComponent();
        }
        void Load_Customer()
        {
            dgv_Customer.DataSource = data.LayDuLieu("SELECT * FROM CUSTOMER");
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            dgv_Customer.DataSource = data.LayDuLieu("SELECT * FROM CUSTOMER");
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CUSTOMER (IDCUSTOMER, FULLNAME, ADDRESS, TEL) " +
              "VALUES (@IDCUSTOMER , @FULLNAME, @ADDRESS, @TEL)";

            try
            {
                
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@IDCUSTOMER", SqlDbType.NVarChar, 50) { Value = txb_IDCus.Text },
            new SqlParameter("@FULLNAME", SqlDbType.NVarChar, 50) { Value = txb_fullName.Text },
            new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = txb_address.Text },
            new SqlParameter("@TEL", SqlDbType.Char,11) { Value = txb_Tel.Text },
         
                };

                
                int rowsAffected = data.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công.");
                  
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

     
            Load_Customer();

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string sql = "Update CUSTOMER " +
               "Set IDCUSTOMER = @IDCUSTOMER, FULLNAME = @FULLNAME, ADDRESS = @ADDRESS, TEL = @TEL " +
               " WHERE  IDCUSTOMER = @IDCUSTOMER ";


            try
            {

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@IDCUSTOMER", SqlDbType.NVarChar, 50) { Value = txb_IDCus.Text },
            new SqlParameter("@FULLNAME", SqlDbType.NVarChar, 50) { Value = txb_fullName.Text },
            new SqlParameter("@ADDRESS", SqlDbType.NVarChar,50) { Value = txb_address.Text },
            new SqlParameter("@TEL", SqlDbType.Char,11) { Value = txb_Tel.Text }
          
                };


                int rowsAffected = data.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            clearALL();
            Load_Customer();


        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Bạn có chắc chắn muốn xoá khách hàng này không?",
           "Xác nhận hành động",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
       );

            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM CUSTOMER WHERE IDCUSTOMER = '" + txb_IDCus.Text + "'";

                int rowsAffected = data.CapNhatDuLieu(sql);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoá khách hàng thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại.");
                }

                clearALL();
                Load_Customer();

               
            }
            else
            {
                
                MessageBox.Show("Hành động đã bị hủy.", "Thông báo");
            }
           

        }

        private void btn_findCus_Click(object sender, EventArgs e)
        {
            dgv_Customer.DataSource = data.LayDuLieu("SELECT * FROM CUSTOMER WHERE FULLNAME LIKE N'%"+txb_fullName.Text +"%'");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INFORMATION DETAIL :\n"+
                "IDCustomer : "+txb_IDCus.Text+"\n"+
                "FULLNAME : "+txb_fullName.Text+"\n"+
                "ADDRESS : "+txb_address.Text+"\n"+
                "TEL : "+txb_Tel.Text+"\n"
                );
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txb_address.Clear();
            txb_fullName.Clear();
            txb_IDCus.Clear();
            txb_Tel.Clear();
        }
        public void clearALL()
        {
            txb_address.Clear();
            txb_fullName.Clear();
            txb_IDCus.Clear();
            txb_Tel.Clear();

        }

        private void btn_detailCustomer_Click(object sender, EventArgs e)
        {
            Chart_Customer p = new Chart_Customer();
            p.ShowDialog();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Load_Customer();
        }
    }
}
