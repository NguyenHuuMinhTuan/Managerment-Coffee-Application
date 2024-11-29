using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnBanHangShop
{
    public partial class Chart_Customer : Form
    {
        private SQLProvider.DataHandle sqlProvider = new SQLProvider.DataHandle();

        public Chart_Customer()
        {
            InitializeComponent();
        }

        private void Chart_Customer_Load(object sender, EventArgs e)
        {

            VeBieuDoTongTienMuaHangTheoKhachHangTrongNam();

        }
        private void VeBieuDoTongTienMuaHangTheoKhachHangTrongNam()
        {
            try
            {
              
                DataTable dt = sqlProvider.LayTongTienMuaHangTheoKhachHangTrongNam(DateTime.Now.Year); 

                // Xóa các series cũ trong biểu đồ (nếu có)
                ch_Customer.Series.Clear();

                // Tạo một series mới để vẽ biểu đồ
                Series series = new Series("Tổng tiền mua hàng theo khách hàng trong năm");
                series.ChartType = SeriesChartType.Column;

                // Thêm dữ liệu vào series
                foreach (DataRow row in dt.Rows)
                {
                    string tenKhachHang = row["KhachHang"].ToString();
                    double tongTien = Convert.ToDouble(row["TongTien"]);

                    // Thêm dữ liệu vào series
                    series.Points.AddXY(tenKhachHang, tongTien);
                }

                // Thêm series vào biểu đồ
                ch_Customer.Series.Add(series);

                // Đặt tên cho trục tung và trục hoành
                ch_Customer.ChartAreas[0].AxisX.Title = "Khách hàng";
                ch_Customer.ChartAreas[0].AxisY.Title = "Tổng tiền mua hàng";

                // Cập nhật lại biểu đồ
                ch_Customer.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ biểu đồ: " + ex.Message);
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }






}

        
    

    


