using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanHangShop.DAO
{
    class SalesDAO
    {
        private string connectionString; // Chuỗi kết nối tới cơ sở dữ liệu

        public SalesDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Phương thức để lấy danh sách sản phẩm được bán nhiều nhất trong một tháng và năm cụ thể
        public List<ProductSales> GetTopSellingProductsByMonthYear(int month, int year)
        {
            List<ProductSales> sales = new List<ProductSales>();

            // Thực hiện truy vấn SQL để lấy dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Viết câu truy vấn SQL ở đây
                string query = @"
                SELECT TOP 5 p.NameGoods AS ProductName, SUM(bi.Count) AS TotalSales
                FROM BillInformation bi
                INNER JOIN Product p ON bi.idProduct = p.idProduct
                INNER JOIN Bill b ON bi.idBill = b.id
                WHERE MONTH(b.DateCheckin) = @Month AND YEAR(b.DateCheckin) = @Year
                GROUP BY p.NameGoods
                ORDER BY TotalSales DESC
            ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Month", month);
                command.Parameters.AddWithValue("@Year", year);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        float totalSales = Convert.ToSingle(reader["TotalSales"]);

                        ProductSales productSales = new ProductSales(productName, totalSales);
                        sales.Add(productSales);
                    }
                }
            }

            return sales;
        }
    }

    // Lớp để lưu thông tin sản phẩm và số lượng bán được
    public class ProductSales
    {
        public string ProductName { get; set; }
        public float TotalSales { get; set; }

        public ProductSales(string productName, float totalSales)
        {
            ProductName = productName;
            TotalSales = totalSales;
        }
    }
}
