using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class ShowShoppingCart : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;
        private string CID = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            // check for customer log in
            CID = (string)Session["CID"];

            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;

            if (CID == null)
            {
                LabelMsg.Text = "Please Login to Access Your Cart";
                return;
            }

            // check for submit button
            string submitToOrder = Request.Form["AddToOrder"];


            if (submitToOrder == "Add to Order")
            {
                try
                {
                    int bookQuantity = 0;
                    string sqlData = null;
                    string ISBN;

                    if (CID == null) CID = "1";

                    OleDbConnection conn = new OleDbConnection(connectionString);

                    foreach (String key in Request.Form)
                    {
                        if (key.StartsWith("z"))
                        {
                            ISBN = key.Substring(4);

                            string squantity = Request.Form[key];
                            bookQuantity = int.Parse(squantity);

                            if (bookQuantity > 0)
                            {
                                //quantity++;
                                sqlData = "update carts set quantity = " + bookQuantity + " where isbn = '" + ISBN + "' and cid = " + CID;

                                conn.Open();
                                OleDbCommand cmd = new OleDbCommand(sqlData, conn);
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                // write item to orders table


                                sqlData = "insert into orders  (isbn,cid,quantity)";
                                sqlData += " values ('" + ISBN + "'," + CID + "," + bookQuantity + ")";
                                conn.Open();
                                cmd = new OleDbCommand(sqlData, conn);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }

                            // else remove item from cart
                            else
                            {
                                string htmlStr = "";

                                htmlStr += "<tr align='center'><td><input type=checkbox name='chk" + ISBN + "," + CID + "'  /></td>";

                                sqlData = "delete from carts";
                                sqlData += " where isbn = '" + ISBN + "' and cid = " + CID;

                                conn.Open();
                                OleDbCommand cmd = new OleDbCommand(sqlData, conn);

                                cmd.ExecuteNonQuery();

                                conn.Close();
                            }

                        }
                    }


                    // go to view shopping cart
                    Response.Redirect("ShowOrders.aspx");
                }
                catch (Exception ex)
                {
                    LabelMsg.Text = ex.Message;

                }
            } // end if se
        }


        // return shopping cart for this customer
        public string getCartData()
        {
            try
            {
          
                if (CID == null)
                {
                    LabelMsg.Text = "Please Login to Access your Cart";
                    return null;
                }

                string stringForHTML = null;

                OleDbConnection conn = new OleDbConnection(connectionString);


                string sqlData = "SELECT Books.Title, Books.ISBN, Carts.Quantity, Carts.CID";
                sqlData += " FROM Books INNER JOIN Carts ON Books.ISBN = Carts.ISBN";
                sqlData += " WHERE(((Carts.CID) = " + CID + "));";

                //string sql = "SELECT * from shopping cart where cid = " + cid;

                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sqlData, conn);

                OleDbDataReader dataBaseReader = cmd.ExecuteReader();

                // foreach record
                while (dataBaseReader.Read())
                {
                    // get data
                    string bookTitle = dataBaseReader.GetString(0);
                    string ISBN = dataBaseReader.GetString(1);
                    int bookQuantity = dataBaseReader.GetInt32(2);



                    // show data
                    stringForHTML += "<tr align='center'>";
                    stringForHTML += "<td><a href='ShowBook.aspx?isbn=" + ISBN + "'>" + bookTitle + "</a></td>";
                    stringForHTML += "<td><input type=text name='quan" + ISBN + "' value = '" + bookQuantity + "'/></td>";
                    stringForHTML += "</tr>";
                }

                dataBaseReader.Close();
                conn.Close();

                //  add to cart button
                stringForHTML += "<tr><td colspan='3' align='center'>";

                stringForHTML += "<input name='AddtoOrder' type='submit' value='Add to Order' />";
                stringForHTML += "</td ></tr>";

                stringForHTML += "</table>";

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
