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
    public partial class ShowSubjects : System.Web.UI.Page
    {
        private string dbpath = "";
        private string connectionString = "";
        private string sid = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            //dbpath = "c:\\260\\WebApplication3\\WebApplication3\\Access\\Bookstore.mdb";
            dbpath = "U:\\WebApplication3\\Access\\Bookstore.mdb";
            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + dbpath;
            sid = Request.QueryString["sid"];
        }

        public string getBooks()
        {
            try
            {
                string htmlStr = "";

                if (sid != null && sid != "")
                {
                    htmlStr = "";
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();

                    string sql = "SELECT distinct books.isbn,books.title,books.price,subjects.name";
                    sql += " FROM books,booksubject,subjects";
                    sql += " WHERE(((subjects.sid) = " + sid + ")and books.isbn = booksubject.isbn and subjects.sid = booksubject.sid)";

                    OleDbCommand dbc = new OleDbCommand(sql, conn);
                    OleDbDataReader dr = dbc.ExecuteReader();


                    while (dr.Read())
                    {
                        string isbn = dr.GetString(0).ToString();
                        string title = dr.GetString(1).ToString();
                        decimal price = dr.GetDecimal(2);
                        string subject = dr.GetString(3);
                        htmlStr += "<tr align='center'>";
                        htmlStr += "<td>" + isbn + "</td>";
                        htmlStr += "<td>" + title + "</td>";
                        htmlStr += "<td>" + price + "</td>";
                        htmlStr += "<td>" + subject + "</td></tr>";
                    }

                    conn.Close();
                }
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