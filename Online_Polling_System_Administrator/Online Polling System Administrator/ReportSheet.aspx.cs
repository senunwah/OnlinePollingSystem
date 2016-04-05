using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Polling_System_Administrator
{
    public partial class ReportSheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstname"] == null)
            {
                Session["ReturnUrl"] = "~/ReportSheet.aspx";
                Response.Redirect("~/Account/Login.aspx");
            }

        }
    }
}