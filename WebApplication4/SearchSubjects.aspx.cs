using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class SearchSubjects : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;
        private string searchTerm = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;

            // check for customer log in
            string CID = (string)Session["cid"];

            if (CID == null)
            {
                LabelMsg.Text = "Please Login to Access your Cart";
                return;
            }


            // get search term
            searchTerm = Request.QueryString["searchterm"];

            // check for submit button
            string submitToCart = Request.Form["AddToCart"];


            if (submitToCart == "Add to Cart")
            {
                try
                {
                    int bookCount = 0;
                    int bookQuantity = 0;
                    string sqlData = null;
                    string line = null;
                    string ISBN;

                    foreach (String key in Request.Form)
                    {
                        if (key.StartsWith("z"))
                        {
                            bookCount++;

                            line = key.Substring(3);
                            ISBN = line;
                            CID = (string)Session["cid"];

                            if (CID == null) CID = "1";


                            // check for item ordered before
                            OleDbConnection conn = new OleDbConnection(connectionString);

                            sqlData = "select quantity from carts where isbn = '" + ISBN + "' and cid = " + CID;

                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand(sqlData, conn);
                            bookQuantity = 0;
                            Object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                bookQuantity = (int)result;
                            }
                            conn.Close();

                            // if item allready in data bsase then just update quantity
                            if (bookQuantity > 0)
                            {
                                //quantity++;
                                sqlData = "update carts set quantity = " + bookQuantity + " where isbn = '" + ISBN + "' and cid = " + CID;

                                conn.Open();
                                cmd = new OleDbCommand(sqlData, conn);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }

                            // else put new item in data base
                            else
                            {
                                bookQuantity = 1;

                                sqlData = "insert into carts  (isbn,cid,quantity)";
                                sqlData += " values ('" + ISBN + "'," + CID + "," + bookQuantity + ")";

                                conn.Open();
                                cmd = new OleDbCommand(sqlData, conn);

                                cmd.ExecuteNonQuery();

                                conn.Close();
                            }

                        }
                    }

                    if (bookCount == 0)
                        LabelMsg.Text = "Please Select Items to be Added to Cart";
                    else
                        // go to view shopping cart
                        Response.Redirect("ShowShoppingCart.aspx");
                }
                catch (Exception ex)
                {
                    LabelMsg.Text = ex.Message;

                }
            } // end if serach subjects
        }

        // return searched subjects from serach term
        public string getSearchData()
        {

            try
            {

                string stringForHTML = null;

                OleDbConnection conn = new OleDbConnection(connectionString);

                string sqlData = "SELECT books.title, books.isbn,count(subjects.sid) as matches";
                sqlData += " FROM(books INNER JOIN BookSubject ON books.ISBN = BookSubject.ISBN) ";
                sqlData += " INNER JOIN Subjects ON BookSubject.SID = Subjects.SID";
                sqlData += " WHERE(((Subjects.name) LIKE '%" + searchTerm + "%'))";
                sqlData += " group by subjects.sid,title,books.isbn";
                sqlData += "  order by count(subjects.sid) desc";

                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sqlData, conn);

                OleDbDataReader dataBaseReader = cmd.ExecuteReader();

                // foreach record
                while (dataBaseReader.Read())
                {
                    // get data
                    string title = dataBaseReader.GetString(0);
                    string ISBN = dataBaseReader.GetString(1);
                    int bookMatches = dataBaseReader.GetInt32(2);

                    // show data
                    stringForHTML += "<tr align='center'><td><input type=checkbox name='chk" + ISBN + "' /></td>";
                    stringForHTML += "<td><a href='ShowBook.aspx?isbn=" + ISBN + "'>" + title + "</a></td>";
                    stringForHTML += "<td>" + bookMatches + "</td>";
                    stringForHTML += "</tr>";
                }

                dataBaseReader.Close();
                conn.Close();

                //  add to cart button
                stringForHTML += "<td colspan='3' align='center'>";

                stringForHTML += "<input name='AddtoCart' type='submit' value='Add to Cart' />";
                stringForHTML += "</td >";


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