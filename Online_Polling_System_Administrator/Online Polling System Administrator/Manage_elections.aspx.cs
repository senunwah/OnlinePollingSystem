using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Polling_System_Administrator
{
    public partial class Manage_elections : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstname"] == null)
            {
                Session["ReturnUrl"] = "~/Manage_elections";
                Response.Redirect("~/Account/Login.aspx");
            }

            string sql,connstring;
            string elections = "";
            connstring = "Integrated Security=SSPI;Initial Catalog=master;Data Source=enunwah-pc\\sqlexpress;";
            sql = "Select name from SYS.databases";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql,conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    elections = reader["name"].ToString();
                    electionCombo.Items.Add(elections);
                    if (elections.ToString().Equals("master") ||
                        elections.ToString().Equals("tempdb") ||
                        elections.ToString().Equals("model") ||
                        elections.ToString().Equals("msdb") ||
                        elections.ToString().Equals("OnlinePollingSystem"))
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
                newelectionBtn.Enabled = false;
                electionTbx.Enabled = false;
                electionCombo.Enabled = false;
                deleteBtn.Enabled = false;
                badstatusLabel.Text = ex + ".........Contact System Administrator";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void newelectionBtn_Click(object sender, EventArgs e)
        {
            string nwelectn = electionTbx.Text;
            string sqlcommand,connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=master;Data Source=enunwah-pc\\sqlexpress;";
            sqlcommand = "create database "+nwelectn+"";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                electionTbx.Text = "";
                goodstatusLabel.Text = "Database Created Successfully";
                Response.Write("<script LANGUAGE= Javascript >alert('Your Election " + nwelectn + " has been created successfully')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE= Javascript >alert(' '" + nwelectn + "' was not deleted sucessfully')</script>");
                newelectionBtn.Enabled = false;
                electionTbx.Enabled = false;
                electionCombo.Enabled = false;
                deleteBtn.Enabled = false;
                badstatusLabel.Enabled = true;
                badstatusLabel.Text = ex + "..............Contact Administrator!!!";
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
     
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            string sql, connstring;
            string election = "";
            election = electionCombo.Text;
            connstring = "Integrated Security=SSPI;Initial Catalog=master;Data Source=enunwah-pc\\sqlexpress;";
            sql = "drop database "+election+"";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                goodstatusLabel.Text = "Database deleted Successfully";
                electionCombo.Items.Remove(election);
                Response.Write("<script LANGUAGE= Javascript >alert('Election '" + election + "' has been deleted Successfully')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE= Javascript >alert('Election was not deleted Successfully')</script>");
                newelectionBtn.Enabled = false;
                electionTbx.Enabled = false;
                electionCombo.Enabled = false;
                deleteBtn.Enabled = false;
                badstatusLabel.Text = ex + ".........Contact System Administrator";
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