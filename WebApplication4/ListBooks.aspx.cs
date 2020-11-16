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

    public partial class ListBooks : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;

            string submitPrices = Request.Form["SubmitPrices"];
        }

        // return book data
        public string getBookData()
        {
            try
            {
                string stringForHTML = null;
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sqlData = "select * from books;";
                OleDbCommand dbconn = new OleDbCommand(sqlData, conn);
                OleDbDataReader dataBaseReader = dbconn.ExecuteReader();

                // display book data
                while (dataBaseReader.Read())
                {
                    string ISBN = dataBaseReader.GetString(0).ToString();
                    string title = dataBaseReader.GetString(1).ToString();
                    decimal price = dataBaseReader.GetDecimal(2);
                    //htmlStr += "<tr align='center'><td><input type=checkbox name='chk' id='chk' /></td>";
                    stringForHTML += "<tr align='center'><td>" + ISBN + "</td><td><a href='ShowBook.aspx?isbn=" + ISBN + "'>" + title + "</a></td><td>";
                    stringForHTML += "<input type='text' name='price" + ISBN + "' value='" + price + "' size='5' /></td></tr>";
                }

                conn.Close();

                return stringForHTML;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
                return null;
            }
        }


        // return subject data
        public string getSubjectData()
        {
            try
            {
                string stringForHTML = null;
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sqlData = "select * from subjects;";
                OleDbCommand dbconn = new OleDbCommand(sqlData, conn);
                OleDbDataReader dataBaseReader = dbconn.ExecuteReader();

                // display subjects
                while (dataBaseReader.Read())
                {
                    string sid = dataBaseReader.GetInt32(0).ToString();
                    string name = dataBaseReader.GetString(1).ToString();

                    stringForHTML += "<tr align='center'>";
                    stringForHTML += "<td>" + sid + "</td><td><a href='ShowSubjects.aspx?sid=" + sid + "'>" + name + "</a></td><td></tr>";

                }

                conn.Close();

                return stringForHTML;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
                return null;
            }
        }

        // return customer data
        public string getCustomerData()
        {
            try
            {
                string stringForHTML = "";
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sqlData = "select * from customers;";
                OleDbCommand dbconn = new OleDbCommand(sqlData, conn);
                OleDbDataReader dataBaseReader = dbconn.ExecuteReader();

                // display orders
                while (dataBaseReader.Read())
                {
                    string cid = dataBaseReader.GetInt32(0).ToString();
                    string name = dataBaseReader.GetString(3).ToString();

                    stringForHTML += "<tr align='center'>";
                    stringForHTML += "<td>" + cid + "</td><td><a href='ShowOrders.aspx?cid=" + cid + "'>" + name + "</a></td><td></tr>";

                }

                conn.Close();

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