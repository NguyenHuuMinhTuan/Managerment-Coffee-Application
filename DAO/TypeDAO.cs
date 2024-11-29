using System;
using System.Data.SqlClient;

public class TypeDAO
{
    private string connectionString = "Data Source=ADMIN;Initial Catalog=Shop_TL;Integrated Security=True";

    private static TypeDAO instance;

    public static TypeDAO Instance
    {
        get
        {
            if (instance == null)
                instance = new TypeDAO();
            return instance;
        }
    }

    private TypeDAO() { }

    public int LayTypeTheoUsername(string username)
    {
        int userType = 0; // Giá trị mặc định

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT Type FROM Account WHERE UserName = @Username";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    userType = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy giá trị Type từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        return userType;
    }
}
