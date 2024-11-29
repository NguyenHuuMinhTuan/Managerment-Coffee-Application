
namespace DoAnBanHangShop
{
    partial class Salary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label sALARYLabel;
            System.Windows.Forms.Label iDEMPLYMENTLabel;
            this.shop_TLDataSet1 = new DoAnBanHangShop.Shop_TLDataSet1();
            this.sALARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALARYTableAdapter = new DoAnBanHangShop.Shop_TLDataSet1TableAdapters.SALARYTableAdapter();
            this.tableAdapterManager = new DoAnBanHangShop.Shop_TLDataSet1TableAdapters.TableAdapterManager();
            this.sALARYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sALARYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.sALARYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.sALARYTextBox = new System.Windows.Forms.TextBox();
            this.iDEMPLYMENTTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            sALARYLabel = new System.Windows.Forms.Label();
            iDEMPLYMENTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shop_TLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingNavigator)).BeginInit();
            this.sALARYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shop_TLDataSet1
            // 
            this.shop_TLDataSet1.DataSetName = "Shop_TLDataSet1";
            this.shop_TLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALARYBindingSource
            // 
            this.sALARYBindingSource.DataMember = "SALARY";
            this.sALARYBindingSource.DataSource = this.shop_TLDataSet1;
            // 
            // sALARYTableAdapter
            // 
            this.sALARYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SALARYTableAdapter = this.sALARYTableAdapter;
            this.tableAdapterManager.UpdateOrder = DoAnBanHangShop.Shop_TLDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sALARYBindingNavigator
            // 
            this.sALARYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sALARYBindingNavigator.BindingSource = this.sALARYBindingSource;
            this.sALARYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sALARYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sALARYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sALARYBindingNavigatorSaveItem});
            this.sALARYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sALARYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sALARYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sALARYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sALARYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sALARYBindingNavigator.Name = "sALARYBindingNavigator";
            this.sALARYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sALARYBindingNavigator.Size = new System.Drawing.Size(635, 25);
            this.sALARYBindingNavigator.TabIndex = 0;
            this.sALARYBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sALARYDataGridView
            // 
            this.sALARYDataGridView.AutoGenerateColumns = false;
            this.sALARYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sALARYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sALARYDataGridView.DataSource = this.sALARYBindingSource;
            this.sALARYDataGridView.Location = new System.Drawing.Point(28, 48);
            this.sALARYDataGridView.Name = "sALARYDataGridView";
            this.sALARYDataGridView.Size = new System.Drawing.Size(345, 220);
            this.sALARYDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SALARY";
            this.dataGridViewTextBoxColumn2.HeaderText = "SALARY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDEMPLYMENT";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDEMPLYMENT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // sALARYBindingNavigatorSaveItem
            // 
            this.sALARYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sALARYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sALARYBindingNavigatorSaveItem.Image")));
            this.sALARYBindingNavigatorSaveItem.Name = "sALARYBindingNavigatorSaveItem";
            this.sALARYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sALARYBindingNavigatorSaveItem.Text = "Save Data";
            this.sALARYBindingNavigatorSaveItem.Click += new System.EventHandler(this.sALARYBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(405, 70);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sALARYBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(499, 67);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // sALARYLabel
            // 
            sALARYLabel.AutoSize = true;
            sALARYLabel.Location = new System.Drawing.Point(405, 96);
            sALARYLabel.Name = "sALARYLabel";
            sALARYLabel.Size = new System.Drawing.Size(52, 13);
            sALARYLabel.TabIndex = 4;
            sALARYLabel.Text = "SALARY:";
            // 
            // sALARYTextBox
            // 
            this.sALARYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sALARYBindingSource, "SALARY", true));
            this.sALARYTextBox.Location = new System.Drawing.Point(499, 93);
            this.sALARYTextBox.Name = "sALARYTextBox";
            this.sALARYTextBox.Size = new System.Drawing.Size(100, 20);
            this.sALARYTextBox.TabIndex = 5;
            // 
            // iDEMPLYMENTLabel
            // 
            iDEMPLYMENTLabel.AutoSize = true;
            iDEMPLYMENTLabel.Location = new System.Drawing.Point(405, 122);
            iDEMPLYMENTLabel.Name = "iDEMPLYMENTLabel";
            iDEMPLYMENTLabel.Size = new System.Drawing.Size(88, 13);
            iDEMPLYMENTLabel.TabIndex = 6;
            iDEMPLYMENTLabel.Text = "IDEMPLYMENT:";
            // 
            // iDEMPLYMENTTextBox
            // 
            this.iDEMPLYMENTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sALARYBindingSource, "IDEMPLYMENT", true));
            this.iDEMPLYMENTTextBox.Location = new System.Drawing.Point(499, 119);
            this.iDEMPLYMENTTextBox.Name = "iDEMPLYMENTTextBox";
            this.iDEMPLYMENTTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDEMPLYMENTTextBox.TabIndex = 7;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 302);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(sALARYLabel);
            this.Controls.Add(this.sALARYTextBox);
            this.Controls.Add(iDEMPLYMENTLabel);
            this.Controls.Add(this.iDEMPLYMENTTextBox);
            this.Controls.Add(this.sALARYDataGridView);
            this.Controls.Add(this.sALARYBindingNavigator);
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shop_TLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingNavigator)).EndInit();
            this.sALARYBindingNavigator.ResumeLayout(false);
            this.sALARYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shop_TLDataSet1 shop_TLDataSet1;
        private System.Windows.Forms.BindingSource sALARYBindingSource;
        private Shop_TLDataSet1TableAdapters.SALARYTableAdapter sALARYTableAdapter;
        private Shop_TLDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sALARYBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sALARYBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sALARYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox sALARYTextBox;
        private System.Windows.Forms.TextBox iDEMPLYMENTTextBox;
    }
}