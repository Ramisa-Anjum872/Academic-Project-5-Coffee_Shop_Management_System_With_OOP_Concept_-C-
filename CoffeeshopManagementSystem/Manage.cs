using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeshopManagementSystem
{
    public partial class Manage : Form
    {
        private DataAccess Da { get; set; }
        public Manage()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ShowGridView();
        }
        public void ShowGridView(string sql = "select * from item;")
        {
            try
            {
                DataSet ds = Da.ExecuteQuery(sql);

                this.dgvIteam.AutoGenerateColumns = false;

                this.dgvIteam.DataSource = ds.Tables[0];
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error :" + exe.Message);
            }
        }

        private void btnIteamSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIteamId.Text) || String.IsNullOrEmpty(this.txtIteamName.Text) ||
                        String.IsNullOrEmpty(this.txtIteamPrice.Text))
                {
                    MessageBox.Show("Please fill all the information first");
                    return;

                }
                var sql = "select * from item where itemId = '" + this.txtIteamId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update
                    string query = "update item set itemName = '" + this.txtIteamName.Text + "', price = " +
                                   this.txtIteamPrice.Text + " where itemId = '" + this.txtIteamId.Text + "';";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Iteam information Updated Successfully.");
                        this.txtIteamId.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Iteam information Upgradation Failed.");
                    }

                }
                else
                {
                    string query = "insert into item values('" + this.txtIteamId.Text + "', '" + this.txtIteamName.Text + "', '" + this.txtIteamPrice.Text + "'); ";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1) // to let the user know that data is inserted to the rows
                    {
                        MessageBox.Show("Row Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Row Inserte Failed");
                    }
                }
                this.ShowGridView();

            }
            catch (Exception exe)
            {
                MessageBox.Show("Error :" + exe.Message);
            }
            this.ShowGridView();// save e press korle e jeno data ta row te show kore tai ei line.
        }

        private void btnSearchIteam_Click(object sender, EventArgs e)
        {
            string sql = "select * from item where itemName='" + this.txtSearchIteam.Text + "';";
            this.ShowGridView(sql);
        }

        private void btnShowIteam_Click(object sender, EventArgs e)
        {
            this.ShowGridView();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            try
            {
                var iteamID = this.dgvIteam.CurrentRow.Cells["itemId"].Value.ToString();
                var name = this.dgvIteam.CurrentRow.Cells["itemName"].Value.ToString();
                String sql = "delete from item where itemId='" + iteamID + "';";
                int count = this.Da.ExecuteDML(sql);
                if (count == 1)
                {
                    MessageBox.Show("Iteam has been deleted");
                }
                else
                {
                    MessageBox.Show("Data deletion failed");
                }
                this.ShowGridView();
            }


            catch (Exception exe)
            {
                MessageBox.Show("Error :" + exe.Message);
            }
        }

        private void dgvIteam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtIteamId.Text = this.dgvIteam.CurrentRow.Cells["itemId"].Value.ToString();
            this.txtIteamName.Text = this.dgvIteam.CurrentRow.Cells["itemName"].Value.ToString();
            this.txtIteamPrice.Text = this.dgvIteam.CurrentRow.Cells["price"].Value.ToString();


            this.txtIteamId.ReadOnly = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearALL();
        }
        private void ClearALL()
        {
            this.txtIteamId.Text = "";
            this.txtIteamName.Text = "";
            this.txtIteamPrice.Text = "";


            this.txtIteamId.ReadOnly = false;
        }

        private void musLogOut_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Visible = true;
            this.Visible = false;
        }

        private void Manage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
