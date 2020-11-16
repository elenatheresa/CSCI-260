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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private string databasepath = "";
        private string connectionString = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";


            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;
        }

        protected void enterBooksButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("EnterBooks.aspx");
        }

        protected void listAllButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListBooks.aspx");
        }

        protected void listSubjectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListSubjects.aspx");
        }

        protected void clearDataBaseButton_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();

                // delete orders
                string sqlData = "delete from [orders]";
                OleDbCommand cmd = new OleDbCommand(sqlData, conn);

                cmd.ExecuteNonQuery();
                conn.Close();

                // delete cart
                sqlData = "delete * from carts";

                conn.Open();
                cmd = new OleDbCommand(sqlData, conn);

                cmd.ExecuteNonQuery();

                conn.Close();


                // delete customers
                sqlData = "delete * from customers";

                conn.Open();
                cmd = new OleDbCommand(sqlData, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                // delete book subject
                sqlData = "delete * from booksubject";


                conn.Open();
                cmd = new OleDbCommand(sqlData, conn);

                cmd.ExecuteNonQuery();

                conn.Close();


                // delete subjects
                sqlData = "delete from Subjects";


                conn.Open();
                cmd = new OleDbCommand(sqlData, conn);

                cmd.ExecuteNonQuery();

                conn.Close();


                // delete books
                sqlData = "delete from Books";


                conn.Open();
                cmd = new OleDbCommand(sqlData, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["cid"] = null;
            Response.Redirect("home.aspx");
        }

        protected void shoppingCartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowShoppingCart.aspx");
        }

        protected void showOrderButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowOrders.aspx");
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void searchSubjectButton_Click(object sender, EventArgs e)
        {
            string searchterm = TextBoxSearchTerm.Text;
            Response.Redirect("SearchSubjects.aspx?searchterm=" + searchterm);
        }
    }
}