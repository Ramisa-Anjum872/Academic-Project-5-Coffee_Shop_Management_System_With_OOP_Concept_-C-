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
    public partial class Login : Form
    {
        SqlConnection sCon = new SqlConnection("Data Source=DESKTOP-P87KILQ;Initial Catalog=chashdb;Persist Security Info=True;User ID=sa;Password=munnasql");
        SqlCommand sCom;
        SqlDataAdapter sda;
        string sql = "select * from OrderInfo;";
        
        DataSet ds;
        public Login()
        {
            InitializeComponent();
            sCon.Open();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from Login where userName='"+this.txtUserName.Text+"' and password='"+this.txtPassword.Text+"';";
            
            ds = ExicuteQuary(sql);
            if (ds.Tables[0].Rows.Count>0)
            {
                if(txtUserName.Text== "employee" && txtPassword.Text== "e123e")
                {
                    EmpForm e1 = new EmpForm(this);
                    e1.Visible = true;
                    this.Visible = false;
                    //this.Close();
                }
                else if(txtUserName.Text == "munna" && txtPassword.Text == "m123a")
                {
                    Manage ma = new Manage();
                    ma.Visible = true;
                    this.Visible = false;
                }
            }
            else
                MessageBox.Show("Information Missing!");
        }
    }
}
