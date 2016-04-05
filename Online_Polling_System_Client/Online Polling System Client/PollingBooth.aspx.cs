using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Polling_System_Client
{
    public partial class PollingBooth : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            disableAllPanels();

            Page.MaintainScrollPositionOnPostBack = true;

            getElectionDetails();

            ValidatePosts();

            //get Presidential Elected Person
            if (PCandidate1.Checked)
            {
                Session["PresidentialElect"] = PLabel1.Text;
                PCandidate2.Enabled = false;
                PCandidate3.Enabled = false;
                PCandidate4.Enabled = false;
                PCandidate5.Enabled = false;
                Response.Write("<script LANGUAGE= Javascript>alert('You have Selected " + Session["PresidentialElect"] + " as your preferred choice')</script>");
            }
            else if (PCandidate2.Checked)
            {
                Session["PresidentialElect"] = PLabel2.Text;
                PCandidate1.Enabled = false;
                PCandidate3.Enabled = false;
                PCandidate4.Enabled = false;
                PCandidate5.Enabled = false;
                Response.Write("<script LANGUAGE= Javascript>alert('You have Selected " + Session["PresidentialElect"] + " as your preferred choice')</script>");
            }
            else if (PCandidate3.Checked)
            {
                Session["PresidentialElect"] = PLabel3.Text;
                PCandidate1.Enabled = false;
                PCandidate2.Enabled = false;
                PCandidate4.Enabled = false;
                PCandidate5.Enabled = false;
                Response.Write("<script LANGUAGE= Javascript>alert('You have Selected " + Session["PresidentialElect"] + " as your preferred choice')</script>");
            }
            else if (PCandidate4.Checked)
            {
                Session["PresidentialElect"] = PLabel4.Text;
                PCandidate1.Enabled = false;
                PCandidate2.Enabled = false;
                PCandidate3.Enabled = false;
                PCandidate5.Enabled = false;
                Response.Write("<script LANGUAGE= Javascript>alert('You have Selected " + Session["PresidentialElect"] + " as your preferred choice')</script>");
            }
            else if (PCandidate5.Checked)
            {
                Session["PresidentialElect"] = PLabel5.Text;
                PCandidate1.Enabled = false;
                PCandidate2.Enabled = false;
                PCandidate3.Enabled = false;
                PCandidate4.Enabled = false;
                Response.Write("<script LANGUAGE= Javascript>alert('You have Selected " + Session["PresidentialElect"] + " as your preferred choice')</script>");
            }
            else
            {
                Session["PresidentialElect"] = "";
                PCandidate1.Enabled = true;
                PCandidate2.Enabled = true;
                PCandidate3.Enabled = true;
                PCandidate4.Enabled = true;
                PCandidate5.Enabled = true;
                //Response.Write("<script LANGUAGE= Javascript>alert('You have no Selected Choice for President')</script>");
            }

        }

        public void ValidatePosts()
        {
            //Show Current Election
            //Response.Write("<script LANGUAGE=Javascript>alert('The Chosen Election for today is " + Session["electionname"] + "')</script>");

            //Get Posts
            string sql2, connstring2;
            string electionposts;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";
            sql2 = "select * from PostTable";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    electionposts = reader2["Name"].ToString();
                    //Response.Write("<script LANGUAGE=Javascript>alert('"+electionposts+"')</script>");

                    //get Presidential Candidates
                    if (electionposts.ToString().Equals("President"))
                    {
                        PresidentialPanel.Enabled = true;
                        PresidentialPanel.Visible = true;
                        getPresidentialCandidates();
                        Session["President"] = null;
                    } 

                    //get Vice Presidential Candidates
                    if (electionposts == "Vice_President")
                    {
                        VicePresidentialPanel.Enabled = true;
                        VicePresidentialPanel.Visible = true;
                        getVicePresidentialCandidates();
                        Session["VicePresident"] = null;
                    }

                    //get General Secretary Candidates
                    if (electionposts == "General_Secretary")
                    {
                        GenSecPanel.Enabled = true;
                        GenSecPanel.Visible = true;
                        getGeneralSecretarialCandidates();
                        Session["GeneralSecretary"] = null;
                    }
                    
                    //get Assistant General Secretary Candidates
                    if (electionposts == "Assistant_General_Secretary")
                    {
                        AsstGenSecPanel.Enabled = true;
                        AsstGenSecPanel.Visible = true;
                        getAssistantGeneralSecretarialCandidates();
                        Session["AssistantGeneralSecretary"] = null;
                    }
                    
                    //get Financial Secretary Candidates
                    if (electionposts == "Financial_Secretary")
                    {
                        FinSecPanel.Enabled = true;
                        FinSecPanel.Visible = true;
                        getFinancialSecretarialCandidates();
                        Session["FinancialSecretary"] = null;
                    }                    

                    //get Treasury Candidates
                    if (electionposts == "Treasurer")
                    {
                        TreasurerPanel.Enabled = true;
                        TreasurerPanel.Visible = true;
                        getTreasuryCandidates();
                        Session["Treasurer"] = null;
                    }
                    
                    //get Academic Officer Candidates
                    if (electionposts == "Academic_Officer")
                    {
                        AcadOffPanel.Enabled = true;
                        AcadOffPanel.Visible = true;
                        getAcademicOfficerCandidates();
                        Session["AcademicOfficer"] = null;
                    }

                    //get Sport's Officer
                    if (electionposts != "Sports_Officer")
                    {
                        SportsOffPanel.Enabled = true;
                        SportsOffPanel.Visible = true;
                        getSportsOfficerCandidates();
                        Session["SportsOfficer"] = null;
                    }

                    //get Welfare Officer
                    if (electionposts != "Welfare_Officer")
                    {
                        WelfOffPanel.Enabled = true;
                        WelfOffPanel.Visible = true;
                        getWelfareOfficerCandidates();
                        Session["WelfareOfficer"] = null;
                    }
                                        
                    //get Public Relations Officer Candidates
                    if (electionposts == "Public_Relations_Officer")
                    {
                        PROPanel.Enabled = true;
                        PROPanel.Visible = true;
                        getPublicRelationsOfficerCandidates();
                        Session["PRO"] = null;
                    }
                                        
                    //get Social Director Candidates
                    if (electionposts == "Social_Director")
                    {
                        SocDirPanel.Enabled = true;
                        SocDirPanel.Visible = true;
                        getSocialDirectorCandidates();
                        Session["SocialDirector"] = null;
                    }
                    
                    //get Hall Rep Jah
                    if (electionposts == "Hall_Rep_JAH")
                    {
                        JAHHR.Enabled = true;
                        JAHHR.Visible = true;
                        getJahCandidates();
                        Session["HallRep"] = null;
                    }

                    //get Hall Rep IB
                    if (electionposts == "Hall_Rep_IB")
                    {
                        IBHR.Enabled = true;
                        IBHR.Visible = true;
                        getIBCandidates();
                        Session["HallRep"] = null;
                    }
                    
                    if (electionposts != "Hall_Rep_LAG")
                    {
                        LAGHR.Enabled = true;
                        LAGHR.Visible = true;
                        getLAGCandidates();
                        Session["HallRep"] = null;
                    }

                    //get Hall Rep Dlw
                    if (electionposts != "Hall_Rep_DLW")
                    {
                        DLWHR.Enabled = true;
                        DLWHR.Visible = true;
                        getDLWCandidates();
                        Session["HallRep"] = null;
                    }

                    //get Hall Rep UFH
                    if (electionposts != "Hall_Rep_UFH")
                    {
                        UFHHR.Enabled = true;
                        UFHHR.Visible = true;
                        getUFHCandidates();
                        Session["HallRep"] = null;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE=Javascipt>alert('System Error " + ex + ",.....Contact System Administrator')</script>");
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }
        }

        public void getElectionDetails()
        {
            //Get Election Name and Duration
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=OnlinePollingSystem;Data Source=enunwah-pc\\sqlexpress;";
            sql = "select * from liveElection election";
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

        public void disableAllPanels()
        {
            PresidentialPanel.Enabled = false;
            PresidentialPanel.Visible = false;
            VicePresidentialPanel.Enabled = false;
            VicePresidentialPanel.Visible = false;
            GenSecPanel.Enabled = false;
            GenSecPanel.Visible = false;
            AsstGenSecPanel.Enabled = false;
            AsstGenSecPanel.Visible = false;
            FinSecPanel.Enabled = false;
            FinSecPanel.Visible = false;
            TreasurerPanel.Enabled = false;
            TreasurerPanel.Visible = false;
            AcadOffPanel.Enabled = false;
            AcadOffPanel.Visible = false;
            SocDirPanel.Enabled = false;
            SocDirPanel.Visible = false;
            JAHHR.Enabled = false;
            JAHHR.Visible = false;
            IBHR.Enabled = false;
            IBHR.Visible = false;
            LAGHR.Enabled = false;
            LAGHR.Visible = false;
            DLWHR.Enabled = false;
            UFHHR.Enabled = false;
            UFHHR.Visible = false;
            DLWHR.Visible = false;
            SportsOffPanel.Enabled = false;
            SportsOffPanel.Visible = false;
            WelfOffPanel.Enabled = false;
            WelfOffPanel.Visible = false;
            PROPanel.Enabled = false;
            PROPanel.Visible = false;
        }

        public void getPresidentialCandidates()
        {
            PLabel1.Enabled = false;
            PLabel1.Visible = false;
            PImage1.Enabled = false;
            PImage1.Visible = false;
            PCandidate1.Enabled = false;
            PCandidate1.Visible = false;
            PLabel2.Enabled = false;
            PLabel2.Visible = false;
            PImage2.Enabled = false;
            PImage2.Visible = false;
            PCandidate2.Enabled = false;
            PCandidate2.Visible = false;
            PLabel3.Enabled = false;
            PLabel3.Visible = false;
            PImage3.Enabled = false;
            PImage3.Visible = false;
            PCandidate3.Enabled = false;
            PCandidate3.Visible = false;
            PLabel4.Enabled = false;
            PLabel4.Visible = false;
            PImage4.Enabled = false;
            PImage4.Visible = false;
            PCandidate4.Enabled = false;
            PCandidate4.Visible = false;
            PLabel5.Enabled = false;
            PLabel5.Visible = false;
            PImage5.Enabled = false;
            PImage5.Visible = false;
            PCandidate5.Enabled = false;
            PCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from PresidentTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    PLabel1.Enabled = true;
                    PLabel1.Visible = true;
                    PImage1.Enabled = true;
                    PImage1.Visible = true;
                    PCandidate1.Enabled = true;
                    PCandidate1.Visible = true;
                    PLabel1.Text = name;
                    PImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                PLabel1.Enabled = false;
                PLabel1.Visible = false;
                PImage1.Enabled = false;
                PImage1.Visible = false;
                PCandidate1.Enabled = false;
                PCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from PresidentTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    PLabel2.Enabled = true;
                    PLabel2.Visible = true;
                    PImage2.Enabled = true;
                    PImage2.Visible = true;
                    PCandidate2.Enabled = true;
                    PCandidate2.Visible = true;
                    PLabel2.Text = name2;
                    PImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                PLabel2.Enabled = false;
                PLabel2.Visible = false;
                PImage2.Enabled = false;
                PImage2.Visible = false;
                PCandidate2.Enabled = false;
                PCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from PresidentTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    PLabel3.Enabled = true;
                    PLabel3.Visible = true;
                    PImage3.Enabled = true;
                    PImage3.Visible = true;
                    PCandidate3.Enabled = true;
                    PCandidate3.Visible = true;
                    PLabel3.Text = name3;
                    PImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                PLabel3.Enabled = false;
                PLabel3.Visible = false;
                PImage3.Enabled = false;
                PImage3.Visible = false;
                PCandidate3.Enabled = false;
                PCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from PresidentTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    PLabel4.Enabled = true;
                    PLabel4.Visible = true;
                    PImage4.Enabled = true;
                    PImage4.Visible = true;
                    PCandidate4.Enabled = true;
                    PCandidate4.Visible = true;
                    PLabel4.Text = name4;
                    PImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                PLabel4.Enabled = false;
                PLabel4.Visible = false;
                PImage4.Enabled = false;
                PImage4.Visible = false;
                PCandidate4.Enabled = false;
                PCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from PresidentTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    PLabel5.Enabled = true;
                    PLabel5.Visible = true;
                    PImage5.Enabled = true;
                    PImage5.Visible = true;
                    PCandidate5.Enabled = true;
                    PCandidate5.Visible = true;
                    PLabel5.Text = name5;
                    PImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                PLabel5.Enabled = false;
                PLabel5.Visible = false;
                PImage5.Enabled = false;
                PImage5.Visible = false;
                PCandidate5.Enabled = false;
                PCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getVicePresidentialCandidates()
        {
            VPLabel1.Enabled = false;
            VPLabel1.Visible = false;
            VPImage1.Enabled = false;
            VPImage1.Visible = false;
            VPCandidate1.Enabled = false;
            VPCandidate1.Visible = false;
            VPLabel2.Enabled = false;
            VPLabel2.Visible = false;
            VPImage2.Enabled = false;
            VPImage2.Visible = false;
            VPCandidate2.Enabled = false;
            VPCandidate2.Visible = false;
            VPLabel3.Enabled = false;
            VPLabel3.Visible = false;
            VPImage3.Enabled = false;
            VPImage3.Visible = false;
            VPCandidate3.Enabled = false;
            VPCandidate3.Visible = false;
            VPLabel4.Enabled = false;
            VPLabel4.Visible = false;
            VPImage4.Enabled = false;
            VPImage4.Visible = false;
            VPCandidate4.Enabled = false;
            VPCandidate4.Visible = false;
            VPLabel5.Enabled = false;
            VPLabel5.Visible = false;
            VPImage5.Enabled = false;
            VPImage5.Visible = false;
            VPCandidate5.Enabled = false;
            VPCandidate5.Visible = false;

            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Vice_PresidentTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    VPLabel1.Enabled = true;
                    VPLabel1.Visible = true;
                    VPImage1.Enabled = true;
                    VPImage1.Visible = true;
                    VPCandidate1.Enabled = true;
                    VPCandidate1.Visible = true;
                    VPLabel1.Text = name;
                    VPImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                VPLabel1.Enabled = false;
                VPLabel1.Visible = false;
                VPImage1.Enabled = false;
                VPImage1.Visible = false;
                VPCandidate1.Enabled = false;
                VPCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Vice_PresidentTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    VPLabel2.Enabled = true;
                    VPLabel2.Visible = true;
                    VPImage2.Enabled = true;
                    VPImage2.Visible = true;
                    VPCandidate2.Enabled = true;
                    VPCandidate2.Visible = true;
                    VPLabel2.Text = name2;
                    VPImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                VPLabel2.Enabled = false;
                VPLabel2.Visible = false;
                VPImage2.Enabled = false;
                VPImage2.Visible = false;
                VPCandidate2.Enabled = false;
                VPCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Vice_PresidentTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    VPLabel3.Enabled = true;
                    VPLabel3.Visible = true;
                    VPImage3.Enabled = true;
                    VPImage3.Visible = true;
                    VPCandidate3.Enabled = true;
                    VPCandidate3.Visible = true;
                    VPLabel3.Text = name3;
                    VPImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                VPLabel3.Enabled = false;
                VPLabel3.Visible = false;
                VPImage3.Enabled = false;
                VPImage3.Visible = false;
                VPCandidate3.Enabled = false;
                VPCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Vice_PresidentTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    VPLabel4.Enabled = true;
                    VPLabel4.Visible = true;
                    VPImage4.Enabled = true;
                    VPImage4.Visible = true;
                    VPCandidate4.Enabled = true;
                    VPCandidate4.Visible = true;
                    VPLabel4.Text = name4;
                    VPImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                VPLabel4.Enabled = false;
                VPLabel4.Visible = false;
                VPImage4.Enabled = false;
                VPImage4.Visible = false;
                VPCandidate4.Enabled = false;
                VPCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Vice_PresidentTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    VPLabel5.Enabled = true;
                    VPLabel5.Visible = true;
                    VPImage5.Enabled = true;
                    VPImage5.Visible = true;
                    VPCandidate5.Enabled = true;
                    VPCandidate5.Visible = true;
                    VPLabel5.Text = name5;
                    VPImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                VPLabel5.Enabled = false;
                VPLabel5.Visible = false;
                VPImage5.Enabled = false;
                VPImage5.Visible = false;
                VPCandidate5.Enabled = false;
                VPCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getGeneralSecretarialCandidates()
        {
            GSLabel1.Enabled = false;
            GSLabel1.Visible = false;
            GSImage1.Enabled = false;
            GSImage1.Visible = false;
            GSCandidate1.Enabled = false;
            GSCandidate1.Visible = false;
            GSLabel2.Enabled = false;
            GSLabel2.Visible = false;
            GSImage2.Enabled = false;
            GSImage2.Visible = false;
            GSCandidate2.Enabled = false;
            GSCandidate2.Visible = false;
            GSLabel3.Enabled = false;
            GSLabel3.Visible = false;
            GSImage3.Enabled = false;
            GSImage3.Visible = false;
            GSCandidate3.Enabled = false;
            GSCandidate3.Visible = false;
            GSLabel4.Enabled = false;
            GSLabel4.Visible = false;
            GSImage4.Enabled = false;
            GSImage4.Visible = false;
            GSCandidate4.Enabled = false;
            GSCandidate4.Visible = false;
            GSLabel5.Enabled = false;
            GSLabel5.Visible = false;
            GSImage5.Enabled = false;
            GSImage5.Visible = false;
            GSCandidate5.Enabled = false;
            GSCandidate5.Visible = false;

            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from General_SecretaryTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    GSLabel1.Enabled = true;
                    GSLabel1.Visible = true;
                    GSImage1.Enabled = true;
                    GSImage1.Visible = true;
                    GSCandidate1.Enabled = true;
                    GSCandidate1.Visible = true;
                    GSLabel1.Text = name;
                    GSImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                GSLabel1.Enabled = false;
                GSLabel1.Visible = false;
                GSImage1.Enabled = false;
                GSImage1.Visible = false;
                GSCandidate1.Enabled = false;
                GSCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from General_SecretaryTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    GSLabel2.Enabled = true;
                    GSLabel2.Visible = true;
                    GSImage2.Enabled = true;
                    GSImage2.Visible = true;
                    GSCandidate2.Enabled = true;
                    GSCandidate2.Visible = true;
                    GSLabel2.Text = name2;
                    GSImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                GSLabel2.Enabled = false;
                GSLabel2.Visible = false;
                GSImage2.Enabled = false;
                GSImage2.Visible = false;
                GSCandidate2.Enabled = false;
                GSCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from General_SecretaryTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    GSLabel3.Enabled = true;
                    GSLabel3.Visible = true;
                    GSImage3.Enabled = true;
                    GSImage3.Visible = true;
                    GSCandidate3.Enabled = true;
                    GSCandidate3.Visible = true;
                    GSLabel3.Text = name3;
                    GSImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                GSLabel3.Enabled = false;
                GSLabel3.Visible = false;
                GSImage3.Enabled = false;
                GSImage3.Visible = false;
                GSCandidate3.Enabled = false;
                GSCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from General_SecretaryTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    GSLabel4.Enabled = true;
                    GSLabel4.Visible = true;
                    GSImage4.Enabled = true;
                    GSImage4.Visible = true;
                    GSCandidate4.Enabled = true;
                    GSCandidate4.Visible = true;
                    GSLabel4.Text = name4;
                    GSImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                GSLabel4.Enabled = false;
                GSLabel4.Visible = false;
                GSImage4.Enabled = false;
                GSImage4.Visible = false;
                GSCandidate4.Enabled = false;
                GSCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from General_SecretaryTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    GSLabel5.Enabled = true;
                    GSLabel5.Visible = true;
                    GSImage5.Enabled = true;
                    GSImage5.Visible = true;
                    GSCandidate5.Enabled = true;
                    GSCandidate5.Visible = true;
                    GSLabel5.Text = name5;
                    GSImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                GSLabel5.Enabled = false;
                GSLabel5.Visible = false;
                GSImage5.Enabled = false;
                GSImage5.Visible = false;
                GSCandidate5.Enabled = false;
                GSCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }

        }

        public void getAssistantGeneralSecretarialCandidates()
        {
            AGSLabel1.Enabled = false;
            AGSLabel1.Visible = false;
            AGSImage1.Enabled = false;
            AGSImage1.Visible = false;
            AGSCandidate1.Enabled = false;
            AGSCandidate1.Visible = false;
            AGSLabel2.Enabled = false;
            AGSLabel2.Visible = false;
            AGSImage2.Enabled = false;
            AGSImage2.Visible = false;
            AGSCandidate2.Enabled = false;
            AGSCandidate2.Visible = false;
            AGSLabel3.Enabled = false;
            AGSLabel3.Visible = false;
            AGSImage3.Enabled = false;
            AGSImage3.Visible = false;
            AGSCandidate3.Enabled = false;
            AGSCandidate3.Visible = false;
            AGSLabel4.Enabled = false;
            AGSLabel4.Visible = false;
            AGSImage4.Enabled = false;
            AGSImage4.Visible = false;
            AGSCandidate4.Enabled = false;
            AGSCandidate4.Visible = false;
            AGSLabel5.Enabled = false;
            AGSLabel5.Visible = false;
            AGSImage5.Enabled = false;
            AGSImage5.Visible = false;
            AGSCandidate5.Enabled = false;
            AGSCandidate5.Visible = false;

            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Assistant_General_SecretaryTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    AGSLabel1.Enabled = true;
                    AGSLabel1.Visible = true;
                    AGSImage1.Enabled = true;
                    AGSImage1.Visible = true;
                    AGSCandidate1.Enabled = true;
                    AGSCandidate1.Visible = true;
                    AGSLabel1.Text = name;
                    AGSImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                AGSLabel1.Enabled = false;
                AGSLabel1.Visible = false;
                AGSImage1.Enabled = false;
                AGSImage1.Visible = false;
                AGSCandidate1.Enabled = false;
                AGSCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Assistant_General_SecretaryTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    AGSLabel2.Enabled = true;
                    AGSLabel2.Visible = true;
                    AGSImage2.Enabled = true;
                    AGSImage2.Visible = true;
                    AGSCandidate2.Enabled = true;
                    AGSCandidate2.Visible = true;
                    AGSLabel2.Text = name2;
                    AGSImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                AGSLabel2.Enabled = false;
                AGSLabel2.Visible = false;
                AGSImage2.Enabled = false;
                AGSImage2.Visible = false;
                AGSCandidate2.Enabled = false;
                AGSCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Assistant_General_SecretaryTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    AGSLabel3.Enabled = true;
                    AGSLabel3.Visible = true;
                    AGSImage3.Enabled = true;
                    AGSImage3.Visible = true;
                    AGSCandidate3.Enabled = true;
                    AGSCandidate3.Visible = true;
                    AGSLabel3.Text = name3;
                    AGSImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                AGSLabel3.Enabled = false;
                AGSLabel3.Visible = false;
                AGSImage3.Enabled = false;
                AGSImage3.Visible = false;
                AGSCandidate3.Enabled = false;
                AGSCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Assistant_General_SecretaryTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    AGSLabel4.Enabled = true;
                    AGSLabel4.Visible = true;
                    AGSImage4.Enabled = true;
                    AGSImage4.Visible = true;
                    AGSCandidate4.Enabled = true;
                    AGSCandidate4.Visible = true;
                    AGSLabel4.Text = name4;
                    AGSImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                AGSLabel4.Enabled = false;
                AGSLabel4.Visible = false;
                AGSImage4.Enabled = false;
                AGSImage4.Visible = false;
                AGSCandidate4.Enabled = false;
                AGSCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Assistant_General_SecretaryTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    AGSLabel5.Enabled = true;
                    AGSLabel5.Visible = true;
                    AGSImage5.Enabled = true;
                    AGSImage5.Visible = true;
                    AGSCandidate5.Enabled = true;
                    AGSCandidate5.Visible = true;
                    AGSLabel5.Text = name5;
                    AGSImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                AGSLabel5.Enabled = false;
                AGSLabel5.Visible = false;
                AGSImage5.Enabled = false;
                AGSImage5.Visible = false;
                AGSCandidate5.Enabled = false;
                AGSCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getFinancialSecretarialCandidates()
        {
            FSLabel1.Enabled = false;
            FSLabel1.Visible = false;
            FSImage1.Enabled = false;
            FSImage1.Visible = false;
            FSCandidate1.Enabled = false;
            FSCandidate1.Visible = false;
            FSLabel2.Enabled = false;
            FSLabel2.Visible = false;
            FSImage2.Enabled = false;
            FSImage2.Visible = false;
            FSCandidate2.Enabled = false;
            FSCandidate2.Visible = false;
            FSLabel3.Enabled = false;
            FSLabel3.Visible = false;
            FSImage3.Enabled = false;
            FSImage3.Visible = false;
            FSCandidate3.Enabled = false;
            FSCandidate3.Visible = false;
            FSLabel4.Enabled = false;
            FSLabel4.Visible = false;
            FSImage4.Enabled = false;
            FSImage4.Visible = false;
            FSCandidate4.Enabled = false;
            FSCandidate4.Visible = false;
            FSLabel5.Enabled = false;
            FSLabel5.Visible = false;
            FSImage5.Enabled = false;
            FSImage5.Visible = false;
            FSCandidate5.Enabled = false;
            FSCandidate5.Visible = false;

            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Financial_SecretaryTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    FSLabel1.Enabled = true;
                    FSLabel1.Visible = true;
                    FSImage1.Enabled = true;
                    FSImage1.Visible = true;
                    FSCandidate1.Enabled = true;
                    FSCandidate1.Visible = true;
                    FSLabel1.Text = name;
                    FSImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                FSLabel1.Enabled = false;
                FSLabel1.Visible = false;
                FSImage1.Enabled = false;
                FSImage1.Visible = false;
                FSCandidate1.Enabled = false;
                FSCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Financial_SecretaryTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    FSLabel2.Enabled = true;
                    FSLabel2.Visible = true;
                    FSImage2.Enabled = true;
                    FSImage2.Visible = true;
                    FSCandidate2.Enabled = true;
                    FSCandidate2.Visible = true;
                    FSLabel2.Text = name2;
                    FSImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                FSLabel2.Enabled = false;
                FSLabel2.Visible = false;
                FSImage2.Enabled = false;
                FSImage2.Visible = false;
                FSCandidate2.Enabled = false;
                FSCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Financial_SecretaryTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    FSLabel3.Enabled = true;
                    FSLabel3.Visible = true;
                    FSImage3.Enabled = true;
                    FSImage3.Visible = true;
                    FSCandidate3.Enabled = true;
                    FSCandidate3.Visible = true;
                    FSLabel3.Text = name3;
                    FSImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                FSLabel3.Enabled = false;
                FSLabel3.Visible = false;
                FSImage3.Enabled = false;
                FSImage3.Visible = false;
                FSCandidate3.Enabled = false;
                FSCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Financial_SecretaryTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    FSLabel4.Enabled = true;
                    FSLabel4.Visible = true;
                    FSImage4.Enabled = true;
                    FSImage4.Visible = true;
                    FSCandidate4.Enabled = true;
                    FSCandidate4.Visible = true;
                    FSLabel4.Text = name4;
                    FSImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                FSLabel4.Enabled = false;
                FSLabel4.Visible = false;
                FSImage4.Enabled = false;
                FSImage4.Visible = false;
                FSCandidate4.Enabled = false;
                FSCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Financial_SecretaryTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    FSLabel5.Enabled = true;
                    FSLabel5.Visible = true;
                    FSImage5.Enabled = true;
                    FSImage5.Visible = true;
                    FSCandidate5.Enabled = true;
                    FSCandidate5.Visible = true;
                    FSLabel5.Text = name5;
                    FSImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                FSLabel5.Enabled = false;
                FSLabel5.Visible = false;
                FSImage5.Enabled = false;
                FSImage5.Visible = false;
                FSCandidate5.Enabled = false;
                FSCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getTreasuryCandidates()
        {
            TLabel1.Enabled = false;
            TLabel1.Visible = false;
            TImage1.Enabled = false;
            TImage1.Visible = false;
            TCandidate1.Enabled = false;
            TCandidate1.Visible = false;
            TLabel2.Enabled = false;
            TLabel2.Visible = false;
            TImage2.Enabled = false;
            TImage2.Visible = false;
            TCandidate2.Enabled = false;
            TCandidate2.Visible = false;
            TLabel3.Enabled = false;
            TLabel3.Visible = false;
            TImage3.Enabled = false;
            TImage3.Visible = false;
            TCandidate3.Enabled = false;
            TCandidate3.Visible = false;
            TLabel4.Enabled = false;
            TLabel4.Visible = false;
            TImage4.Enabled = false;
            TImage4.Visible = false;
            TCandidate4.Enabled = false;
            TCandidate4.Visible = false;
            TLabel5.Enabled = false;
            TLabel5.Visible = false;
            TImage5.Enabled = false;
            TImage5.Visible = false;
            TCandidate5.Enabled = false;
            TCandidate5.Visible = false;

            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from TreasurerTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    TLabel1.Enabled = true;
                    TLabel1.Visible = true;
                    TImage1.Enabled = true;
                    TImage1.Visible = true;
                    TCandidate1.Enabled = true;
                    TCandidate1.Visible = true;
                    TLabel1.Text = name;
                    TImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                TLabel1.Enabled = false;
                TLabel1.Visible = false;
                TImage1.Enabled = false;
                TImage1.Visible = false;
                TCandidate1.Enabled = false;
                TCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from TreasurerTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    TLabel2.Enabled = true;
                    TLabel2.Visible = true;
                    TImage2.Enabled = true;
                    TImage2.Visible = true;
                    TCandidate2.Enabled = true;
                    TCandidate2.Visible = true;
                    TLabel2.Text = name2;
                    TImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                TLabel2.Enabled = false;
                TLabel2.Visible = false;
                TImage2.Enabled = false;
                TImage2.Visible = false;
                TCandidate2.Enabled = false;
                TCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from TreasurerTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    TLabel3.Enabled = true;
                    TLabel3.Visible = true;
                    TImage3.Enabled = true;
                    TImage3.Visible = true;
                    TCandidate3.Enabled = true;
                    TCandidate3.Visible = true;
                    TLabel3.Text = name3;
                    TImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                TLabel3.Enabled = false;
                TLabel3.Visible = false;
                TImage3.Enabled = false;
                TImage3.Visible = false;
                TCandidate3.Enabled = false;
                TCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from TreasurerTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    TLabel4.Enabled = true;
                    TLabel4.Visible = true;
                    TImage4.Enabled = true;
                    TImage4.Visible = true;
                    TCandidate4.Enabled = true;
                    TCandidate4.Visible = true;
                    TLabel4.Text = name4;
                    TImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                TLabel4.Enabled = false;
                TLabel4.Visible = false;
                TImage4.Enabled = false;
                TImage4.Visible = false;
                TCandidate4.Enabled = false;
                TCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from TreasurerTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    TLabel5.Enabled = true;
                    TLabel5.Visible = true;
                    TImage5.Enabled = true;
                    TImage5.Visible = true;
                    TCandidate5.Enabled = true;
                    TCandidate5.Visible = true;
                    TLabel5.Text = name5;
                    TImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                TLabel5.Enabled = false;
                TLabel5.Visible = false;
                TImage5.Enabled = false;
                TImage5.Visible = false;
                TCandidate5.Enabled = false;
                TCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getAcademicOfficerCandidates()
        {
            AOCLabel1.Enabled = false;
            AOCLabel1.Visible = false;
            AOCImage1.Enabled = false;
            AOCImage1.Visible = false;
            AOCCandidate1.Enabled = false;
            AOCCandidate1.Visible = false;
            AOCLabel2.Enabled = false;
            AOCLabel2.Visible = false;
            AOCImage2.Enabled = false;
            AOCImage2.Visible = false;
            AOCCandidate2.Enabled = false;
            AOCCandidate2.Visible = false;
            AOCLabel3.Enabled = false;
            AOCLabel3.Visible = false;
            AOCImage3.Enabled = false;
            AOCImage3.Visible = false;
            AOCCandidate3.Enabled = false;
            AOCCandidate3.Visible = false;
            AOCLabel4.Enabled = false;
            AOCLabel4.Visible = false;
            AOCImage4.Enabled = false;
            AOCImage4.Visible = false;
            AOCCandidate4.Enabled = false;
            AOCCandidate4.Visible = false;
            AOCLabel5.Enabled = false;
            AOCLabel5.Visible = false;
            AOCImage5.Enabled = false;
            AOCImage5.Visible = false;
            AOCCandidate5.Enabled = false;
            AOCCandidate5.Visible = false;

            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Academic_OfficerTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    AOCLabel1.Enabled = true;
                    AOCLabel1.Visible = true;
                    AOCImage1.Enabled = true;
                    AOCImage1.Visible = true;
                    AOCCandidate1.Enabled = true;
                    AOCCandidate1.Visible = true;
                    AOCLabel1.Text = name;
                    AOCImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                AOCLabel1.Enabled = false;
                AOCLabel1.Visible = false;
                AOCImage1.Enabled = false;
                AOCImage1.Visible = false;
                AOCCandidate1.Enabled = false;
                AOCCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Academic_OfficerTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    AOCLabel2.Enabled = true;
                    AOCLabel2.Visible = true;
                    AOCImage2.Enabled = true;
                    AOCImage2.Visible = true;
                    AOCCandidate2.Enabled = true;
                    AOCCandidate2.Visible = true;
                    AOCLabel2.Text = name2;
                    AOCImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                AOCLabel2.Enabled = false;
                AOCLabel2.Visible = false;
                AOCImage2.Enabled = false;
                AOCImage2.Visible = false;
                AOCCandidate2.Enabled = false;
                AOCCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Academic_OfficerTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    AOCLabel3.Enabled = true;
                    AOCLabel3.Visible = true;
                    AOCImage3.Enabled = true;
                    AOCImage3.Visible = true;
                    AOCCandidate3.Enabled = true;
                    AOCCandidate3.Visible = true;
                    AOCLabel3.Text = name3;
                    AOCImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                AOCLabel3.Enabled = false;
                AOCLabel3.Visible = false;
                AOCImage3.Enabled = false;
                AOCImage3.Visible = false;
                AOCCandidate3.Enabled = false;
                AOCCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Academic_OfficerTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    AOCLabel4.Enabled = true;
                    AOCLabel4.Visible = true;
                    AOCImage4.Enabled = true;
                    AOCImage4.Visible = true;
                    AOCCandidate4.Enabled = true;
                    AOCCandidate4.Visible = true;
                    AOCLabel4.Text = name4;
                    AOCImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                AOCLabel4.Enabled = false;
                AOCLabel4.Visible = false;
                AOCImage4.Enabled = false;
                AOCImage4.Visible = false;
                AOCCandidate4.Enabled = false;
                AOCCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Academic_OfficerTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    AOCLabel5.Enabled = true;
                    AOCLabel5.Visible = true;
                    AOCImage5.Enabled = true;
                    AOCImage5.Visible = true;
                    AOCCandidate5.Enabled = true;
                    AOCCandidate5.Visible = true;
                    AOCLabel5.Text = name5;
                    AOCImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                AOCLabel5.Enabled = false;
                AOCLabel5.Visible = false;
                AOCImage5.Enabled = false;
                AOCImage5.Visible = false;
                AOCCandidate5.Enabled = false;
                AOCCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getSportsOfficerCandidates()
        {
            SOLabel1.Enabled = false;
            SOLabel1.Visible = false;
            SOImage1.Enabled = false;
            SOImage1.Visible = false;
            SOCandidate1.Enabled = false;
            SOCandidate1.Visible = false;
            SOLabel2.Enabled = false;
            SOLabel2.Visible = false;
            SOImage2.Enabled = false;
            SOImage2.Visible = false;
            SOCandidate2.Enabled = false;
            SOCandidate2.Visible = false;
            SOLabel3.Enabled = false;
            SOLabel3.Visible = false;
            SOImage3.Enabled = false;
            SOImage3.Visible = false;
            SOCandidate3.Enabled = false;
            SOCandidate3.Visible = false;
            SOLabel4.Enabled = false;
            SOLabel4.Visible = false;
            SOImage4.Enabled = false;
            SOImage4.Visible = false;
            SOCandidate4.Enabled = false;
            SOCandidate4.Visible = false;
            SOLabel5.Enabled = false;
            SOLabel5.Visible = false;
            SOImage5.Enabled = false;
            SOImage5.Visible = false;
            SOCandidate5.Enabled = false;
            SOCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Sports_OfficerTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    SOLabel1.Enabled = true;
                    SOLabel1.Visible = true;
                    SOImage1.Enabled = true;
                    SOImage1.Visible = true;
                    SOCandidate1.Enabled = true;
                    SOCandidate1.Visible = true;
                    SOLabel1.Text = name;
                    SOImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                SOLabel1.Enabled = false;
                SOLabel1.Visible = false;
                SOImage1.Enabled = false;
                SOImage1.Visible = false;
                SOCandidate1.Enabled = false;
                SOCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Sports_OfficerTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    SOLabel2.Enabled = true;
                    SOLabel2.Visible = true;
                    SOImage2.Enabled = true;
                    SOImage2.Visible = true;
                    SOCandidate2.Enabled = true;
                    SOCandidate2.Visible = true;
                    SOLabel2.Text = name2;
                    SOImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                SOLabel2.Enabled = false;
                SOLabel2.Visible = false;
                SOImage2.Enabled = false;
                SOImage2.Visible = false;
                SOCandidate2.Enabled = false;
                SOCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Sports_OfficerTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    SOLabel3.Enabled = true;
                    SOLabel3.Visible = true;
                    SOImage3.Enabled = true;
                    SOImage3.Visible = true;
                    SOCandidate3.Enabled = true;
                    SOCandidate3.Visible = true;
                    SOLabel3.Text = name3;
                    SOImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                SOLabel3.Enabled = false;
                SOLabel3.Visible = false;
                SOImage3.Enabled = false;
                SOImage3.Visible = false;
                SOCandidate3.Enabled = false;
                SOCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Sports_OfficerTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    SOLabel4.Enabled = true;
                    SOLabel4.Visible = true;
                    SOImage4.Enabled = true;
                    SOImage4.Visible = true;
                    SOCandidate4.Enabled = true;
                    SOCandidate4.Visible = true;
                    SOLabel4.Text = name4;
                    SOImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                SOLabel4.Enabled = false;
                SOLabel4.Visible = false;
                SOImage4.Enabled = false;
                SOImage4.Visible = false;
                SOCandidate4.Enabled = false;
                SOCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Sports_OfficerTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    SOLabel5.Enabled = true;
                    SOLabel5.Visible = true;
                    SOImage5.Enabled = true;
                    SOImage5.Visible = true;
                    SOCandidate5.Enabled = true;
                    SOCandidate5.Visible = true;
                    SOLabel5.Text = name5;
                    SOImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                SOLabel5.Enabled = false;
                SOLabel5.Visible = false;
                SOImage5.Enabled = false;
                SOImage5.Visible = false;
                SOCandidate5.Enabled = false;
                SOCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getWelfareOfficerCandidates()
        {
            WOLabel1.Enabled = false;
            WOLabel1.Visible = false;
            WOImage1.Enabled = false;
            WOImage1.Visible = false;
            WOCandidate1.Enabled = false;
            WOCandidate1.Visible = false;
            WOLabel2.Enabled = false;
            WOLabel2.Visible = false;
            WOImage2.Enabled = false;
            WOImage2.Visible = false;
            WOCandidate2.Enabled = false;
            WOCandidate2.Visible = false;
            WOLabel3.Enabled = false;
            WOLabel3.Visible = false;
            WOImage3.Enabled = false;
            WOImage3.Visible = false;
            WOCandidate3.Enabled = false;
            WOCandidate3.Visible = false;
            WOLabel4.Enabled = false;
            WOLabel4.Visible = false;
            WOImage4.Enabled = false;
            WOImage4.Visible = false;
            WOCandidate4.Enabled = false;
            WOCandidate4.Visible = false;
            WOLabel5.Enabled = false;
            WOLabel5.Visible = false;
            WOImage5.Enabled = false;
            WOImage5.Visible = false;
            WOCandidate5.Enabled = false;
            WOCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Welfare_OfficerTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    WOLabel1.Enabled = true;
                    WOLabel1.Visible = true;
                    WOImage1.Enabled = true;
                    WOImage1.Visible = true;
                    WOCandidate1.Enabled = true;
                    WOCandidate1.Visible = true;
                    WOLabel1.Text = name;
                    WOImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                WOLabel1.Enabled = false;
                WOLabel1.Visible = false;
                WOImage1.Enabled = false;
                WOImage1.Visible = false;
                WOCandidate1.Enabled = false;
                WOCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Welfare_OfficerTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    WOLabel2.Enabled = true;
                    WOLabel2.Visible = true;
                    WOImage2.Enabled = true;
                    WOImage2.Visible = true;
                    WOCandidate2.Enabled = true;
                    WOCandidate2.Visible = true;
                    WOLabel2.Text = name2;
                    WOImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                WOLabel2.Enabled = false;
                WOLabel2.Visible = false;
                WOImage2.Enabled = false;
                WOImage2.Visible = false;
                WOCandidate2.Enabled = false;
                WOCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Welfare_OfficerTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    WOLabel3.Enabled = true;
                    WOLabel3.Visible = true;
                    WOImage3.Enabled = true;
                    WOImage3.Visible = true;
                    WOCandidate3.Enabled = true;
                    WOCandidate3.Visible = true;
                    WOLabel3.Text = name3;
                    WOImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                WOLabel3.Enabled = false;
                WOLabel3.Visible = false;
                WOImage3.Enabled = false;
                WOImage3.Visible = false;
                WOCandidate3.Enabled = false;
                WOCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Welfare_OfficerTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    WOLabel4.Enabled = true;
                    WOLabel4.Visible = true;
                    WOImage4.Enabled = true;
                    WOImage4.Visible = true;
                    WOCandidate4.Enabled = true;
                    WOCandidate4.Visible = true;
                    WOLabel4.Text = name4;
                    WOImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                WOLabel4.Enabled = false;
                WOLabel4.Visible = false;
                WOImage4.Enabled = false;
                WOImage4.Visible = false;
                WOCandidate4.Enabled = false;
                WOCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Welfare_OfficerTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    WOLabel5.Enabled = true;
                    WOLabel5.Visible = true;
                    WOImage5.Enabled = true;
                    WOImage5.Visible = true;
                    WOCandidate5.Enabled = true;
                    WOCandidate5.Visible = true;
                    WOLabel5.Text = name5;
                    WOImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                WOLabel5.Enabled = false;
                WOLabel5.Visible = false;
                WOImage5.Enabled = false;
                WOImage5.Visible = false;
                WOCandidate5.Enabled = false;
                WOCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getPublicRelationsOfficerCandidates()
        {
            PRLabel1.Enabled = false;
            PRLabel1.Visible = false;
            PRImage1.Enabled = false;
            PRImage1.Visible = false;
            PRCandidate1.Enabled = false;
            PRCandidate1.Visible = false;
            PRLabel2.Enabled = false;
            PRLabel2.Visible = false;
            PRImage2.Enabled = false;
            PRImage2.Visible = false;
            PRCandidate2.Enabled = false;
            PRCandidate2.Visible = false;
            PRLabel3.Enabled = false;
            PRLabel3.Visible = false;
            PRImage3.Enabled = false;
            PRImage3.Visible = false;
            PRCandidate3.Enabled = false;
            PRCandidate3.Visible = false;
            PRLabel4.Enabled = false;
            PRLabel4.Visible = false;
            PRImage4.Enabled = false;
            PRImage4.Visible = false;
            PRCandidate4.Enabled = false;
            PRCandidate4.Visible = false;
            PRLabel5.Enabled = false;
            PRLabel5.Visible = false;
            PRImage5.Enabled = false;
            PRImage5.Visible = false;
            PRCandidate5.Enabled = false;
            PRCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Public_Relations_OfficerTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    PRLabel1.Enabled = true;
                    PRLabel1.Visible = true;
                    PRImage1.Enabled = true;
                    PRImage1.Visible = true;
                    PRCandidate1.Enabled = true;
                    PRCandidate1.Visible = true;
                    PRLabel1.Text = name;
                    PRImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                PRLabel1.Enabled = false;
                PRLabel1.Visible = false;
                PRImage1.Enabled = false;
                PRImage1.Visible = false;
                PRCandidate1.Enabled = false;
                PRCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Public_Relations_OfficerTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    PRLabel2.Enabled = true;
                    PRLabel2.Visible = true;
                    PRImage2.Enabled = true;
                    PRImage2.Visible = true;
                    PRCandidate2.Enabled = true;
                    PRCandidate2.Visible = true;
                    PRLabel2.Text = name2;
                    PRImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                PRLabel2.Enabled = false;
                PRLabel2.Visible = false;
                PRImage2.Enabled = false;
                PRImage2.Visible = false;
                PRCandidate2.Enabled = false;
                PRCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Public_Relations_OfficerTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    PRLabel3.Enabled = true;
                    PRLabel3.Visible = true;
                    PRImage3.Enabled = true;
                    PRImage3.Visible = true;
                    PRCandidate3.Enabled = true;
                    PRCandidate3.Visible = true;
                    PRLabel3.Text = name3;
                    PRImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                PRLabel3.Enabled = false;
                PRLabel3.Visible = false;
                PRImage3.Enabled = false;
                PRImage3.Visible = false;
                PRCandidate3.Enabled = false;
                PRCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Public_Relations_OfficerTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    PRLabel4.Enabled = true;
                    PRLabel4.Visible = true;
                    PRImage4.Enabled = true;
                    PRImage4.Visible = true;
                    PRCandidate4.Enabled = true;
                    PRCandidate4.Visible = true;
                    PRLabel4.Text = name4;
                    PRImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                PRLabel4.Enabled = false;
                PRLabel4.Visible = false;
                PRImage4.Enabled = false;
                PRImage4.Visible = false;
                PRCandidate4.Enabled = false;
                PRCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Public_Relations_OfficerTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    PRLabel5.Enabled = true;
                    PRLabel5.Visible = true;
                    PRImage5.Enabled = true;
                    PRImage5.Visible = true;
                    PRCandidate5.Enabled = true;
                    PRCandidate5.Visible = true;
                    PRLabel5.Text = name5;
                    PRImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                PRLabel5.Enabled = false;
                PRLabel5.Visible = false;
                PRImage5.Enabled = false;
                PRImage5.Visible = false;
                PRCandidate5.Enabled = false;
                PRCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getSocialDirectorCandidates()
        {
            SDLabel1.Enabled = false;
            SDLabel1.Visible = false;
            SDImage1.Enabled = false;
            SDImage1.Visible = false;
            SDCandidate1.Enabled = false;
            SDCandidate1.Visible = false;
            SDLabel2.Enabled = false;
            SDLabel2.Visible = false;
            SDImage2.Enabled = false;
            SDImage2.Visible = false;
            SDCandidate2.Enabled = false;
            SDCandidate2.Visible = false;
            SDLabel3.Enabled = false;
            SDLabel3.Visible = false;
            SDImage3.Enabled = false;
            SDImage3.Visible = false;
            SDCandidate3.Enabled = false;
            SDCandidate3.Visible = false;
            SDLabel4.Enabled = false;
            SDLabel4.Visible = false;
            SDImage4.Enabled = false;
            SDImage4.Visible = false;
            SDCandidate4.Enabled = false;
            SDCandidate4.Visible = false;
            SDLabel5.Enabled = false;
            SDLabel5.Visible = false;
            SDImage5.Enabled = false;
            SDImage5.Visible = false;
            SDCandidate5.Enabled = false;
            SDCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Social_DirectorTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    SDLabel1.Enabled = true;
                    SDLabel1.Visible = true;
                    SDImage1.Enabled = true;
                    SDImage1.Visible = true;
                    SDCandidate1.Enabled = true;
                    SDCandidate1.Visible = true;
                    SDLabel1.Text = name;
                    SDImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                SDLabel1.Enabled = false;
                SDLabel1.Visible = false;
                SDImage1.Enabled = false;
                SDImage1.Visible = false;
                SDCandidate1.Enabled = false;
                SDCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Social_DirectorTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    SDLabel2.Enabled = true;
                    SDLabel2.Visible = true;
                    SDImage2.Enabled = true;
                    SDImage2.Visible = true;
                    SDCandidate2.Enabled = true;
                    SDCandidate2.Visible = true;
                    SDLabel2.Text = name2;
                    SDImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                SDLabel2.Enabled = false;
                SDLabel2.Visible = false;
                SDImage2.Enabled = false;
                SDImage2.Visible = false;
                SDCandidate2.Enabled = false;
                SDCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Social_DirectorTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    SDLabel3.Enabled = true;
                    SDLabel3.Visible = true;
                    SDImage3.Enabled = true;
                    SDImage3.Visible = true;
                    SDCandidate3.Enabled = true;
                    SDCandidate3.Visible = true;
                    SDLabel3.Text = name3;
                    SDImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                SDLabel3.Enabled = false;
                SDLabel3.Visible = false;
                SDImage3.Enabled = false;
                SDImage3.Visible = false;
                SDCandidate3.Enabled = false;
                SDCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Social_DirectorTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    SDLabel4.Enabled = true;
                    SDLabel4.Visible = true;
                    SDImage4.Enabled = true;
                    SDImage4.Visible = true;
                    SDCandidate4.Enabled = true;
                    SDCandidate4.Visible = true;
                    SDLabel4.Text = name4;
                    SDImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                SDLabel4.Enabled = false;
                SDLabel4.Visible = false;
                SDImage4.Enabled = false;
                SDImage4.Visible = false;
                SDCandidate4.Enabled = false;
                SDCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Social_DirectorTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    SDLabel5.Enabled = true;
                    SDLabel5.Visible = true;
                    SDImage5.Enabled = true;
                    SDImage5.Visible = true;
                    SDCandidate5.Enabled = true;
                    SDCandidate5.Visible = true;
                    SDLabel5.Text = name5;
                    SDImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                SDLabel5.Enabled = false;
                SDLabel5.Visible = false;
                SDImage5.Enabled = false;
                SDImage5.Visible = false;
                SDCandidate5.Enabled = false;
                SDCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getJahCandidates()
        {
            JAHLabel1.Enabled = false;
            JAHLabel1.Visible = false;
            JAHImage1.Enabled = false;
            JAHImage1.Visible = false;
            JAHCandidate1.Enabled = false;
            JAHCandidate1.Visible = false;
            JAHLabel2.Enabled = false;
            JAHLabel2.Visible = false;
            JAHImage2.Enabled = false;
            JAHImage2.Visible = false;
            JAHCandidate2.Enabled = false;
            JAHCandidate2.Visible = false;
            JAHLabel3.Enabled = false;
            JAHLabel3.Visible = false;
            JAHImage3.Enabled = false;
            JAHImage3.Visible = false;
            JAHCandidate3.Enabled = false;
            JAHCandidate3.Visible = false;
            JAHLabel4.Enabled = false;
            JAHLabel4.Visible = false;
            JAHImage4.Enabled = false;
            JAHImage4.Visible = false;
            JAHCandidate4.Enabled = false;
            JAHCandidate4.Visible = false;
            JAHLabel5.Enabled = false;
            JAHLabel5.Visible = false;
            JAHImage5.Enabled = false;
            JAHImage5.Visible = false;
            JAHCandidate5.Enabled = false;
            JAHCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Hall_Rep_JAHTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    JAHLabel1.Enabled = true;
                    JAHLabel1.Visible = true;
                    JAHImage1.Enabled = true;
                    JAHImage1.Visible = true;
                    JAHCandidate1.Enabled = true;
                    JAHCandidate1.Visible = true;
                    JAHLabel1.Text = name;
                    JAHImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                JAHLabel1.Enabled = false;
                JAHLabel1.Visible = false;
                JAHImage1.Enabled = false;
                JAHImage1.Visible = false;
                JAHCandidate1.Enabled = false;
                JAHCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Hall_Rep_JAHTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    JAHLabel2.Enabled = true;
                    JAHLabel2.Visible = true;
                    JAHImage2.Enabled = true;
                    JAHImage2.Visible = true;
                    JAHCandidate2.Enabled = true;
                    JAHCandidate2.Visible = true;
                    JAHLabel2.Text = name2;
                    JAHImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                JAHLabel2.Enabled = false;
                JAHLabel2.Visible = false;
                JAHImage2.Enabled = false;
                JAHImage2.Visible = false;
                JAHCandidate2.Enabled = false;
                JAHCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Hall_Rep_JAHTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    JAHLabel3.Enabled = true;
                    JAHLabel3.Visible = true;
                    JAHImage3.Enabled = true;
                    JAHImage3.Visible = true;
                    JAHCandidate3.Enabled = true;
                    JAHCandidate3.Visible = true;
                    JAHLabel3.Text = name3;
                    JAHImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                JAHLabel3.Enabled = false;
                JAHLabel3.Visible = false;
                JAHImage3.Enabled = false;
                JAHImage3.Visible = false;
                JAHCandidate3.Enabled = false;
                JAHCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Hall_Rep_JAHTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    JAHLabel4.Enabled = true;
                    JAHLabel4.Visible = true;
                    JAHImage4.Enabled = true;
                    JAHImage4.Visible = true;
                    JAHCandidate4.Enabled = true;
                    JAHCandidate4.Visible = true;
                    JAHLabel4.Text = name4;
                    JAHImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                JAHLabel4.Enabled = false;
                JAHLabel4.Visible = false;
                JAHImage4.Enabled = false;
                JAHImage4.Visible = false;
                JAHCandidate4.Enabled = false;
                JAHCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Hall_Rep_JAHTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    JAHLabel5.Enabled = true;
                    JAHLabel5.Visible = true;
                    JAHImage5.Enabled = true;
                    JAHImage5.Visible = true;
                    JAHCandidate5.Enabled = true;
                    JAHCandidate5.Visible = true;
                    JAHLabel5.Text = name5;
                    JAHImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                JAHLabel5.Enabled = false;
                JAHLabel5.Visible = false;
                JAHImage5.Enabled = false;
                JAHImage5.Visible = false;
                JAHCandidate5.Enabled = false;
                JAHCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getIBCandidates()
        {
            IBLabel1.Enabled = false;
            IBLabel1.Visible = false;
            IBImage1.Enabled = false;
            IBImage1.Visible = false;
            IBCandidate1.Enabled = false;
            IBCandidate1.Visible = false;
            IBLabel2.Enabled = false;
            IBLabel2.Visible = false;
            IBImage2.Enabled = false;
            IBImage2.Visible = false;
            IBCandidate2.Enabled = false;
            IBCandidate2.Visible = false;
            IBLabel3.Enabled = false;
            IBLabel3.Visible = false;
            IBImage3.Enabled = false;
            IBImage3.Visible = false;
            IBCandidate3.Enabled = false;
            IBCandidate3.Visible = false;
            IBLabel4.Enabled = false;
            IBLabel4.Visible = false;
            IBImage4.Enabled = false;
            IBImage4.Visible = false;
            IBCandidate4.Enabled = false;
            IBCandidate4.Visible = false;
            IBLabel5.Enabled = false;
            IBLabel5.Visible = false;
            IBImage5.Enabled = false;
            IBImage5.Visible = false;
            IBCandidate5.Enabled = false;
            IBCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Hall_Rep_IBTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    IBLabel1.Enabled = true;
                    IBLabel1.Visible = true;
                    IBImage1.Enabled = true;
                    IBImage1.Visible = true;
                    IBCandidate1.Enabled = true;
                    IBCandidate1.Visible = true;
                    IBLabel1.Text = name;
                    IBImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                IBLabel1.Enabled = false;
                IBLabel1.Visible = false;
                IBImage1.Enabled = false;
                IBImage1.Visible = false;
                IBCandidate1.Enabled = false;
                IBCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Hall_Rep_IBTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    IBLabel2.Enabled = true;
                    IBLabel2.Visible = true;
                    IBImage2.Enabled = true;
                    IBImage2.Visible = true;
                    IBCandidate2.Enabled = true;
                    IBCandidate2.Visible = true;
                    IBLabel2.Text = name2;
                    IBImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                IBLabel2.Enabled = false;
                IBLabel2.Visible = false;
                IBImage2.Enabled = false;
                IBImage2.Visible = false;
                IBCandidate2.Enabled = false;
                IBCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Hall_Rep_IBTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    IBLabel3.Enabled = true;
                    IBLabel3.Visible = true;
                    IBImage3.Enabled = true;
                    IBImage3.Visible = true;
                    IBCandidate3.Enabled = true;
                    IBCandidate3.Visible = true;
                    IBLabel3.Text = name3;
                    IBImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                IBLabel3.Enabled = false;
                IBLabel3.Visible = false;
                IBImage3.Enabled = false;
                IBImage3.Visible = false;
                IBCandidate3.Enabled = false;
                IBCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Hall_Rep_IBTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    IBLabel4.Enabled = true;
                    IBLabel4.Visible = true;
                    IBImage4.Enabled = true;
                    IBImage4.Visible = true;
                    IBCandidate4.Enabled = true;
                    IBCandidate4.Visible = true;
                    IBLabel4.Text = name4;
                    IBImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                IBLabel4.Enabled = false;
                IBLabel4.Visible = false;
                IBImage4.Enabled = false;
                IBImage4.Visible = false;
                IBCandidate4.Enabled = false;
                IBCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Hall_Rep_IBTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    IBLabel5.Enabled = true;
                    IBLabel5.Visible = true;
                    IBImage5.Enabled = true;
                    IBImage5.Visible = true;
                    IBCandidate5.Enabled = true;
                    IBCandidate5.Visible = true;
                    IBLabel5.Text = name5;
                    IBImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                IBLabel5.Enabled = false;
                IBLabel5.Visible = false;
                IBImage5.Enabled = false;
                IBImage5.Visible = false;
                IBCandidate5.Enabled = false;
                IBCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getLAGCandidates()
        {
            LGLabel1.Enabled = false;
            LGLabel1.Visible = false;
            LGImage1.Enabled = false;
            LGImage1.Visible = false;
            LGCandidate1.Enabled = false;
            LGCandidate1.Visible = false;
            LGLabel2.Enabled = false;
            LGLabel2.Visible = false;
            LGImage2.Enabled = false;
            LGImage2.Visible = false;
            LGCandidate2.Enabled = false;
            LGCandidate2.Visible = false;
            LGLabel3.Enabled = false;
            LGLabel3.Visible = false;
            LGImage3.Enabled = false;
            LGImage3.Visible = false;
            LGCandidate3.Enabled = false;
            LGCandidate3.Visible = false;
            LGLabel4.Enabled = false;
            LGLabel4.Visible = false;
            LGImage4.Enabled = false;
            LGImage4.Visible = false;
            LGCandidate4.Enabled = false;
            LGCandidate4.Visible = false;
            LGLabel5.Enabled = false;
            LGLabel5.Visible = false;
            LGImage5.Enabled = false;
            LGImage5.Visible = false;
            LGCandidate5.Enabled = false;
            LGCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Hall_Rep_LAGTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    LGLabel1.Enabled = true;
                    LGLabel1.Visible = true;
                    LGImage1.Enabled = true;
                    LGImage1.Visible = true;
                    LGCandidate1.Enabled = true;
                    LGCandidate1.Visible = true;
                    LGLabel1.Text = name;
                    LGImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                LGLabel1.Enabled = false;
                LGLabel1.Visible = false;
                LGImage1.Enabled = false;
                LGImage1.Visible = false;
                LGCandidate1.Enabled = false;
                LGCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Hall_Rep_LAGTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    LGLabel2.Enabled = true;
                    LGLabel2.Visible = true;
                    LGImage2.Enabled = true;
                    LGImage2.Visible = true;
                    LGCandidate2.Enabled = true;
                    LGCandidate2.Visible = true;
                    LGLabel2.Text = name2;
                    LGImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                LGLabel2.Enabled = false;
                LGLabel2.Visible = false;
                LGImage2.Enabled = false;
                LGImage2.Visible = false;
                LGCandidate2.Enabled = false;
                LGCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Hall_Rep_LAGTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    LGLabel3.Enabled = true;
                    LGLabel3.Visible = true;
                    LGImage3.Enabled = true;
                    LGImage3.Visible = true;
                    LGCandidate3.Enabled = true;
                    LGCandidate3.Visible = true;
                    LGLabel3.Text = name3;
                    LGImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                LGLabel3.Enabled = false;
                LGLabel3.Visible = false;
                LGImage3.Enabled = false;
                LGImage3.Visible = false;
                LGCandidate3.Enabled = false;
                LGCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Hall_Rep_LAGTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    LGLabel4.Enabled = true;
                    LGLabel4.Visible = true;
                    LGImage4.Enabled = true;
                    LGImage4.Visible = true;
                    LGCandidate4.Enabled = true;
                    LGCandidate4.Visible = true;
                    LGLabel4.Text = name4;
                    LGImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                LGLabel4.Enabled = false;
                LGLabel4.Visible = false;
                LGImage4.Enabled = false;
                LGImage4.Visible = false;
                LGCandidate4.Enabled = false;
                LGCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Hall_Rep_LAGTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    LGLabel5.Enabled = true;
                    LGLabel5.Visible = true;
                    LGImage5.Enabled = true;
                    LGImage5.Visible = true;
                    LGCandidate5.Enabled = true;
                    LGCandidate5.Visible = true;
                    LGLabel5.Text = name5;
                    LGImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                LGLabel5.Enabled = false;
                LGLabel5.Visible = false;
                LGImage5.Enabled = false;
                LGImage5.Visible = false;
                LGCandidate5.Enabled = false;
                LGCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getDLWCandidates()
        {
            LWLabel1.Enabled = false;
            LWLabel1.Visible = false;
            LWImage1.Enabled = false;
            LWImage1.Visible = false;
            LWCandidate1.Enabled = false;
            LWCandidate1.Visible = false;
            LWLabel2.Enabled = false;
            LWLabel2.Visible = false;
            LWImage2.Enabled = false;
            LWImage2.Visible = false;
            LWCandidate2.Enabled = false;
            LWCandidate2.Visible = false;
            LWLabel3.Enabled = false;
            LWLabel3.Visible = false;
            LWImage3.Enabled = false;
            LWImage3.Visible = false;
            LWCandidate3.Enabled = false;
            LWCandidate3.Visible = false;
            LWLabel4.Enabled = false;
            LWLabel4.Visible = false;
            LWImage4.Enabled = false;
            LWImage4.Visible = false;
            LWCandidate4.Enabled = false;
            LWCandidate4.Visible = false;
            LWLabel5.Enabled = false;
            LWLabel5.Visible = false;
            LWImage5.Enabled = false;
            LWImage5.Visible = false;
            LWCandidate5.Enabled = false;
            LWCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Hall_Rep_DLWTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    LWLabel1.Enabled = true;
                    LWLabel1.Visible = true;
                    LWImage1.Enabled = true;
                    LWImage1.Visible = true;
                    LWCandidate1.Enabled = true;
                    LWCandidate1.Visible = true;
                    LWLabel1.Text = name;
                    LWImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                LWLabel1.Enabled = false;
                LWLabel1.Visible = false;
                LWImage1.Enabled = false;
                LWImage1.Visible = false;
                LWCandidate1.Enabled = false;
                LWCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Hall_Rep_DLWTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    LWLabel2.Enabled = true;
                    LWLabel2.Visible = true;
                    LWImage2.Enabled = true;
                    LWImage2.Visible = true;
                    LWCandidate2.Enabled = true;
                    LWCandidate2.Visible = true;
                    LWLabel2.Text = name2;
                    LWImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                LWLabel2.Enabled = false;
                LWLabel2.Visible = false;
                LWImage2.Enabled = false;
                LWImage2.Visible = false;
                LWCandidate2.Enabled = false;
                LWCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Hall_Rep_DLWTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    LWLabel3.Enabled = true;
                    LWLabel3.Visible = true;
                    LWImage3.Enabled = true;
                    LWImage3.Visible = true;
                    LWCandidate3.Enabled = true;
                    LWCandidate3.Visible = true;
                    LWLabel3.Text = name3;
                    LWImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                LWLabel3.Enabled = false;
                LWLabel3.Visible = false;
                LWImage3.Enabled = false;
                LWImage3.Visible = false;
                LWCandidate3.Enabled = false;
                LWCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Hall_Rep_DLWTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    LWLabel4.Enabled = true;
                    LWLabel4.Visible = true;
                    LWImage4.Enabled = true;
                    LWImage4.Visible = true;
                    LWCandidate4.Enabled = true;
                    LWCandidate4.Visible = true;
                    LWLabel4.Text = name4;
                    LWImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                LWLabel4.Enabled = false;
                LWLabel4.Visible = false;
                LWImage4.Enabled = false;
                LWImage4.Visible = false;
                LWCandidate4.Enabled = false;
                LWCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Hall_Rep_DLWTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    LWLabel5.Enabled = true;
                    LWLabel5.Visible = true;
                    LWImage5.Enabled = true;
                    LWImage5.Visible = true;
                    LWCandidate5.Enabled = true;
                    LWCandidate5.Visible = true;
                    LWLabel5.Text = name5;
                    LWImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                LWLabel5.Enabled = false;
                LWLabel5.Visible = false;
                LWImage5.Enabled = false;
                LWImage5.Visible = false;
                LWCandidate5.Enabled = false;
                LWCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }

        public void getUFHCandidates()
        {
            UFHLabel1.Enabled = false;
            UFHLabel1.Visible = false;
            UFHImage1.Enabled = false;
            UFHImage1.Visible = false;
            UFHCandidate1.Enabled = false;
            UFHCandidate1.Visible = false;
            UFHLabel2.Enabled = false;
            UFHLabel2.Visible = false;
            UFHImage2.Enabled = false;
            UFHImage2.Visible = false;
            UFHCandidate2.Enabled = false;
            UFHCandidate2.Visible = false;
            UFHLabel3.Enabled = false;
            UFHLabel3.Visible = false;
            UFHImage3.Enabled = false;
            UFHImage3.Visible = false;
            UFHCandidate3.Enabled = false;
            UFHCandidate3.Visible = false;
            UFHLabel4.Enabled = false;
            UFHLabel4.Visible = false;
            UFHImage4.Enabled = false;
            UFHImage4.Visible = false;
            UFHCandidate4.Enabled = false;
            UFHCandidate4.Visible = false;
            UFHLabel5.Enabled = false;
            UFHLabel5.Visible = false;
            UFHImage5.Enabled = false;
            UFHImage5.Visible = false;
            UFHCandidate5.Enabled = false;
            UFHCandidate5.Visible = false;



            //get first Candidate
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql = "select CandidateName,ImagePath from Hall_Rep_DLWTable where ID = '1'";
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
                    string ImagePath = reader["ImagePath"].ToString();
                    UFHLabel1.Enabled = true;
                    UFHLabel1.Visible = true;
                    UFHImage1.Enabled = true;
                    UFHImage1.Visible = true;
                    UFHCandidate1.Enabled = true;
                    UFHCandidate1.Visible = true;
                    UFHLabel1.Text = name;
                    UFHImage1.ImageUrl = ImagePath;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 1')</script>");
                UFHLabel1.Enabled = false;
                UFHLabel1.Visible = false;
                UFHImage1.Enabled = false;
                UFHImage1.Visible = false;
                UFHCandidate1.Enabled = false;
                UFHCandidate1.Visible = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get Second Candidate
            string sql2, connstring2;
            connstring2 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql2 = "select CandidateName,ImagePath from Hall_Rep_UFHTable where ID = '2'";
            SqlConnection conn2 = new SqlConnection(connstring2);
            SqlCommand cmd2 = new SqlCommand(sql2, conn2);
            SqlDataReader reader2;
            try
            {
                conn2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string name2 = reader2["CandidateName"].ToString();
                    string ImagePath2 = reader2["ImagePath"].ToString();
                    UFHLabel2.Enabled = true;
                    UFHLabel2.Visible = true;
                    UFHImage2.Enabled = true;
                    UFHImage2.Visible = true;
                    UFHCandidate2.Enabled = true;
                    UFHCandidate2.Visible = true;
                    UFHLabel2.Text = name2;
                    UFHImage2.ImageUrl = ImagePath2;
                }
                reader2.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 2')</script>");
                UFHLabel2.Enabled = false;
                UFHLabel2.Visible = false;
                UFHImage2.Enabled = false;
                UFHImage2.Visible = false;
                UFHCandidate2.Enabled = false;
                UFHCandidate2.Visible = false;
            }
            finally
            {
                if (conn2.State == System.Data.ConnectionState.Open)
                {
                    conn2.Close();
                }
            }

            //get third Candidate
            string sql3, connstring3;
            connstring3 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql3 = "select CandidateName,ImagePath from Hall_Rep_UFHTable where ID = '3'";
            SqlConnection conn3 = new SqlConnection(connstring3);
            SqlCommand cmd3 = new SqlCommand(sql3, conn3);
            SqlDataReader reader3;
            try
            {
                conn3.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    string name3 = reader3["CandidateName"].ToString();
                    string ImagePath3 = reader3["ImagePath"].ToString();
                    UFHLabel3.Enabled = true;
                    UFHLabel3.Visible = true;
                    UFHImage3.Enabled = true;
                    UFHImage3.Visible = true;
                    UFHCandidate3.Enabled = true;
                    UFHCandidate3.Visible = true;
                    UFHLabel3.Text = name3;
                    UFHImage3.ImageUrl = ImagePath3;
                }
                reader3.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 3')</script>");
                UFHLabel3.Enabled = false;
                UFHLabel3.Visible = false;
                UFHImage3.Enabled = false;
                UFHImage3.Visible = false;
                UFHCandidate3.Enabled = false;
                UFHCandidate3.Visible = false;
            }
            finally
            {
                if (conn3.State == System.Data.ConnectionState.Open)
                {
                    conn3.Close();
                }
            }

            //get Fourth Candidate
            string sql4, connstring4;
            connstring4 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql4 = "select CandidateName,ImagePath from Hall_Rep_UFHTable where ID = '4'";
            SqlConnection conn4 = new SqlConnection(connstring4);
            SqlCommand cmd4 = new SqlCommand(sql4, conn4);
            SqlDataReader reader4;
            try
            {
                conn4.Open();
                reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    string name4 = reader4["CandidateName"].ToString();
                    string ImagePath4 = reader4["ImagePath"].ToString();
                    UFHLabel4.Enabled = true;
                    UFHLabel4.Visible = true;
                    UFHImage4.Enabled = true;
                    UFHImage4.Visible = true;
                    UFHCandidate4.Enabled = true;
                    UFHCandidate4.Visible = true;
                    UFHLabel4.Text = name4;
                    UFHImage4.ImageUrl = ImagePath4;
                }
                reader4.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                UFHLabel4.Enabled = false;
                UFHLabel4.Visible = false;
                UFHImage4.Enabled = false;
                UFHImage4.Visible = false;
                UFHCandidate4.Enabled = false;
                UFHCandidate4.Visible = false;
            }
            finally
            {
                if (conn4.State == System.Data.ConnectionState.Open)
                {
                    conn4.Close();
                }
            }

            //get Fifth Candidate
            string sql5, connstring5;
            connstring5 = "Integrated Security=SSPI;Initial Catalog=" + Session["electionname"] + ";Data Source=enunwah-pc\\sqlexpress;";

            sql5 = "select CandidateName,ImagePath from Hall_Rep_UFHTable where ID = '5'";
            SqlConnection conn5 = new SqlConnection(connstring5);
            SqlCommand cmd5 = new SqlCommand(sql5, conn5);
            SqlDataReader reader5;
            try
            {
                conn5.Open();
                reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    string name5 = reader5["CandidateName"].ToString();
                    string ImagePath5 = reader5["ImagePath"].ToString();
                    UFHLabel5.Enabled = true;
                    UFHLabel5.Visible = true;
                    UFHImage5.Enabled = true;
                    UFHImage5.Visible = true;
                    UFHCandidate5.Enabled = true;
                    UFHCandidate5.Visible = true;
                    UFHLabel5.Text = name5;
                    UFHImage5.ImageUrl = ImagePath5;
                }
                reader5.Close();
            }
            catch (Exception e)
            {
                //Response.Write("<script LANGUAGE= Javascript>alert('Issues Loading Presidential Candidate 4')</script>");
                UFHLabel5.Enabled = false;
                UFHLabel5.Visible = false;
                UFHImage5.Enabled = false;
                UFHImage5.Visible = false;
                UFHCandidate5.Enabled = false;
                UFHCandidate5.Visible = false;
            }
            finally
            {
                if (conn5.State == System.Data.ConnectionState.Open)
                {
                    conn5.Close();
                }
            }
        }


    }
}
