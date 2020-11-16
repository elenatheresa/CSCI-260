using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Home : System.Web.UI.Page
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

        // customer logs  in
        protected void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = TextBoxUsername.Text;
                string password = TextBoxPassword.Text;
                string customerName = TextBoxCustomerName.Text;

                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sqlData = "select * from customers where username = '" + userName + "'";
                sqlData += " and password = '" + password + "' and name = '" + customerName + "'";
                OleDbCommand dbconn = new OleDbCommand(sqlData, conn);
                OleDbDataReader dataBaseReader = dbconn.ExecuteReader();

                // check for login
                if (dataBaseReader.Read())
                {
                    Session["cid"] = dataBaseReader["cid"].ToString();
                    LabelMsg.Text = "Welcome To Elena's Bookstore";

                }

                else
                {
                    LabelMsg.Text = "Are you new? Please Register";
                }

                conn.Close();


            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;

            }
        }

        // register a new customer
        protected void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to data base
                OleDbConnection conn = new OleDbConnection(connectionString);

                // get customer info
                string userName = TextBoxUsername.Text;
                string password = TextBoxPassword.Text;
                string customerName = TextBoxCustomerName.Text;

                // insert customer into data base
                OleDbCommand cmd = new OleDbCommand();
                string sqlData = "INSERT INTO Customers ([username], [password], [name]) values ";
                sqlData += "('" + userName + "','" + password + "','" + customerName + "')";
                cmd.CommandText = sqlData;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                // tell customer to login
                LabelMsg.Text = "You are now Registered, Please Continue by Clicking Login";
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}