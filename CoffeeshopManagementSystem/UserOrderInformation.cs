using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CoffeeshopManagementSystem
{
    public partial class UserOrderInformation : UserControl
    {
        SqlConnection sCon = new SqlConnection("Data Source=DESKTOP-P87KILQ;Initial Catalog=chashdb;Persist Security Info=True;User ID=sa;Password=munnasql");
        SqlCommand sCom;
        SqlDataAdapter sda;
        string sql = "select * from OrderInfo;";
        DataSet ds;
        int index=101;
        double price = 0;
        string date="";
        EventArgs ee;
        public UserOrderInformation()
        {
            InitializeComponent();
            sql = "select MAX(orderId) from OrderInfo;";
            sCon.Open();
            ds = ExicuteQuary(sql);
            if (ds.Tables[0].Rows.Count>0 && ds.Tables[0].Rows[0][0].ToString() != "") index=Convert.ToInt32( ds.Tables[0].Rows[0][0])+1;
            this.txtOrderId.Text = index.ToString();
        }
        private DataSet ExicuteQuary(string sql)// Exicute Quary
        {
            try
            {
                sCom = new SqlCommand(sql, sCon);
                sda = new SqlDataAdapter(sCom);
                ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (date != "")// for update 
                {
                    //
                    //update orderInfo set itemId = '1', itemName = '2', price = '15', quantity = '2' where date = '01/05/2021  (03:00:25)';
                    sql = "update orderInfo set itemId='" + txtItemId.Text + "',itemName='" + cmbItemName.Text + "',price=" + Convert.ToDouble(txtPrice.Text) + ",quantity='" + lstQuantity.Text + "' where date='" + date + "';";
                    SqlCommand sCom2 = new SqlCommand(sql, sCon);
                    //MessageBox.Show("1");
                    int i = sCom2.ExecuteNonQuery();
                    //MessageBox.Show("1");
                    if (i > 0)
                    {
                        //MessageBox.Show("inserted..");
                        sql = "select * from OrderInfo where orderId='" + this.txtOrderId.Text + "' ;";
                        ds = ExicuteQuary(sql);
                        gridViewOrder.DataSource = ds.Tables[0];
                    }
                    date = "";
                }
                else if (txtItemId.Text != "" && cmbItemName.Text != "" && txtPrice.Text != "")// for add
                {
                    if (lstQuantity.Text == "") lstQuantity.Text = "1";
                     sql = "insert into orderInfo(orderId,itemId,itemName,price,quantity,date) values('" + index.ToString() + "','" + txtItemId.Text + "', '" + cmbItemName.Text + "','" + Convert.ToDouble(txtPrice.Text) + "','" + lstQuantity.Text + "', '" + /*date1.Text*/DateTime.Now.ToString() + "');";
                    SqlCommand sCom2 = new SqlCommand(sql, sCon);
                    int i = sCom2.ExecuteNonQuery();
                    if (i > 0)
                    {
                        //MessageBox.Show("inserted..");
                        sql = "select * from OrderInfo where orderId='" + this.txtOrderId.Text + "' ;";
                        ds = ExicuteQuary(sql);
                        gridViewOrder.DataSource = ds.Tables[0];
                    }
                }
                else
                    MessageBox.Show("Information Missing!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from item where itemName='" + this.cmbItemName.Text + "';";
                ds = ExicuteQuary(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtItemId.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtOrderId.Text = index.ToString();
                    price = Convert.ToDouble(ds.Tables[0].Rows[0][2]);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                // sum of all purches
                sql = "select SUM(price) from orderInfo where orderId='" + this.txtOrderId.Text + "';";
                ds = ExicuteQuary(sql);
                double total = Convert.ToDouble(ds.Tables[0].Rows[0][0]);

                // validation of membership
                sql = "select memberId from MemberInfo where memberId='" + this.txtMemberId.Text + "';";
                ds = ExicuteQuary(sql);
                if (cbMemberShip.Checked && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    this.txtTotal.Text = total - total * .15 + " Taka";
                }
                else
                {
                    this.cbMemberShip.Checked = false;
                    this.txtMemberId.Text = "";
                    this.txtTotal.Text = total + " Taka";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void lstQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtPrice.Text = Convert.ToString(price * Convert.ToDouble(this.lstQuantity.SelectedItem));
        }

        private void cbMemberShip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMemberShip.Checked)
            { 
                txtMemberId.Visible = true;
            }
            else
            {
                txtMemberId.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql = "select * from orderInfo where orderId ='" + this.txtOrderId.Text + "';";
            ds = ExicuteQuary(sql);
            gridViewOrder.DataSource = ds.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtTotal.Text = "";
            txtItemId.Text = "";
            txtMemberId.Text = "";
            cmbItemName.Text = "";
        }
        private void gridViewOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string oid = this.gridViewOrder.CurrentRow.Cells[0].Value.ToString();
            string iid = this.gridViewOrder.CurrentRow.Cells[1].Value.ToString();
            string iname = this.gridViewOrder.CurrentRow.Cells[2].Value.ToString();
            string iprice = this.gridViewOrder.CurrentRow.Cells[3].Value.ToString();
            date = this.gridViewOrder.CurrentRow.Cells[5].Value.ToString();
            txtPrice.Text = iprice;
            txtItemId.Text = iid;
            txtOrderId.Text = oid;
            cmbItemName.Text = iname;
        }
    }
}
