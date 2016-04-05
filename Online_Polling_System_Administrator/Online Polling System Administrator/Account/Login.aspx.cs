using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Online_Polling_System_Administrator.Models;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.Web.Routing;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Online_Polling_System_Administrator.Account
{
    public partial class Login : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }

           

        }


        protected void LogIn_Authenticate(object sender, AuthenticateEventArgs e)
        {

            

        }

        protected void LogIn(object sender, EventArgs e)
        {
            string sql, connstring;
            connstring = "Integrated Security=SSPI;Initial Catalog=OnlinePollingSystem;Data Source=enunwah-pc\\sqlexpress;";
            sql = "select * from adminauthtable where username = '"+Email.Text+"' and password = '"+Password.Text+"'";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            string sql2 = "update adminauthtable SET loginstatus = 'true' WHERE username = '" + Email.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string dbusername = reader["username"].ToString();
                    string dbpassword = reader["password"].ToString();
                    string dbloginstatus = reader["loginstatus"].ToString();
                    if ((Email.Text == dbusername) && (Password.Text == dbpassword) && (dbloginstatus == "false"))
                    {
                        Session["firstName"] = Email.Text;
                        //cmd2.ExecuteNonQuery();
                        //Response.Write("<script Language=JAVASCRIPT>alert('" + Email.Text + "')</script>");
                        LoggedIn();
                    }
                    else if((Email.Text != dbusername) || (Password.Text != dbpassword))
                    {
                        Response.Write("<script LANGUAGE = Javascript >alert('Incorrect Password & or Username')</script>");
                    }
                    else if ((dbusername == "true"))
                    {
                        Response.Write("<script LANGUAGE = Javascript >alert('User already Logged In')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script Language=JAVASCRIPT>alert('"+ex+"')</script>");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void LoggedIn()
        {
            
            if (Session["ReturnUrl"] != null)
            {
                Response.Redirect("" + Session["ReturnUrl"] + "");
                //AutoPostBackControl.Page.Response.Redirect(""+Session["ReturnUrl"]+""); 
               
            }
            else if (Session["ReturnUrl"] == null)
            {
                Response.Redirect("~/Default.aspx");   
            }
        }

    }
}