
namespace DoAnBanHangShop
{
    partial class Account
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nm_Type = new System.Windows.Forms.NumericUpDown();
            this.ck_Gender = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Position = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txb_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.Btn_Preview = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(937, 349);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 63);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nm_Type);
            this.panel1.Controls.Add(this.ck_Gender);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txb_Email);
            this.panel1.Controls.Add(this.dtp_DOB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txb_Position);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_UserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 339);
            this.panel1.TabIndex = 17;
            // 
            // nm_Type
            // 
            this.nm_Type.Location = new System.Drawing.Point(124, 296);
            this.nm_Type.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_Type.Name = "nm_Type";
            this.nm_Type.Size = new System.Drawing.Size(80, 22);
            this.nm_Type.TabIndex = 18;
            // 
            // ck_Gender
            // 
            this.ck_Gender.AutoSize = true;
            this.ck_Gender.Location = new System.Drawing.Point(123, 254);
            this.ck_Gender.Name = "ck_Gender";
            this.ck_Gender.Size = new System.Drawing.Size(130, 19);
            this.ck_Gender.TabIndex = 17;
            this.ck_Gender.Text = "1: Male / 0: Female";
            this.ck_Gender.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email :";
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(123, 134);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(191, 22);
            this.txb_Email.TabIndex = 15;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Location = new System.Drawing.Point(123, 173);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(190, 22);
            this.dtp_DOB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender :";
            // 
            // txb_Position
            // 
            this.txb_Position.Location = new System.Drawing.Point(123, 212);
            this.txb_Position.Name = "txb_Position";
            this.txb_Position.Size = new System.Drawing.Size(191, 22);
            this.txb_Position.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posittion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Of Birth :";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(123, 95);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(191, 22);
            this.txb_Password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(123, 56);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(191, 22);
            this.txb_UserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // txb_ID
            // 
            this.txb_ID.Location = new System.Drawing.Point(123, 17);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(191, 22);
            this.txb_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // dgv_Account
            // 
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Location = new System.Drawing.Point(420, 21);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.Size = new System.Drawing.Size(599, 316);
            this.dgv_Account.TabIndex = 18;
            this.dgv_Account.SelectionChanged += new System.EventHandler(this.dgv_Account_SelectionChanged);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(420, 349);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(82, 63);
            this.btn_Insert.TabIndex = 19;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(522, 349);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(82, 63);
            this.btn_Update.TabIndex = 20;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(626, 349);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(82, 63);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txb_Find
            // 
            this.txb_Find.Location = new System.Drawing.Point(729, 352);
            this.txb_Find.Name = "txb_Find";
            this.txb_Find.Size = new System.Drawing.Size(186, 22);
            this.txb_Find.TabIndex = 22;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(729, 380);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(186, 32);
            this.btn_Find.TabIndex = 23;
            this.btn_Find.Text = "Find User Name";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(285, 349);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(82, 63);
            this.btn_Show.TabIndex = 24;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Btn_Preview
            // 
            this.Btn_Preview.Location = new System.Drawing.Point(25, 349);
            this.Btn_Preview.Name = "Btn_Preview";
            this.Btn_Preview.Size = new System.Drawing.Size(82, 63);
            this.Btn_Preview.TabIndex = 25;
            this.Btn_Preview.Text = "Preview";
            this.Btn_Preview.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(157, 349);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(82, 63);
            this.btn_Clear.TabIndex = 26;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 424);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Btn_Preview);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txb_Find);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.dgv_Account);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Account";
            this.Text = "formAccount";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txb_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button Btn_Preview;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.CheckBox ck_Gender;
        private System.Windows.Forms.NumericUpDown nm_Type;
    }
}