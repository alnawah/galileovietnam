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
    public partial class ThongTinHanhTrinhControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListControlUtilities.FillDataToDropDownList(ddlNoiDi, "tblThanhPho", "Ten", "MaThanhPho");
                ListControlUtilities.FillCityData(ddlNoiDen, ddlNoiDi.SelectedValue);
            }
        }

        protected void calEventDate_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayDi.Text = calEventDate.SelectedDate.ToString("d");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayVe.Text = Calendar1.SelectedDate.ToString("d");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckDateNgayDi() == false)
            {
                txtNgayDi.Text = "";
                txtNgayDi.Focus();
                return;
            }
            else
            {
                lblMsg.Text = "";
            }
        }

        protected void ddlNoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListControlUtilities.FillCityData(ddlNoiDen, ddlNoiDi.SelectedValue);
        }

        protected bool CheckDateNgayDi()
        {
            bool isValid = false;

            string strDate = txtNgayDi.Text.Trim();
            try
            {
                DateTime dt = DateTime.Parse(strDate);
                if (dt < DateTime.Now.Date)
                {
                    lblMsg.Text = "Bạn không được nhập ngày trước ngày hiện tại";
                }
                else
                {
                    isValid = true;
                }
            }
            catch
            {
                lblMsg.Text = "Ngày không hợp lệ";
                isValid = false;
            }

            return isValid;
        }

        protected void SearchHanhTrinh(string MaTPDi, string MaTPDen, string ngay)
        {
 
        }
    }
}