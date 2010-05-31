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
    public partial class KetThucBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMaBF.Text = ThongTinHanhTrinhControl.bf.MaBF.ToUpper().Trim();
                ReleaseData();
            }
        }

        protected void ReleaseData()
        {
            ThongTinHanhTrinhControl.bf = null;
            ThongTinHanhTrinhControl.gMachang = null;
            ThongTinHanhTrinhControl.gNgaytrongtuan = null;
            ThongTinHanhTrinhControl.listKhach = null;
            SearchHanhTrinhResultControl.hanhtrinh = null;
        }
    }
}
