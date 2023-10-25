namespace WindowsFormsApp_System___Grocery_Store_
{
    partial class ViewOrders
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
            this.label5 = new System.Windows.Forms.Label();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_generateReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 100);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Crimson;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(383, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "View Orders";
            // 
            // OrdersGV
            // 
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Location = new System.Drawing.Point(137, 152);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersWidth = 51;
            this.OrdersGV.RowTemplate.Height = 24;
            this.OrdersGV.Size = new System.Drawing.Size(737, 423);
            this.OrdersGV.TabIndex = 10;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Back.Location = new System.Drawing.Point(527, 609);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(165, 37);
            this.btn_Back.TabIndex = 30;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_generateReport
            // 
            this.btn_generateReport.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_generateReport.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_generateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generateReport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_generateReport.Location = new System.Drawing.Point(771, 609);
            this.btn_generateReport.Name = "btn_generateReport";
            this.btn_generateReport.Size = new System.Drawing.Size(202, 37);
            this.btn_generateReport.TabIndex = 29;
            this.btn_generateReport.Text = "Generate Report";
            this.btn_generateReport.UseVisualStyleBackColor = false;
            this.btn_generateReport.Click += new System.EventHandler(this.btn_generateReport_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 664);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_generateReport);
            this.Controls.Add(this.OrdersGV);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView OrdersGV;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_generateReport;
    }
}