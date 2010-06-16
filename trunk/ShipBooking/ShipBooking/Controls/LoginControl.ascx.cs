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
using ShipBooking.Library;

namespace ShipBooking.Controls
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        public static bool bLogin = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            bLogin = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckPassword() == true)
            {
                bLogin = true;
                Response.Redirect("Admin_Functions.aspx");
            }
            else
            {
                lblMsg.Text = "Bạn đăng nhập không thành công, xin thử lại.";
                bLogin = false;
            }
        }

        protected bool CheckPassword()
        {
            bool isValid = false;
            string cmd = "SELECT *FROM tblUser WHERE UserName='" + txtUserName.Text.Trim() + "' AND Password='" + txtPassword.Text.Trim() + "'";
            DataSet ds = new DataSet();
            ds = ExecuteDataUtilities.FillDataset(cmd);
            if (ds.Tables[0].Rows.Count == 0)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }


        protected void InitData()
        {
            lblMsg.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}