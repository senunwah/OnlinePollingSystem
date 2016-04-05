using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Polling_System_Administrator
{
    public partial class Manage_Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
            if (Session["firstname"] == null)
            {
                Session["ReturnUrl"] = "~/Manage_Post.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }

            if (IsPostBack)
            {
                modifycheckbox.Enabled = true;
            }
            else
            {
                modifycheckbox.Enabled = false;
                modifypost.Enabled = false;
                modifyPostBtn.Enabled = false;
                electiondropdown.Items.Add("");
                electionCombo.Items.Add("");
                string sqlQuery, connstring;
                string electiondb;
                connstring = "Integrated Security=SSPI;Initial Catalog=master;Data Source=enunwah-pc\\sqlexpress;";
                sqlQuery = "Select * from Sys.databases";
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader;
                try
                {

                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        electiondb = reader["name"].ToString();
                        electiondropdown.Items.Add(electiondb);
                        if (electiondb.ToString().Equals("master") ||
                            electiondb.ToString().Equals("tempdb") ||
                            electiondb.ToString().Equals("model") ||
                            electiondb.ToString().Equals("msdb") ||
                            electiondb.ToString().Equals("OnlinePollingSystem"))
                        {
                            electiondropdown.Items.Remove("master");
                            electiondropdown.Items.Remove("tempdb");
                            electiondropdown.Items.Remove("model");
                            electiondropdown.Items.Remove("msdb");
                            electiondropdown.Items.Remove("OnlinePollingSystem");

                        }
                        modifycheckbox.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    badstatusLabel.Text = ex + ".......Contact System Administrator";
                    Response.Write("<script Language=JAVASCRIPT>alert('Cannot Connect to Database')</script>");
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                addPosts();
                addCandidateNo();
                addMinimumlevel();
                addMinimumcgpa();
            }
        }

        public void addPosts()
        {
            //Add Election Posts
            electionPostNamecombo.Items.Add("");
            electionPostNamecombo.Items.Add("President");
            electionPostNamecombo.Items.Add("Vice_President");
            electionPostNamecombo.Items.Add("General_Secretary");
            electionPostNamecombo.Items.Add("Assistant_General_Secretary");
            electionPostNamecombo.Items.Add("Financial_Secretary");
            electionPostNamecombo.Items.Add("Treasurer");
            electionPostNamecombo.Items.Add("Academic_Officer");
            electionPostNamecombo.Items.Add("Sports_Officer");
            electionPostNamecombo.Items.Add("Welfare_Officer");
            electionPostNamecombo.Items.Add("Public_Relations_Officer");
            electionPostNamecombo.Items.Add("Social_Director");
            electionPostNamecombo.Items.Add("Hall_Rep_JAH");
            electionPostNamecombo.Items.Add("Hall_Rep_IB");
            electionPostNamecombo.Items.Add("Hall_Rep_LAG");
            electionPostNamecombo.Items.Add("Hall_Rep_DLW");
            electionPostNamecombo.Items.Add("Hall_Rep_UFH");
        }

        public void addCandidateNo()
        {
            //Add Candidate Number
            candidateNumbercombo.Items.Add("");
            for (int cn = 1; cn <= 5; cn++)
            {  
                candidateNumbercombo.Items.Add("" + cn);
            }
        }

        public void addMinimumlevel()
        {
            //add minimum level
            minimumlevelcombo.Items.Add("");
            minimumlevelcombo.Items.Add("100");
            minimumlevelcombo.Items.Add("200");
            minimumlevelcombo.Items.Add("300");
            minimumlevelcombo.Items.Add("400");
        }

        public void addMinimumcgpa()
        {
            //add minimum c.g.p.a
            minimumcgpacombo.Items.Add("");
            for (double cgpa = 0.0; cgpa <= 5.0; cgpa += 0.1)
            {     
                minimumcgpacombo.Items.Add("" + cgpa);
            }

        }

        protected void createPostBtn_Click(object sender, EventArgs e)
        {
            string sqlQuery, sqlQuery2, sqlQuery3, sqlQuery4, connstring;
            string electionname = electiondropdown.Text;
            string postname = electionPostNamecombo.SelectedItem.Text;
            string postlevel = minimumlevelcombo.SelectedItem.Text;
            
            connstring = "Integrated Security=SSPI;Initial Catalog="+electionname+";Data Source=enunwah-pc\\sqlexpress;";
            sqlQuery = "if not exists (select * from sys.tables where name = 'PostTable') create table PostTable (Name Varchar(MAX) NOT NULL, "+
                " CandidateNo Varchar(50) NOT NULL, " +
                " Minimumlevel Varchar(MAX) NOT NULL, "+
                " Minimumcgpa Varchar (50) NOT NULL, )";
            sqlQuery2 = "if not exists (select * from PostTable where name = '"+postname+"') insert into PostTable (Name,CandidateNo,Minimumlevel,Minimumcgpa) values ('"+postname+"','"+candidateNumbercombo.Text+"','"+postlevel+"','"+minimumcgpacombo.Text+"')";
            string PostCandidates =""+postname+"Table";
            sqlQuery3 = "if not exists (select * from sys.tables where name = '"+PostCandidates+"') create table "+PostCandidates+" (ID int NOT NULL IDENTITY(1,1), " + 
                " CandidateName Varchar(MAX) NOT NULL, " +
                " MatricNo Varchar(50) NOT NULL, " +
                " Faculty Varchar(50) NOT NULL, " +
                " Department Varchar(50) NOT NULL, " +
                " Programme Varchar(50) NOT NULL, " +
                " Level Varchar(50) NOT NULL, " + 
                " CGPA Varchar(50) NOT NULL, " +
                " Purpose Varchar(50) NOT NULL, " + 
                " ImagePath Varchar(MAX) NOT NULL, " +
                " PRIMARY KEY (ID))";
            string PostResult = ""+postname+"Result";
            sqlQuery4 = "if not exists (select * from sys.tables where name = '"+PostResult+"') create table "+PostResult+" (ID int NOT NULL IDENTITY(1,1), " + 
                " CandidateName Varchar(MAX) NOT NULL," +
                " MatricNo Varchar(50) NOT NULL," +
                " Post Varchar(50) NOT NULL," +
                " Votes Varchar(50) NOT NULL, " +
                " PRIMARY KEY (ID))";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            SqlCommand command2 = new SqlCommand(sqlQuery2, conn);
            SqlCommand command3 = new SqlCommand(sqlQuery3, conn);
            SqlCommand command4 = new SqlCommand(sqlQuery4, conn);
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                goodstatusLabel.Text = "Your New Post has been added Succesfully";
                Response.Write("<script LANGUAGE= Javascript >alert('Your post '"+postname+"' has been created Succesfully')</script>");
                
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE= Javascript >alert('Post creation Failed')</script>");
                badstatusLabel.Text = "Post Creation Failed || " + ex + ".....Contact System Administrator";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void deletedrpdownBtn_Click(object sender, EventArgs e)
        {
            string connstring, sql1, sql2, sql3;
            string dbname = electiondropdown.Text;
            string postname = electionCombo.Text;
            connstring = "Integrated Security=SSPI;Initial Catalog="+dbname+";Data Source=enunwah-pc\\sqlexpress;";
            sql1 = "delete from PostTable where Name = '"+postname+"'";
            string postnameTable = "" + postname + "Table";
            string postnameResult = "" + postname + "Result";
            sql2 = "drop table "+postnameTable+"";
            sql3 = "drop table "+postnameResult+"";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlCommand cmd3 = new SqlCommand(sql3, conn);

            try
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                goodstatusLabel.Text = "Post has been deleted Succesfully";
                Response.Write("<script LANGUAGE= Javascript >alert('" + electiondropdown.Text + "'s details have been updated sucessfully')</script>");
                electiondropdown.AutoPostBack = true;
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE= Javascript >alert('Election was not deleted Successfully')</script>");
                badstatusLabel.Text = ex + "......Contact System Administrator";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void modifycheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (modifycheckbox.Checked)
            {
                modifypost.Enabled = true;
                modifyPostBtn.Enabled = true;
                createPostBtn.Enabled = false;
            }
            else
            {
                modifypost.Enabled = false;
                modifyPostBtn.Enabled = false;
                createPostBtn.Enabled = true;
            }
        }

        protected void modifyPostBtn_Click(object sender, EventArgs e)
        {
            string dbname = electiondropdown.Text;
            string connstring = "Integrated Security=SSPI;Initial Catalog="+dbname+";Data Source=enunwah-pc\\sqlexpress;";
            string postname = modifypost.Text;
            string candidateno = candidateNumbercombo.Text;
            string minimumlevel = minimumlevelcombo.Text;
            string mininumcgpa = minimumcgpacombo.Text;
            string sql1 = "delete from PostTable where Name = '"+electionPostNamecombo.Text+"'";
            string sql2 = "insert into PostTable (Name, CandidateNo, Minimumlevel, Minimumcgpa) values ('"+postname+"','"+candidateno+"','"+minimumlevel+"','"+mininumcgpa+"') ";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);

            try
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                goodstatusLabel.Text = "Post Details have been modified Succesfully";
                electiondropdown.AutoPostBack = true;
                Response.Write("<script LANGUAGE= Javascript >alert('Your post " + postname + " has been updated sucessfully')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE= Javascript >alert(''"+postname+"' was not updated successfully')</script>");
                badstatusLabel.Text = ex + "";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        protected void electiondropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbname = electiondropdown.Text;
            string connstring2, sqlQuery2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + dbname + ";Data Source=enunwah-pc\\sqlexpress;";
            SqlConnection conn2 = new SqlConnection(connstring2);
            sqlQuery2 = "Select * from PostTable";
            SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn2);
            SqlDataReader reader;
            try
            {
                conn2.Open();
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    string postname = reader["Name"].ToString();
                    electionCombo.Items.Add(postname);
                    modifypost.Items.Add("");
                    modifypost.Items.Add(postname);
                }
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }
        }

        protected void modifypost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifycheckbox.Checked)
            {
                string modifytext = modifypost.Text;
                electionPostNamecombo.Text = modifytext;
            }
            else if (!modifycheckbox.Checked)
            {
                electionPostNamecombo.Text = "";
                candidateNumbercombo.Text = "";
                minimumlevelcombo.Text = "";
                minimumcgpacombo.Text = "";
            }
        }
    }
}