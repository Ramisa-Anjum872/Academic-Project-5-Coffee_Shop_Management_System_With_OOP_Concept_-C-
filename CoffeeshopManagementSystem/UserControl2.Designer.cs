namespace CoffeeshopManagementSystem
{
    partial class UserControl2
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
            this.gridView2 = new System.Windows.Forms.DataGridView();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.addNotification = new System.Windows.Forms.Button();
            this.txtNotification = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.pnlMember.SuspendLayout();
            this.pnlNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.AllowUserToAddRows = false;
            this.gridView2.AllowUserToDeleteRows = false;
            this.gridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView2.Location = new System.Drawing.Point(157, 375);
            this.gridView2.Name = "gridView2";
            this.gridView2.ReadOnly = true;
            this.gridView2.RowHeadersWidth = 62;
            this.gridView2.RowTemplate.Height = 28;
            this.gridView2.Size = new System.Drawing.Size(664, 393);
            this.gridView2.TabIndex = 4;
            // 
            // pnlMember
            // 
            this.pnlMember.Controls.Add(this.btnAdd);
            this.pnlMember.Controls.Add(this.txtAddress);
            this.pnlMember.Controls.Add(this.label2);
            this.pnlMember.Controls.Add(this.txtPhoneNo);
            this.pnlMember.Controls.Add(this.label3);
            this.pnlMember.Controls.Add(this.txtMemberId);
            this.pnlMember.Controls.Add(this.label1);
            this.pnlMember.Controls.Add(this.txtName);
            this.pnlMember.Controls.Add(this.label5);
            this.pnlMember.Location = new System.Drawing.Point(3, 3);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(369, 313);
            this.pnlMember.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(229, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 38);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 26);
            this.txtAddress.TabIndex = 20;
            this.txtAddress.Text = "Tongi,Gazipur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Address";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(135, 185);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(200, 26);
            this.txtPhoneNo.TabIndex = 22;
            this.txtPhoneNo.Text = "019**********";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone No";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Enabled = false;
            this.txtMemberId.Location = new System.Drawing.Point(139, 35);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(200, 26);
            this.txtMemberId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Member Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 18;
            this.txtName.Text = "Munna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // pnlNotification
            // 
            this.pnlNotification.Controls.Add(this.addNotification);
            this.pnlNotification.Controls.Add(this.txtNotification);
            this.pnlNotification.Controls.Add(this.label4);
            this.pnlNotification.Location = new System.Drawing.Point(387, 3);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(591, 313);
            this.pnlNotification.TabIndex = 6;
            // 
            // addNotification
            // 
            this.addNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNotification.Location = new System.Drawing.Point(474, 240);
            this.addNotification.Name = "addNotification";
            this.addNotification.Size = new System.Drawing.Size(106, 38);
            this.addNotification.TabIndex = 24;
            this.addNotification.Text = "Add";
            this.addNotification.UseVisualStyleBackColor = true;
            this.addNotification.Click += new System.EventHandler(this.addNotification_Click);
            // 
            // txtNotification
            // 
            this.txtNotification.Location = new System.Drawing.Point(29, 60);
            this.txtNotification.Multiline = true;
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(432, 218);
            this.txtNotification.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Write A Massage (only 200 letters):";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.pnlMember);
            this.Controls.Add(this.gridView2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(978, 768);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.pnlMember.ResumeLayout(false);
            this.pnlMember.PerformLayout();
            this.pnlNotification.ResumeLayout(false);
            this.pnlNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView2;
        public System.Windows.Forms.Panel pnlMember;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel pnlNotification;
        public System.Windows.Forms.Button addNotification;
        public System.Windows.Forms.TextBox txtNotification;
        private System.Windows.Forms.Label label4;
    }
}
