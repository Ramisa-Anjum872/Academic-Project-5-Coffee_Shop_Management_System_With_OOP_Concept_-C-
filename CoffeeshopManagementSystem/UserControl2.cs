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
    public partial class UserControl2 : UserControl
    {
        SqlConnection sCon = new SqlConnection("Data Source=DESKTOP-P87KILQ;Initial Catalog=chashdb;Persist Security Info=True;User ID=sa;Password=munnasql");
        SqlCommand sCom;
        SqlDataAdapter sda;
        string sql = "select * from OrderInfo;";
        DataSet ds;
        int memberId = 10001;
        int notificationId = 1;
        double price = 0;
        EventArgs ee;
        public UserControl2()
        {
            InitializeComponent();
            sCon.Open();
        }
        private DataSet ExicuteQuary(string sql)
        {
            try
            {
                sCom = new SqlCommand(sql, sCon);
                sda = new SqlDataAdapter(sCom);
                ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return null;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select MAX(memberId) from MemberInfo;";
            ds = ExicuteQuary(sql);
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "") memberId = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;//Next id Should be
            MessageBox.Show(memberId.ToString());
            this.txtMemberId.Text = memberId.ToString();
            sql = "insert into MemberInfo values('" + memberId.ToString() + "','" + txtName.Text + "', '" + txtAddress.Text + "','" + txtPhoneNo.Text + "');";
            SqlCommand sCom2 = new SqlCommand(sql, sCon);
            int i = sCom2.ExecuteNonQuery();
            if (i > 0)
            {
                //MessageBox.Show("inserted..");
                sql = "select * from MemberInfo order by memberId desc;";
                ds = ExicuteQuary(sql);
                gridView2.DataSource = ds.Tables[0];
            }
        }

        internal void addNotification_Click(object sender, EventArgs e)
        {
            int lineNum=1;
            if (txtNotification.Text!="")
            {
                sql = "select MAX(notificationId) from NotificationInfo;";
                ds = ExicuteQuary(sql);
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "") notificationId = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
                this.txtMemberId.Text = notificationId.ToString();
                sql = "insert into NotificationInfo(notificationId,notification,date) values('" + notificationId.ToString() + "','" + txtNotification.Text + "','" + DateTime.Today.ToString() + "');";
                SqlCommand sCom2 = new SqlCommand(sql, sCon);
                lineNum = sCom2.ExecuteNonQuery();
            }
            if (lineNum > 0)
            {
                //MessageBox.Show("inserted..");
                sql = "select * from NotificationInfo order by notificationId desc;";
                ds = ExicuteQuary(sql);
                gridView2.DataSource = ds.Tables[0];
            }
        }
    }
}
