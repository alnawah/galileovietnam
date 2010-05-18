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

namespace ShipBooking
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Image3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/DatVe.aspx");
        }

        protected void imgbtnXemLichChuyen_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ThongTinHanhTrinh.aspx");
        }

        protected void imgbtnTinhTrangCho_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("http://www.galileo.com.vn/");
        }

        protected void imgbtnBangGiaVe_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("http://dantri.com.vn/");
        }
    }
}
