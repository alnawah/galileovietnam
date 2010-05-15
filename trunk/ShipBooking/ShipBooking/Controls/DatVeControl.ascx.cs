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
using System.Drawing;

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
                FillHanhTrinhInfoData();
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

        protected void FillHanhTrinhInfoData()
        {
            ListItem item;
            string strHanhTrinh = GetHanhTrinh();

            TinhTrangChuyen HanhTrinhInfo = new TinhTrangChuyen();
            HanhTrinhInfo = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            List<BookingFile> BFList = new List<BookingFile>();
            BFList = BookingFileDB.GetListBookingFileByDate(txtNgayDi.Text.Trim(), strHanhTrinh);

            if (HanhTrinhInfo != null)
            {
                #region  Điền dữ liệu giờ khởi hành - giờ kết thúc
                if (CheckDateNgayDi() == true)
                {
                    DateTime dt = DateTime.Parse(txtNgayDi.Text.Trim());
                    switch (dt.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            {
                                if (HanhTrinhInfo.GioKhoiHanh_Thu2 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioKhoiHanh.Text = "";
                                    ResetRdbSoGhe();
                                }
                                else
                                {
                                    lblGioKhoiHanh.Text = HanhTrinhInfo.GioKhoiHanh_Thu2.ToShortTimeString();
                                }

                                if (HanhTrinhInfo.GioDen_Thu2 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioDen.Text = "";
                                    ResetRdbSoGhe();
                                    return;
                                }
                                else 
                                {
                                    lblGioDen.Text = HanhTrinhInfo.GioDen_Thu2.ToShortTimeString();
                                }
                            }
                            break;
                        case DayOfWeek.Tuesday:
                            {
                                if (HanhTrinhInfo.GioKhoiHanh_Thu3 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioKhoiHanh.Text = "";
                                    ResetRdbSoGhe();
                                }
                                else
                                {
                                    lblGioKhoiHanh.Text = HanhTrinhInfo.GioKhoiHanh_Thu3.ToShortTimeString();
                                }

                                if (HanhTrinhInfo.GioDen_Thu3 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioDen.Text = "";
                                    ResetRdbSoGhe();
                                    return;
                                }
                                else
                                {
                                    lblGioDen.Text = HanhTrinhInfo.GioDen_Thu3.ToShortTimeString();
                                }
                            }
                            break;
                        case DayOfWeek.Wednesday:
                            {
                                if (HanhTrinhInfo.GioKhoiHanh_Thu4 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioKhoiHanh.Text = "";
                                    ResetRdbSoGhe();
                                }
                                else
                                {
                                    lblGioKhoiHanh.Text = HanhTrinhInfo.GioKhoiHanh_Thu4.ToShortTimeString();
                                }

                                if (HanhTrinhInfo.GioDen_Thu4 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioDen.Text = "";
                                    ResetRdbSoGhe();
                                    return;
                                }
                                else
                                {
                                    lblGioDen.Text = HanhTrinhInfo.GioDen_Thu4.ToShortTimeString();
                                }
                            }
                            break;
                        case DayOfWeek.Thursday:
                            {
                                if (HanhTrinhInfo.GioKhoiHanh_Thu5 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioKhoiHanh.Text = "";
                                    ResetRdbSoGhe();
                                }
                                else
                                {
                                    lblGioKhoiHanh.Text = HanhTrinhInfo.GioKhoiHanh_Thu5.ToShortTimeString();
                                }

                                if (HanhTrinhInfo.GioDen_Thu5 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioDen.Text = "";
                                    ResetRdbSoGhe();
                                    return;
                                }
                                else
                                {
                                    lblGioDen.Text = HanhTrinhInfo.GioDen_Thu5.ToShortTimeString();
                                }
                            }
                            break;
                        case DayOfWeek.Friday:
                            {
                                if (HanhTrinhInfo.GioKhoiHanh_Thu6 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioKhoiHanh.Text = "";
                                    ResetRdbSoGhe();
                                }
                                else
                                {
                                    lblGioKhoiHanh.Text = HanhTrinhInfo.GioKhoiHanh_Thu6.ToShortTimeString();
                                }

                                if (HanhTrinhInfo.GioDen_Thu6 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioDen.Text = "";
                                    ResetRdbSoGhe();
                                    return;
                                }
                                else
                                {
                                    lblGioDen.Text = HanhTrinhInfo.GioDen_Thu6.ToShortTimeString();
                                }
                            }
                            break;
                        case DayOfWeek.Saturday:
                            {
                                if (HanhTrinhInfo.GioKhoiHanh_Thu7 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioKhoiHanh.Text = "";
                                    ResetRdbSoGhe();
                                }
                                else
                                {
                                    lblGioKhoiHanh.Text = HanhTrinhInfo.GioKhoiHanh_Thu7.ToShortTimeString();
                                }

                                if (HanhTrinhInfo.GioDen_Thu7 == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioDen.Text = "";
                                    ResetRdbSoGhe();
                                    return;
                                }
                                else
                                {
                                    lblGioDen.Text = HanhTrinhInfo.GioDen_Thu7.ToShortTimeString();
                                }
                            }
                            break;
                        case DayOfWeek.Sunday:
                            {
                                if (HanhTrinhInfo.GioKhoiHanh_ChuNhat == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioKhoiHanh.Text = "";
                                    ResetRdbSoGhe();
                                }
                                else
                                {
                                    lblGioKhoiHanh.Text = HanhTrinhInfo.GioKhoiHanh_ChuNhat.ToShortTimeString();
                                }

                                if (HanhTrinhInfo.GioDen_ChuNhat == DateTime.Parse("1/1/1900 12:00:00 AM"))
                                {
                                    lblGioDen.Text = "";
                                    ResetRdbSoGhe();
                                    return;
                                }
                                else
                                {
                                    lblGioDen.Text = HanhTrinhInfo.GioDen_ChuNhat.ToShortTimeString();
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    ResetRdbSoGhe();
                    lblGioKhoiHanh.Text = "";
                    lblGioDen.Text = "";
                    return;
                }
                #endregion

                #region Điền dữ liệu số lượng vé
                switch (ddlLoaiVe.SelectedValue)
                {
                    case "HangThuong":
                        {
                            int count = 0;
                            int SoLuongVeConLai = 0;
                            lblGiaVe.Text = HanhTrinhInfo.GiaVe1.Trim() + " VNĐ";
                            for (int i = 0; i < BFList.Count; i++)
                            {
                                if (BFList[i].LoaiVe.Equals("Hạng thường") == true)
                                {
                                    count += 1;
                                }
                            }
                            SoLuongVeConLai = Convert.ToInt16(HanhTrinhInfo.SoLuongVe1);
                            SoLuongVeConLai -= count;
                            if (SoLuongVeConLai > 0)
                            {
                                lblSoLuongVe.Text = Convert.ToString(SoLuongVeConLai) + " vé";
                                lblSoLuongVe.ForeColor = Color.Blue;
                            }
                            else
                            {
                                lblSoLuongVe.Text = "Đã hết vé";
                                lblSoLuongVe.ForeColor = Color.Red;
                                return;
                            }
                        }
                        break;
                    case "HangDoanhNhan":
                        {
                            int count = 0;
                            int SoLuongVeConLai = 0;
                            lblGiaVe.Text = HanhTrinhInfo.GiaVe2.Trim() + " VNĐ";
                            for (int i = 0; i < BFList.Count; i++)
                            {
                                if (BFList[i].LoaiVe.Equals("Hạng doanh nhân") == true)
                                {
                                    count += 1;
                                }
                            }
                            SoLuongVeConLai = Convert.ToInt16(HanhTrinhInfo.SoLuongVe2);
                            SoLuongVeConLai -= count;
                            if (SoLuongVeConLai > 0)
                            {
                                lblSoLuongVe.Text = Convert.ToString(SoLuongVeConLai) + " vé";
                                lblSoLuongVe.ForeColor = Color.Blue;
                            }
                            else
                            {
                                lblSoLuongVe.Text = "Đã hết vé";
                                lblSoLuongVe.ForeColor = Color.Red;
                                return;
                            }
                        }
                        break;
                    case "HangVIP":
                        {
                            int count = 0;
                            int SoLuongVeConLai = 0;
                            lblGiaVe.Text = HanhTrinhInfo.GiaVe3.Trim() + " VNĐ";
                            for (int i = 0; i < BFList.Count; i++)
                            {
                                if (BFList[i].LoaiVe.Equals("Hạng VIP") == true)
                                {
                                    count += 1;
                                }
                            }
                            SoLuongVeConLai = Convert.ToInt16(HanhTrinhInfo.SoLuongVe3);
                            SoLuongVeConLai -= count;
                            if (SoLuongVeConLai > 0)
                            {
                                lblSoLuongVe.Text = Convert.ToString(SoLuongVeConLai) + " vé";
                                lblSoLuongVe.ForeColor = Color.Blue;
                            }
                            else
                            {
                                lblSoLuongVe.Text = "Đã hết vé";
                                lblSoLuongVe.ForeColor = Color.Red;
                                return;
                            }
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                #region Điền tất cả các ghế trên chuyến tàu
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
                int SoGheDaDat = 0;
                for (int i = 1; i <= SoGhe; i++)
                {
                    item = new ListItem();
                    item.Text = Convert.ToString(i);
                    item.Value = Convert.ToString(i);

                    for (int j = 0; j < BFList.Count; j++)
                    {
                        SoGheDaDat = Convert.ToInt16(BFList[j].SoGhe.Trim());
                        if (i == SoGheDaDat)
                        {
                            rdbSoGhe.Items.Remove(item);
                        }
                    }
                    item = null;
                }
                #endregion  
            }
                
            lblMsg.Text = "";
        }

        protected void GetBookingData()
        {
            bf.LoaiChuyen = rblLoaiHanhTrinh.SelectedItem.Text;
            if (ddlNoiDen.Items.Count > 0)
            {
                bf.NoiDi = ddlNoiDi.SelectedItem.Text;
            }
            else
            {
                return;
            }
            if (ddlNoiDi.Items.Count > 0)
            {
                bf.NoiDen = ddlNoiDen.SelectedItem.Text;
            }
            else
            {
                return;
            }
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
            lblMsg.Text = "";
            lblSoLuongVe.Text = "";
            lblGioKhoiHanh.Text = "";
            lblGioDen.Text = "";
            lblGiaVe.Text = "";
        }

        protected void calEventDate_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayDi.Text = calEventDate.SelectedDate.ToString("d");
            InitData();
            ResetRdbSoGhe();
            FillHanhTrinhInfoData();
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
                //chkOpen.Visible = true;
                imgCalendar2.Visible = true;
            }
            else
            {
                lblNgayVe.Visible = false;
                txtNgayVe.Visible = false;
                //chkOpen.Visible = false;
                imgCalendar2.Visible = false;
            }
        }

        protected void ddlNoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListControlUtilities.FillCityData(ddlNoiDen, ddlNoiDi.SelectedValue);
            InitData();
            ResetRdbSoGhe();
            FillHanhTrinhInfoData();
        }

        protected void ddlNoiDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitData();
            ResetRdbSoGhe();
            FillHanhTrinhInfoData();
        }

        protected void ResetRdbSoGhe()
        {
            lblMsg.Text = "";
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

        protected void ddlLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitData();
            ResetRdbSoGhe();
            FillHanhTrinhInfoData();
        }

        protected void btnContinue_Click(object sender, EventArgs e)
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
                        if (rdbSoGhe.Items.Count > 0)
                        {
                            if (bf.SoGhe == "0" || bf.SoGhe == null || bf.SoGhe == "")
                            {
                                lblMsg.Text = "Bạn phải chọn số ghế";
                            }
                            else
                            {
                                bf.GioKhoiHanh = DateTime.Parse(lblGioKhoiHanh.Text.Trim());
                                bf.GioDen = DateTime.Parse(lblGioDen.Text.Trim());
                                Response.Redirect("ThongTinKhach.aspx");
                            }
                        }
                        else
                        {
                            if (bf.SoGhe == "0" || bf.SoGhe == null || bf.SoGhe == "")
                            {
                                lblMsg.Text = "Không thể tạo hành trình";
                            }
                            else
                            {
                                bf.GioKhoiHanh = DateTime.Parse(lblGioKhoiHanh.Text.Trim());
                                bf.GioDen = DateTime.Parse(lblGioDen.Text.Trim());
                                Response.Redirect("ThongTinKhach.aspx");
                            }
                        }
                    }
                }
                else
                {
                    GetBookingData();
                    if (rdbSoGhe.Items.Count > 0)
                    {
                        if (bf.SoGhe == "0" || bf.SoGhe == null || bf.SoGhe == "")
                        {
                            lblMsg.Text = "Bạn phải chọn số ghế";
                        }
                        else
                        {
                            bf.GioKhoiHanh = DateTime.Parse(lblGioKhoiHanh.Text.Trim());
                            bf.GioDen = DateTime.Parse(lblGioDen.Text.Trim());
                            Response.Redirect("ThongTinKhach.aspx");
                        }
                    }
                    else
                    {
                        if (bf.SoGhe == "0" || bf.SoGhe == null || bf.SoGhe == "")
                        {
                            lblMsg.Text = "Không thể tạo hành trình";
                        }
                        else
                        {
                            bf.GioKhoiHanh = DateTime.Parse(lblGioKhoiHanh.Text.Trim());
                            bf.GioDen = DateTime.Parse(lblGioDen.Text.Trim());
                            Response.Redirect("ThongTinKhach.aspx");
                        }
                    }
                }
            }
        }
    }
}