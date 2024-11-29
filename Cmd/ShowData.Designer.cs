
namespace DoAnBanHangShop.Cmd
{
    partial class ShowData
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
            this.dgv_Cmd = new System.Windows.Forms.DataGridView();
            this.txb_Command = new System.Windows.Forms.TextBox();
            this.Btn_Execute = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cmd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Preview);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.Btn_Execute);
            this.panel1.Controls.Add(this.txb_Command);
            this.panel1.Controls.Add(this.dgv_Cmd);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 422);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Cmd
            // 
            this.dgv_Cmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cmd.Location = new System.Drawing.Point(7, 3);
            this.dgv_Cmd.Name = "dgv_Cmd";
            this.dgv_Cmd.Size = new System.Drawing.Size(776, 287);
            this.dgv_Cmd.TabIndex = 0;
            // 
            // txb_Command
            // 
            this.txb_Command.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Command.Location = new System.Drawing.Point(128, 304);
            this.txb_Command.Name = "txb_Command";
            this.txb_Command.Size = new System.Drawing.Size(644, 29);
            this.txb_Command.TabIndex = 1;
            // 
            // Btn_Execute
            // 
            this.Btn_Execute.Location = new System.Drawing.Point(128, 358);
            this.Btn_Execute.Name = "Btn_Execute";
            this.Btn_Execute.Size = new System.Drawing.Size(134, 40);
            this.Btn_Execute.TabIndex = 2;
            this.Btn_Execute.Text = "Execute";
            this.Btn_Execute.UseVisualStyleBackColor = true;
            this.Btn_Execute.Click += new System.EventHandler(this.Btn_Execute_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(291, 358);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(134, 40);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(444, 358);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(134, 40);
            this.btn_Preview.TabIndex = 4;
            this.btn_Preview.Text = "ShowPreview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Command :";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(600, 358);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(134, 43);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button Btn_Execute;
        private System.Windows.Forms.TextBox txb_Command;
        private System.Windows.Forms.DataGridView dgv_Cmd;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
    }
}