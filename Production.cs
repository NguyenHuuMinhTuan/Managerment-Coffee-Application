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
    public partial class Production : Form
    {
        private const string connectionString = "Data Source=your_server;Initial Catalog=Shop_TL;Integrated Security=True";
        SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        private SQLProvider sqlProvider = new SQLProvider();
        private Dictionary<int, string> categoryDictionary = new Dictionary<int, string>();
        public Production()
        {
            InitializeComponent();
            LoadCategory();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgv_Product.DataSource = data.LayDuLieu("select * from Product");
        
            
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            // Xử lý khi người dùng click vào button sản phẩm
            Button btnProduct = sender as Button;
            string description = btnProduct.Tag.ToString();
            MessageBox.Show(description, "Chi tiết sản phẩm");
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
           
            LoadProducts();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadCategory()
        {
            try
            {
                string sql = "SELECT id, name FROM category";
                SqlParameter[] parameters = null;

                DataTable dt = data.LayDuLieu(sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    cb_Category.Items.Clear();
                    categoryDictionary.Clear(); // Clear dictionary before re-populating

                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string name = row["name"].ToString();

                        cb_Category.Items.Add(name); // Add name to ComboBox

                        // Add to dictionary for later reference
                        categoryDictionary.Add(id, name);
                    }

                    cb_Category.SelectedIndex = 0; // Select the first item by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu danh mục: " + ex.Message);
            }
        }
    

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO PRODUCT (IDProduct, NameGoods, size, idCategory, Price, quantity) " +
                           "VALUES (@IDProduct , @NameGoods, @size, @idCategory, @Price, @Quantity)";

            try
            {
                // Lấy idCategory từ categoryDictionary thay vì từ ComboBox
                string selectedCategoryName = cb_Category.SelectedItem.ToString();
                int selectedCategoryId = -1; // Default value in case not found

                // Find the id corresponding to the selected name in the dictionary
                foreach (var pair in categoryDictionary)
                {
                    if (pair.Value == selectedCategoryName)
                    {
                        selectedCategoryId = pair.Key;
                        break;
                    }
                }

                // Nếu không tìm thấy selectedCategoryId, xử lý lỗi hoặc thông báo cho người dùng

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@IDProduct", SqlDbType.NVarChar, 50) { Value = txb_IDPro.Text },
            new SqlParameter("@NameGoods", SqlDbType.NVarChar, 50) { Value = txb_NamePro.Text },
            new SqlParameter("@size", SqlDbType.Char, 5) { Value = txb_SizePro.Text },
            new SqlParameter("@idCategory", SqlDbType.Int) { Value = selectedCategoryId },
            new SqlParameter("@Price", SqlDbType.Float) { Value = float.Parse(txb_Price.Text) },
            new SqlParameter("@Quantity", SqlDbType.Int) { Value = int.Parse(txb_QuantityPro.Text) }
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
            LoadProducts();
            ClearAll();

        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cb_Category.SelectedItem.ToString();

            // Find the id corresponding to the selected name in the dictionary
            foreach (var pair in categoryDictionary)
            {
                if (pair.Value == selectedName)
                {
                    int selectedId = pair.Key;
                    // Now you have the selected id
                    // Do whatever you need with this id
                    break;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
                string sql = "UPDATE PRODUCT SET NameGoods = @NameGoods, size = @size, idCategory = @idCategory, " +
                             "Price = @Price, quantity = @Quantity WHERE IDProduct = @IDProduct";

                try
                {
                    // Lấy idCategory từ categoryDictionary thay vì từ ComboBox
                    string selectedCategoryName = cb_Category.SelectedItem.ToString();
                    int selectedCategoryId = -1; // Default value in case not found

                    // Find the id corresponding to the selected name in the dictionary
                    foreach (var pair in categoryDictionary)
                    {
                        if (pair.Value == selectedCategoryName)
                        {
                            selectedCategoryId = pair.Key;
                            break;
                        }
                    }

                    // Nếu không tìm thấy selectedCategoryId, xử lý lỗi hoặc thông báo cho người dùng

                    SqlParameter[] parameters = new SqlParameter[]
                    {
            new SqlParameter("@IDProduct", SqlDbType.NVarChar, 50) { Value = txb_IDPro.Text },
            new SqlParameter("@NameGoods", SqlDbType.NVarChar, 50) { Value = txb_NamePro.Text },
            new SqlParameter("@size", SqlDbType.Char, 5) { Value = txb_SizePro.Text },
            new SqlParameter("@idCategory", SqlDbType.Int) { Value = selectedCategoryId },
            new SqlParameter("@Price", SqlDbType.Float) { Value = float.Parse(txb_Price.Text) },
            new SqlParameter("@Quantity", SqlDbType.Int) { Value = int.Parse(txb_QuantityPro.Text) }
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
            LoadProducts();
            ClearAll();


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
         
                string sql = "DELETE FROM PRODUCT WHERE IDProduct = @IDProduct";

                try
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
            new SqlParameter("@IDProduct", SqlDbType.NVarChar, 50) { Value = txb_IDPro.Text }
                    };

                    int rowsAffected = data.CapNhatDuLieu(sql, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            LoadProducts();

            ClearAll();


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
        void ClearAll()
        {

            txb_IDPro.Clear();
            txb_NamePro.Clear();
            txb_Price.Clear();
            txb_QuantityPro.Clear();
            txb_SizePro.Clear();
        }
           
    }

      
    
}

