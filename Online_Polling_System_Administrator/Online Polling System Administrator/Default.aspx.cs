using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Online_Polling_System_Administrator
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            



        }

        protected void newelectionBtn_Click(object sender, EventArgs e)
        {
            if (Session["firstName"] != null)
            {
                Response.Redirect("~/Manage_elections.aspx");
            }
            else
            {
                Session["ReturnUrl"] = "~/Manage_elections.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void electoralpostBtn_Click(object sender, EventArgs e)
        {
            if (Session["firstName"] != null)
            {
                Response.Redirect("~/Manage_Post.aspx");
            }
            else
            {
                Session["ReturnUrl"] = "~/Manage_Post.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void addcandidateBtn_Click(object sender, EventArgs e)
        {
            if (Session["firstName"] != null)
            {
                Response.Redirect("~/ManageCandidates.aspx");
            }
            else
            {
                Session["ReturnUrl"] = "~/ManageCandidates.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void electionoverviewbtn_Click(object sender, EventArgs e)
        {
            if (Session["firstName"] != null)
            {
                Response.Redirect("~/ElectionOverview.aspx");
            }
            else
            {
                Session["ReturnUrl"] = "~/ElectionOverview.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void newcandidatebtn_Click(object sender, EventArgs e)
        {
            if (Session["firstName"] != null)
            {
                Response.Redirect("~/NewCandidate");
            }
            else
            {
                Session["ReturnUrl"] = "~/NewCandidate.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void newadminbtn_Click(object sender, EventArgs e)
        {
            if (Session["firstName"] != null)
            {
                Response.Redirect("~/Account/Register.aspx");
            }
            else
            {
                Session["ReturnUrl"] = "~/Register.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }
        }
    }
}