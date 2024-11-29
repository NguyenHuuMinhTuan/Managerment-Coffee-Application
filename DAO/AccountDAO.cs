using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class AccountDAO
{
    private string connectionString = File.ReadAllText(Application.StartupPath + "\\Connection\\Connection.txt");

    private static AccountDAO instance;

    public static AccountDAO Instance
    {
        get
        {
            if (instance == null)
                instance = new AccountDAO();
            return instance;
        }
    }

    private AccountDAO() { }

    public bool KiemTraDangNhap(string userName, string password)
    {
        bool result = false;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT COUNT(*) FROM Account WHERE UserName = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Username", userName);

            
            string hashedPassword = GetMd5Hash(password);
            command.Parameters.AddWithValue("@Password", hashedPassword);

            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    result = true; // Đăng nhập thành công
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đăng nhập: " + ex.Message);
            }
        }
        return result;
    }

    // Hàm băm MD5
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
