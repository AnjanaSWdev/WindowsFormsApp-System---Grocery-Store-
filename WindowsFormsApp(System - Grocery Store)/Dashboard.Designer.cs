
namespace WindowsFormsApp_System___Grocery_Store_
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemsToolStripMenuItem,
            this.dealersToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(183, 601);
            this.menuStrip1.TabIndex = 0;
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.DoubleClickEnabled = true;
            this.addItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addItemsToolStripMenuItem.Image")));
            this.addItemsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(182, 74);
            this.addItemsToolStripMenuItem.Text = "Add Items";
            this.addItemsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.addItemsToolStripMenuItem_Click);
            // 
            // dealersToolStripMenuItem
            // 
            this.dealersToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.dealersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDealersToolStripMenuItem,
            this.viewDealersToolStripMenuItem});
            this.dealersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dealersToolStripMenuItem.Image")));
            this.dealersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dealersToolStripMenuItem.Name = "dealersToolStripMenuItem";
            this.dealersToolStripMenuItem.Size = new System.Drawing.Size(182, 94);
            this.dealersToolStripMenuItem.Text = "Customers";
            this.dealersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addDealersToolStripMenuItem
            // 
            this.addDealersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addDealersToolStripMenuItem.Image")));
            this.addDealersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addDealersToolStripMenuItem.Name = "addDealersToolStripMenuItem";
            this.addDealersToolStripMenuItem.Size = new System.Drawing.Size(247, 76);
            this.addDealersToolStripMenuItem.Text = "Add Customers";
            this.addDealersToolStripMenuItem.Click += new System.EventHandler(this.addDealersToolStripMenuItem_Click);
            // 
            // viewDealersToolStripMenuItem
            // 
            this.viewDealersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewDealersToolStripMenuItem.Image")));
            this.viewDealersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewDealersToolStripMenuItem.Name = "viewDealersToolStripMenuItem";
            this.viewDealersToolStripMenuItem.Size = new System.Drawing.Size(247, 76);
            this.viewDealersToolStripMenuItem.Text = "View Customers";
            this.viewDealersToolStripMenuItem.Click += new System.EventHandler(this.viewDealersToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.orderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("orderToolStripMenuItem.Image")));
            this.orderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(182, 94);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(182, 94);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(182, 94);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 74);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(829, 543);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(127, 46);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 601);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem dealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Button btn_Logout;
    }
}

