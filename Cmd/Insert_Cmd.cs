using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnBanHangShop.Cmd
{
   
    public partial class Insert_Cmd : Form
    {
        private SQLProvider.DataHandle data = new SQLProvider.DataHandle();
        public Insert_Cmd()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string sql = "" + txb_Command.Text + "";

            int check = data.CapNhatDuLieu(sql);
            if(check > 0)
            {
                MessageBox.Show("Command Complete ");
            }
            else
            {
                MessageBox.Show("Command Fail");
            }

            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txb_Command.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txb_Command.Text);
        }
    }
}
