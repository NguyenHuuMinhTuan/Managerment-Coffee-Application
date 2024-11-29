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
    public partial class FormMenuCmd : Form
    {
        public FormMenuCmd()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        void MoFormCon(Form f)
        {

            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == f.Name)
                {
                    child.Activate();
                    return;
                }
            }
            f.MdiParent = this;


            f.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenuCmd_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            MoFormCon(new Insert_Cmd());
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            MoFormCon(new ShowData());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MoFormCon(new Update_Delete());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MoFormCon(new Update_Delete());
        }
    }
}
