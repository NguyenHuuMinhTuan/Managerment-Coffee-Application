using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanHangShop
{
    class SQLProvider
    {
        private string connectionString;

        internal class DataHandle
        {
            private string connectionString = File.ReadAllText(Application.StartupPath+"\\Connection\\Connection.txt");
            public DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
                    }
                }

                return dt;
            }
        
        public DataTable LayDuLieu(string sql, SqlParameter[] parameters = null)
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        if (parameters != null)
                        {
                            adapter.SelectCommand.Parameters.AddRange(parameters);
                        }
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
                    }
                }
                return dt;
            }

            public int CapNhatDuLieu(string sql, SqlParameter[] parameters = null)
            {
                int kq = -1;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        kq = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
                    }
                }
                return kq;
            }
            public DataTable LayDoanhThuTheoThang()
            {
                DataTable dt = new DataTable();
                string sql = "SELECT MONTH(DateCheckout) AS Thang, SUM(Count) AS DoanhThu " +
                             "FROM BillInformation " +
                             "GROUP BY MONTH(DateCheckout)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi lấy dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                    }
                }

                return dt;
            }


            internal int LayDuLieuInt(string sql, SqlParameter[] parameters)
            {
                int result = 0;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        var queryResult = command.ExecuteScalar();
                        if (queryResult != null && queryResult != DBNull.Value)
                        {
                            result = Convert.ToInt32(queryResult);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi lấy dữ liệu int: " + ex.Message);
                        // Xử lý các exception khác nếu cần thiết
                    }
                }
                return result;
            }
            public DataTable LayTongTienMuaHangTheoKhachHangTrongNam(int year)
            {
                DataTable dt = new DataTable();
                           string sql = @"
                             SELECT c.Fullname AS KhachHang, SUM(bi.Count) AS TongTien 
                               FROM BillInformation bi 
                              INNER JOIN Bill b ON bi.idBill = b.id 
                               INNER JOIN Customer c ON b.idCustomer = c.idCustomer 
                              WHERE YEAR(bi.DateCheckout) = @Year
                           GROUP BY c.Fullname";

                  SqlParameter[] parameters = new SqlParameter[]
                  {
                           new SqlParameter("@Year", year)
                  };

                dt = LayDuLieu(sql, parameters);
                return dt;
            }
        


            public DataTable LayMatHangBanChayNhatTrongNam(int year)
            {
                DataTable dt = new DataTable();
                string sql = @"
        SELECT TOP 10 p.NameGoods AS Product, SUM(bi.Count) AS TotalProduct
        FROM BillInformation bi
        INNER JOIN Bill b ON bi.idBill = b.id
        INNER JOIN Product p ON bi.idProduct = p.idProduct
        WHERE YEAR(bi.DateCheckout) = @Year
        GROUP BY p.NameGoods
        ORDER BY SUM(bi.Count) DESC";

                SqlParameter[] parameters = new SqlParameter[]
                {
        new SqlParameter("@Year", year)
                };

                dt = LayDuLieu(sql, parameters);
                return dt;
            }
        }

        internal DataTable ExecuteQuery(string sql, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        internal DataTable LayDuLieu(string sql, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
                    // Xử lý các exception nếu cần thiết
                }
            }
            return dt;
        }

    }
}
