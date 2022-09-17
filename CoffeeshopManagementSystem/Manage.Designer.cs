namespace CoffeeshopManagementSystem/// this
{
    partial class Manage
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
            this.btnShowIteam = new System.Windows.Forms.Button();
            this.btnSearchIteam = new System.Windows.Forms.Button();
            this.txtSearchIteam = new System.Windows.Forms.TextBox();
            this.dgvIteam = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIteamSave = new System.Windows.Forms.Button();
            this.txtIteamPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIteamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIteamId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musTotalSell = new System.Windows.Forms.ToolStripMenuItem();
            this.musLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteam)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowIteam
            // 
            this.btnShowIteam.Location = new System.Drawing.Point(448, 254);
            this.btnShowIteam.Name = "btnShowIteam";
            this.btnShowIteam.Size = new System.Drawing.Size(131, 44);
            this.btnShowIteam.TabIndex = 15;
            this.btnShowIteam.Text = "Show Iteams";
            this.btnShowIteam.UseVisualStyleBackColor = true;
            this.btnShowIteam.Click += new System.EventHandler(this.btnShowIteam_Click);
            // 
            // btnSearchIteam
            // 
            this.btnSearchIteam.Location = new System.Drawing.Point(372, 304);
            this.btnSearchIteam.Name = "btnSearchIteam";
            this.btnSearchIteam.Size = new System.Drawing.Size(131, 44);
            this.btnSearchIteam.TabIndex = 13;
            this.btnSearchIteam.Text = "Search Iteams";
            this.btnSearchIteam.UseVisualStyleBackColor = true;
            this.btnSearchIteam.Click += new System.EventHandler(this.btnSearchIteam_Click);
            // 
            // txtSearchIteam
            // 
            this.txtSearchIteam.Location = new System.Drawing.Point(509, 310);
            this.txtSearchIteam.Multiline = true;
            this.txtSearchIteam.Name = "txtSearchIteam";
            this.txtSearchIteam.Size = new System.Drawing.Size(149, 38);
            this.txtSearchIteam.TabIndex = 14;
            // 
            // dgvIteam
            // 
            this.dgvIteam.AllowUserToAddRows = false;
            this.dgvIteam.AllowUserToDeleteRows = false;
            this.dgvIteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.itemName,
            this.price});
            this.dgvIteam.Location = new System.Drawing.Point(21, 354);
            this.dgvIteam.Name = "dgvIteam";
            this.dgvIteam.ReadOnly = true;
            this.dgvIteam.RowHeadersWidth = 62;
            this.dgvIteam.RowTemplate.Height = 28;
            this.dgvIteam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIteam.Size = new System.Drawing.Size(637, 301);
            this.dgvIteam.TabIndex = 12;
            this.dgvIteam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIteam_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelet);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnIteamSave);
            this.panel1.Controls.Add(this.txtIteamPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIteamName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIteamId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 292);
            this.panel1.TabIndex = 11;
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(141, 229);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(94, 39);
            this.btnDelet.TabIndex = 8;
            this.btnDelet.Text = "Delet";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(241, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 39);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIteamSave
            // 
            this.btnIteamSave.Location = new System.Drawing.Point(41, 229);
            this.btnIteamSave.Name = "btnIteamSave";
            this.btnIteamSave.Size = new System.Drawing.Size(94, 39);
            this.btnIteamSave.TabIndex = 6;
            this.btnIteamSave.Text = "Save";
            this.btnIteamSave.UseVisualStyleBackColor = true;
            this.btnIteamSave.Click += new System.EventHandler(this.btnIteamSave_Click);
            // 
            // txtIteamPrice
            // 
            this.txtIteamPrice.Location = new System.Drawing.Point(156, 156);
            this.txtIteamPrice.Multiline = true;
            this.txtIteamPrice.Name = "txtIteamPrice";
            this.txtIteamPrice.Size = new System.Drawing.Size(149, 38);
            this.txtIteamPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtIteamName
            // 
            this.txtIteamName.Location = new System.Drawing.Point(156, 92);
            this.txtIteamName.Multiline = true;
            this.txtIteamName.Name = "txtIteamName";
            this.txtIteamName.Size = new System.Drawing.Size(149, 38);
            this.txtIteamName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iteam Name";
            // 
            // txtIteamId
            // 
            this.txtIteamId.Location = new System.Drawing.Point(156, 30);
            this.txtIteamId.Multiline = true;
            this.txtIteamId.Name = "txtIteamId";
            this.txtIteamId.Size = new System.Drawing.Size(149, 38);
            this.txtIteamId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iteam ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 31);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeInformationToolStripMenuItem,
            this.musTotalSell,
            this.musLogOut});
            this.moreToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(72, 28);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            // 
            // musTotalSell
            // 
            this.musTotalSell.Name = "musTotalSell";
            this.musTotalSell.Size = new System.Drawing.Size(297, 34);
            this.musTotalSell.Text = "Total Sell";
            // 
            // musLogOut
            // 
            this.musLogOut.Name = "musLogOut";
            this.musLogOut.Size = new System.Drawing.Size(297, 34);
            this.musLogOut.Text = "Log Out";
            this.musLogOut.Click += new System.EventHandler(this.musLogOut_Click);
            // 
            // itemId
            // 
            this.itemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemId.DataPropertyName = "itemId";
            this.itemId.HeaderText = "Iteam ID";
            this.itemId.MinimumWidth = 8;
            this.itemId.Name = "itemId";
            this.itemId.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "Iteam Name";
            this.itemName.MinimumWidth = 8;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Regular Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 660);
            this.Controls.Add(this.btnShowIteam);
            this.Controls.Add(this.btnSearchIteam);
            this.Controls.Add(this.txtSearchIteam);
            this.Controls.Add(this.dgvIteam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Manage";
            this.Text = "Manage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowIteam;
        private System.Windows.Forms.Button btnSearchIteam;
        private System.Windows.Forms.TextBox txtSearchIteam;
        private System.Windows.Forms.DataGridView dgvIteam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIteamSave;
        private System.Windows.Forms.TextBox txtIteamPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIteamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIteamId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musTotalSell;
        private System.Windows.Forms.ToolStripMenuItem musLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}