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
    public partial class EnterBooks : System.Web.UI.Page
    {
        private string dbpath = "";
        private string connectionString = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            dbpath = "U:\\WebApplication3\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + dbpath;

            if (!Page.IsPostBack)
            {

                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sql = "select * from subjects;";
                OleDbCommand dbc = new OleDbCommand(sql, conn);
                OleDbDataReader dr = dbc.ExecuteReader();

                DropDownListSubjects.DataSource = dr;
                DropDownListSubjects.DataTextField = "name";
                DropDownListSubjects.DataValueField = "sid";
                DropDownListSubjects.DataBind();
                dr.Close();
                conn.Close();

            }

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                // connect to data base
                OleDbConnection conn = new OleDbConnection(connectionString);

                // get book info
                string isbn = TextBoxISBN.Text;
                string title = TextBoxTitle.Text;
                decimal price = decimal.Parse(TextBoxPrice.Text);
                string subject = TextBoxSubject.Text;

                // insert book into data base
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "insert into books(ISBN,Title,Price)values('" + isbn + "','" + title + "'," + price + ")";
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
                cmd.CommandText = "insert into BookSubject(ISBN,Sid)values('" + isbn + "'," + sid + ")";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();

                // clear controls
                TextBoxISBN.Text = "";
                TextBoxTitle.Text = "";
                TextBoxPrice.Text = "";
                TextBoxSubject.Text = "";
                DropDownListSubjects.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            // clear controls
            TextBoxISBN.Text = "";
            TextBoxTitle.Text = "";
            TextBoxPrice.Text = "";
            TextBoxSubject.Text = "";
            DropDownListSubjects.SelectedIndex = -1;
        }

        protected void DropDownListSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get selected name
            string name = DropDownListSubjects.SelectedItem.ToString();

            // put in subjects text box
            TextBoxSubject.Text = name;
        }
    }
}