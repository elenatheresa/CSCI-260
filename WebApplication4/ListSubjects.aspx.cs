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
    public partial class ListSubjects : System.Web.UI.Page
    {
        private string databasepath = null;
        private string connectionString = null;
        private String selectedSubjects = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            databasepath = "E:\\WebApplication4\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + databasepath;

            string submitSubjects = Request.Form["SearchSubjects"];

            try
            {
                if (submitSubjects == "Search Subjects")
                {
                    selectedSubjects = null;

                    foreach (String key in Request.Form)
                    {
                        if (key.StartsWith("chk"))
                        {

                            string line = key.Substring(3);
                            string[] fields = line.Split(',');
                            string SID = fields[0];
                            string bookName = fields[1];
                            OleDbConnection conn = new OleDbConnection(connectionString);

                            string sqlData = "SELECT books.title, BOOKSUBJECT.isbn";
                            sqlData += " FROM BOOKSUBJECT INNER JOIN books ON BOOKSUBJECT.isbn = books.isbn";
                            sqlData += " WHERE(((BOOKSUBJECT.sid) = " + SID + "))";

                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand(sqlData, conn);

                            OleDbDataReader dataBaseReader = cmd.ExecuteReader();

                            // get a list of selected subjects
                            while (dataBaseReader.Read())
                            {
                                string bookTitle = dataBaseReader.GetString(0);
                                string ISBN = dataBaseReader.GetString(1);

                                selectedSubjects += bookTitle + "," + SID + "," + ISBN + "|";
                            }

                            dataBaseReader.Close();
                            conn.Close();
                        }
                    }
                } 

                else if (submitSubjects == "Delete Book")
                {
                    foreach (String key in Request.Form)
                    {
                        if (key.StartsWith("rad"))
                        {

                            string line = key.Substring(3);
                            string[] fields = line.Split(',');
                            string ISBN = fields[0];
                            string SID = fields[1];


                            OleDbConnection conn = new OleDbConnection(connectionString);


                            string sqlData = "delete from books where isbn='" + ISBN + "'";


                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand(sqlData, conn);

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            sqlData = "delete from BookSubject where isbn='" + ISBN + "'";

                            conn.Open();
                            cmd = new OleDbCommand(sqlData, conn);

                            cmd.ExecuteNonQuery();

                            conn.Close();


                            // get sid count
                            sqlData = "SELECT Count(booksubject.sid) AS CountOfsid FROM booksubject";
                            sqlData += " WHERE(((booksubject.sid) = " + SID + "))";
                            conn.Open();
                            cmd = new OleDbCommand(sqlData, conn);
                            int bookMatches = (int)cmd.ExecuteScalar();

                            conn.Close();

                            // delete subject if no matched
                            if (bookMatches == 0)
                            {
                                sqlData = "delete from subjects where sid = " + SID;

                                conn.Open();
                                cmd = new OleDbCommand(sqlData, conn);
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
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

                // for all subjects
                while (dataBaseReader.Read())
                {
                    int SID = dataBaseReader.GetInt32(0);
                    string bookTitle = dataBaseReader.GetString(1).ToString();

                    stringForHTML += "<tr align='center'><td><input type=checkbox name='chk" + SID + "," + bookTitle + "'  /></td>";
                    stringForHTML += "<td><a href='ShowSubjects.aspx?sid=" + SID + "'>" + bookTitle + "</a></td>";
                    stringForHTML += "</tr>";
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

        // return searched subjects
        public string getSearchedSubjects()
        {

            try
            {

                if (selectedSubjects == null || selectedSubjects == null) return null;

                string stringForHTML = null;

                stringForHTML += "<table width='40%' align='center' cellpadding = '5' cellspacing='5'bgcolor='deeppink'>";
                stringForHTML += "<tr align='center' style='background-color: white; color: deeppink;' >";
                stringForHTML += "<th>Title</th>";
                stringForHTML += "<th>Matches</th>";

                stringForHTML += "</tr>";

                String[] fields = selectedSubjects.Split('|');
                OleDbConnection conn = new OleDbConnection(connectionString);

                // display subjects to delete
                foreach (string item in fields)
                {
                    string[] tokens = item.Split(',');

                    if (tokens.Length == 3)
                    {

                        string bookTitle = tokens[0];
                        string SID = tokens[1];
                        string ISBN = tokens[2];

                        string sqlData = "SELECT Count(booksubject.sid) AS CountOfsid FROM booksubject";
                        sqlData += " WHERE(((booksubject.sid) = " + SID + "))";
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand(sqlData, conn);
                        string bookMatches = cmd.ExecuteScalar().ToString();

                        conn.Close();

                        stringForHTML += "<td>" + bookTitle + "</a></td>";
                        stringForHTML += "<td>" + bookMatches + "</td>";
                        stringForHTML += "</tr>";
                    }
                }

                // delete button
                stringForHTML += "<td colspan='3' align='center'>";

                stringForHTML += "</td >";

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