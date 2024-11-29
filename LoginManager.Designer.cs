
namespace DoAnBanHangShop
{
    partial class LoginManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ShowAccount = new System.Windows.Forms.Button();
            this.dgv_AccontLogin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccontLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ShowAccount
            // 
            this.btn_ShowAccount.Location = new System.Drawing.Point(482, 63);
            this.btn_ShowAccount.Name = "btn_ShowAccount";
            this.btn_ShowAccount.Size = new System.Drawing.Size(172, 108);
            this.btn_ShowAccount.TabIndex = 0;
            this.btn_ShowAccount.Text = "Show";
            this.btn_ShowAccount.UseVisualStyleBackColor = true;
            this.btn_ShowAccount.Click += new System.EventHandler(this.btn_ShowAccount_Click);
            // 
            // dgv_AccontLogin
            // 
            this.dgv_AccontLogin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_AccontLogin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AccontLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccontLogin.Location = new System.Drawing.Point(22, 20);
            this.dgv_AccontLogin.Name = "dgv_AccontLogin";
            this.dgv_AccontLogin.ReadOnly = true;
            this.dgv_AccontLogin.Size = new System.Drawing.Size(416, 389);
            this.dgv_AccontLogin.TabIndex = 1;
            // 
            // LoginManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_AccontLogin);
            this.Controls.Add(this.btn_ShowAccount);
            this.Name = "LoginManager";
            this.Text = "LoginManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccontLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowAccount;
        private System.Windows.Forms.DataGridView dgv_AccontLogin;
    }
}