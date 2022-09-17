namespace CoffeeshopManagementSystem
{
    partial class UserOrderInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cbMemberShip = new System.Windows.Forms.CheckBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstQuantity = new System.Windows.Forms.ListBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridViewOrder = new System.Windows.Forms.DataGridView();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlOrder.Controls.Add(this.txtMemberId);
            this.pnlOrder.Controls.Add(this.txtTotal);
            this.pnlOrder.Controls.Add(this.btnTotal);
            this.pnlOrder.Controls.Add(this.cbMemberShip);
            this.pnlOrder.Controls.Add(this.date1);
            this.pnlOrder.Controls.Add(this.btnSearch);
            this.pnlOrder.Controls.Add(this.lstQuantity);
            this.pnlOrder.Controls.Add(this.txtOrderId);
            this.pnlOrder.Controls.Add(this.label1);
            this.pnlOrder.Controls.Add(this.label6);
            this.pnlOrder.Controls.Add(this.cmbItemName);
            this.pnlOrder.Controls.Add(this.txtItemId);
            this.pnlOrder.Controls.Add(this.label5);
            this.pnlOrder.Controls.Add(this.btnClear);
            this.pnlOrder.Controls.Add(this.btnAdd);
            this.pnlOrder.Controls.Add(this.label4);
            this.pnlOrder.Controls.Add(this.rdoLarge);
            this.pnlOrder.Controls.Add(this.rdoMedium);
            this.pnlOrder.Controls.Add(this.rdoRegular);
            this.pnlOrder.Controls.Add(this.txtPrice);
            this.pnlOrder.Controls.Add(this.label3);
            this.pnlOrder.Controls.Add(this.label2);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(978, 400);
            this.pnlOrder.TabIndex = 2;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(800, 227);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(142, 26);
            this.txtMemberId.TabIndex = 26;
            this.txtMemberId.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Chocolate;
            this.txtTotal.Location = new System.Drawing.Point(664, 320);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(227, 35);
            this.txtTotal.TabIndex = 25;
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(460, 322);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(173, 36);
            this.btnTotal.TabIndex = 24;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cbMemberShip
            // 
            this.cbMemberShip.AutoSize = true;
            this.cbMemberShip.Location = new System.Drawing.Point(459, 227);
            this.cbMemberShip.Name = "cbMemberShip";
            this.cbMemberShip.Size = new System.Drawing.Size(335, 24);
            this.cbMemberShip.TabIndex = 23;
            this.cbMemberShip.Text = "Member Ship Card Holder  (15% Discount)";
            this.cbMemberShip.UseVisualStyleBackColor = true;
            this.cbMemberShip.CheckedChanged += new System.EventHandler(this.cbMemberShip_CheckedChanged);
            // 
            // date1
            // 
            this.date1.CustomFormat = "dd/MM/yyyy  (hh:mm:ss)";
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(812, 3);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(154, 28);
            this.date1.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(475, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 36);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstQuantity
            // 
            this.lstQuantity.AllowDrop = true;
            this.lstQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQuantity.FormattingEnabled = true;
            this.lstQuantity.HorizontalScrollbar = true;
            this.lstQuantity.ItemHeight = 25;
            this.lstQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstQuantity.Location = new System.Drawing.Point(457, 108);
            this.lstQuantity.Name = "lstQuantity";
            this.lstQuantity.Size = new System.Drawing.Size(139, 29);
            this.lstQuantity.TabIndex = 18;
            this.lstQuantity.Tag = "0";
            this.lstQuantity.SelectedIndexChanged += new System.EventHandler(this.lstQuantity_SelectedIndexChanged);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(165, 21);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(227, 26);
            this.txtOrderId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity";
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbItemName.Items.AddRange(new object[] {
            "black coffee",
            "donate",
            "ice coffee",
            "mafin"});
            this.cmbItemName.Location = new System.Drawing.Point(165, 125);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(227, 28);
            this.cmbItemName.TabIndex = 15;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged);
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Location = new System.Drawing.Point(165, 68);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(227, 26);
            this.txtItemId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Item Id";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(299, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(165, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLarge.Location = new System.Drawing.Point(686, 171);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(80, 24);
            this.rdoLarge.TabIndex = 8;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedium.Location = new System.Drawing.Point(574, 171);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(96, 24);
            this.rdoMedium.TabIndex = 7;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRegular.Location = new System.Drawing.Point(459, 172);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(97, 24);
            this.rdoRegular.TabIndex = 6;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(165, 172);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // gridViewOrder
            // 
            this.gridViewOrder.AllowUserToAddRows = false;
            this.gridViewOrder.AllowUserToDeleteRows = false;
            this.gridViewOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridViewOrder.Location = new System.Drawing.Point(0, 417);
            this.gridViewOrder.Name = "gridViewOrder";
            this.gridViewOrder.ReadOnly = true;
            this.gridViewOrder.RowHeadersWidth = 62;
            this.gridViewOrder.RowTemplate.Height = 28;
            this.gridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewOrder.Size = new System.Drawing.Size(978, 351);
            this.gridViewOrder.TabIndex = 3;
            this.gridViewOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridViewOrder_MouseDoubleClick);
            // 
            // UserOrderInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.gridViewOrder);
            this.Controls.Add(this.pnlOrder);
            this.Name = "UserOrderInformation";
            this.Size = new System.Drawing.Size(978, 768);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlOrder;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ListBox lstQuantity;
        public System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbItemName;
        public System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton rdoLarge;
        public System.Windows.Forms.RadioButton rdoMedium;
        public System.Windows.Forms.RadioButton rdoRegular;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.CheckBox cbMemberShip;
        private System.Windows.Forms.DataGridView gridViewOrder;
        public System.Windows.Forms.Button btnTotal;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtMemberId;
    }
}
