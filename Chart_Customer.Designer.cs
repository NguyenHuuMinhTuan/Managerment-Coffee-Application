
namespace DoAnBanHangShop
{
    partial class Chart_Customer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.ch_Customer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(616, 349);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(155, 57);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // ch_Customer
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_Customer.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_Customer.Legends.Add(legend2);
            this.ch_Customer.Location = new System.Drawing.Point(20, 17);
            this.ch_Customer.Name = "ch_Customer";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ch_Customer.Series.Add(series2);
            this.ch_Customer.Size = new System.Drawing.Size(751, 290);
            this.ch_Customer.TabIndex = 3;
            this.ch_Customer.Text = "chart1";
            // 
            // Chart_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ch_Customer);
            this.Controls.Add(this.Btn_Exit);
            this.Name = "Chart_Customer";
            this.Text = "Chart_Customer";
            this.Load += new System.EventHandler(this.Chart_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Customer;
    }
}