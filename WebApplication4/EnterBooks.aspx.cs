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
    public partial class EnterBooks : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;

            if (!Page.IsPostBack)
            {
                // pouplate combo box with subjects
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sqlData = "select * from subjects;";
                OleDbCommand dbconn = new OleDbCommand(sqlData, conn);
                OleDbDataReader dataBaseReader = dbconn.ExecuteReader();

                // fill cimbod box with subjects
                DropDownListSubjects.DataSource = dataBaseReader;
                DropDownListSubjects.DataTextField = "name";
                DropDownListSubjects.DataValueField = "sid";
                DropDownListSubjects.DataBind();
                dataBaseReader.Close();
                conn.Close();
            }

        }

        // add book button
        protected void AddBook_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to data base
                OleDbConnection conn = new OleDbConnection(connectionString);

                // get book info
                string ISBN = TextBoxISBN.Text;
                string title = TextBoxTitle.Text;
                decimal price = decimal.Parse(TextBoxPrice.Text);
                string subject = TextBoxSubject.Text;

                // insert book into data base
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "insert into books(ISBN,Title,Price)values('" + ISBN + "','" + title + "'," + price + ")";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                // get sid from subject table
                string sid = null;
                try
                {
                    cmd = new OleDbCommand();
                    cmd.CommandText = "select sid from subjects where name = '" + subject + "'";
                    cmd.Connection = conn;
                    conn.Open();
                    sid = cmd.ExecuteScalar().ToString();
                    conn.Close();
                }

                catch
                {
                    conn.Close();
                }

                // no sid
                if (sid == null)
                {
                    // add subject to data base
                    cmd = new OleDbCommand();
                    cmd.CommandText = "insert into subjects(Name)values('" + subject + "')";
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // get sid
                    cmd = new OleDbCommand();
                    cmd.CommandText = "select sid from subjects where name = '" + subject + "'";
                    cmd.Connection = conn;
                    conn.Open();
                    sid = cmd.ExecuteScalar().ToString();
                    conn.Close();
                }


                // insert isbn
                cmd = new OleDbCommand();
                cmd.CommandText = "insert into BookSubject(ISBN,Sid)values('" + ISBN + "'," + sid + ")";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();

                // clear controls
                TextBoxISBN.Text = null;
                TextBoxTitle.Text = null;
                TextBoxPrice.Text = null;
                TextBoxSubject.Text = null;
                DropDownListSubjects.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        // ckear text box
        protected void ClearText_Click(object sender, EventArgs e)
        {
            // clear controls
            TextBoxISBN.Text = null;
            TextBoxTitle.Text = null;
            TextBoxPrice.Text = null;
            TextBoxSubject.Text = null;
            DropDownListSubjects.SelectedIndex = -1;
        }

        // select subject
        protected void DropDownListSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get selected name
            string name = DropDownListSubjects.SelectedItem.ToString();

            // put in subjects text box
            TextBoxSubject.Text = name;
        }
    }
}