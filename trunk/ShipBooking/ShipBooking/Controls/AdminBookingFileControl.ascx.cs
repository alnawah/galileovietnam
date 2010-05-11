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
using System.Web.UI.MobileControls;
using ShipBooking.Module;
using System.Collections.Generic;

namespace ShipBooking.Controls
{
    public partial class AdminBookingFileControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (rblTieuChiTimKiem.SelectedValue == "TenKhach")
            {
                string TenHK = "";
                TenHK = txtKeyword.Text.Trim();
                SearchBFByKhach(TenHK);
            }
            else if (rblTieuChiTimKiem.SelectedValue == "MaBF")
            {

            }
            else
            { 
            }

        }

        protected void calEventDate_SelectionChanged(object sender, EventArgs e)
        {
            txtNgay1.Text = calEventDate.SelectedDate.ToString("d");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgay2.Text = calEventDate.SelectedDate.ToString("d");
        }

        protected void SearchBFByID(string keyword)
        {

        }

        protected void SearchBFByKhach(string keyword)
        {
            List<HanhKhach> HKList = new List<HanhKhach>();
            HKList = HanhKhachDB.GetListHanhKhachByName(keyword);
        }

        protected void SearchBFByNguoiNhan(string keyword)
        {
 
        }
    }
}