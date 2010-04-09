using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using System.Web.DataAccess;
using System.Drawing;

namespace QuickSurvey
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            
        }

        protected void reset()
        {   
            txtHoten.Text = "";
            txtIdTruyCap.Text = "";
            txtNgaySinh.Text = "";
            txtPPC.Text = "";
            txtTenCongTy.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtSoThich.Text = "";

            txt_HoiThao_YKienKhac.Text = "";
            txt_KhuyenMai_YKienKhac.Text = "";
            txt_SinhHoat_YKienKhac.Text = "";
            txt_ThoiGian_YKienKhac.Text = "";
            txt_YKienRieng.Text = "";
        }

        protected void resetMaso()
        {
            lblMsg.Visible = true;
            lblSubmitSuccessMsg.Visible = false;
            lblMaSo.Visible = false;
        }
    }
}
