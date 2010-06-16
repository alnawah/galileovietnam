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
using ShipBooking.Controls;
using ShipBooking.Library;
using System.Drawing;

namespace ShipBooking
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            lblMsg.ForeColor = Color.Red;
            if (LoginControl.bLogin == false)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                LinkButton lbtnThoat = (LinkButton)Master.FindControl("lbtnDangNhap");
                lbtnThoat.Text = "Thoát";
            }
        }

        protected void ChangePasswordPushButton_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            lblMsg.ForeColor = Color.Red;
            if (CheckPassword() == false)
            {
                lblMsg.Text = "Mật khẩu không đúng!";
                return;
            }
            else
            {
                string cmd = "UPDATE tblUser SET UserName = 'Admin', Password ='" + ChangePassword1.NewPassword + "' WHERE UserName = 'Admin'";
                ExecuteDataUtilities.ExecuteData(cmd);
                lblMsg.Text = "Bạn đã thay đổi mật khẩu thành công!";
                lblMsg.ForeColor = Color.Green;
            }
        }

        protected bool CheckPassword()
        {
            bool isValid = false;
            string cmd = "SELECT *FROM tblUser WHERE UserName='Admin' AND Password='" + ChangePassword1.CurrentPassword + "'";
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
    }
}
