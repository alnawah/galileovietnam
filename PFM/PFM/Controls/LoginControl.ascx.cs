using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PFM.Controls
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserName.Text.Trim().Equals("nqminh") && Password.Text.Trim().Equals("nwcnebuchad"))
            {
                Session["user"] = "admin";
                Response.Redirect("~/Pages/Main.aspx");
            }
            else
            {
                FailureText.Text = "Đăng nhập không đúng. Làm lại đi!";
            }
        }
    }
}