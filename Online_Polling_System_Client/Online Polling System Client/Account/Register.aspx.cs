using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Online_Polling_System_Client.Account
{
    public partial class Register : System.Web.UI.Page
    {

        string liveelection;

        protected void Page_Load(object sender, EventArgs e)
        {
            getElectionDetails();
            MaintainScrollPositionOnPostBack = true;
            //Session["Username"] = null;
            //Session["Password"] = null;
            addYear();
            addFacultyInitials();
            addProgrammeSerialNo();
            addSerialNo();
            
        }

        public void addYear()
        {
            yearcombo.Items.Add("");
            string[] addyear = new string[]
            {
                "",
                "05",
                "06",
                "07",
                "08",
                "09",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15"
            };
            yearcombo.DataSource = addyear;
            yearcombo.DataBind();
        }

        public void addFacultyInitials()
        {
            string[] facultyinitials = new string[]
            {
                "",
                "N",
                "S",
                "H",
                "L"
            };
            facultyinitialcombo.DataSource = facultyinitials;
            facultyinitialcombo.DataBind();
        }

        public void addProgrammeSerialNo()
        {
            Programmeserialno.Items.Clear();
            Programmeserialno.Items.Add("");
            for (int i = 1; i <= 10; i++)
            {
                Programmeserialno.Items.Add("0" + i);
            }
        }

        public void addSerialNo()
        {
            serialnocombo.Items.Clear();
            serialnocombo.Items.Add("");
            for (double i = 1; i <= 70; i++)
            {
                if (i < 10)
                {
                    serialnocombo.Items.Add("00" + i);
                }
                else if (i > 10 && i < 100)
                {
                    serialnocombo.Items.Add("0" + i);
                }  
            }
        }

        public void getElectionDetails()
        {
            //Get Election Name and Duration
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=OnlinePollingSystem;Data Source=enunwah-pc\\sqlexpress;";
            sql = "select * from liveElection";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Session["electionname"] = reader["dbname"].ToString();
                    liveelection = reader["dbname"].ToString();
                    Session["startdate"] = reader["startdate"];
                    Session["finishdate"] = reader["finishdate"];


                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE= Javascript>alert('No Election has been set for this site + " + ex + "')</script>");
                Console.WriteLine(ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //public void verifyVotersTable()
        //{
        //    Response.Write("<script LANGUAGE=Javascript>alert('Registration for the " + Session["electionname"] + " Elections')</script>");
        //    string sql, connstring;
        //    connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";
        //    sql = "if not exists(select * from sys.tables where name = 'votersTable' ) create table votersTable(ID int NOT NULL IDENTITY(1,1), " +
        //        " Firstname Varchar(MAX) , " +
        //        " Middlename Varchar(MAX) , " +
        //        " Surname Varchar(MAX) , " +
        //        " MatricNo Varchar(10) NOT NULL, " +
        //        " Faculty Varchar(MAX) , " +
        //        " Department Varchar(MAX) , " +
        //        " Programme Varchar(MAX) , " +
        //        " Hostel Varchar(MAX) , " +
        //        " RoomNo Varchar(MAX) , " +
        //        " Password Varchar(MAX) NOT NULL, " +
        //        " SecurityQuestion1 Varchar(MAX) , " +
        //        " SecurityAnswer1 Varchar(MAX) , " +
        //        " SecurityQuestion2 Varchar(MAX) , " +
        //        " SecurityAnswer2 Varchar(MAX) , " +
        //        " ImageUrl Varchar(MAX) , " +
        //        " PRIMARY KEY (ID))";
        //    SqlConnection conn = new SqlConnection(connstring);
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    try
        //    {
        //        conn.Open();
        //        cmd.ExecuteNonQuery();    
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script LANGUAGE=Javascript>alert('We encountered an error while trying to register you, try again later " + ex + " ')</script>");
        //    }
        //    finally
        //    {
        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        //public void checkMatricNo()
        //{
        //    string sql, connstring2;
        //    connstring2 = "Data Source=enunwah-pc\\sqlexpress; Initial Catalog=" + Session["electionname"] + "; Integrated Security=SSPI;";
        //    sql = "select from votersTable where MatricNo = '" + MatricNoTbx.Text + "'";
        //    SqlConnection conn = new SqlConnection(connstring2);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataReader reader;
        //    conn.Open();
        //    reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        Response.Write("<script LANGUAGE=Javascript>alert('This user already exists')</script>");
        //        conn.Close();
        //    }

        //    while (!reader.Read())
        //    {
        //        addvoter();
        //    }

        //}

        //public void addvoter()
        //{
        //    string sql2, connstring2;
        //    connstring2 = "Data Source=enunwah-pc\\sqlexpress; Initial Catalog=" + Session["electionname"] + "; Integrated Security=SSPI;";
        //    //sql2 = "insert into votersTable (MatricNo,Password) values ('" + MatricNoTbx.Text + "','" + PasswordTbx.Text + "')";
        //    SqlConnection conn = new SqlConnection(connstring2);
        //    //SqlCommand cmd2 = new SqlCommand(sql2, conn);
        //    try
        //    {
        //        conn.Open();
        //        cmd2.ExecuteNonQuery();
        //        Response.Write("<script LANGUAGE=Javascript>alert('Username and Password Successfully Added')</script>");
        //        //Session["Username"] = MatricNoTbx.Text;
        //        Session["Password"] = PasswordTbx.Text;
        //        Response.Redirect("~/Account/Profile.aspx");
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script LANGUAGE=Javascript>alert('Registration Failed due to " + ex + "')</script>");
        //    }
        //}

        protected void Registerbtn_Click(object sender, EventArgs e)
        {
        //    Response.Write("<script LANGUAGE=Javascript>alert('Registration for the " + Session["electionname"] + " Elections')</script>");
        //    string sql, connstring;
        //    connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";
        //    sql = "if not exists(select * from sys.tables where name = 'votersTable' ) create table votersTable(ID int NOT NULL IDENTITY(1,1), " +
        //        " Firstname Varchar(MAX) , " +
        //        " Middlename Varchar(MAX) , " +
        //        " Surname Varchar(MAX) , " +
        //        " MatricNo Varchar(10) NOT NULL, " +
        //        " Faculty Varchar(MAX) , " +
        //        " Department Varchar(MAX) , " +
        //        " Programme Varchar(MAX) , " +
        //        " Hostel Varchar(MAX) , " +
        //        " RoomNo Varchar(MAX) , " +
        //        " Password Varchar(MAX) NOT NULL, " +
        //        " SecurityQuestion1 Varchar(MAX) , " +
        //        " SecurityAnswer1 Varchar(MAX) , " +
        //        " SecurityQuestion2 Varchar(MAX) , " +
        //        " SecurityAnswer2 Varchar(MAX) , " +
        //        " ImageUrl Varchar(MAX) , " +
        //        " PRIMARY KEY (ID))";
        //    SqlConnection conn = new SqlConnection(connstring);
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    try
        //    {
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script LANGUAGE=Javascript>alert('We encountered an error while trying to register you, try again later " + ex + " ')</script>");
        //    }
        //    finally
        //    {
        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }

        //    //Check Matric No
        //    string sql2, connstring2;
        //    connstring2 = "Data Source=enunwah-pc\\sqlexpress; Initial Catalog=" + Session["electionname"] + "; Integrated Security=SSPI;";
        //    //sql2 = "select from votersTable where MatricNo = '" + MatricNoTbx.Text + "'";
        //    SqlConnection conn2 = new SqlConnection(connstring2);
        //    //SqlCommand cmd2 = new SqlCommand(sql2, conn2);
        //    SqlDataReader reader;
        //    try
        //    {
        //        conn2.Open();
        //        //reader = cmd2.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Response.Write("<script LANGUAGE=Javascript>alert('This user already exists')</script>");
        //            conn2.Close();
        //            break;
        //        }
        //    }
        //    catch (Exception ex2)
        //    {
        //        Response.Write("<script LANGUAGE=Javascript>alert('"+e+"')</script>");
        //    }
        //    finally
        //    {
        //        if (conn2.State == System.Data.ConnectionState.Open)
        //        {
        //            conn2.Close();
        //        }
        //    }

        //    //Add Voter
        //    string sql3, connstring3;
        //    connstring3 = "Data Source=enunwah-pc\\sqlexpress; Initial Catalog=" + Session["electionname"] + "; Integrated Security=SSPI;";
        //    //sql3 = "insert into votersTable (MatricNo,Password) values ('" + MatricNoTbx.Text + "','" + PasswordTbx.Text + "')";
        //    SqlConnection conn3 = new SqlConnection(connstring3);
        //    SqlCommand cmd3 = new SqlCommand(sql3, conn3);
        //    try
        //    {
        //        conn3.Open();
        //        cmd3.ExecuteNonQuery();
        //        Response.Write("<script LANGUAGE=Javascript>alert('Username and Password Successfully Added')</script>");
        //        //Session["Username"] = MatricNoTbx.Text;
        //        Session["Password"] = PasswordTbx.Text;
        //        Response.Redirect("~/Account/Profile.aspx");
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script LANGUAGE=Javascript>alert('Registration Failed due to " + ex + "')</script>");
        //    }
        //    finally
        //    {
        //        if (conn3.State == System.Data.ConnectionState.Open)
        //        {
        //            conn3.Close();
        //        }
        //    }
        }

        protected void generatebtn_Click(object sender, EventArgs ev)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[12];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            PasswordLabel.Text = finalString;
        }
    }
}