using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanHangShop
{
    public partial class LoginManager : Form
    {
        public LoginManager()
        {
            InitializeComponent();
        }
        public void LoadDataFromFile(string filePathInfo)
        {
            string[] lines = File.ReadAllLines(filePathInfo);

            // Tạo DataTable để lưu dữ liệu từ tập tin
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date");
          
           

            // Thêm dữ liệu từ tập tin vào DataTable
            foreach (string line in lines)
            {
                string[] fields = line.Split('\t'); // Phân tách dữ liệu bằng dấu tab (\t) hoặc ký tự phù hợp khác
                dataTable.Rows.Add(fields);
            }

            // Hiển thị dữ liệu trong DataTable lên DataGridView
            dgv_AccontLogin.DataSource = dataTable;
        }

        private void btn_ShowAccount_Click(object sender, EventArgs e)
        {
            string filePathInfo = @"D:\lapTrinhTrucQuan\DoAnBanHangShop\bin\Debug\ManagerLogin.txt";
            LoginManager b = new LoginManager();
            b.LoadDataFromFile(filePathInfo);
            b.Show(); 

        }
    }
}
