using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace CoffeeshopManagementSystem
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-P87KILQ;Initial Catalog=chashdb;Persist Security Info=True;User ID=sa;Password=munnasql");
            this.Sqlcon.Open(); //step 1 done 
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);// step 2
        }

        public DataSet ExecuteQuery(string sql)
        {
            //try
            //{
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
            //}
            //catch (Exception exc)
            //{
            //    return null;
            //}
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        public int ExecuteDML(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        public int ExecuteDMLImg(string sql, string imageLoc)
        {
            FileStream file = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(file);
            byte[] img = binaryReader.ReadBytes((int)file.Length);
            SqlCommand sqlCommand = new SqlCommand(sql, Sqlcon);
            sqlCommand.Parameters.Add(new SqlParameter("@image", img));
            int u = sqlCommand.ExecuteNonQuery();
            return u;
        }
    }
}

