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
using ShipBooking.Module;
using System.Collections.Generic;

namespace ShipBooking.Controls
{
    public partial class ThongTinHanhTrinhControl : System.Web.UI.UserControl
    {
        public static BookingFile bf = new BookingFile();
        public static List<HanhKhach> listKhach = new List<HanhKhach>();
        public static string gMachang = "";
        public static string gNgaytrongtuan = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rblLoaiHanhTrinh.SelectedIndex = 0;
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
                GetBookingFile();
                SearchHanhTrinh();
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

        protected void SearchHanhTrinh()
        {
            gMachang = GetMaChang();
            gNgaytrongtuan = GetNgayTrongTuan(DateTime.Parse(txtNgayDi.Text.Trim()));
            if (gMachang != "")
            {
                Response.Redirect("SearchHanhTrinhResult.aspx");
            }
        }

        protected string GetMaChang()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            return strHanhTrinh;
        }

        protected string GetNgayTrongTuan(DateTime dt)
        {
            string ngaytrongtuan = "";

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    {
                        ngaytrongtuan = "Thứ hai";
                    }
                    break;
                case DayOfWeek.Tuesday:
                    {
                        ngaytrongtuan = "Thứ ba";
                    }
                    break;
                case DayOfWeek.Wednesday:
                    {
                        ngaytrongtuan = "Thứ tư";
                    }
                    break;
                case DayOfWeek.Thursday:
                    {
                        ngaytrongtuan = "Thứ năm";
                    }
                    break;
                case DayOfWeek.Friday:
                    {
                        ngaytrongtuan = "Thứ sáu";
                    }
                    break;
                case DayOfWeek.Saturday:
                    {
                        ngaytrongtuan = "Thứ bảy";
                    }
                    break;
                case DayOfWeek.Sunday:
                    {
                        ngaytrongtuan = "Chủ nhật";
                    }
                    break;
                default:
                    break;
            }
            return ngaytrongtuan;
        }

        protected void GetBookingFile()
        {
            //bf.MaBF = "";
            bf.LoaiChuyen = rblLoaiHanhTrinh.SelectedItem.Text;
            bf.NoiDi = ddlNoiDi.SelectedItem.Text.Trim();
            bf.NoiDen = ddlNoiDen.SelectedItem.Text.Trim();
            bf.NgayDi = DateTime.Parse(txtNgayDi.Text.Trim());
            //bf.NgayVe = DateTime.Parse(txtNgayVe.Text.Trim());
            //bf.ThoiGian = "";
            //bf.OpenChecking = true;
            bf.LoaiVe = "";
            bf.SoGhe = "";
            bf.GiaTien = "";
            bf.ThanhToan = "";
            bf.MaNguoiNhan = "";
            bf.HanhTrinh = GetMaChang();
            //bf.GioKhoiHanh = "";
            //bf.GioDen = "";
        }
    }
}