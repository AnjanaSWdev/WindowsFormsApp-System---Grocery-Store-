namespace WindowsFormsApp_System___Grocery_Store_
{
    partial class ManageOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.text_OrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_CusId = new System.Windows.Forms.TextBox();
            this.order_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addtocart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Cusname = new System.Windows.Forms.TextBox();
            this.OrderGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_TotAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_InsertOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers List";
            // 
            // CustomersGV
            // 
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Location = new System.Drawing.Point(12, 55);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.RowHeadersWidth = 51;
            this.CustomersGV.RowTemplate.Height = 24;
            this.CustomersGV.Size = new System.Drawing.Size(621, 330);
            this.CustomersGV.TabIndex = 1;
            this.CustomersGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellClick);
            // 
            // text_OrderId
            // 
            this.text_OrderId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_OrderId.Location = new System.Drawing.Point(24, 423);
            this.text_OrderId.Name = "text_OrderId";
            this.text_OrderId.Size = new System.Drawing.Size(184, 34);
            this.text_OrderId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer ID :";
            // 
            // text_CusId
            // 
            this.text_CusId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CusId.Location = new System.Drawing.Point(24, 499);
            this.text_CusId.Name = "text_CusId";
            this.text_CusId.ReadOnly = true;
            this.text_CusId.Size = new System.Drawing.Size(184, 34);
            this.text_CusId.TabIndex = 4;
            // 
            // order_date
            // 
            this.order_date.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_date.Location = new System.Drawing.Point(24, 662);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(212, 31);
            this.order_date.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(933, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item List";
            // 
            // ItemsGV
            // 
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(659, 55);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersWidth = 51;
            this.ItemsGV.RowTemplate.Height = 24;
            this.ItemsGV.Size = new System.Drawing.Size(621, 330);
            this.ItemsGV.TabIndex = 9;
            this.ItemsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(670, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantity :";
            // 
            // btn_addtocart
            // 
            this.btn_addtocart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_addtocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addtocart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addtocart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtocart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addtocart.Location = new System.Drawing.Point(1115, 423);
            this.btn_addtocart.Name = "btn_addtocart";
            this.btn_addtocart.Size = new System.Drawing.Size(165, 37);
            this.btn_addtocart.TabIndex = 16;
            this.btn_addtocart.Text = "Add to Order";
            this.btn_addtocart.UseVisualStyleBackColor = false;
            this.btn_addtocart.Click += new System.EventHandler(this.btn_addtocart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Customer Name :";
            // 
            // text_Cusname
            // 
            this.text_Cusname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Cusname.Location = new System.Drawing.Point(24, 585);
            this.text_Cusname.Name = "text_Cusname";
            this.text_Cusname.ReadOnly = true;
            this.text_Cusname.Size = new System.Drawing.Size(184, 34);
            this.text_Cusname.TabIndex = 17;
            // 
            // OrderGV
            // 
            this.OrderGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderGV.ColumnHeadersHeight = 29;
            this.OrderGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.OrderGV.GridColor = System.Drawing.Color.SlateBlue;
            this.OrderGV.Location = new System.Drawing.Point(308, 471);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.RowHeadersWidth = 51;
            this.OrderGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderGV.RowTemplate.Height = 24;
            this.OrderGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderGV.Size = new System.Drawing.Size(972, 205);
            this.OrderGV.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 174;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 173;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 174;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 173;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(675, 426);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 34);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label_TotAmount
            // 
            this.label_TotAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_TotAmount.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotAmount.Location = new System.Drawing.Point(755, 683);
            this.label_TotAmount.Name = "label_TotAmount";
            this.label_TotAmount.Size = new System.Drawing.Size(172, 56);
            this.label_TotAmount.TabIndex = 26;
            this.label_TotAmount.Text = "Rs . 00";
            this.label_TotAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(616, 703);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Grand Total :";
            // 
            // btn_InsertOrder
            // 
            this.btn_InsertOrder.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_InsertOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InsertOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InsertOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_InsertOrder.Location = new System.Drawing.Point(341, 697);
            this.btn_InsertOrder.Name = "btn_InsertOrder";
            this.btn_InsertOrder.Size = new System.Drawing.Size(165, 37);
            this.btn_InsertOrder.TabIndex = 27;
            this.btn_InsertOrder.Text = "Insert Order";
            this.btn_InsertOrder.UseVisualStyleBackColor = false;
            this.btn_InsertOrder.Click += new System.EventHandler(this.btn_InsertOrder_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(24, 703);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "View Orders";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1292, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_InsertOrder);
            this.Controls.Add(this.label_TotAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.OrderGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_Cusname);
            this.Controls.Add(this.btn_addtocart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemsGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.order_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_CusId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_OrderId);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.TextBox text_OrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_CusId;
        private System.Windows.Forms.DateTimePicker order_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addtocart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_Cusname;
        private System.Windows.Forms.DataGridView OrderGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_TotAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_InsertOrder;
        private System.Windows.Forms.Button button2;
    }
}