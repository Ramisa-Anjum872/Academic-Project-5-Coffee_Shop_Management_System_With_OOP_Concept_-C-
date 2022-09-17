namespace CoffeeshopManagementSystem
{
    partial class EmpForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.msSearchOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMember = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allNotification = new System.Windows.Forms.ToolStripMenuItem();
            this.newNotification = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformat = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisSyste = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderInformationToolStripMenuItem,
            this.mToolStripMenuItem,
            this.notificationToolStripMenuItem,
            this.accountInformationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderInformationToolStripMenuItem
            // 
            this.orderInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msNewOrder,
            this.msSearchOrder});
            this.orderInformationToolStripMenuItem.Name = "orderInformationToolStripMenuItem";
            this.orderInformationToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.orderInformationToolStripMenuItem.Text = "Order Information";
            // 
            // msNewOrder
            // 
            this.msNewOrder.Name = "msNewOrder";
            this.msNewOrder.Size = new System.Drawing.Size(217, 34);
            this.msNewOrder.Text = "New Order";
            this.msNewOrder.Click += new System.EventHandler(this.msNewOrder_Click);
            // 
            // msSearchOrder
            // 
            this.msSearchOrder.Name = "msSearchOrder";
            this.msSearchOrder.Size = new System.Drawing.Size(217, 34);
            this.msSearchOrder.Text = "Search Order";
            this.msSearchOrder.Click += new System.EventHandler(this.msSearchOrder_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMember});
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.mToolStripMenuItem.Text = "Membership";
            // 
            // addMember
            // 
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(253, 34);
            this.addMember.Text = "Add Membership";
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allNotification,
            this.newNotification});
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.notificationToolStripMenuItem.Text = "Notification";
            // 
            // allNotification
            // 
            this.allNotification.Name = "allNotification";
            this.allNotification.Size = new System.Drawing.Size(280, 34);
            this.allNotification.Text = "Show All Notification";
            this.allNotification.Click += new System.EventHandler(this.allNotification_Click);
            // 
            // newNotification
            // 
            this.newNotification.Name = "newNotification";
            this.newNotification.Size = new System.Drawing.Size(280, 34);
            this.newNotification.Text = "New Notification";
            this.newNotification.Click += new System.EventHandler(this.newNotification_Click);
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInformat,
            this.logOutToolStripMenuItem});
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.accountInformationToolStripMenuItem.Text = "Account";
            // 
            // accountInformat
            // 
            this.accountInformat.Name = "accountInformat";
            this.accountInformat.Size = new System.Drawing.Size(278, 34);
            this.accountInformat.Text = "Account Information";
            this.accountInformat.Click += new System.EventHandler(this.accountInformat_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisSyste});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutThisSyste
            // 
            this.aboutThisSyste.Name = "aboutThisSyste";
            this.aboutThisSyste.Size = new System.Drawing.Size(259, 34);
            this.aboutThisSyste.Text = "About The System";
            this.aboutThisSyste.Click += new System.EventHandler(this.aboutThisSyste_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnl1);
            this.pnlMain.Controls.Add(this.menuStrip1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(978, 1050);
            this.pnlMain.TabIndex = 0;
            // 
            // pnl1
            // 
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 33);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(978, 904);
            this.pnl1.TabIndex = 2;
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 1050);
            this.Controls.Add(this.pnlMain);
            this.Name = "EmpForm";
            this.Text = "Employee Working Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmpForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msNewOrder;
        private System.Windows.Forms.ToolStripMenuItem msSearchOrder;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMember;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allNotification;
        private System.Windows.Forms.ToolStripMenuItem newNotification;
        private System.Windows.Forms.ToolStripMenuItem accountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountInformat;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisSyste;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnl1;
    }
}