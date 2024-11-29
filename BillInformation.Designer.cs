
namespace DoAnBanHangShop
{
    partial class dtp_ChoseYear
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_BillInformation = new System.Windows.Forms.DataGridView();
            this.btn_BillDatabase = new System.Windows.Forms.Button();
            this.Ch_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_ChosseYear = new System.Windows.Forms.DateTimePicker();
            this.Chart_Pie_Product = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_Revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Pie_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BillInformation
            // 
            this.dgv_BillInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_BillInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BillInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BillInformation.Location = new System.Drawing.Point(30, 370);
            this.dgv_BillInformation.Name = "dgv_BillInformation";
            this.dgv_BillInformation.ReadOnly = true;
            this.dgv_BillInformation.Size = new System.Drawing.Size(517, 277);
            this.dgv_BillInformation.TabIndex = 0;
            // 
            // btn_BillDatabase
            // 
            this.btn_BillDatabase.Location = new System.Drawing.Point(30, 658);
            this.btn_BillDatabase.Name = "btn_BillDatabase";
            this.btn_BillDatabase.Size = new System.Drawing.Size(165, 79);
            this.btn_BillDatabase.TabIndex = 2;
            this.btn_BillDatabase.Text = "dataBase";
            this.btn_BillDatabase.UseVisualStyleBackColor = true;
            this.btn_BillDatabase.Click += new System.EventHandler(this.btn_BillDatabase_Click);
            // 
            // Ch_Revenue
            // 
            chartArea1.Name = "ChartArea1";
            this.Ch_Revenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Ch_Revenue.Legends.Add(legend1);
            this.Ch_Revenue.Location = new System.Drawing.Point(30, 67);
            this.Ch_Revenue.Name = "Ch_Revenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Ch_Revenue.Series.Add(series1);
            this.Ch_Revenue.Size = new System.Drawing.Size(1311, 297);
            this.Ch_Revenue.TabIndex = 3;
            this.Ch_Revenue.Text = "Revenue";
            // 
            // dtp_ChosseYear
            // 
            this.dtp_ChosseYear.Location = new System.Drawing.Point(30, 12);
            this.dtp_ChosseYear.Name = "dtp_ChosseYear";
            this.dtp_ChosseYear.Size = new System.Drawing.Size(262, 20);
            this.dtp_ChosseYear.TabIndex = 4;
            // 
            // Chart_Pie_Product
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart_Pie_Product.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_Pie_Product.Legends.Add(legend2);
            this.Chart_Pie_Product.Location = new System.Drawing.Point(581, 370);
            this.Chart_Pie_Product.Name = "Chart_Pie_Product";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_Pie_Product.Series.Add(series2);
            this.Chart_Pie_Product.Size = new System.Drawing.Size(760, 323);
            this.Chart_Pie_Product.TabIndex = 5;
            this.Chart_Pie_Product.Text = "chart1";
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.Location = new System.Drawing.Point(215, 653);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(165, 79);
            this.btn_DeleteAll.TabIndex = 6;
            this.btn_DeleteAll.Text = "Reset";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // dtp_ChoseYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.Chart_Pie_Product);
            this.Controls.Add(this.dtp_ChosseYear);
            this.Controls.Add(this.btn_BillDatabase);
            this.Controls.Add(this.dgv_BillInformation);
            this.Controls.Add(this.Ch_Revenue);
            this.Name = "dtp_ChoseYear";
            this.Text = "BillInformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_Revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Pie_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BillInformation;
        private System.Windows.Forms.Button btn_BillDatabase;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ch_Revenue;
        private System.Windows.Forms.DateTimePicker dtp_ChosseYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Pie_Product;
        private System.Windows.Forms.Button btn_DeleteAll;
    }
}