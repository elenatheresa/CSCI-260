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

    public partial class ListBooks : System.Web.UI.Page
    {
        private string dbpath = "";
        private string connectionString = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //dbpath = "c:\\260\\WebApplication3\\WebApplication3\\Access\\Bookstore.mdb";
            dbpath = "U:\\WebApplication3\\Access\\Bookstore.mdb";
            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + dbpath;

            string submit = Request.Form["SubmitPrices"];

            try
            {
                if (submit == "Update Prices")
                {
                    foreach (String key in Request.Form)
                    {
                        if (key.StartsWith("price"))
                        {
                            string isbn = key.Substring(5);
                            string price = Request.Form[key];
                            OleDbConnection conn = new OleDbConnection(connectionString);
                            string sql = "UPDATE books SET price = " + price + " WHERE isbn = '" + isbn + "'";
                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        public string getBookData()
        {
            try
            {
                string htmlStr = "";
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sql = "select * from books;";
                OleDbCommand dbc = new OleDbCommand(sql, conn);
                OleDbDataReader dr = dbc.ExecuteReader();


                while (dr.Read())
                {
                    string isbn = dr.GetString(0).ToString();
                    string title = dr.GetString(1).ToString();
                    decimal price = dr.GetDecimal(2);
                    htmlStr += "<tr align='center'><td><input type=checkbox name='chk' id='chk' /></td>";
                    htmlStr += "<td>" + isbn + "</td><td><a href='ShowBook.aspx?isbn=" + isbn + "'>" + title + "</a></td><td>";
                    htmlStr += "<input type='text' name='price" + isbn + "' value='" + price + "' size='5' /></td></tr>";
                }

                conn.Close();

                return htmlStr;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
                return "";
            }
        }

    }
}