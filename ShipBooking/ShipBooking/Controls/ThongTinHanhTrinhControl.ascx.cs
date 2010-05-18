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
    public partial class ThongTinHanhTrinhControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calEventDate_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayDi.Text = calEventDate.SelectedDate.ToString("d");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayVe.Text = Calendar1.SelectedDate.ToString("d");
        }
    }
}