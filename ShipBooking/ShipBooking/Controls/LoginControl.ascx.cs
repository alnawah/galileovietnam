using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ShipBooking.Controls
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public static bool bLogin = false;

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToLower().Trim() == "admin" && txtPassword.Text == "admin")
            {
                bLogin = true;
                Response.Redirect("Admin.aspx");
            }
            else
            {
                lblMsg.Text = "Bạn đăng nhập không thành công, xin thử lại.";
                bLogin = false;
            }
        }

        protected void InitData()
        {
            lblMsg.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}