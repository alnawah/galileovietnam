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
        string MaBF;
        protected void Page_Load(object sender, EventArgs e)
        {
            MaBF = Request.QueryString["MaBF"];
            if (!IsPostBack)
            {
                lblMaBF.Text = MaBF;
                ReleaseData();
            }
        }

        protected void ReleaseData()
        {
           
        }
    }
}
