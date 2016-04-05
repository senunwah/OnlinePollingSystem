using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Polling_System_Administrator
{
    public partial class ManageCandidates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstname"] == null)
            {
                Session["ReturnUrl"] = "~/ManageCandidates.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }

            if (IsPostBack){

            }
            else
            {
                postCombo.Enabled = false;
                candidateCombo.Enabled = false;
                candidatenameTbx.Enabled = false;
                matricnoTbx.Enabled = false;
                facultyTbx.Enabled = false;
                departmentTbx.Enabled = false;
                programmeTbx.Enabled = false;
                cgpaTbx.Enabled = false;
                purposeTbx.Enabled = false;
                modifybtn.Enabled = false;
                clearbtn.Enabled = false;
                CandidateImage.Enabled = false;
                FileUpload.Enabled = false;
                addImagebtn.Enabled = false;
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
                        electionCombo.Items.Add(electiondb);

                        if (electiondb.ToString().Equals("master") ||
                            electiondb.ToString().Equals("tempdb") ||
                            electiondb.ToString().Equals("model") ||
                            electiondb.ToString().Equals("msdb") ||
                            electiondb.ToString().Equals("OnlinePollingSystem"))
                        {
                            electionCombo.Items.Remove("master");
                            electionCombo.Items.Remove("tempdb");
                            electionCombo.Items.Remove("model");
                            electionCombo.Items.Remove("msdb");
                            electionCombo.Items.Remove("OnlinePollingSystem");
                            

                        }

                    }
                }
                catch (Exception ex)
                {
                    badstatusLabel.Text = ex + ".......Contact System Administrator";
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            
        }

        protected void electionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            postCombo.Enabled = true;
            string sql, connstring, dbname;
            dbname = electionCombo.Text;
            sql = "select * from PostTable";
            connstring = "Integrated Security=SSPI;Initial Catalog="+dbname+";Data Source=enunwah-pc\\sqlexpress;";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                postCombo.Items.Add("");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tablename = reader["Name"].ToString(); 
                    postCombo.Items.Add(tablename);
                }
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void candidateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string sql, connstring, dbname, postname, candidatecomboname;
            dbname = electionCombo.Text;
            postname = postCombo.Text + "Table";
            candidatecomboname = candidateCombo.Text;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + dbname + ";Data Source=enunwah-pc\\sqlexpress;";
            sql = "select * from " + postname + " where Candidatename = '"+candidatecomboname+"' ";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["CandidateName"].ToString();
                    string matricno = reader["matricno"].ToString();
                    string faculty = reader["faculty"].ToString();
                    string department = reader["department"].ToString();
                    string programme = reader["programme"].ToString();
                    string cgpa = reader["cgpa"].ToString();
                    string purpose = reader["purpose"].ToString();
                    string imagepath = reader["purpose"].ToString();
                    candidatenameTbx.Enabled = true;
                    candidatenameTbx.Text = name;
                    matricnoTbx.Text = matricno;
                    facultyTbx.Enabled = true;
                    facultyTbx.Text = faculty;
                    departmentTbx.Enabled = true;
                    departmentTbx.Text = department;
                    programmeTbx.Enabled = true;
                    programmeTbx.Text = programme;
                    cgpaTbx.Text = cgpa;
                    purposeTbx.Enabled = true;
                    purposeTbx.Text = purpose;
                    modifybtn.Enabled = true;
                    clearbtn.Enabled = true;
                    CandidateImage.Enabled = true;
                    FileUpload.Enabled = true;
                    addImagebtn.Enabled = true;
                    CandidateImage.ImageUrl = imagepath;
                }
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void postCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            candidateCombo.Items.Add("--Select Candidate--");
            string sql, connstring, dbname, postname;
            dbname = electionCombo.Text;
            postname = postCombo.Text + "Table";
            connstring = "Integrated Security=SSPI;Initial Catalog=" + dbname + ";Data Source=enunwah-pc\\sqlexpress;";
            sql = "select * from " + postname + "";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                candidateCombo.Items.Add("");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["Candidatename"].ToString();
                    candidateCombo.Enabled = true;
                    candidateCombo.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void modifybtn_Click(object sender, EventArgs e)
        {
            string sql1, sql2, dbname, postname, connstring;
            dbname = electionCombo.Text;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + dbname + ";Data Source=enunwah-pc\\sqlexpress;";
            postname = postCombo.Text + "Table";
            string name = candidateCombo.Text;
            sql1 = "delete from "+postname+" where name = '"+name+"'";
            sql2 = "insert into "+postname+" (CandidateName,MatricNo,Faculty,Department,programme,cgpa,purpose,Image) values ('"+candidatenameTbx.Text+"','"+matricnoTbx.Text+"','"+facultyTbx.Text+"','"+departmentTbx.Text+"','"+programmeTbx.Text+"','"+cgpaTbx.Text+"','"+purposeTbx.Text+"','') ";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            try
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                goodstatusLabel.Text = "Candidate Details have been modified successfully";
                Response.Write("<script LANGUAGE= Javascript >alert('"+candidatenameTbx.Text+"'s details have been updated sucessfully')</script>");
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void clearbtn_Click(object sender, EventArgs e)
        {
            candidatenameTbx.Text = "";
            matricnoTbx.Text = "";
            facultyTbx.Text = "";
            departmentTbx.Text = "";
            programmeTbx.Text = "";
            cgpaTbx.Text = "";
            purposeTbx.Text = "";
            candidateCombo.AutoPostBack = true;
        }

        protected void addImagebtn_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string directorypath = Server.MapPath(string.Format("~/CandidateImages/" + electionCombo.Text + "/"));
                if (!Directory.Exists(directorypath))
                {
                    Directory.CreateDirectory(directorypath);
                    if (FileUpload.HasFile)
                    {
                        CandidateImage.ImageUrl = "~/Images/DefaultImage.png";
                        string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
                        FileUpload.PostedFile.SaveAs(Server.MapPath("~/CandidateImages/" + electionCombo.Text + "/" + candidatenameTbx.Text + ".jpg"));
                        CandidateImage.ImageUrl = "~/CandidateImages/" + electionCombo.Text + "/" + candidatenameTbx.Text + ".jpg";
                        goodstatusLabel.Text = "Image has been Added Succesfully";
                        badstatusLabel.Text = "The file you selected is " + filename + ", if not, reupload an image";
                        Response.Write("<script LANGUAGE= Javascript>alert('Image Added Succesfully')</script>");
                        candidatenameTbx.Enabled = false;
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE= Javascript>alert('No Image was Selected')</script>");
                        badstatusLabel.Text = "No Image Found";
                    }
                }
                else
                {
                    if (FileUpload.HasFile)
                    {
                        string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
                        FileUpload.PostedFile.SaveAs(Server.MapPath("~/CandidateImages/" + electionCombo.Text + "/" + candidatenameTbx.Text + ".jpg"));
                        CandidateImage.ImageUrl = "~/Images/DefaultImage.png";
                        CandidateImage.ImageUrl = "~/CandidateImages/" + electionCombo.Text + "/" + candidatenameTbx.Text + ".jpg";
                        goodstatusLabel.Text = "Image has been Added Succesfully";
                        badstatusLabel.Text = "The file you selected is " + filename + ", if not, reupload an image";
                        Response.Write("<script LANGUAGE= Javascript>alert('Image Added Succesfully')</script>");
                        candidatenameTbx.Enabled = false;
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE= Javascript>alert('No Image was Selected')</script>");
                        badstatusLabel.Text = "No Image Found";
                    }
                }
            }
            else
            {
                badstatusLabel.Text = "Image was not Added";
                Response.Write("<script LANGUAGE= Javascript>alert('Image Not Found')</script>");
            }
        }
    }
}