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
    public partial class DatVeControl : System.Web.UI.UserControl
    {
        public static BookingFile bf = new BookingFile();
        public static List<HanhKhach> listKhach = new List<HanhKhach>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                InitData();
                ListControlUtilities.FillDataToDropDownList(ddlNoiDi, "tblThanhPho", "Ten", "MaThanhPho");
                ListControlUtilities.FillCityData(ddlNoiDen, ddlNoiDi.SelectedValue);
                FillDataToDdlThoiGian();
                FillDataToRdbLoaiHanhTrinh();
                FillDataToDdlLoaiVe();
                FillDataToRdbSoGhe();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            bool isValidDate = false;
            isValidDate = CheckDateNgayDi();
            if (isValidDate == false)
            {
                txtNgayDi.Text = "";
                txtNgayDi.Focus();
                return;
            }
            else
            {
                if (rblLoaiHanhTrinh.SelectedValue == "KhuHoi")
                {
                    if (CheckDateNgayVe() == false)
                    {
                        txtNgayVe.Text = "";
                        txtNgayVe.Focus();
                        return;
                    }
                    else
                    {
                        GetBookingData();
                        Response.Redirect("ThongTinKhach.aspx");
                    }
                }
                else 
                {
                    GetBookingData();
                    Response.Redirect("ThongTinKhach.aspx");
                }
            }
        }

        protected void FillDataToDdlThoiGian()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Buổi sáng";
            item.Value = "Sang";
            ddlThoiGian.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Buổi chiều";
            item.Value = "Chieu";
            ddlThoiGian.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Buổi tối";
            item.Value = "Toi";
            ddlThoiGian.Items.Add(item);
            item = null;
        }

        protected void FillDataToDdlLoaiVe()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Hạng thường";
            item.Value = "HangThuong";
            ddlLoaiVe.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Hạng doanh nhân";
            item.Value = "HangDoanhNhan";
            ddlLoaiVe.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Hạng VIP";
            item.Value = "HangVIP";
            ddlLoaiVe.Items.Add(item);
            item = null;
        }

        protected void FillDataToRdbLoaiHanhTrinh()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Một lượt";
            item.Value = "MotLuot";
            rblLoaiHanhTrinh.Items.Add(item);
            item = null;
            
            item = new ListItem();
            item.Text = "Khứ hồi";
            item.Value = "KhuHoi";
            rblLoaiHanhTrinh.Items.Add(item);
            item = null;

            rblLoaiHanhTrinh.SelectedIndex = 0;
        }

        protected string GetHanhTrinh()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            return strHanhTrinh.Trim();
        }

        protected void FillDataToRdbSoGhe()
        {
            ListItem item;
            string strHanhTrinh = GetHanhTrinh();

            TinhTrangChuyen HanhTrinhInfo = new TinhTrangChuyen();
            HanhTrinhInfo = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            //Điền tất cả các ghế trên chuyến tàu
            if (HanhTrinhInfo != null)
            {
                Tau tau = new Tau();
                tau = TauDB.GetInfo(HanhTrinhInfo.MaSoTau.Trim());
                int SoGhe = 0;
                if (tau != null)
                {
                    SoGhe = Convert.ToInt16(tau.SoGhe);
                }
                for (int i = 1; i <= SoGhe; i++)
                {
                    item = new ListItem();
                    item.Text = Convert.ToString(i);
                    item.Value = Convert.ToString(i);
                    rdbSoGhe.Items.Add(item);
                    item = null;
                }

                //Remove những ghế đã được chọn trong ngày
                List<BookingFile> BFList = new List<BookingFile>();
                BFList = BookingFileDB.GetListBookingFileByDate(txtNgayDi.Text.Trim(), strHanhTrinh);
                int SoGheDatDat = 0;
                for (int i = 1; i <= SoGhe; i++)
                {
                    item = new ListItem();
                    item.Text = Convert.ToString(i);
                    item.Value = Convert.ToString(i);

                    for (int j = 0; j < BFList.Count; j++)
                    {
                        SoGheDatDat = Convert.ToInt16(BFList[j].SoGhe.Trim());
                        if (i == SoGheDatDat)
                        {
                            rdbSoGhe.Items.Remove(item);
                        }
                    }
                    item = null;
                }
            }
        }

        protected void GetBookingData()
        {
            bf.LoaiChuyen = rblLoaiHanhTrinh.SelectedItem.Text;
            bf.NoiDi = ddlNoiDi.SelectedItem.Text;
            bf.NoiDen = ddlNoiDen.SelectedItem.Text;
            bf.NgayDi = DateTime.Parse(txtNgayDi.Text.Trim());
            if (rblLoaiHanhTrinh.SelectedValue == "KhuHoi")
            {
                if (CheckDateNgayVe() == true)
                {
                    bf.NgayVe = DateTime.Parse(txtNgayVe.Text.Trim());
                }
                else
                {
                    return;
                }
            }
            else
            {
                bf.NgayVe = DateTime.Parse(txtNgayDi.Text.Trim());
            }
            
            bf.ThoiGian = ddlThoiGian.SelectedItem.Text;
            if (chkOpen.Checked == true)
            {
                bf.OpenChecking = true;
            }
            else
            {
                bf.OpenChecking = false;
            }
            bf.LoaiVe = ddlLoaiVe.SelectedItem.Text;
            if (rdbSoGhe.SelectedItem != null)
            {
                bf.SoGhe = rdbSoGhe.SelectedItem.Text;
            }
            else
            {
                bf.SoGhe = "";
            }

            string strHanhTrinh = GetHanhTrinh();

            TinhTrangChuyen obj = new TinhTrangChuyen();
            obj = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            if (ddlLoaiVe.SelectedValue == "HangThuong")
            {
                bf.GiaTien = obj.GiaVe1;
            }
            else if (ddlLoaiVe.SelectedValue == "HangDoanhNhan")
            {
                bf.GiaTien = obj.GiaVe2;
            }
            else
            {
                bf.GiaTien = obj.GiaVe3;
            }

            bf.HanhTrinh = strHanhTrinh;
        }

        protected void InitData()
        {
            rblLoaiHanhTrinh.SelectedIndex = 0;
            txtNgayDi.Text = "";
            txtNgayVe.Text = "";
            lblMsg.Text = "";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void calEventDate_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayDi.Text = calEventDate.SelectedDate.ToString("d");
            ResetRdbSoGhe();
            FillDataToRdbSoGhe();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayVe.Text = Calendar1.SelectedDate.ToString("d");
        }

        protected void rblLoaiHanhTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblLoaiHanhTrinh.SelectedValue == "KhuHoi")
            {
                lblNgayVe.Visible = true;
                txtNgayVe.Visible = true;
                lblDateFormat.Visible = true;
                chkOpen.Visible = true;
                imgCalendar2.Visible = true;
            }
            else
            {
                lblNgayVe.Visible = false;
                txtNgayVe.Visible = false;
                lblDateFormat.Visible = false;
                chkOpen.Visible = false;
                imgCalendar2.Visible = false;
            }
        }

        protected void ddlNoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListControlUtilities.FillCityData(ddlNoiDen, ddlNoiDi.SelectedValue);
        }

        protected void ddlNoiDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRdbSoGhe();
            FillDataToRdbSoGhe();
        }

        protected void ResetRdbSoGhe()
        {
            rdbSoGhe.Items.Clear();
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

        protected bool CheckDateNgayVe()
        {
            bool isValid = false;

            string strDate = txtNgayVe.Text.Trim();
            try
            {
                DateTime dt = DateTime.Parse(strDate);
                if (dt < DateTime.Parse(txtNgayDi.Text.Trim()))
                {
                    lblMsg.Text = "Ngày về phải sau ngày đi";
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
    }
}