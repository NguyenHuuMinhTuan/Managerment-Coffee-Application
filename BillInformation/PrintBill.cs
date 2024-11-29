using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanHangShop.BillInformation
{
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Bill.BillInformation' table. You can move, or remove it, as needed.
            this.BillInformationTableAdapter.Fill(this.Bill.BillInformation);

            this.reportViewer1.RefreshReport();
        }
    }
}
