using DoAnBanHangShop.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnBanHangShop
{
    public partial class Payment : Form
    {
        private DataTable dataTable;
        private SQLProvider sqlProvider = new SQLProvider();
        private SQLProvider.DataHandle dataHandler;
        private string connectionString = "Data Source=ADMIN;Initial Catalog=Shop_TL;Integrated Security=True";
        private SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        private LoadComboxBillDAO loadComboxBillDAO;
        private string SaveUserName;
        private static Random random = new Random();

        public Payment(string username)
        {
            InitializeComponent();
            this.SaveUserName = username;
            loadComboxBillDAO = new LoadComboxBillDAO(connectionString);
            dataHandler = new SQLProvider.DataHandle();
            LoadCategory();
            LoadIDCustomer();
            cb_Category.SelectedIndexChanged += cb_Category_SelectedIndexChanged;
            cb_IDProduct.SelectedIndexChanged += cb_IDProduct_SelectedIndexChanged;

           
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cb_IDCustomer.Text) || String.IsNullOrWhiteSpace(cb_Category.Text) || String.IsNullOrWhiteSpace(mn_Quantity.Text) || String.IsNullOrWhiteSpace(cb_IDCustomer.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                LoadIDUserNameFromData();
                LoadInfomation();
                LoadCategoryID();

                string Id = string.Empty;
                foreach (DataGridViewRow row in dgv_Id.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        Id = row.Cells[0].Value?.ToString();
                    }
                }
                string idCategory = string.Empty;
                foreach (DataGridViewRow row in dgv_IdCategory.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        idCategory = row.Cells[0].Value?.ToString();
                    }
                }

                foreach (DataGridViewRow row in dgv_Infomation.Rows)
                {
                   
                    if (!row.IsNewRow)
                    {
                       
                        string NameProduct = row.Cells[0].Value?.ToString();
                        string Price = row.Cells[1].Value?.ToString();
                        string idProduct = cb_IDProduct.Text;
                        int quantityToAdd = (int)mn_Quantity.Value;

                        DateTime convertDate1 = dtp_Payment.Value;
                        string Username = txb_Username.Text;

                       
                        bool productExists = false;
                        foreach (DataGridViewRow paymentRow in dgv_Bill.Rows)
                        {
                            if (!paymentRow.IsNewRow)
                            {
                                string existingIdProduct = paymentRow.Cells["idProduct"].Value?.ToString();

                                if (existingIdProduct == idProduct)
                                {
                                    int existingQuantity = Convert.ToInt32(paymentRow.Cells["Quantity"].Value);
                                    int newQuantity = existingQuantity + quantityToAdd;

                                    if (newQuantity > 0)
                                    {
                                        paymentRow.Cells["Quantity"].Value = newQuantity;
                                    }
                                    else
                                    {
                                        dgv_Bill.Rows.Remove(paymentRow);
                                    }

                                    productExists = true;
                                    break;
                                }
                            }
                        }

                        
                        if (!productExists && quantityToAdd > 0)
                        {
                            dataTable.Rows.Add(convertDate1, Id, idProduct, NameProduct, idCategory, quantityToAdd, Price, Username);
                        }

                       
                    }
                }
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txb_Username.Text = SaveUserName;
           
            // Khởi tạo DataTable
            dataTable = new DataTable();
        
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("IDCustomer");
            dataTable.Columns.Add("idProduct");
            dataTable.Columns.Add("Name Product");
            dataTable.Columns.Add("Type Product");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Username");

            dgv_Bill.DataSource = dataTable;
        }

        void LoadInfomation()
        {
            dgv_Bill.DataSource = dataTable;
            string idProduct = cb_IDProduct.Text;
            string sql = "Select NameGoods, Price from Product Where idProduct = '" + idProduct + "'";
            dgv_Infomation.DataSource = data.LayDuLieu(sql);
        }
        void LoadDataGripView()
        {
            dataTable = new DataTable();
          
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("IDCustomer");
            dataTable.Columns.Add("idProduct");
            dataTable.Columns.Add("Name Product");
            dataTable.Columns.Add("Type Product");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Username");

            dgv_Bill.DataSource = dataTable;
        }
        void LoadIDUserNameFromData()
        {
            dgv_Id.DataSource = dataTable;
            string Name = cb_IDCustomer.Text;
            string sql = "Select idCustomer from Customer Where FullName = N'" + Name + "'";
            dgv_Id.DataSource = data.LayDuLieu(sql);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            LoadDataGripView();
        }
        public void LoadCategory()
        {
            string sql = "SELECT id, Name FROM Category";
            DataTable dt = dataHandler.LayDuLieu(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                cb_Category.DataSource = dt;
                cb_Category.DisplayMember = "Name";
                cb_Category.ValueMember = "id";

                // Load sản phẩm của Category đầu tiên
                LoadComboBoxProduct(Convert.ToInt32(dt.Rows[0]["id"]));
            }
            else
            {
                cb_Category.DataSource = null;
                MessageBox.Show("Không có dữ liệu Category.");
            }
        }

        public void LoadIDCustomer()
        {
            DataTable dtCustomers = loadComboxBillDAO.GetAllCustomers();

            cb_IDCustomer.DisplayMember = "Fullname";
            cb_IDCustomer.ValueMember = "idCustomer";
            cb_IDCustomer.DataSource = dtCustomers;
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Category.SelectedValue != null)
            {
                int categoryId;

                if (cb_Category.SelectedValue is DataRowView)
                {
                    DataRowView selectedRow = (DataRowView)cb_Category.SelectedValue;
                    categoryId = Convert.ToInt32(selectedRow["id"]);
                }
                else if (cb_Category.SelectedValue is int)
                {
                    categoryId = (int)cb_Category.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Giá trị của SelectedValue không hợp lệ.");
                    return;
                }
                string selectedItem = cb_Category.SelectedItem.ToString();

                LoadComboBoxProduct(categoryId);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Category.");
            }
        }

        private void LoadComboBoxProduct(int categoryId)
        {
            string sql = "SELECT idProduct, NameGoods FROM Product WHERE idCategory = @idCategory";
            SqlParameter parameter = new SqlParameter("@idCategory", categoryId);

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idCategory", categoryId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                cb_IDProduct.DataSource = dt;
                cb_IDProduct.DisplayMember = "idProduct";
                cb_IDProduct.ValueMember = "idProduct";
            }
            else
            {
                cb_IDProduct.DataSource = null;
                MessageBox.Show("Không có sản phẩm thuộc Category này.");
            }
        }

   
        private void cb_IDProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadCategoryID()
        {
            dgv_IdCategory.DataSource = dataTable;
            string idProduct = cb_Category.Text;
            string sql = "Select id from Category Where name = '" + idProduct + "'";
            dgv_IdCategory.DataSource = data.LayDuLieu(sql);

        }
        void LoadProfileCustomer()
        {
            string sql = "Select Address, Tel From Customer Where FullName = N'"+cb_IDCustomer.Text+"'";
            DataTable dt = data.LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                // Lấy dữ liệu từ dòng đầu tiên
                DataRow row = dt.Rows[0];
                string address = row["Address"].ToString();
                string tel = row["Tel"].ToString();

                // Gán dữ liệu vào các TextBox
                txb_Address.Text = address;
                txb_Tel.Text = tel;
            }


        }
      
        private void LoadIdBill()
        {
            StringBuilder randomString = new StringBuilder();
            GenerateRandomString(randomString);
            txb_IDBILL.Text = randomString.ToString();
        }

        private static void GenerateRandomString(StringBuilder result)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const int length = 8;
            const int minLetters = 2;
            const int minDigits = 2;

            // Ensure that we have at least the minimum number of letters and digits
            char[] tempResult = new char[length];
            for (int i = 0; i < minLetters; i++)
            {
                tempResult[i] = letters[random.Next(letters.Length)];
            }

            for (int i = minLetters; i < minLetters + minDigits; i++)
            {
                tempResult[i] = digits[random.Next(digits.Length)];
            }

            // Fill the rest of the array with random letters and digits
            for (int i = minLetters + minDigits; i < length; i++)
            {
                if (random.Next(2) == 0)
                {
                    tempResult[i] = letters[random.Next(letters.Length)];
                }
                else
                {
                    tempResult[i] = digits[random.Next(digits.Length)];
                }
            }

            // Shuffle the array to ensure randomness
            tempResult = tempResult.OrderBy(x => random.Next()).ToArray();

            // Clear the result StringBuilder and append the new random string
            result.Clear();
            result.Append(tempResult);
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadIDUserNameFromData();
            LoadInfomation();
            LoadCategoryID();
            LoadProfileCustomer();
            LoadIdBill();


        }

        private void btn_PaymenttoBill_Click(object sender, EventArgs e)
        {
            // Câu lệnh SQL để chèn dữ liệu vào bảng Bill
            string sql = "INSERT INTO Bill (DateCheckin, idProduct, idCustomer, CategoryType, Quantity, Username) " +
                         "VALUES (@DateCheckin, @IdProduct, @IDCustomer, @CategoryType, @Quantity, @Username)";

            foreach (DataGridViewRow row in dgv_Bill.Rows)
            {
                // Bỏ qua hàng mới
                if (!row.IsNewRow)
                {
                    // Tạo danh sách tham số để chèn vào câu lệnh SQL
                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@DateCheckin", SqlDbType.Date) { Value = Convert.ToDateTime(row.Cells["Date"].Value).ToString("yyyy-MM-dd") },
                new SqlParameter("@IdProduct", SqlDbType.NVarChar, 50) { Value = row.Cells["idProduct"].Value.ToString() },
                new SqlParameter("@IDCustomer", SqlDbType.NVarChar, 50) { Value = row.Cells["IDCustomer"].Value.ToString() },
                new SqlParameter("@CategoryType", SqlDbType.Int) { Value = Convert.ToInt32(row.Cells["Type Product"].Value) },
                new SqlParameter("@Quantity", SqlDbType.Int) { Value = Convert.ToInt32(row.Cells["Quantity"].Value) },
                new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = row.Cells["Username"].Value.ToString() }
            };

                    try
                    {
                        // Gọi hàm CapNhatDuLieu để thực thi câu lệnh SQL
                        int rowsAffected = data.CapNhatDuLieu(sql, parameters.ToArray());

                        // Kiểm tra kết quả và hiển thị thông báo
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Insert Bill Complete!");
                        }
                        else
                        {
                            MessageBox.Show("Insert Bill Fail, Please try again!");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo lỗi nếu có ngoại lệ xảy ra
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            // Tải lại dữ liệu lên DataGridView
            LoadDataGripView();

        }

        private void btn_PrintBill_Click(object sender, EventArgs e)
        {

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += printBill_PrintPage;

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printDoc;
            printPreview.ShowDialog();

        }

        private void printBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Initialization of required variables
            int startX = 10;
            int startY = 10;
            int offsetY = 0;

            Font titleFont = new Font("Times New Roman", 24, FontStyle.Bold);
            Font headerFont = new Font("Times New Roman", 14, FontStyle.Bold);
            Font font = new Font("Times New Roman", 14);

            string title = "Phiếu Hóa Đơn";
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            float titleX = (e.PageBounds.Width / 2) - (titleSize.Width / 2);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, titleX, startY);
            offsetY += 50;

            e.Graphics.DrawString("Mã hóa đơn: "+txb_IDBILL.Text, font, Brushes.Black, startX, startY + offsetY);

            e.Graphics.DrawString("Tên NV Tiếp Nhận:" + txb_Username.Text, font, Brushes.Black, startX + 300, startY + offsetY);
            offsetY += 30;
            e.Graphics.DrawString("Họ và tên: " + cb_IDCustomer.Text, font, Brushes.Black, startX, startY + offsetY);
            offsetY += 30;
            e.Graphics.DrawString("Phone : "+txb_Tel.Text, font, Brushes.Black, startX, startY + offsetY);
            offsetY += 30;
            e.Graphics.DrawString("Địa chỉ: "+txb_Address.Text, font, Brushes.Black, startX, startY + offsetY);
            offsetY += 30;
            e.Graphics.DrawString("Ngày mua: " + dtp_Payment.Value, font, Brushes.Black, startX, startY + offsetY);
            offsetY += 50;

            // Drawing the table
            int tableStartX = startX;
            int tableStartY = startY + offsetY;
            int tableWidth = 830;
            int tableHeight = dgv_Bill.Rows.Count * 30 + 30;

            e.Graphics.DrawRectangle(Pens.Black, tableStartX, tableStartY, tableWidth, tableHeight);

            int colX = tableStartX;
            int colWidth = 80;

            // Draw column headers
            e.Graphics.DrawString("Mã SP", headerFont, Brushes.Black, colX, tableStartY);
            e.Graphics.DrawRectangle(Pens.Black, colX, tableStartY, colWidth, 30);
            colX += colWidth;

            colWidth = 200;
            e.Graphics.DrawString("Tên Sản Phẩm", headerFont, Brushes.Black, colX, tableStartY);
            e.Graphics.DrawRectangle(Pens.Black, colX, tableStartY, colWidth, 30);
            colX += colWidth;

            colWidth = 150;
            e.Graphics.DrawString("Số lượng", headerFont, Brushes.Black, colX, tableStartY);
            e.Graphics.DrawRectangle(Pens.Black, colX, tableStartY, colWidth, 30);
            colX += colWidth;

            colWidth = 150;
            e.Graphics.DrawString("Loại danh mục", headerFont, Brushes.Black, colX, tableStartY);
            e.Graphics.DrawRectangle(Pens.Black, colX, tableStartY, colWidth, 30);
            colX += colWidth;

            colWidth = 100;
            e.Graphics.DrawString("Giá Bán", headerFont, Brushes.Black, colX, tableStartY);
            e.Graphics.DrawRectangle(Pens.Black, colX, tableStartY, colWidth, 30);
            colX += colWidth;

            colWidth = 150;
            e.Graphics.DrawString("Thành Tiền", headerFont, Brushes.Black, colX, tableStartY);
            e.Graphics.DrawRectangle(Pens.Black, colX, tableStartY, colWidth, 30);
            colX += colWidth;

            offsetY += 30;

            // Draw product rows
            foreach (DataGridViewRow row in dgv_Bill.Rows)
            {
                if (!row.IsNewRow)
                {
                    colX = tableStartX;

                    colWidth = 80;
                    e.Graphics.DrawString(row.Cells["idProduct"].Value.ToString(), font, Brushes.Black, colX, startY + offsetY);
                    e.Graphics.DrawRectangle(Pens.Black, colX, startY + offsetY, colWidth, 30);
                    colX += colWidth;

                    colWidth = 200;
                    e.Graphics.DrawString(row.Cells["Name Product"].Value.ToString(), font, Brushes.Black, colX, startY + offsetY);
                    e.Graphics.DrawRectangle(Pens.Black, colX, startY + offsetY, colWidth, 30);
                    colX += colWidth;

                    colWidth = 150;
                    e.Graphics.DrawString(row.Cells["Quantity"].Value.ToString(), font, Brushes.Black, colX, startY + offsetY);
                    e.Graphics.DrawRectangle(Pens.Black, colX, startY + offsetY, colWidth, 30);
                    colX += colWidth;

                    colWidth = 150;
                    e.Graphics.DrawString(row.Cells["Type Product"].Value.ToString(), font, Brushes.Black, colX, startY + offsetY);
                    e.Graphics.DrawRectangle(Pens.Black, colX, startY + offsetY, colWidth, 30);
                    colX += colWidth;

                    colWidth = 100;
                    e.Graphics.DrawString(row.Cells["Price"].Value.ToString(), font, Brushes.Black, colX, startY + offsetY);
                    e.Graphics.DrawRectangle(Pens.Black, colX, startY + offsetY, colWidth, 30);
                    colX += colWidth;

                    colWidth = 150;
                    e.Graphics.DrawString((Convert.ToInt32(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["Price"].Value)).ToString("N2"), font, Brushes.Black, colX, startY + offsetY);
                    e.Graphics.DrawRectangle(Pens.Black, colX, startY + offsetY, colWidth, 30);
                    colX += colWidth;

                    offsetY += 30; // Increment offsetY by row height
                }
            }

         
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dgv_Bill.Rows)
            {
                if (!row.IsNewRow)
                {
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal totalLinePrice = quantity * price;
                    totalPrice += totalLinePrice;
                }
            }

            decimal taxValue = 0;
            decimal finalValue = totalPrice + taxValue;

            // Draw total, tax, and final values
            string totalLabel = "Tổng tiền: ";
            string totalValue = totalPrice.ToString("N0") + " USD";
            SizeF totalLabelSize = e.Graphics.MeasureString(totalLabel, font);
            SizeF totalValueSize = e.Graphics.MeasureString(totalValue, font);
            e.Graphics.DrawString(totalLabel, font, Brushes.Black, e.PageBounds.Width - startX - totalLabelSize.Width - totalValueSize.Width, startY + offsetY);
            e.Graphics.DrawString(totalValue, font, Brushes.Black, e.PageBounds.Width - startX - totalValueSize.Width, startY + offsetY);
            offsetY += 30;

            string taxLabel = "Thuế: ";
            string taxValueStr = taxValue.ToString("N0") + " USD";
            SizeF taxLabelSize = e.Graphics.MeasureString(taxLabel, font);
            SizeF taxValueSize = e.Graphics.MeasureString(taxValueStr, font);
            e.Graphics.DrawString(taxLabel, font, Brushes.Black, e.PageBounds.Width - startX - taxLabelSize.Width - taxValueSize.Width, startY + offsetY);
            e.Graphics.DrawString(taxValueStr, font, Brushes.Black, e.PageBounds.Width - startX - taxValueSize.Width, startY + offsetY);
            offsetY += 30;

            string finalLabel = "Phải trả: ";
            string finalValueStr = finalValue.ToString("N0") + " USD";
            SizeF finalLabelSize = e.Graphics.MeasureString(finalLabel, font);
            SizeF finalValueSize = e.Graphics.MeasureString(finalValueStr, font);
            e.Graphics.DrawString(finalLabel, font, Brushes.Black, e.PageBounds.Width - startX - finalLabelSize.Width - finalValueSize.Width, startY + offsetY);
            e.Graphics.DrawString(finalValueStr, font, Brushes.Black, e.PageBounds.Width - startX - finalValueSize.Width, startY + offsetY);
            offsetY += 50;

            e.Graphics.DrawString("Chữ ký khách hàng", font, Brushes.Black, e.PageBounds.Width - startX - e.Graphics.MeasureString("Chữ ký khách hàng", font).Width, startY + offsetY);

            Image image = Properties.Resources.OIP;

            int imageX = 8; 
            int imageY = e.PageBounds.Height - image.Height - 8 ;

         
            e.Graphics.DrawImage(image, imageX, imageY);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pls send message to mail 'minhtuan7543@gmail.com'\n tel : 0377232631 \n Message response abount 15' to 30' \n Thank you so much ! to repair","Caution",MessageBoxButtons.OK);
        }

        private void cb_IDCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    }
    
}
