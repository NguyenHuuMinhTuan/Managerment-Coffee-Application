using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanHangShop
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void sALARYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALARYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shop_TLDataSet1);

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shop_TLDataSet1.SALARY' table. You can move, or remove it, as needed.
            this.sALARYTableAdapter.Fill(this.shop_TLDataSet1.SALARY);

        }
    }
}
