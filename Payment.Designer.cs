
namespace DoAnBanHangShop
{
    partial class Payment
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
            this.dgv_Bill = new System.Windows.Forms.DataGridView();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.cb_IDProduct = new System.Windows.Forms.ComboBox();
            this.cb_IDCustomer = new System.Windows.Forms.ComboBox();
            this.lb_idCustomer = new System.Windows.Forms.Label();
            this.mn_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Payment = new System.Windows.Forms.DateTimePicker();
            this.dgv_Infomation = new System.Windows.Forms.DataGridView();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.dgv_Id = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_IdCategory = new System.Windows.Forms.DataGridView();
            this.printBill = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_PrintBill = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_PaymenttoBill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_Tel = new System.Windows.Forms.TextBox();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.txb_IDBILL = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Infomation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IdCategory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill.Location = new System.Drawing.Point(293, 337);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.ReadOnly = true;
            this.dgv_Bill.Size = new System.Drawing.Size(972, 361);
            this.dgv_Bill.TabIndex = 0;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(134, 106);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(231, 21);
            this.cb_Category.TabIndex = 19;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // cb_IDProduct
            // 
            this.cb_IDProduct.FormattingEnabled = true;
            this.cb_IDProduct.Location = new System.Drawing.Point(134, 160);
            this.cb_IDProduct.Name = "cb_IDProduct";
            this.cb_IDProduct.Size = new System.Drawing.Size(231, 21);
            this.cb_IDProduct.TabIndex = 17;
            this.cb_IDProduct.SelectedIndexChanged += new System.EventHandler(this.cb_IDProduct_SelectedIndexChanged);
            // 
            // cb_IDCustomer
            // 
            this.cb_IDCustomer.FormattingEnabled = true;
            this.cb_IDCustomer.Location = new System.Drawing.Point(5, 62);
            this.cb_IDCustomer.Name = "cb_IDCustomer";
            this.cb_IDCustomer.Size = new System.Drawing.Size(231, 21);
            this.cb_IDCustomer.TabIndex = 16;
            this.cb_IDCustomer.SelectedIndexChanged += new System.EventHandler(this.cb_IDCustomer_SelectedIndexChanged);
            // 
            // lb_idCustomer
            // 
            this.lb_idCustomer.AutoSize = true;
            this.lb_idCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idCustomer.Location = new System.Drawing.Point(11, 39);
            this.lb_idCustomer.Name = "lb_idCustomer";
            this.lb_idCustomer.Size = new System.Drawing.Size(125, 19);
            this.lb_idCustomer.TabIndex = 11;
            this.lb_idCustomer.Text = "Name Customer :";
            // 
            // mn_Quantity
            // 
            this.mn_Quantity.Location = new System.Drawing.Point(134, 214);
            this.mn_Quantity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.mn_Quantity.Name = "mn_Quantity";
            this.mn_Quantity.Size = new System.Drawing.Size(231, 20);
            this.mn_Quantity.TabIndex = 14;
            this.mn_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1027, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Infomation Product";
            // 
            // dtp_Payment
            // 
            this.dtp_Payment.Location = new System.Drawing.Point(134, 61);
            this.dtp_Payment.Name = "dtp_Payment";
            this.dtp_Payment.Size = new System.Drawing.Size(231, 20);
            this.dtp_Payment.TabIndex = 14;
            // 
            // dgv_Infomation
            // 
            this.dgv_Infomation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Infomation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Infomation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Infomation.Location = new System.Drawing.Point(1031, 44);
            this.dgv_Infomation.Name = "dgv_Infomation";
            this.dgv_Infomation.Size = new System.Drawing.Size(276, 58);
            this.dgv_Infomation.TabIndex = 18;
            // 
            // txb_Username
            // 
            this.txb_Username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Username.Location = new System.Drawing.Point(89, 39);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.ReadOnly = true;
            this.txb_Username.Size = new System.Drawing.Size(189, 29);
            this.txb_Username.TabIndex = 20;
            this.txb_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Id
            // 
            this.dgv_Id.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Id.Location = new System.Drawing.Point(1031, 148);
            this.dgv_Id.Name = "dgv_Id";
            this.dgv_Id.Size = new System.Drawing.Size(276, 55);
            this.dgv_Id.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1027, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1027, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID Category";
            // 
            // dgv_IdCategory
            // 
            this.dgv_IdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IdCategory.Location = new System.Drawing.Point(1031, 259);
            this.dgv_IdCategory.Name = "dgv_IdCategory";
            this.dgv_IdCategory.Size = new System.Drawing.Size(276, 55);
            this.dgv_IdCategory.TabIndex = 23;
            // 
            // printBill
            // 
            this.printBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printBill_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Print";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pay";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.customerServiceToolStripMenuItem,
            this.shortKeyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.addToolStripMenuItem,
            this.showToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.printToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.showToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.DisplayStyleChanged += new System.EventHandler(this.btn_PrintBill_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.DisplayStyleChanged += new System.EventHandler(this.btn_PaymenttoBill_Click);
            // 
            // customerServiceToolStripMenuItem
            // 
            this.customerServiceToolStripMenuItem.Name = "customerServiceToolStripMenuItem";
            this.customerServiceToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.customerServiceToolStripMenuItem.Text = "Customer Service";
            this.customerServiceToolStripMenuItem.Click += new System.EventHandler(this.customerServiceToolStripMenuItem_Click);
            // 
            // shortKeyToolStripMenuItem
            // 
            this.shortKeyToolStripMenuItem.Name = "shortKeyToolStripMenuItem";
            this.shortKeyToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.shortKeyToolStripMenuItem.Text = "Short Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "User :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.mn_Quantity);
            this.panel2.Controls.Add(this.cb_IDProduct);
            this.panel2.Controls.Add(this.cb_Category);
            this.panel2.Controls.Add(this.dtp_Payment);
            this.panel2.Location = new System.Drawing.Point(563, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 275);
            this.panel2.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Detail Product :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Id Product :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Category :";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::DoAnBanHangShop.Properties.Resources.trash;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.Location = new System.Drawing.Point(-4, 256);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(175, 56);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackgroundImage = global::DoAnBanHangShop.Properties.Resources.eye;
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Show.Location = new System.Drawing.Point(-4, 188);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(175, 56);
            this.btn_Show.TabIndex = 20;
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_PrintBill
            // 
            this.btn_PrintBill.BackgroundImage = global::DoAnBanHangShop.Properties.Resources.print;
            this.btn_PrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PrintBill.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintBill.Location = new System.Drawing.Point(-4, 563);
            this.btn_PrintBill.Name = "btn_PrintBill";
            this.btn_PrintBill.Size = new System.Drawing.Size(158, 66);
            this.btn_PrintBill.TabIndex = 25;
            this.btn_PrintBill.UseVisualStyleBackColor = true;
            this.btn_PrintBill.Click += new System.EventHandler(this.btn_PrintBill_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackgroundImage = global::DoAnBanHangShop.Properties.Resources.multiple;
            this.btn_AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddProduct.Location = new System.Drawing.Point(0, 126);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(175, 56);
            this.btn_AddProduct.TabIndex = 11;
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_PaymenttoBill
            // 
            this.btn_PaymenttoBill.BackgroundImage = global::DoAnBanHangShop.Properties.Resources.credit_card;
            this.btn_PaymenttoBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PaymenttoBill.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PaymenttoBill.Location = new System.Drawing.Point(0, 457);
            this.btn_PaymenttoBill.Name = "btn_PaymenttoBill";
            this.btn_PaymenttoBill.Size = new System.Drawing.Size(154, 66);
            this.btn_PaymenttoBill.TabIndex = 9;
            this.btn_PaymenttoBill.UseVisualStyleBackColor = true;
            this.btn_PaymenttoBill.Click += new System.EventHandler(this.btn_PaymenttoBill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txb_Tel);
            this.panel1.Controls.Add(this.txb_Address);
            this.panel1.Controls.Add(this.lb_idCustomer);
            this.panel1.Controls.Add(this.cb_IDCustomer);
            this.panel1.Location = new System.Drawing.Point(302, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 274);
            this.panel1.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Profile Customer :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tel :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Address :";
            // 
            // txb_Tel
            // 
            this.txb_Tel.Location = new System.Drawing.Point(0, 192);
            this.txb_Tel.Name = "txb_Tel";
            this.txb_Tel.Size = new System.Drawing.Size(231, 20);
            this.txb_Tel.TabIndex = 18;
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(5, 123);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(231, 20);
            this.txb_Address.TabIndex = 17;
            // 
            // txb_IDBILL
            // 
            this.txb_IDBILL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IDBILL.Location = new System.Drawing.Point(89, 74);
            this.txb_IDBILL.Name = "txb_IDBILL";
            this.txb_IDBILL.ReadOnly = true;
            this.txb_IDBILL.Size = new System.Drawing.Size(189, 29);
            this.txb_IDBILL.TabIndex = 32;
            this.txb_IDBILL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 19);
            this.label15.TabIndex = 33;
            this.label15.Text = "ID BILL :";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 725);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txb_IDBILL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_PrintBill);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_IdCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Id);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.dgv_Infomation);
            this.Controls.Add(this.btn_PaymenttoBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Bill);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Payment";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mn_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Infomation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IdCategory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Bill;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mn_Quantity;
        private System.Windows.Forms.Button btn_PaymenttoBill;
        private System.Windows.Forms.Label lb_idCustomer;
        private System.Windows.Forms.DateTimePicker dtp_Payment;
        private System.Windows.Forms.ComboBox cb_IDProduct;
        private System.Windows.Forms.ComboBox cb_IDCustomer;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.DataGridView dgv_Infomation;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.DataGridView dgv_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_IdCategory;
        private System.Windows.Forms.Button btn_PrintBill;
        private System.Drawing.Printing.PrintDocument printBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortKeyToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_Tel;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.TextBox txb_IDBILL;
        private System.Windows.Forms.Label label15;
    }
}