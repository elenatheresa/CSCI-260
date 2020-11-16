using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class ShowOrders : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;
        private string CID = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";


            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;

            // check for customer log in
            CID = (string)Session["cid"];

            if (CID == null)
            {
                CID = Request.QueryString["cid"];

                if (CID == null)
                {
                    LabelMsg.Text = "Please Login to Access your Orders";
                    return;
                }
            }

        }

        // return  order data for this customer
        public string getOrderData()
        {
            try
            {
                if (CID == null)
                {
                    LabelMsg.Text = "Please Login to Access your Orders";
                    return null;
 
                }

             
                string stringForHTML = "";

                System.Data.OleDb.OleDbConnection conn = new OleDbConnection(connectionString);

                string sqlData = "SELECT Books.Title, Books.ISBN, Orders.Quantity, Books.Price";
                sqlData += " FROM Books INNER JOIN Orders ON Books.ISBN = Orders.ISBN";
                sqlData += " WHERE(((Orders.cid) = " + CID + "));";

                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sqlData, conn);

                OleDbDataReader dataBaseReader = cmd.ExecuteReader();

                decimal total = 0;

                // foreach record
                while (dataBaseReader.Read())
                {
                    // get data
                    string title = dataBaseReader.GetString(0);
                    string isbn = dataBaseReader.GetString(1);
                    int quantity = dataBaseReader.GetInt32(2);
                    decimal price = dataBaseReader.GetDecimal(3);

                    // show data
                    stringForHTML += "<tr align='center'>";
                    stringForHTML += "<td><a href='ShowBook.aspx?isbn=" + isbn + "'>" + title + "</a></td>";
                    stringForHTML += "<td>" + quantity + "</td>";
                    stringForHTML += "<td>" + price.ToString("c2") + "</td>";
                    stringForHTML += "<td>" + (price*quantity).ToString("c2") + "</td>";
                    stringForHTML += "</tr>";

                    total += (price * quantity);
                }

                dataBaseReader.Close();
                conn.Close();

                //  add to cart button
                stringForHTML += "<tr align='center'>";
                stringForHTML += "<td></td><td></td>";
                stringForHTML += "<td>Total Order:</td><td>"+total.ToString("c2")+"</td>";
                stringForHTML += "</td></tr>";

                stringForHTML += "</table>";

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