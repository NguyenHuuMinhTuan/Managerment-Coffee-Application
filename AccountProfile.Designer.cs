
namespace DoAnBanHangShop
{
    partial class AccountProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ck_Show = new System.Windows.Forms.CheckBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.mn_Genderr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DOB = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_ResetPass = new System.Windows.Forms.Button();
            this.btn_UpdateAccount = new System.Windows.Forms.Button();
            this.btn_ChoseImage = new System.Windows.Forms.Button();
            this.pb_Employment = new System.Windows.Forms.PictureBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mn_Genderr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Employment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.txb_Email);
            this.panel1.Controls.Add(this.ck_Show);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.mn_Genderr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txb_DOB);
            this.panel1.Controls.Add(this.txb_Password);
            this.panel1.Controls.Add(this.txb_Username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Preview);
            this.panel1.Controls.Add(this.btn_ResetPass);
            this.panel1.Controls.Add(this.btn_UpdateAccount);
            this.panel1.Location = new System.Drawing.Point(301, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 372);
            this.panel1.TabIndex = 0;
            // 
            // ck_Show
            // 
            this.ck_Show.AutoSize = true;
            this.ck_Show.Location = new System.Drawing.Point(418, 105);
            this.ck_Show.Name = "ck_Show";
            this.ck_Show.Size = new System.Drawing.Size(53, 17);
            this.ck_Show.TabIndex = 19;
            this.ck_Show.Text = "Show";
            this.ck_Show.UseVisualStyleBackColor = true;
            this.ck_Show.CheckedChanged += new System.EventHandler(this.ck_Show_CheckedChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(388, 281);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 62);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "Clear all";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // mn_Genderr
            // 
            this.mn_Genderr.Location = new System.Drawing.Point(153, 234);
            this.mn_Genderr.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mn_Genderr.Name = "mn_Genderr";
            this.mn_Genderr.Size = new System.Drawing.Size(137, 20);
            this.mn_Genderr.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gender :";
            // 
            // txb_DOB
            // 
            this.txb_DOB.Location = new System.Drawing.Point(153, 187);
            this.txb_DOB.Name = "txb_DOB";
            this.txb_DOB.Size = new System.Drawing.Size(259, 20);
            this.txb_DOB.TabIndex = 15;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(153, 103);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(259, 20);
            this.txb_Password.TabIndex = 14;
            // 
            // txb_Username
            // 
            this.txb_Username.Location = new System.Drawing.Point(153, 61);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(259, 20);
            this.txb_Username.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "DOB :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID :";
            // 
            // txb_ID
            // 
            this.txb_ID.Location = new System.Drawing.Point(153, 19);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(259, 20);
            this.txb_ID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserName :";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(14, 281);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(100, 62);
            this.btn_Preview.TabIndex = 2;
            this.btn_Preview.Text = "Preview Information";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_ResetPass
            // 
            this.btn_ResetPass.Location = new System.Drawing.Point(153, 281);
            this.btn_ResetPass.Name = "btn_ResetPass";
            this.btn_ResetPass.Size = new System.Drawing.Size(85, 62);
            this.btn_ResetPass.TabIndex = 1;
            this.btn_ResetPass.Text = "Reset Pass";
            this.btn_ResetPass.UseVisualStyleBackColor = true;
            this.btn_ResetPass.Click += new System.EventHandler(this.btn_ResetPass_Click);
            // 
            // btn_UpdateAccount
            // 
            this.btn_UpdateAccount.Location = new System.Drawing.Point(271, 281);
            this.btn_UpdateAccount.Name = "btn_UpdateAccount";
            this.btn_UpdateAccount.Size = new System.Drawing.Size(94, 62);
            this.btn_UpdateAccount.TabIndex = 0;
            this.btn_UpdateAccount.Text = "UpdateAccount";
            this.btn_UpdateAccount.UseVisualStyleBackColor = true;
            this.btn_UpdateAccount.Click += new System.EventHandler(this.btn_UpdateAccount_Click);
            // 
            // btn_ChoseImage
            // 
            this.btn_ChoseImage.Location = new System.Drawing.Point(78, 322);
            this.btn_ChoseImage.Name = "btn_ChoseImage";
            this.btn_ChoseImage.Size = new System.Drawing.Size(140, 40);
            this.btn_ChoseImage.TabIndex = 2;
            this.btn_ChoseImage.Text = "Chosse avatar";
            this.btn_ChoseImage.UseVisualStyleBackColor = true;
            this.btn_ChoseImage.Click += new System.EventHandler(this.btn_ChoseImage_Click);
            // 
            // pb_Employment
            // 
            this.pb_Employment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Employment.Image = global::DoAnBanHangShop.Properties.Resources.logo_gia_dinh;
            this.pb_Employment.Location = new System.Drawing.Point(24, 12);
            this.pb_Employment.Name = "pb_Employment";
            this.pb_Employment.Size = new System.Drawing.Size(252, 283);
            this.pb_Employment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Employment.TabIndex = 1;
            this.pb_Employment.TabStop = false;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(153, 145);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(259, 20);
            this.txb_Email.TabIndex = 20;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(33, 148);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(68, 22);
            this.Email.TabIndex = 21;
            this.Email.Text = "Email :";
            // 
            // AccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btn_ChoseImage);
            this.Controls.Add(this.pb_Employment);
            this.Controls.Add(this.panel1);
            this.Name = "AccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mn_Genderr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Employment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_DOB;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_ResetPass;
        private System.Windows.Forms.Button btn_UpdateAccount;
        private System.Windows.Forms.Button btn_ChoseImage;
        private System.Windows.Forms.NumericUpDown mn_Genderr;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.PictureBox pb_Employment;
        private System.Windows.Forms.CheckBox ck_Show;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txb_Email;
    }
}