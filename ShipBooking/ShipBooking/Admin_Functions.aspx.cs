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

namespace ShipBooking
{
    public partial class Admin_Functions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void imgbtnQLBooking_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Admin_BookingFile.aspx");
        }

        protected void imgbtnQLHanhtrinh_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Admin_HanhTrinh.aspx");
        }

        protected void imgbtnQLThanhPho_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Admin_ThanhPho.aspx");
        }

        protected void imgbtnQLTauThuy_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Admin_Tau.aspx");
        }
    }
}
