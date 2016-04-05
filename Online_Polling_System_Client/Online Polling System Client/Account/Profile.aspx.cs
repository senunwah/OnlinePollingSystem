using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Online_Polling_System_Client.Models;
using Online_Polling_System_Client;
using System.Data.SqlClient;
using System.IO;

namespace Online_Polling_System_Client.Account
{
    public partial class Profile : Page
    {
        public string securityQuestion1, securityAnswer1;
        public string securityQuestion2, securityAnswer2;
        public string liveelection;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
            
            if (IsPostBack)
            {
                
                if (pq1.Checked)
                {
                    alternatequestiontbx1.Visible = true;
                    sq1combo.Enabled = false;
                    securityQuestion1 = alternatequestiontbx1.Text;
                    securityAnswer1 = sq1Tbx.Text;
                }
                else if (!pq1.Checked)
                {
                    alternatequestiontbx1.Visible = false;
                    sq1combo.Enabled = true;
                    securityQuestion1 = sq1combo.Text;
                    securityAnswer1 = sq1Tbx.Text;
                }

                if (pq2.Checked)
                {
                    alternatequestiontbx2.Visible = true;
                    sq2combo.Enabled = false;
                    securityQuestion2 = alternatequestiontbx2.Text;
                    securityAnswer2 = sq2Tbx.Text;
                }
                else if (!pq2.Checked)
                {
                    alternatequestiontbx2.Visible = false;
                    sq2combo.Enabled = true;
                    securityQuestion2 = sq2combo.Text;
                    securityAnswer2 = sq2Tbx.Text;
                }
            } 
            else if (!IsPostBack)
            {
                addFaculty();
                addHostel();
                addSecurityQuestions();
                getElectionDetails();
                Response.Write("<script LANGUAGE=Javascript>alert('Registration for the " + Session["electionname"] + " Elections, your username is " + Session["Username"] + " and your password is " + Session["Password"] + "')</script>");
                getvoterdata();
                MatricNoTbx.Enabled = false;
                Password.Enabled = false;
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

        public void getvoterdata()
        {
            string sql, connstring;
            connstring = "Data Source=enunwah-pc\\sqlexpress; Initial Catalog=" + Session["electionname"] + "; Integrated Security=SSPI;";
            sql = "select from votersTable where username = '" + Session["Username"] + "' and Password = '" + Session["Password"] + "'";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Session["Username"] = reader["MatricNo"].ToString();
                    Session["Password"] = reader["Password"].ToString();
                    Response.Write("<script LANGUAGE=Javascript>alert('Your username is your " + Session["Username"] + " and your Password is " + Session["Password"] + "')</script>");
                    MatricNoTbx.Text = Session["Username"].ToString();
                    Password.Text = Session["Password"].ToString();
                    MatricNoTbx.Enabled = false;
                    Password.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE=Javascript>alert('Failure to retrieve Pre-registered information due to " + ex + "')</script>");
            }
        }
        public void addSecurityQuestions()
        {
            
            string[] SecurityQuestions = new string[]
            {
                "",
                "What is your Mother's maiden name?",
                "Who is your oldest sibling?",
                "What is your oldest sibling's birthday month & year?",
                "What is your pet's name?",
                "Who was your childhood role model?",
                "What is the name of your primary school?",
                "What is your favourite teacher's pet name?",
                "What is the name of your hometown?",
                "What is your favourite color?",
                "What is your bbm pin?",
                "What was your dream job as a child?",
                "What is the first name of the boy or girl you first kissed?",
                "Where do you want to retire?",
                "What is your driver's license number?",
                "What is your car registration number?",
                "What was the make of your first car?",
                "What month & year were you born?"
            };
            sq1combo.DataSource = SecurityQuestions;
            sq1combo.DataBind();
            sq2combo.DataSource = SecurityQuestions;
            sq2combo.DataBind();
        }

        public void addHostel()
        {
            string[] hostel = new string[]
            {
                "",
                "JAH",
                "IB",
                "LAG",
                "DLW",
                "UFH"
            };
            hosteldrp.DataSource = hostel;
            hosteldrp.DataBind();
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
            FacultyTbx.Items.Add("");
            FacultyTbx.DataSource = faculties;
            FacultyTbx.DataBind();
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
            DepartmentTbx.DataSource = nasdepartments;
            DepartmentTbx.DataBind();
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
            DepartmentTbx.DataSource = smsdepartments;
            DepartmentTbx.DataBind();
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
            DepartmentTbx.DataSource = humdepartments;
            DepartmentTbx.DataBind();
        }

        public void addlawdepartments()
        {
            DepartmentTbx.Items.Add("");
            DepartmentTbx.Items.Add("Law");
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
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addPhyProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Physics with Electronics",
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addMthProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Mathematics"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addStatProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Statistics",
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
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
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addEaScProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Geology"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addBioScProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "MicroBiology",
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addMasscmProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Mass Communication",
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addAcctProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Financial Accounting",
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addBafProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Banking and Finance",
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addBusadProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Buisiness Administration"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addEconsProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Economics"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addEngProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "English"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addCRSProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "C.R.S"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addHistoryProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "History"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        public void addLawProgrammes()
        {
            //Adding programmes
            string[] programmes = new string[]
            {
                "",
                "Law"
            };
            ProgrammeTbx.DataSource = programmes;
            ProgrammeTbx.DataBind();
        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            //var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            //var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            //IdentityResult result = manager.Create(user, Password.Text);
            //if (result.Succeeded)
            //{
            //    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
            //    //string code = manager.GenerateEmailConfirmationToken(user.Id);
            //    //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
            //    //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

            //    signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
            //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            //}
            //else 
            //{
            //    ErrorMessage.Text = result.Errors.FirstOrDefault();
            //}
            
        }

        protected void FileUploadBtn_Click1(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                getElectionDetails();
                string directorypath = Server.MapPath(string.Format("~/VoterImages/" + liveelection + "/"));
                if (!Directory.Exists(directorypath))
                {
                    Directory.CreateDirectory(directorypath);
                    if (FileUpload.HasFile)
                    {
                        getElectionDetails();
                        VoterImage.ImageUrl = "~/Images/DefaultImage.png";
                        string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
                        Response.Write("<script LANGUAGE= Javascript>alert('The file you was uploaded was "+filename+"')</script>");
                        FileUpload.PostedFile.SaveAs(Server.MapPath("~/VoterImages/" + liveelection + "/" +FirstnameTbx.Text+ " "+MiddlenameTbx.Text+" "+SurnameTbx.Text+".jpg"));
                        VoterImage.ImageUrl = "~/VoterImages/" + liveelection + "/" + FirstnameTbx.Text + " " + MiddlenameTbx.Text + " " + SurnameTbx.Text + ".jpg";
                        Response.Write("<script LANGUAGE= Javascript>alert('Image Added Succesfully')</script>");
                        FirstnameTbx.Enabled = false;
                        MiddlenameTbx.Enabled = false;
                        SurnameTbx.Enabled = false;
                        MatricNoTbx.Enabled = false;
                    }
                    else if (!FileUpload.HasFile)
                    {
                        Response.Write("<script LANGUAGE= Javascript>alert('No Image was Selected')</script>");
                    }
                }
                else if (Directory.Exists(directorypath))
                {
                    if (FileUpload.HasFile)
                    {
                        getElectionDetails();
                        VoterImage.ImageUrl = "~/Images/DefaultImage.png";
                        string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
                        Response.Write("<script LANGUAGE= Javascript>alert('The file you was uploaded was " + filename + "')</script>");
                        FileUpload.PostedFile.SaveAs(Server.MapPath("~/VoterImages/" + liveelection + "/" + FirstnameTbx.Text + " " + MiddlenameTbx.Text + " " + SurnameTbx.Text + ".jpg"));
                        VoterImage.ImageUrl = "~/VoterImages/" + liveelection + "/" + FirstnameTbx.Text + " " + MiddlenameTbx.Text + " " + SurnameTbx.Text + ".jpg";
                        Response.Write("<script LANGUAGE= Javascript>alert('Image Added Succesfully')</script>");
                        MatricNoTbx.Enabled = false;
                    }
                    else if (!FileUpload.HasFile)
                    {
                        Response.Write("<script LANGUAGE= Javascript>alert('No Image was Selected')</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script LANGUAGE= Javascript>alert('Image Not Found')</script>");
            }
        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            
            getElectionDetails();
            Response.Write("<script LANGUAGE=Javascript>alert('Registration for the " + Session["electionname"] + " Elections')</script>");
            string imageurl = "~/VoterImages/" + liveelection + "/" + FirstnameTbx.Text + " " + MiddlenameTbx.Text + " " + SurnameTbx.Text + ".jpg";
            string sql, sql2, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";
            sql = "if not exists(select * from sys.tables where name = 'voterTable' ) create table votersTable(ID int NOT NULL IDENTITY(1,1), " +
                " Firstname Varchar(MAX) NOT NULL, " +
                " Middlename Varchar(MAX) NOT NULL, " +
                " Surname Varchar(MAX) NOT NULL, " +
                " MatricNo Varchar(10) NOT NULL, " +
                " Faculty Varchar(MAX) NOT NULL, " +
                " Department Varchar(MAX) NOT NULL, " +
                " Programme Varchar(MAX) NOT NULL, " +
                " Hostel Varchar(MAX) NOT NULL, " +
                " RoomNo Varchar(MAX) NOT NULL, " +
                " Password Varchar(MAX) NOT NULL, " +
                " SecurityQuestion1 Varchar(MAX) NOT NULL, " +
                " SecurityAnswer1 Varchar(MAX) NOT NULL, " +
                " SecurityQuestion2 Varchar(MAX) NOT NULL, " +
                " SecurityAnswer2 Varchar(MAX) NOT NULL, " +
                " ImageUrl Varchar(MAX) NOT NULL, " +
                " PRIMARY KEY (ID))";
            
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                FirstnameTbx.Enabled = true;
                MiddlenameTbx.Enabled = true;
                SurnameTbx.Enabled = true;
                MatricNoTbx.Enabled = true;
                addvoter();
                Response.Write("<script LANGUAGE=Javascript>alert('You have been Registered Successfully, Your Username is " + MatricNoTbx.Text + "')</script>");
                //Response.Redirect("");

            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE=Javascript>alert('We encountered an error while trying to register you, try again later " + ex + " ')</script>");
            }
            finally 
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            Response.Redirect("~/Account/Login.aspx");  
        }

        public void addvoter()
        {
            string sql2, connstring;
            string firstname = FirstnameTbx.Text;
            string middlename = MiddlenameTbx.Text;
            string surname = SurnameTbx.Text;
            string matricno = MatricNoTbx.Text;
            string faculty = FacultyTbx.Text;
            string department = DepartmentTbx.Text;
            string programme = ProgrammeTbx.Text;
            string hostel = hosteldrp.Text;
            string roomno = roomtbx.Text;
            string password = Password.Text;
            string imageurl = 
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";
            sql2 = "insert into votersTable(MatricNo,Firstname,Middlename,Surname,Faculty,Department,Programme,Hostel,RoomNo,Password,SecurityQuestion1,SecurityAnswer1,SecurityQuestion2,SecurityAnswer2,ImageUrl) values('" + firstname + "','" + middlename + "','" + surname + "','" + matricno + "','" + faculty + "','" + department + "','" + programme + "','" + hostel + "','" + roomno + "','" + password + "','" + securityQuestion1 + "','" + securityAnswer1 + "','" + securityQuestion2 + "','" + securityAnswer2 + "','" + imageurl + "')";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd2 = new SqlCommand(sql2, conn); 
            try
            {
                MatricNoTbx.Enabled = false;
                FirstnameTbx.Enabled = false;
                MiddlenameTbx.Enabled = false;
                SurnameTbx.Enabled = false;
                FacultyTbx.Enabled = false;
                DepartmentTbx.Enabled = false;
                ProgrammeTbx.Enabled = false;
                hosteldrp.Enabled = false;
                roomtbx.Enabled = false;
                Password.Enabled = false;
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE=Javascript>alert('We encountered and error registering you for the "+Session["electionname"]+" Elections, due to "+ex+"')<script>");
            } 
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void DepartmentTbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartmentTbx.SelectedItem.Text == "")
            {
                ProgrammeTbx.Items.Clear();
                ProgrammeTbx.Items.Add("");
            }
            else if (DepartmentTbx.SelectedItem.Text == "Computer Sciences")
            {
                ProgrammeTbx.Items.Clear();
                addCSCProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Physics")
            {
                ProgrammeTbx.Items.Clear();
                addPhyProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Mathematics")
            {
                ProgrammeTbx.Items.Clear();
                addMthProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Statistics")
            {
                ProgrammeTbx.Items.Clear();
                addStatProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Chemical Sciences")
            {
                ProgrammeTbx.Items.Clear();
                addChmScProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Biological Sciences")
            {
                ProgrammeTbx.Items.Clear();
                addBioScProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Earth Sciences")
            {
                ProgrammeTbx.Items.Clear();
                addEaScProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Mass Communication")
            {
                ProgrammeTbx.Items.Clear();
                addMasscmProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Financial Accounting")
            {
                ProgrammeTbx.Items.Clear();
                addAcctProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Banking and Finance")
            {
                ProgrammeTbx.Items.Clear();
                addBafProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Buisiness Administration")
            {
                ProgrammeTbx.Items.Clear();
                addBusadProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Economics")
            {
                ProgrammeTbx.Items.Clear();
                addEconsProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "English")
            {
                ProgrammeTbx.Items.Clear();
                addEngProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "C.R.S")
            {
                ProgrammeTbx.Items.Clear();
                addCRSProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "History")
            {
                ProgrammeTbx.Items.Clear();
                addHistoryProgrammes();
            }
            else if (DepartmentTbx.SelectedItem.Text == "Law")
            {
                ProgrammeTbx.Items.Clear();
                addLawProgrammes();
            }
            else
            {
                ProgrammeTbx.Items.Clear();
            }
        }

        protected void FacultyTbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FacultyTbx.SelectedItem.Text == "")
            {
                DepartmentTbx.Items.Clear();
                DepartmentTbx.Items.Add("");
            }
            else if (FacultyTbx.SelectedItem.Text == "Natural Sciences")
            {
                DepartmentTbx.Items.Clear();
                addNaturalSciencesDepartment();
            }
            else if (FacultyTbx.SelectedItem.Text == "Social and Management Sciences")
            {
                DepartmentTbx.Items.Clear();
                addsmsdepartments();
            }
            else if (FacultyTbx.SelectedItem.Text == "Humanities")
            {
                DepartmentTbx.Items.Clear();
                addhumdepartments();
            }
            else if (FacultyTbx.SelectedItem.Text == "Law")
            {
                DepartmentTbx.Items.Clear();
                addlawdepartments();
            }
        }
    }
}