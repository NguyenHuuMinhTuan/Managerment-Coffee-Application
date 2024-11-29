using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnBanHangShop.Cmd;
using DoAnBanHangShop.DTO;
using DoAnBanHangShop.BillInformation;

namespace DoAnBanHangShop
{
    public partial class MenuShop : Form
    {
        private string loggedInUsername;

        SQLProvider.DataHandle data = new SQLProvider.DataHandle();

        public MenuShop(string username)
        {
            InitializeComponent();

            this.loggedInUsername = username;

            LoadTextUserName();
            LoadPosition();

            tm_Date.Interval = 1000; 
            tm_Date.Tick += tm_Date_Tick;
            tm_Date.Start(); 

        }
        public void LoadTextUserName()
        {
            txb_UserName.Text = loggedInUsername;
        }
        private void btn_payment_Click(object sender, EventArgs e)
        {
            string username = txb_UserName.Text;
            Payment p = new Payment(username);
            p.ShowDialog();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BillInfo_Click(object sender, EventArgs e)
        {
            dtp_ChoseYear p = new dtp_ChoseYear();
            p.ShowDialog();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            LoginManager p = new LoginManager();
            p.ShowDialog();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Production p = new Production();
            p.ShowDialog();
           

        }

   

        private void btn_AccountManager_Click(object sender, EventArgs e)
        {
            Account p = new Account();
            p.ShowDialog();
        }

        private void btn_AccountProfile_Click(object sender, EventArgs e)
        {
            string userName = txb_UserName.Text;
            AccountProfile p = new AccountProfile(userName);
            p.ShowDialog();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer p = new Customer();
            p.ShowDialog();
        }

        private void btn_Marketing_Click(object sender, EventArgs e)
        {
            Marketing p = new Marketing();
            p.ShowDialog();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            Category p = new Category();
            p.ShowDialog();
        }
        void LoadPosition() {
            string sql = "select Position From Account where Username = N'"+txb_UserName.Text+"'";
            DataTable dt = data.LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string posit = row["Position"].ToString();
                txb_Position.Text = posit;
            }
           
        }

        
        private void MenuShop_Load_1(object sender, EventArgs e)
        {
            int userType = TypeDAO.Instance.LayTypeTheoUsername(loggedInUsername);

            if (userType == 0)
            {
                btn_BillInfo.Enabled = false;
                btn_CheckLogin.Enabled = false;
                btn_Product.Enabled = false;
                btn_AccountManager.Enabled = false;
                btn_Category.Enabled = false;
                btn_Command.Enabled = false;
                btn_Sale.Enabled = false;
                btn_Salary.Enabled = false;
                

            }
            else if (userType == 1)
            {
                btn_BillInfo.Enabled = true;
                btn_CheckLogin.Enabled = true;
                btn_Product.Enabled = true;
                btn_AccountManager.Enabled = true;
            }

        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();  
            sales.ShowDialog();
        }

        private void btn_Command_Click(object sender, EventArgs e)
        {
            FormMenuCmd p = new FormMenuCmd();
            p.ShowDialog();
        }

        private void tm_Date_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txb_DateAndTime.Text = now.ToString("yyyy-MM-dd HH:mm");
        }

        private void btn_Rule_Click(object sender, EventArgs e)
        {
            MessageBoxOptions.ServiceNotification.ToString();
            string rulesMessage =
          "Shop Rules and Penalties:\n\n" +
          "1. No Food or Drinks Inside the Store\n   Penalty: $25\n" +
          "2. Keep the Store Clean and Tidy\n   Penalty: $30\n" +
          "3. Handle Clothes with Care\n   Penalty: $20\n" +
          "4. Return Items Within 30 Days of Purchase\n   Penalty: $15 for unauthorized returns after 30 days\n" +
          "5. Follow Store Hours\n   Penalty: $50 for after-hours entry without permission\n" +
          "6. No Smoking Inside the Store\n   Penalty: $100\n" +
          "7. No Running or Rough Play\n   Penalty: $20\n" +
          "8. Respect Other Customers and Staff\n   Penalty: $40 for disruptive behavior\n" +
          "9. Keep Personal Belongings with You\n   Penalty: $25 for leaving items unattended\n" +
          "10. No Unauthorized Discounts or Price Negotiations\n   Penalty: $50 for unauthorized discount requests";
           
            MessageBox.Show(rulesMessage,"Shop Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Salary().ShowDialog();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            new PrintBill().ShowDialog();
        }
    }
}  