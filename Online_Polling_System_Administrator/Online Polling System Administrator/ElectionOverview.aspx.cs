using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Online_Polling_System_Administrator
{
    public partial class ElectionOverview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstname"] == null)
            {
                Session["ReturnUrl"] = "~/ElectionOverview.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }

            if (IsPostBack)
            {

            }
            else
            {
                electionDrp.Items.Add("--No Election Available--");
                string sql, connstring;
                connstring = connstring = "Integrated Security=SSPI;Initial Catalog=master;Data Source=enunwah-pc\\sqlexpress;";
                sql = "select name from SYS.databases";
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    electionDrp.Items.Clear();
                    electionDrp.Items.Add(".....");
                    while (reader.Read())
                    {
                        string elections = reader["name"].ToString();
                        electionDrp.Items.Add(elections);
                        if (elections.ToString().Equals("master") ||
                            elections.ToString().Equals("tempdb") ||
                            elections.ToString().Equals("model") ||
                            elections.ToString().Equals("msdb") ||
                            elections.ToString().Equals("OnlinePollingSystem"))
                        {
                            electionDrp.Items.Remove("master");
                            electionDrp.Items.Remove("tempdb");
                            electionDrp.Items.Remove("model");
                            electionDrp.Items.Remove("msdb");
                            electionDrp.Items.Remove("OnlinePollingSystem");
                        }
                    }

                }
                catch (Exception ex)
                {
                    badstatusLabel.Text = ex + ".....Contact System Administrator";
                    electionDrp.Enabled = false;
                    electionDrp.Items.Clear();
                    electionDrp.Items.Add("--No Election Available");
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

        protected void finalizebutton_Click(object sender, EventArgs e)
        {
            
            string startdate = startDatecalendar.SelectedDate.ToString();
            string finishdate = finishDatecalendar.SelectedDate.ToString();
            string sql, sql2, sql3, connstring;
            connstring = connstring = "Integrated Security=SSPI;Initial Catalog=OnlinePollingSystem;Data Source=enunwah-pc\\sqlexpress;";
            sql = "if not exists (select * from sys.tables where name = 'liveElection') create table liveElection (dbname VarChar(MAX) NOT NULL, " + " startdate VarChar(50) NOT NULL, " + " finishdate VarChar(50) NOT NULL, )";
            sql2 = "delete from liveElection";
            sql3 = "insert into liveElection (dbname,startdate,finishdate) values('"+electionDrp.Text+"','"+startdate+"','"+finishdate+"')";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                Response.Write("<script LANGUAGE= Javascript >alert('Your Start Date is " + startdate + " and the Finish Date is " + finishdate + ", Your Live Election has been set')</script>");
                goodstatusLabel.Text = "Your Live Election has been Set";
            }
            catch (Exception ex)
            {
                badstatusLabel.Text = ex + ".....Contact System Administrator";
                Response.Write("<script LANGUAGE= Javascript >alert('"+ex+"')</script>");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }
}