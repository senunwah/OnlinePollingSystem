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
    public partial class NewCandidate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
            if (Session["firstname"] == null)
            {
                Session["ReturnUrl"] = "~/NewCandidate.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }

            if (IsPostBack)
            {
                postcombo.Enabled = true;

            }
            else
            {
                addYear();
                addFacultyInitials();
                addProgramCodes();
                addSerialNos();
                addFaculty();
                postcombo.Enabled = false;
                addlevel();
                addCgpa();
                electioncombo.Items.Add("");
                string connstring, sql;
                connstring = "Integrated Security=SSPI;Initial Catalog=master;Data Source=enunwah-pc\\sqlexpress;";
                sql = "Select * from Sys.databases";
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string electionname = reader["name"].ToString();
                        electioncombo.Items.Add(electionname);
                        if (electionname.ToString().Equals("master") ||
                            electionname.ToString().Equals("tempdb") ||
                            electionname.ToString().Equals("model") ||
                            electionname.ToString().Equals("msdb") ||
                            electionname.ToString().Equals("OnlinePollingSystem"))
                        {
                            electioncombo.Items.Remove("master");
                            electioncombo.Items.Remove("tempdb");
                            electioncombo.Items.Remove("model");
                            electioncombo.Items.Remove("msdb");
                            electioncombo.Items.Remove("OnlinePollingSystem");
                        }

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

        }

        public void addYear()
        {
            //Adding years of admission
            yearCombo.Items.Add("");
            for (int yc = 05; yc <= 15; yc++)
            {
                yearCombo.Items.Add("" + yc);
            }
        }

        public void addFacultyInitials()
        {
            //Adding faculty initials
            facultyinitialsCombo.Items.Add("");
            facultyinitialsCombo.Items.Add("N");
            facultyinitialsCombo.Items.Add("S");
            facultyinitialsCombo.Items.Add("H");
            facultyinitialsCombo.Items.Add("L");
        }

        public void addProgramCodes()
        {
            //Adding programme codes
            programmecodeCombo.Items.Add("");
            for (int pcc = 01; pcc <= 15; pcc++)
            {
                programmecodeCombo.Items.Add("" + pcc);
            }
        }

        public void addSerialNos()
        {
            //Adding Serial Nos
            serialnoCombo.Items.Add("");
            for (int snc = 001; snc <= 150; snc++)
            {
                serialnoCombo.Items.Add("" + snc);
            }
        }

        public void addFaculty()
        {
            //Adding Faculties
            string[] faculties = new string[]
            {
                "",
                "Natural Sciences",
                "Social and Management Sciences",
                "Humanities",
                "Law"
            };
            facultyCombo.Items.Add("");
            facultyCombo.DataSource = faculties;
            facultyCombo.DataBind();
        }

        public void addlevel()
        {
            levelDrp.Items.Add("");
            //Add levels
            levelDrp.Items.Add("100");
            levelDrp.Items.Add("200");
            levelDrp.Items.Add("300");
            levelDrp.Items.Add("400");
            levelDrp.Items.Add("500");

        }

        public void addCgpa()
        {
            for (double cgpa = 0.0; cgpa <= 5.0; cgpa += 0.1)
            {
                cgpaCombo.Items.Add("" + cgpa);
            }
        }

        public void addNaturalSciencesDepartment()
        {
            //Adding NASDepartments 
            string[] nasdepartments = new string[]
                {
                    "",
                    "Computer Sciences",
                    "Physics",
                    "Mathematics",
                    "Statistics",
                    "Chemical Sciences",
                    "Earth Sciences",
                    "Biological Sciences"
                };
            departmentCombo.DataSource = nasdepartments;
            departmentCombo.DataBind();
        }

        public void addsmsdepartments()
        {
            //Adding SMS Departments
            string[] smsdepartments = new string[]
            {
                //Adding Departments 
            
                    "",
                    "Mass Communication",
                    "Financial Accounting",
                    "Banking and Finance",
                    "Buisiness Administration",
                    "Economics"
            };
            departmentCombo.DataSource = smsdepartments;
            departmentCombo.DataBind();
        }

        public void addhumdepartments()
        {
            //Adding SMS Departments
            string[] humdepartments = new string[]
            {
                //Adding Departments 
            
                    "",
                    "English",
                    "C.R.S",
                    "History"
            };
            departmentCombo.DataSource = humdepartments;
            departmentCombo.DataBind();
        }

        public void addlawdepartments()
        {
            departmentCombo.Items.Add("");
            departmentCombo.Items.Add("Law");
        }

        public void addCSCProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Computer Science",
                "Computer Science(I.C.T Option)"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addPhyProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Physics with Electronics",
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addMthProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Mathematics"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addStatProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Statistics",
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addChmScProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Industrial Chemistry",
                "Bio-Chemistry",
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addEaScProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Geology"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addBioScProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "MicroBiology",
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addMasscmProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Mass Communication",
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addAcctProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Financial Accounting",
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addBafProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Banking and Finance",
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addBusadProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Buisiness Administration"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addEconsProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Economics"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addEngProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "English"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addCRSProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "C.R.S"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addHistoryProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "History"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        public void addLawProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Law"
            };
            programmeCombo.DataSource = programmes;
            programmeCombo.DataBind();
        }

        protected void electioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            postcombo.Enabled = true;
            postcombo.Items.Clear();
            postcombo.Items.Add("");
            string sql, connstring, dbname;
            dbname = electioncombo.Text;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + dbname + ";Data Source=enunwah-pc\\sqlexpress;";
            sql = "select * from PostTable";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string postname = reader["name"].ToString();
                    postcombo.Items.Add(postname);
                }
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
            }
        }

        protected void addImagebtn_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string directorypath = Server.MapPath(string.Format("~/CandidateImages/" + electioncombo.Text + "/"));
                if (!Directory.Exists(directorypath))
                {
                    Directory.CreateDirectory(directorypath);
                    if (FileUpload.HasFile)
                    {
                        CandidateImage.ImageUrl = "~/Images/DefaultImage.png";
                        string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
                        FileUpload.PostedFile.SaveAs(Server.MapPath("~/CandidateImages/" + electioncombo.Text + "/" + nameTbx.Text + ".jpg"));
                        CandidateImage.ImageUrl = "~/CandidateImages/" + electioncombo.Text + "/" + nameTbx.Text + ".jpg";
                        goodstatusLabel.Text = "Image has been Added Succesfully";
                        badstatusLabel.Text = "The file you selected is " + filename + ", if not, reupload an image";
                        Response.Write("<script LANGUAGE= Javascript>alert('Image Added Succesfully')</script>");
                        nameTbx.Enabled = false;
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
                        FileUpload.PostedFile.SaveAs(Server.MapPath("~/CandidateImages/" + electioncombo.Text + "/" + nameTbx.Text + ".jpg"));
                        CandidateImage.ImageUrl = "~/Images/DefaultImage.png";
                        CandidateImage.ImageUrl = "~/CandidateImages/" + electioncombo.Text + "/" + nameTbx.Text + ".jpg";
                        goodstatusLabel.Text = "Image has been Added Succesfully";
                        badstatusLabel.Text = "The file you selected is " + filename + ", if not, reupload an image";
                        Response.Write("<script LANGUAGE= Javascript>alert('Image Added Succesfully')</script>");
                        nameTbx.Enabled = false;
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

        protected void facultyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (facultyCombo.SelectedItem.Text == "")
            {
                departmentCombo.Items.Clear();
                departmentCombo.Items.Add("");
            }
            else if (facultyCombo.SelectedItem.Text == "Natural Sciences")
            {
                departmentCombo.Items.Clear();
                addNaturalSciencesDepartment();
            }
            else if (facultyCombo.SelectedItem.Text == "Social and Management Sciences")
            {
                departmentCombo.Items.Clear();
                addsmsdepartments();
            }
            else if (facultyCombo.SelectedItem.Text == "Humanities")
            {
                departmentCombo.Items.Clear();
                addhumdepartments();
            }
            else if (facultyCombo.SelectedItem.Text == "Law")
            {
                departmentCombo.Items.Clear();
                addlawdepartments();
            }
        }

        protected void departmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentCombo.SelectedItem.Text == "")
            {
                programmeCombo.Items.Clear();
                programmeCombo.Items.Add("");
            }
            else if (departmentCombo.SelectedItem.Text == "Computer Sciences")
            {
                programmeCombo.Items.Clear();
                addCSCProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Physics")
            {
                programmeCombo.Items.Clear();
                addPhyProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Mathematics")
            {
                programmeCombo.Items.Clear();
                addMthProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Statistics")
            {
                programmeCombo.Items.Clear();
                addStatProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Chemical Sciences")
            {
                programmeCombo.Items.Clear();
                addChmScProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Biological Sciences")
            {
                programmeCombo.Items.Clear();
                addBioScProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Earth Sciences")
            {
                programmeCombo.Items.Clear();
                addEaScProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Mass Communication")
            {
                programmeCombo.Items.Clear();
                addMasscmProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Financial Accounting")
            {
                programmeCombo.Items.Clear();
                addAcctProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Banking and Finance")
            {
                programmeCombo.Items.Clear();
                addBafProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Buisiness Administration")
            {
                programmeCombo.Items.Clear();
                addBusadProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Economics")
            {
                programmeCombo.Items.Clear();
                addEconsProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "English")
            {
                programmeCombo.Items.Clear();
                addEngProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "C.R.S")
            {
                programmeCombo.Items.Clear();
                addCRSProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "History")
            {
                programmeCombo.Items.Clear();
                addHistoryProgrammes();
            }
            else if (departmentCombo.SelectedItem.Text == "Law")
            {
                programmeCombo.Items.Clear();
                addLawProgrammes();
            }
            else
            {
                programmeCombo.Items.Clear();
            }
        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            string sql, sql2, sql3, postresult, connstring, dbname, post;
            dbname = electioncombo.Text;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + dbname + ";Data Source=enunwah-pc\\sqlexpress;";
            string name, matricno;
            name = nameTbx.Text;
            post = postcombo.Text + "Table";
            postresult = postcombo.Text + "Result";
            string yad, fai, pnc, srn;
            yad = yearCombo.Text;
            fai = facultyinitialsCombo.Text;
            int i = Convert.ToInt32(programmecodeCombo.Text);
            if (i < 10)
            {
                pnc = "0" + programmecodeCombo.Text;
            }
            else
            {
                pnc = programmecodeCombo.Text;
            }

            int x = Convert.ToInt32(serialnoCombo.Text);
            if (x < 10)
            {
                srn = "00" + serialnoCombo.Text;
            }
            else if (x < 100 && x > 9)
            {
                srn = "0" + serialnoCombo.Text;
            }
            else
            {
                srn = serialnoCombo.Text;
            }
            matricno = yad + fai + pnc + "/" + srn;
            
            string imagepath = "~/CandidateImages/" + electioncombo.Text + "/" + nameTbx.Text + ".jpg";
            sql = "if not exists(select * from " + post + " where CandidateName = '" + name + "') insert into " + post + " (CandidateName,Matricno,Faculty,Department,Programme,Level,CGPA,Purpose,ImagePath) values ('" + nameTbx.Text + "','" + matricno + "','" + facultyCombo.Text + "','" + departmentCombo.Text + "','" + programmeCombo.Text + "','" + levelDrp.Text + "','" + cgpaCombo.Text + "','" + purposeTbx.Text + "','"+imagepath+"')";
            sql2 = "if not exists(select * from "+postresult+" where CandidateName = '"+name+"') insert into "+postresult+" (CandidateName, Matricno,Post,Votes) values('"+nameTbx.Text+"','"+matricno+"','"+postcombo.Text+"','')";
            sql3 = "select * from PostTable where Name = '" + postcombo.Text + " '";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            string countsql = "select count(*) from dbo." + post + "";
            SqlCommand cmd4 = new SqlCommand(countsql, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd3.ExecuteReader();
                while (reader.Read())
                {
                    string rName = reader["Name"].ToString();
                    int rCandidateNo = Convert.ToInt32(reader["CandidateNo"]);
                    int rMinimumlevel = Convert.ToInt32(reader["Minimumlevel"]);
                    double rMinimumcgpa = Convert.ToDouble(reader["Minimumcgpa"]);
                    double cgpa = Convert.ToDouble(cgpaCombo.Text);
                    int level = Convert.ToInt32(levelDrp.Text);
                   
                    
                    if ((cgpa > rMinimumcgpa) || (cgpa == rMinimumcgpa) && ((level == rMinimumlevel)))
                    {
                        Response.Write("<script LANGUAGE= Javascript>alert('This data meets the requirements for this post')</script>");
                    } 
                    else
                    {
                        Response.Write("<script LANGUAGE= Javascript>alert('You do not meet the minimum requirements for this post')</script>");
                        badstatusLabel.Text = "You do not meet the minimum requirements for this post";
                        break;
                    }
                    reader.Close();
                    int count;
                    count = (int)cmd4.ExecuteScalar();
                    Convert.ToInt32(count);
                    if ((count < 5))
                    {
                        reader.Close();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        nameTbx.Enabled = true;
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE= Javascript >alert('The Slots for this post are already full')</script>");
                        badstatusLabel.Text = "The Slots for this post are already full";
                        goodstatusLabel.Text = "";
                        Response.Write("<script LANGUAGE= Javascript >alert('You can no longer apply for this post')</script>");
                        break;
                    }
                    reader.Close();
                    Response.Write("<script LANGUAGE= Javascript>alert('Candidate has been added successfully')</script>");
                    goodstatusLabel.Text = "Candidate has been added Succesfully";
                }
                
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
                Response.Write("<script LANGUAGE= Javascript>alert('Candidate creation failed')</script>");
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
}