using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace UsingSkin_Css
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTheme1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Theme1.aspx");
        }

        protected void btnTheme2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Theme2.aspx");
        }
    }
}
