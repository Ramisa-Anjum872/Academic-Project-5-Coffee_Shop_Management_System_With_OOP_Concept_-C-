using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CoffeeshopManagementSystem
{
    public partial class EmpForm : Form
    {
        UserOrderInformation uoi=new UserOrderInformation();
        UserControl2 u2 = new UserControl2();
        Login login1;
        public EmpForm(Login login1)
        {
            InitializeComponent();
            pnl1.Controls.Add(uoi);
            this.login1 = login1;
        }
        
        private void msNewOrder_Click(object sender, EventArgs e)
        {
            u2.Visible = false;
            uoi.Visible = true;
            pnl1.Controls.Add(uoi);
            uoi.txtOrderId.Enabled = false;
            uoi.cmbItemName.Enabled = true;
            uoi.btnSearch.Visible = false;
            uoi.btnAdd.Visible = true;
            uoi.lstQuantity.Enabled = true;
            uoi.rdoLarge.Enabled = true;
            uoi.rdoMedium.Enabled = true;
            uoi.rdoRegular.Enabled = true;
            uoi.cbMemberShip.Enabled = true;
        }

       private void msSearchOrder_Click(object sender, EventArgs e)
       {
            u2.Visible = false;
            uoi.Visible = true;
            pnl1.Controls.Add(uoi);
            uoi.txtOrderId.Enabled = true;
            uoi.cmbItemName.Enabled = false;
            uoi.btnSearch.Visible = true;
            uoi.btnAdd.Visible = false;
            uoi.lstQuantity.Enabled = false;
            uoi.rdoLarge.Enabled = false;
            uoi.rdoMedium.Enabled = false;
            uoi.rdoRegular.Enabled = false;
            uoi.cbMemberShip.Enabled = false;

        }
        private void msModifyOrdersList_Click(object sender, EventArgs e)
        {
            u2.Visible = false;
            uoi.Visible = true;
            pnl1.Controls.Add(uoi);
            uoi.txtOrderId.Enabled = false;
            uoi.cmbItemName.Enabled = true;
            uoi.btnSearch.Visible = true;
            uoi.btnAdd.Visible = false;
            uoi.lstQuantity.Enabled = true;
            uoi.rdoLarge.Enabled = true;
            uoi.rdoMedium.Enabled = true;
            uoi.rdoRegular.Enabled = true;
            uoi.cbMemberShip.Enabled = true;
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            pnl1.Controls.Add(u2);
            u2.Visible = true;
            uoi.Visible = false;
            u2.pnlMember.Visible = true;
            u2.pnlNotification.Visible = false;
        }

        private void newNotification_Click(object sender, EventArgs e)
        {
            pnl1.Controls.Add(u2);
            u2.Visible = true;
            uoi.Visible = false;
            u2.pnlMember.Visible = false;
            u2.pnlNotification.Visible = true;
        }

        private void allNotification_Click(object sender, EventArgs e)
        {
            pnl1.Controls.Add(u2);
            u2.Visible = true;
            uoi.Visible = false;
            u2.pnlMember.Visible = false;
            u2.pnlNotification.Visible = false;
            u2.addNotification_Click(0, e);// its a event call for show notification in gridview
        }

        private void accountInformat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is The employee form.\nEmployee can perform many roles..\nEmployee Name:________\nAddress:___________\nEmp ID:________");
        }

        private void aboutThisSyste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Coffee Managent System 1.00.\nDeveloped by Group27 .\nDeveloped in Visual Stadio.");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           //this.Close();
            login1.Visible = true;
        }
        private void EmpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("ccc");
            Application.Exit();
        }
    }
}
