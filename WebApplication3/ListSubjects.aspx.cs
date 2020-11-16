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
    public partial class ListSubjects : System.Web.UI.Page
    {
        private string dbpath = "";
        private string connectionString = "";
        private String selectedSubjects = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            dbpath = "U:\\WebApplication3\\Access\\Bookstore.mdb";

            // ConnectionString.
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=" + dbpath;


            string submit = Request.Form["SearchSubjects"];

            try
            {

                if (submit == "Search Subjects")
                {
                    selectedSubjects = "";

                    foreach (String key in Request.Form)
                    {
                        if (key.StartsWith("chk"))
                        {

                            string line = key.Substring(3);
                            string[] fields = line.Split(',');
                            string sid = fields[0];
                            string name = fields[1];
                            OleDbConnection conn = new OleDbConnection(connectionString);


                            string sql = "SELECT books.title, BOOKSUBJECT.isbn";
                            sql += " FROM BOOKSUBJECT INNER JOIN books ON BOOKSUBJECT.isbn = books.isbn";
                            sql += " WHERE(((BOOKSUBJECT.sid) = " + sid + "))";

                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand(sql, conn);

                            OleDbDataReader dr = cmd.ExecuteReader();


                            while (dr.Read())
                            {
                                string title = dr.GetString(0);
                                string isbn = dr.GetString(1);

                                selectedSubjects += title + "," + sid + "," + isbn + "|";
                            }

                            dr.Close();
                            conn.Close();
                        }
                    }
                } // end if serach subjects

                // delete book
                else if (submit == "Delete Book")
                {
                    foreach (String key in Request.Form)
                    {
                        if (key.StartsWith("rad"))
                        {

                            string line = key.Substring(3);
                            string[] fields = line.Split(',');
                            string isbn = fields[0];
                            string sid = fields[1];
                            //string isbn = fields[2];

                            OleDbConnection conn = new OleDbConnection(connectionString);


                            string sql = "delete from books where isbn='" + isbn + "'";


                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand(sql, conn);

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            sql = "delete from BookSubject where isbn='" + isbn + "'";


                            conn.Open();
                            cmd = new OleDbCommand(sql, conn);

                            cmd.ExecuteNonQuery();

                            conn.Close();


                            // get sid count
                            sql = "SELECT Count(booksubject.sid) AS CountOfsid FROM booksubject";
                            sql += " WHERE(((booksubject.sid) = " + sid + "))";
                            conn.Open();
                            cmd = new OleDbCommand(sql, conn);
                            int numMatches = (int)cmd.ExecuteScalar();

                            conn.Close();

                            // delete subject if no matched
                            if (numMatches == 0)
                            {
                                sql = "delete from subjects where sid = " + sid;

                                conn.Open();
                                cmd = new OleDbCommand(sql, conn);
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

        public string getSubjectData()
        {
            try
            {
                string htmlStr = "";
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                string sql = "select * from subjects;";
                OleDbCommand dbc = new OleDbCommand(sql, conn);
                OleDbDataReader dr = dbc.ExecuteReader();


                while (dr.Read())
                {
                    int sid = dr.GetInt32(0);
                    string title = dr.GetString(1).ToString();

                    htmlStr += "<tr align='center'><td><input type=checkbox name='chk" + sid + "," + title + "'  /></td>";
                    htmlStr += "<td><a href='ShowSubjects.aspx?sid=" + sid + "'>" + title + "</a></td>";
                    htmlStr += "</tr>";
                }

                conn.Close();
                return htmlStr;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
                return "";
            }
        }


        public string getSearchedSubjects()
        {

            try
            {

                if (selectedSubjects == null || selectedSubjects == "") return "";

                string htmlStr = "";

                htmlStr += "<table width='60%' align='center' cellpadding = '2' cellspacing='2' border='0' bgcolor='white'>";
                htmlStr += "<tr align='center' style='background-color: white; color: black;' >";
                htmlStr += "<th>Select</th>";
                htmlStr += "<th>Title</th>";
                htmlStr += "<th>Matches</th>";

                htmlStr += "</tr>";

                String[] fields = selectedSubjects.Split('|');
                OleDbConnection conn = new OleDbConnection(connectionString);

                foreach (string item in fields)
                {
                    string[] tokens = item.Split(',');

                    if (tokens.Length == 3)
                    {

                        string title = tokens[0];
                        string sid = tokens[1];
                        string isbn = tokens[2];

                        string sql = "SELECT Count(booksubject.sid) AS CountOfsid FROM booksubject";
                        sql += " WHERE(((booksubject.sid) = " + sid + "))";
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand(sql, conn);
                        string numMatches = cmd.ExecuteScalar().ToString();

                        conn.Close();

                        htmlStr += "<tr align='center'><td><input type=radio name='rad" + isbn + "," + sid + "' /></td>";
                        htmlStr += "<td>" + title + "</a></td>";
                        htmlStr += "<td>" + numMatches + "</td>";
                        htmlStr += "</tr>";
                    }
                }

                // delete button
                htmlStr += "<td colspan='3' align='center'>";

                htmlStr += "<input name='SearchSubjects' type='submit' value='Delete Book' />";
                htmlStr += "</td >";

                htmlStr += "</table>";

                return htmlStr;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
                return "";
            }
        }

    }
}