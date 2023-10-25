
namespace WindowsFormsApp_System___Grocery_Store_
{
    partial class AddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItems));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker_BookPurchase = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_CLEAR = new System.Windows.Forms.Button();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.text_ItemQty = new System.Windows.Forms.TextBox();
            this.text_ItemPrice = new System.Windows.Forms.TextBox();
            this.text_IName = new System.Windows.Forms.TextBox();
            this.text_ItemID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 78);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.dateTimePicker_BookPurchase);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_CLEAR);
            this.panel2.Controls.Add(this.btn_SAVE);
            this.panel2.Controls.Add(this.text_ItemQty);
            this.panel2.Controls.Add(this.text_ItemPrice);
            this.panel2.Controls.Add(this.text_IName);
            this.panel2.Controls.Add(this.text_ItemID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(254, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 441);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimePicker_BookPurchase
            // 
            this.dateTimePicker_BookPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_BookPurchase.Location = new System.Drawing.Point(264, 170);
            this.dateTimePicker_BookPurchase.Name = "dateTimePicker_BookPurchase";
            this.dateTimePicker_BookPurchase.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_BookPurchase.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Item Purchase Date";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(362, 374);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 31);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_CLEAR
            // 
            this.btn_CLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CLEAR.Location = new System.Drawing.Point(208, 374);
            this.btn_CLEAR.Name = "btn_CLEAR";
            this.btn_CLEAR.Size = new System.Drawing.Size(91, 31);
            this.btn_CLEAR.TabIndex = 14;
            this.btn_CLEAR.Text = "CLEAR";
            this.btn_CLEAR.UseVisualStyleBackColor = true;
            this.btn_CLEAR.Click += new System.EventHandler(this.btn_CLEAR_Click);
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAVE.Location = new System.Drawing.Point(60, 374);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(82, 31);
            this.btn_SAVE.TabIndex = 13;
            this.btn_SAVE.Text = "SAVE";
            this.btn_SAVE.UseVisualStyleBackColor = true;
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            // 
            // text_ItemQty
            // 
            this.text_ItemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ItemQty.Location = new System.Drawing.Point(263, 299);
            this.text_ItemQty.Name = "text_ItemQty";
            this.text_ItemQty.Size = new System.Drawing.Size(201, 27);
            this.text_ItemQty.TabIndex = 8;
            // 
            // text_ItemPrice
            // 
            this.text_ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ItemPrice.Location = new System.Drawing.Point(263, 236);
            this.text_ItemPrice.Name = "text_ItemPrice";
            this.text_ItemPrice.Size = new System.Drawing.Size(201, 27);
            this.text_ItemPrice.TabIndex = 7;
            // 
            // text_IName
            // 
            this.text_IName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_IName.Location = new System.Drawing.Point(264, 113);
            this.text_IName.Name = "text_IName";
            this.text_IName.Size = new System.Drawing.Size(200, 27);
            this.text_IName.TabIndex = 6;
            // 
            // text_ItemID
            // 
            this.text_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ItemID.Location = new System.Drawing.Point(264, 51);
            this.text_ItemID.Name = "text_ItemID";
            this.text_ItemID.Size = new System.Drawing.Size(200, 27);
            this.text_ItemID.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 441);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 515);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BookPurchase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_CLEAR;
        private System.Windows.Forms.Button btn_SAVE;
        private System.Windows.Forms.TextBox text_ItemQty;
        private System.Windows.Forms.TextBox text_ItemPrice;
        private System.Windows.Forms.TextBox text_IName;
        private System.Windows.Forms.TextBox text_ItemID;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}