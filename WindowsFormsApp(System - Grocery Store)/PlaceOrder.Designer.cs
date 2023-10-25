namespace WindowsFormsApp_System___Grocery_Store_
{
    partial class PlaceOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Items = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_Itemname = new System.Windows.Forms.TextBox();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.text_Tot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_avbQTY = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_addtocart = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label_TotAmount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items";
            // 
            // cmb_Items
            // 
            this.cmb_Items.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Items.FormattingEnabled = true;
            this.cmb_Items.Location = new System.Drawing.Point(31, 109);
            this.cmb_Items.Name = "cmb_Items";
            this.cmb_Items.Size = new System.Drawing.Size(176, 33);
            this.cmb_Items.TabIndex = 2;
            this.cmb_Items.SelectedIndexChanged += new System.EventHandler(this.cmb_Items_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(771, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(771, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            // 
            // text_Itemname
            // 
            this.text_Itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Itemname.Location = new System.Drawing.Point(374, 83);
            this.text_Itemname.Name = "text_Itemname";
            this.text_Itemname.ReadOnly = true;
            this.text_Itemname.Size = new System.Drawing.Size(251, 30);
            this.text_Itemname.TabIndex = 8;
            // 
            // text_Price
            // 
            this.text_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Price.Location = new System.Drawing.Point(777, 80);
            this.text_Price.Name = "text_Price";
            this.text_Price.ReadOnly = true;
            this.text_Price.Size = new System.Drawing.Size(251, 30);
            this.text_Price.TabIndex = 9;
            // 
            // text_Tot
            // 
            this.text_Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Tot.Location = new System.Drawing.Point(777, 194);
            this.text_Tot.Name = "text_Tot";
            this.text_Tot.ReadOnly = true;
            this.text_Tot.Size = new System.Drawing.Size(251, 30);
            this.text_Tot.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Avb_Qty :";
            // 
            // text_avbQTY
            // 
            this.text_avbQTY.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.text_avbQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_avbQTY.Location = new System.Drawing.Point(31, 220);
            this.text_avbQTY.Name = "text_avbQTY";
            this.text_avbQTY.ReadOnly = true;
            this.text_avbQTY.Size = new System.Drawing.Size(128, 30);
            this.text_avbQTY.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(374, 195);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(251, 30);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_addtocart
            // 
            this.btn_addtocart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_addtocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addtocart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addtocart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtocart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addtocart.Location = new System.Drawing.Point(902, 248);
            this.btn_addtocart.Name = "btn_addtocart";
            this.btn_addtocart.Size = new System.Drawing.Size(165, 37);
            this.btn_addtocart.TabIndex = 15;
            this.btn_addtocart.Text = "Add to Cart";
            this.btn_addtocart.UseVisualStyleBackColor = false;
            this.btn_addtocart.Click += new System.EventHandler(this.btn_addtocart_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.AutoEllipsis = true;
            this.btn_removeItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_removeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_removeItem.Location = new System.Drawing.Point(374, 578);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(153, 42);
            this.btn_removeItem.TabIndex = 18;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = false;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.AutoEllipsis = true;
            this.btn_Print.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Print.Location = new System.Drawing.Point(946, 578);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(121, 42);
            this.btn_Print.TabIndex = 19;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(646, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Grand Total :";
            // 
            // label_TotAmount
            // 
            this.label_TotAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_TotAmount.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotAmount.Location = new System.Drawing.Point(643, 567);
            this.label_TotAmount.Name = "label_TotAmount";
            this.label_TotAmount.Size = new System.Drawing.Size(172, 56);
            this.label_TotAmount.TabIndex = 21;
            this.label_TotAmount.Text = "Rs . 00";
            this.label_TotAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(106, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(972, 205);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_TotAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_addtocart);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.text_avbQTY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_Tot);
            this.Controls.Add(this.text_Price);
            this.Controls.Add(this.text_Itemname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Items;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_Itemname;
        private System.Windows.Forms.TextBox text_Price;
        private System.Windows.Forms.TextBox text_Tot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_avbQTY;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_addtocart;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_TotAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}