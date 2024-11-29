using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanHangShop.Cmd
{
    public partial class Update_Delete : Form
    {
        private SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        public Update_Delete()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "" + textBox1.Text + "";
            int checkRow = data.CapNhatDuLieu(sql);
            if(checkRow > 0)
            {
                MessageBox.Show("Execute Complete !");
            }
            else
            {
                MessageBox.Show("Error Execute !!! \n please try again");
            }
        }
    }
}
