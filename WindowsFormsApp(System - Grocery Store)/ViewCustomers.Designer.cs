namespace WindowsFormsApp_System___Grocery_Store_
{
    partial class ViewCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.btn_DEL = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.text_SearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_CusRegister = new System.Windows.Forms.DateTimePicker();
            this.text_Telno = new System.Windows.Forms.TextBox();
            this.text_CusADD = new System.Windows.Forms.TextBox();
            this.text_Cusname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 134);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(456, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Member";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(506, 468);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(107, 35);
            this.btn_Update.TabIndex = 28;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXIT.Location = new System.Drawing.Point(823, 468);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(107, 35);
            this.btn_EXIT.TabIndex = 27;
            this.btn_EXIT.Text = "Exit";
            this.btn_EXIT.UseVisualStyleBackColor = true;
            this.btn_EXIT.Click += new System.EventHandler(this.btn_EXIT_Click);
            // 
            // btn_DEL
            // 
            this.btn_DEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DEL.Location = new System.Drawing.Point(668, 468);
            this.btn_DEL.Name = "btn_DEL";
            this.btn_DEL.Size = new System.Drawing.Size(107, 35);
            this.btn_DEL.TabIndex = 26;
            this.btn_DEL.Text = "Delete";
            this.btn_DEL.UseVisualStyleBackColor = true;
            this.btn_DEL.Click += new System.EventHandler(this.btn_DEL_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(677, 170);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 35);
            this.btn_search.TabIndex = 31;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // text_SearchName
            // 
            this.text_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_SearchName.Location = new System.Drawing.Point(407, 169);
            this.text_SearchName.Name = "text_SearchName";
            this.text_SearchName.Size = new System.Drawing.Size(217, 30);
            this.text_SearchName.TabIndex = 30;
            this.text_SearchName.TextChanged += new System.EventHandler(this.text_SearchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Customer ID :";
            // 
            // dateTimePicker_CusRegister
            // 
            this.dateTimePicker_CusRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_CusRegister.Location = new System.Drawing.Point(730, 272);
            this.dateTimePicker_CusRegister.Name = "dateTimePicker_CusRegister";
            this.dateTimePicker_CusRegister.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_CusRegister.TabIndex = 39;
            // 
            // text_Telno
            // 
            this.text_Telno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Telno.Location = new System.Drawing.Point(730, 368);
            this.text_Telno.Name = "text_Telno";
            this.text_Telno.Size = new System.Drawing.Size(200, 27);
            this.text_Telno.TabIndex = 38;
            // 
            // text_CusADD
            // 
            this.text_CusADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CusADD.Location = new System.Drawing.Point(242, 370);
            this.text_CusADD.Name = "text_CusADD";
            this.text_CusADD.Size = new System.Drawing.Size(200, 27);
            this.text_CusADD.TabIndex = 37;
            // 
            // text_Cusname
            // 
            this.text_Cusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Cusname.Location = new System.Drawing.Point(242, 269);
            this.text_Cusname.Name = "text_Cusname";
            this.text_Cusname.Size = new System.Drawing.Size(200, 27);
            this.text_Cusname.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "Contact.No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Register_date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Customer Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "Customer Name :";
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(968, 540);
            this.Controls.Add(this.dateTimePicker_CusRegister);
            this.Controls.Add(this.text_Telno);
            this.Controls.Add(this.text_CusADD);
            this.Controls.Add(this.text_Cusname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.text_SearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_DEL);
            this.Controls.Add(this.panel1);
            this.Name = "ViewCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Customers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_EXIT;
        private System.Windows.Forms.Button btn_DEL;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox text_SearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CusRegister;
        private System.Windows.Forms.TextBox text_Telno;
        private System.Windows.Forms.TextBox text_CusADD;
        private System.Windows.Forms.TextBox text_Cusname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}