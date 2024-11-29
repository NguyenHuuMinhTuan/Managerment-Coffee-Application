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
    public partial class ShowData : Form
    {
        private SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        public ShowData()
        {
            InitializeComponent();
        }

        private void Btn_Execute_Click(object sender, EventArgs e)
        {
            string sql = ("" + txb_Command.Text + "");

            dgv_Cmd.DataSource = data.LayDuLieu(sql);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txb_Command.Clear();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txb_Command.Text);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
