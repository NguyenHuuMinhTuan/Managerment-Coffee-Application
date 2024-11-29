using DoAnBanHangShop.DAO;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace DoAnBanHangShop
{
    public partial class dtp_ChoseYear : Form
    {
        SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        private SQLProvider.DataHandle sqlProvider = new SQLProvider.DataHandle();
       




        private SalesDAO salesDAO;


        public dtp_ChoseYear()
        {
            InitializeComponent();
          
            string connectionString = "Data Source=ADMIN;Initial Catalog=Shop_TL;Integrated Security=True";
            salesDAO = new SalesDAO(connectionString);
        


        }

       
        public void LoadDataFromFile(string filePathInfo)
        {
            string[] lines = File.ReadAllLines(filePathInfo);

            // Tạo DataTable để lưu dữ liệu từ tập tin
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("IDCustomer");
            dataTable.Columns.Add("idProduct");
            dataTable.Columns.Add("Name Product");
            dataTable.Columns.Add("Type Product");
            dataTable.Columns.Add("Size");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");

            // Thêm dữ liệu từ tập tin vào DataTable
            foreach (string line in lines)
            {
                string[] fields = line.Split('\t'); 
                dataTable.Rows.Add(fields);
            }

            // Hiển thị dữ liệu trong DataTable lên DataGridView
            dgv_BillInformation.DataSource = dataTable;
        }


        private void btn_BillDatabase_Click(object sender, EventArgs e)
        {
            dgv_BillInformation.DataSource = data.LayDuLieu("Select * from Billinformation");
        }

        private void BillInformation_Load(object sender, EventArgs e)
        {
            VeBieuDoDoanhThu();
            VeBieuDoMatHangBanChayNhatTrongNam(DateTime.Now.Year);
        }
   
        private void SalesChartForm_Load(object sender, EventArgs e)
        {
            // Thiết lập DateTimePicker để chỉ chọn tháng và năm
            dtp_ChosseYear.CustomFormat = "MM/yyyy";
            dtp_ChosseYear.Format = DateTimePickerFormat.Custom;
        }
        

        private void VeBieuDoMatHangBanChayNhatTrongNam(int year)
        {

            try
            {
                // Gọi phương thức truy vấn dữ liệu từ SQLProvider
                DataTable dt = sqlProvider.LayMatHangBanChayNhatTrongNam(year);

                // Xóa các series cũ trong biểu đồ (nếu có)
                Chart_Pie_Product.Series.Clear();

                // Tạo một series mới để vẽ biểu đồ
                Series series = new Series("Best-selling item of the year.");
                series.ChartType = SeriesChartType.Pie;

                // Thêm dữ liệu vào series
                foreach (DataRow row in dt.Rows)
                {
                    string matHang = row["Product"].ToString();
                    double tongSoLuong = Convert.ToDouble(row["TotalProduct"]);

                    // Thêm dữ liệu vào series
                    series.Points.AddXY(matHang, tongSoLuong);
                }

                // Thêm series vào biểu đồ
                Chart_Pie_Product.Series.Add(series);

                // Cấu hình các thuộc tính của biểu đồ tròn
                Chart_Pie_Product.ChartAreas[0].Area3DStyle.Enable3D = true; // Cho phép hiển thị 3D
                Chart_Pie_Product.ChartAreas[0].AxisX.Enabled = AxisEnabled.False; // Ẩn trục X
                Chart_Pie_Product.ChartAreas[0].AxisY.Enabled = AxisEnabled.False; // Ẩn trục Y

                // Cập nhật lại biểu đồ
                Chart_Pie_Product.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ biểu đồ: " + ex.Message);
            }


        }

        private void VeBieuDoDoanhThu()
        {

            try
            {
                DataTable dt = sqlProvider.LayDoanhThuTheoThang();
                Ch_Revenue.Series.Clear();

                Series series = new Series("Doanh thu theo tháng");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "$0.00";

                foreach (DataRow row in dt.Rows)
                {
                    int thang = Convert.ToInt32(row["Thang"]);
                    double doanhThu = Convert.ToDouble(row["DoanhThu"]);
                    series.Points.AddXY($"Tháng {thang}", doanhThu);
                }

                Ch_Revenue.Series.Add(series);
                Ch_Revenue.ChartAreas[0].AxisX.Title = "Month";
                Ch_Revenue.ChartAreas[0].AxisY.Title = "Revenue";
                Ch_Revenue.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ biểu đồ: " + ex.Message);
            }
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM BILLINFORMATION";
            int COUNT = data.CapNhatDuLieu(sql);
            if(COUNT > 0)
            {
                MessageBox.Show("Delete Emergency Complete !!!");
            }
            else {

                MessageBox.Show("Warning!! Fail...........");
                MessageBox.Show("Please ! Try again!!!");
            }
            this.Close();

        }
    }
}




    

    


