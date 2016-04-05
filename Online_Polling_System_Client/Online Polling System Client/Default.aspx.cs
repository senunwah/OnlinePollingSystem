using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Polling_System_Client
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void SignUpbutton_Click(object sender, EventArgs e)
        {
            if ( Session["firstname"] != null)
            {
                Response.Write("<script LANGUAGE = Javascript >alert('You are already Logged In')</script>");
            }
            else if( Session["firstname"] == null)
            {
                Response.Redirect("~/Account/Register.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void pollbtn_Click(object sender, EventArgs e)
        {
            if (Session["firstname"] != null)
            {
                Response.Redirect("PollingBooth.aspx");
            }
            else if (Session["firstname"] == null)
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void applybtn_Click(object sender, EventArgs e)
        {
            if (Session["firstname"] != null)
            {
                Response.Redirect("OTPIN.aspx");
            }
            else if (Session["firstname"] == null)
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }
    }
}