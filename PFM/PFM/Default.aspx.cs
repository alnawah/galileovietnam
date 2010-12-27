using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PFM
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Pages/LoginPage.aspx");
            }
            else if (Session["user"] == "admin")
            {
                Response.Redirect("~/Pages/Main.aspx");
            }
        }
    }
}
