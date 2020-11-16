using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace WebApplication4
{
    public partial class ShowBook : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;
        private string ISBN = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;
            ISBN = Request.QueryString["isbn"];

           
        }

        // return book data
        public string getBook()
        {
            string stringForHTML = null;

            try
            {

                if (ISBN != null && ISBN != null)
                {
                    stringForHTML = null;
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();

                    string sqlData = "SELECT distinct books.isbn,books.title,books.price,subjects.name";
                    sqlData += " FROM books,booksubject,subjects";
                    sqlData += " WHERE(((books.isbn) = '" + ISBN + "')and books.isbn = booksubject.isbn and subjects.sid = booksubject.sid)";

                    OleDbCommand dbconn = new OleDbCommand(sqlData, conn);
                    OleDbDataReader dataBaseReader = dbconn.ExecuteReader();

                    // for all books
                    while (dataBaseReader.Read())
                    {
                        string isbn = dataBaseReader.GetString(0).ToString();
                        string title = dataBaseReader.GetString(1).ToString();
                        decimal price = dataBaseReader.GetDecimal(2);
                        string subject = dataBaseReader.GetString(3);
                        stringForHTML += "<tr align='center'>";
                        stringForHTML += "<td>" + isbn + "</td>";
                        stringForHTML += "<td>" + title + "</td>";
                        stringForHTML += "<td>" + price + "</td>";
                        stringForHTML += "<td>" + subject + "</td></tr>";
                    }

                    conn.Close();
                }
                return stringForHTML;
            }
            catch (Exception abc)
            {
                LabelMsg.Text = abc.Message;
                return null;
            }
        }
    }

}
