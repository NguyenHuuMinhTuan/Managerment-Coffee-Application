
namespace DoAnBanHangShop
{
    partial class Customer
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
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.txb_Tel = new System.Windows.Forms.TextBox();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_fullName = new System.Windows.Forms.TextBox();
            this.txb_IDCus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_findCus = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_detailCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 333);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Location = new System.Drawing.Point(25, 23);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.Size = new System.Drawing.Size(444, 328);
            this.dgv_Customer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.btn_Preview);
            this.panel2.Controls.Add(this.txb_Tel);
            this.panel2.Controls.Add(this.txb_address);
            this.panel2.Controls.Add(this.txb_fullName);
            this.panel2.Controls.Add(this.txb_IDCus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(476, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 331);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Full Name :";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(175, 237);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 72);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(30, 237);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(110, 72);
            this.btn_Preview.TabIndex = 8;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // txb_Tel
            // 
            this.txb_Tel.Location = new System.Drawing.Point(85, 174);
            this.txb_Tel.Name = "txb_Tel";
            this.txb_Tel.Size = new System.Drawing.Size(211, 20);
            this.txb_Tel.TabIndex = 7;
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(85, 124);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(211, 20);
            this.txb_address.TabIndex = 5;
            // 
            // txb_fullName
            // 
            this.txb_fullName.Location = new System.Drawing.Point(85, 70);
            this.txb_fullName.Name = "txb_fullName";
            this.txb_fullName.Size = new System.Drawing.Size(211, 20);
            this.txb_fullName.TabIndex = 3;
            // 
            // txb_IDCus
            // 
            this.txb_IDCus.Location = new System.Drawing.Point(85, 18);
            this.txb_IDCus.Name = "txb_IDCus";
            this.txb_IDCus.Size = new System.Drawing.Size(211, 20);
            this.txb_IDCus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdCustomer :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_findCus);
            this.panel3.Controls.Add(this.btn_Del);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Controls.Add(this.btn_ADD);
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.btn_Show);
            this.panel3.Location = new System.Drawing.Point(5, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 86);
            this.panel3.TabIndex = 3;
            // 
            // btn_findCus
            // 
            this.btn_findCus.Location = new System.Drawing.Point(545, 6);
            this.btn_findCus.Name = "btn_findCus";
            this.btn_findCus.Size = new System.Drawing.Size(110, 72);
            this.btn_findCus.TabIndex = 8;
            this.btn_findCus.Text = "Find";
            this.btn_findCus.UseVisualStyleBackColor = true;
            this.btn_findCus.Click += new System.EventHandler(this.btn_findCus_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(410, 6);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(110, 72);
            this.btn_Del.TabIndex = 7;
            this.btn_Del.Text = "DEL";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(276, 6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(110, 72);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(139, 6);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(110, 72);
            this.btn_ADD.TabIndex = 5;
            this.btn_ADD.Text = "ADD";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(691, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 75);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(7, 6);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(110, 72);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_detailCustomer);
            this.panel4.Location = new System.Drawing.Point(801, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 389);
            this.panel4.TabIndex = 4;
            // 
            // btn_detailCustomer
            // 
            this.btn_detailCustomer.Location = new System.Drawing.Point(15, 15);
            this.btn_detailCustomer.Name = "btn_detailCustomer";
            this.btn_detailCustomer.Size = new System.Drawing.Size(165, 66);
            this.btn_detailCustomer.TabIndex = 5;
            this.btn_detailCustomer.Text = "Detail";
            this.btn_detailCustomer.UseVisualStyleBackColor = true;
            this.btn_detailCustomer.Click += new System.EventHandler(this.btn_detailCustomer_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_Customer);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.TextBox txb_Tel;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_fullName;
        private System.Windows.Forms.TextBox txb_IDCus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_findCus;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_detailCustomer;
    }
}