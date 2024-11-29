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
    public partial class Category : Form
    {
        SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        public Category()
        {
            InitializeComponent();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
        
            LoadCategory();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CATEGORY VALUES (@NAME)";

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = txb_NameCategory.Text }
                };

                int rowsAffected = data.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Insert Complete !.");
                }
                else
                {
                    MessageBox.Show("Insert Fail !.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            ClearAll();
            LoadCategory();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CATEGORY SET NAME = @NAME WHERE ID = @ID";

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@ID", SqlDbType.Int) { Value = int.Parse(txb_IDCategory.Text) },
            new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = txb_NameCategory.Text }
                };

                int rowsAffected = data.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update Complete !");
                }
                else
                {
                    MessageBox.Show("Update Fail !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            ClearAll();
            LoadCategory();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CATEGORY WHERE ID = @ID";

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@ID", SqlDbType.Int) { Value = int.Parse(txb_IDCategory.Text) }
         
                };

                int rowsAffected = data.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete Complete !.");
                }
                else
                {
                    MessageBox.Show("Delete Fail !.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            ClearAll();
            LoadCategory();

        }
        void ClearAll()
        {
            txb_IDCategory.Clear();
            txb_NameCategory.Clear();
        }
        void LoadCategory()
        {
            dgv_Category.DataSource = data.LayDuLieu("SELECT * FROM CATEGORY");
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}
