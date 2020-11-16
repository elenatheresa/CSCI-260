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
    public partial class ShowSubjects : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;
        private string SID = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;
            SID = Request.QueryString["SID"];
        }

        public string getBooks()
        {
            try
            {
                string stringForHTML = null;

                if (SID != null && SID != null)
                {
                    stringForHTML = null;
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();

                    string sqlData = "SELECT distinct books.isbn, books.title, books.price, subjects.name";
                    sqlData += " FROM books,booksubject,subjects";
                    sqlData += " WHERE(((subjects.sid) = " + SID + ")and books.isbn = booksubject.isbn and subjects.sid = booksubject.sid)";

                    OleDbCommand dbconn = new OleDbCommand(sqlData, conn);
                    OleDbDataReader dataBaseReader = dbconn.ExecuteReader();

                    // for all subjects
                    while (dataBaseReader.Read())
                    {
                        string ISBN = dataBaseReader.GetString(0).ToString();
                        string bookTitle = dataBaseReader.GetString(1).ToString();
                        decimal bookPrice = dataBaseReader.GetDecimal(2);
                        string bookSubject = dataBaseReader.GetString(3);
                        stringForHTML += "<tr align='center'>";
                        stringForHTML += "<td>" + ISBN + "</td>";
                        stringForHTML += "<td>" + bookTitle + "</td>";
                        stringForHTML += "<td>" + bookPrice + "</td>";
                        stringForHTML += "<td>" + bookSubject + "</td></tr>";
                    }

                    conn.Close();
                }
                return stringForHTML;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
                return null;
            }
        }
    }
}