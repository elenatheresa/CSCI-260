using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace WebApplication3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private string dbpath = "";
        private string connectionString = "";
    

        protected void Page_Load(object sender, EventArgs e)
        {
            dbpath = "U:\\WebApplication3\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + dbpath;
        }

        protected void ButtonEnterBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("EnterBooks.aspx");
        }

        protected void ButtonListBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListBooks.aspx");
        }

        protected void ButtonListSubjects_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListSubjects.aspx");
        }

        protected void ClearDatabase_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);


                string sql = "delete * from booksubject";


                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                sql = "delete from Subjects";


                conn.Open();
                cmd = new OleDbCommand(sql, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                sql = "delete from Books";


                conn.Open();
                cmd = new OleDbCommand(sql, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}