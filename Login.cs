using DoAnBanHangShop.DTO;
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
    public partial class Login : Form
    {
        private DateTime disableLoginTime;
        private bool loginDisabled = false;



        public Login()
        {
            InitializeComponent();

            TimerLockLogin.Interval = 1000; 
            TimerLockLogin.Tick += TimerLockLogin_Tick;
            TimerLockLogin.Start();

        }

    

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Caution ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }
        int count = 0;
        private void btn_Login_Click(object sender, EventArgs e)
        {

            string userName = txb_Username.Text;
            string password = txb_Password.Text;

            if (String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password!","Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                if (AccountDAO.Instance.KiemTraDangNhap(userName,password))
                {
                    MessageBox.Show("Login successful","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    MenuShop f = new MenuShop(userName);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    count++;
                    MessageBox.Show("Username or password is incorrect !");
                 
              

                    if (count == 3)
                    {
                        MessageBox.Show("Too many failed attempts, account temporarily locked.");
                       
                       
                        disableLoginTime = DateTime.Now;

                        TimerLockLogin.Start();

                       
                        btn_Login.Enabled = false;

                       
                    }
                }
            }
        
            List<string> content = new List<string>();

            string dateTimeString = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");

            content.Add($"Ngày và giờ: {dateTimeString}");
            content.Add("Name Account: " + userName +"\n");

            String filePathInfo = Path.Combine(Application.StartupPath, "ManagerLogin.txt");

            
            using (StreamWriter writer = new StreamWriter(filePathInfo, append: true))
            {
                foreach (var line in content)
                {
                    writer.WriteLine(line);
                }
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txb_Password.PasswordChar = '\0';
            }
            else
            {
                txb_Password.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new SMSPassword()).ShowDialog();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TimerLockLogin_Tick(object sender, EventArgs e)
        {
            if (loginDisabled && DateTime.Now >= disableLoginTime)
            {
                btn_Login.Enabled = true;
                loginDisabled = false;
            }
        }

        private void Ll_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new Register()).ShowDialog();
        }
    }
}
