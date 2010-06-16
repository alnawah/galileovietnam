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
using ShipBooking.Module;
using System.Collections.Generic;
using System.Drawing;

namespace ShipBooking.Controls
{
    public partial class BookingStep1Control : System.Web.UI.UserControl
    {
        string loaichuyen;
        string noidi;
        string noiden;
        string ngaydi;
        string ngayve;
        string machang;
        string MaHanhTrinh;
        HanhTrinh hanhtrinh = new HanhTrinh();

        string[] ListSoGhe = new string[9];
        protected void Page_Load(object sender, EventArgs e)
        {
            loaichuyen = Request.QueryString["LoaiChuyen"];
            noidi = Request.QueryString["NoiDi"];
            noiden = Request.QueryString["NoiDen"];
            ngaydi = Request.QueryString["NgayDi"];
            ngayve = Request.QueryString["NgayVe"];
            machang = Request.QueryString["MaChang"];
            MaHanhTrinh = Request.QueryString["MaHanhTrinh"];
            hanhtrinh = HanhTrinhDB.GetInfo(MaHanhTrinh);

            if (!IsPostBack)
            {
                lblMsg.Text = "";
                FillDataToDdlLoaiVe();
                ResetCheckBoxListSoGhe();
                FillBookingData();
                FillTinhTrangVe();
                FillCheckBoxListSoGhe();
            }
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

        protected void FillBookingData()
        {
            lblLoaiHanhTrinh.Text = loaichuyen;
            lblNoiDi.Text = noidi;
            lblNoiDen.Text = noiden;
            lblNgayKhoiHanh.Text = ngaydi;
            if (loaichuyen == "Khứ hồi")
            {
                lblNgayVeLabel.Visible = true;
                lblNgayVe.Visible = true;
                lblNgayVe.Text = ngayve;
            }
            else
            {
                lblNgayVeLabel.Visible = false;
                lblNgayVe.Visible = false;
            }
            if (hanhtrinh != null)
            {
                lblGioKhoiHanh.Text = hanhtrinh.GioKhoiHanh.ToShortTimeString();
                lblGioDen.Text = hanhtrinh.GioDen.ToShortTimeString();
            }
        }

        protected void FillCheckBoxListSoGhe()
        {
            int nSoGhe = 0;
            ListItem item;
            List<HanhKhach> HKList = new List<HanhKhach>();
            HKList = HanhKhachDB.GetListHangKhachByHanhTrinhAndDate(ngaydi, MaHanhTrinh);
            nSoGhe = Convert.ToInt16(hanhtrinh.SoGhe);
            for (int i = 1; i <= nSoGhe; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                CheckBoxListSoGhe.Items.Add(item);
                item = null;
            }


            //Remove những ghế đã được chọn trong ngày
            int SoGheDaDat = 0;
            for (int i = 1; i <= nSoGhe; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);

                for (int j = 0; j < HKList.Count; j++)
                {
                    SoGheDaDat = Convert.ToInt16(HKList[j].SoGhe.Trim());
                    if (i == SoGheDaDat)
                    {
                        CheckBoxListSoGhe.Items.Remove(item);
                    }
                }
                item = null;
            }
        }

        protected void FillTinhTrangVe()
        {
            List<BookingFile> BFList = new List<BookingFile>();
            BFList = BookingFileDB.GetListBookingFileByDate(ngaydi, MaHanhTrinh);
            ListItem item;

            int count = 0;
            int SoLuongVeConLai = 0;

            switch (ddlLoaiVe.SelectedValue)
            {
                case "HangThuong":
                    {
                        if (loaichuyen == "Khứ hồi")
                        {
                            long giamgia = 0;
                            long giave = 0;
                            try
                            {
                                giave = Convert.ToInt64(hanhtrinh.GiaVeNguoiLon1);
                                giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                            }
                            catch
                            {
                                giamgia = 0;
                            }
                            giave = 2 * giave - giamgia;
                            lblGiaVe.Text = giave.ToString();
                        }
                        else
                        {
                            lblGiaVe.Text = hanhtrinh.GiaVeNguoiLon1 + " VNĐ";
                        }
                        for (int i = 0; i < BFList.Count; i++)
                        {
                            if (BFList[i].LoaiVe.Equals("Hạng thường") == true)
                            {
                                count += Convert.ToInt16(BFList[i].SoVe);
                            }
                        }
                        SoLuongVeConLai = Convert.ToInt16(hanhtrinh.SoLuongVe1);
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
                        }
                    }
                    break;
                case "HangDoanhNhan":
                    {
                        if (loaichuyen == "Khứ hồi")
                        {
                            long giamgia = 0;
                            long giave = 0;
                            try
                            {
                                giave = Convert.ToInt64(hanhtrinh.GiaVeNguoiLon2);
                                giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                            }
                            catch
                            {
                                giamgia = 0;
                            }
                            giave = 2 * giave - giamgia;
                            lblGiaVe.Text = giave.ToString();
                        }
                        else
                        {
                            lblGiaVe.Text = hanhtrinh.GiaVeNguoiLon2 + " VNĐ";
                        }
                        for (int i = 0; i < BFList.Count; i++)
                        {
                            if (BFList[i].LoaiVe.Equals("Hạng doanh nhân") == true)
                            {
                                count += Convert.ToInt16(BFList[i].SoVe);
                            }
                        }
                        SoLuongVeConLai = Convert.ToInt16(hanhtrinh.SoLuongVe2);
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
                        }
                    }
                    break;
                case "HangVIP":
                    {
                        if (loaichuyen == "Khứ hồi")
                        {
                            long giamgia = 0;
                            long giave = 0;
                            try
                            {
                                giave = Convert.ToInt64(hanhtrinh.GiaVeNguoiLon3);
                                giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                            }
                            catch
                            {
                                giamgia = 0;
                            }
                            giave = 2 * giave - giamgia;
                            lblGiaVe.Text = giave.ToString();
                        }
                        else
                        {
                            lblGiaVe.Text = hanhtrinh.GiaVeNguoiLon3 + " VNĐ";
                        }
                        for (int i = 0; i < BFList.Count; i++)
                        {
                            if (BFList[i].LoaiVe.Equals("Hạng VIP") == true)
                            {
                                count += Convert.ToInt16(BFList[i].SoVe);
                            }
                        }
                        SoLuongVeConLai = Convert.ToInt16(hanhtrinh.SoLuongVe3);
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
                        }
                    }
                    break;
                default:
                    break;
            }

            ddlSLVe.Items.Clear();
            for (int i = 1; i <= SoLuongVeConLai; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                ddlSLVe.Items.Add(item);
                item = null;
            }
        }

        protected void ddlLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            FillTinhTrangVe();
        }

        protected void ResetCheckBoxListSoGhe()
        {
            CheckBoxListSoGhe.Items.Clear();
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            if (ddlSLVe.SelectedValue == "")
            {
                lblMsg.Text = "Bạn hãy chọn số lượng vé lớn hơn không";
                return;
            }
            else
            {
                if (CheckSoGhe() == true)
                {
                    GetListSoGhe();

                    string urlValue = "";
                    string urlListSoGhe = "";
                    for (int i = 0; i < Convert.ToInt16(ddlSLVe.SelectedValue); i++)
                    {
                        urlListSoGhe += "SoGhe" + i.ToString() + "=" + ListSoGhe[i] + "&";
                    }

                    urlValue = "LoaiChuyen=" + loaichuyen + "&"
                         + "NoiDi=" + noidi + "&"
                         + "NoiDen=" + noiden + "&"
                         + "NgayDi=" + ngaydi + "&"
                         + "NgayVe=" + ngayve + "&"
                         + "MaChang=" + machang + "&"
                         + "MaHanhTrinh=" + MaHanhTrinh + "&"
                         + "LoaiVe=" + ddlLoaiVe.SelectedItem.Text.Trim() + "&"
                         + urlListSoGhe
                         + "SoVe=" + ddlSLVe.SelectedValue;
                    Response.Redirect("ThongTinKhach.aspx?" + urlValue);
                }
                else
                {
                    return;
                }
            }
        }

        protected bool CheckSoGhe()
        {
            bool isValid = false;
            int sove = 0;
            int soghe = 0;

            if (ddlSLVe.SelectedValue.Trim() != "")
            {
                sove = Convert.ToInt16(ddlSLVe.SelectedValue.Trim());
            }
            for (int i = 0; i < CheckBoxListSoGhe.Items.Count; i++)
            {
                if (CheckBoxListSoGhe.Items[i].Selected == true)
                {
                    soghe += 1;
                }
            }

            if (sove != soghe)
            {
                lblMsg.Text = "Chú ý: Số lượng ghế được chọn phải bằng số lượng vé";
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }

        protected void GetListSoGhe()
        {
            int j = 0;
            for (int i = 0; i < CheckBoxListSoGhe.Items.Count; i++)
            {
                if (CheckBoxListSoGhe.Items[i].Selected == true)
                {
                    ListSoGhe[j] = CheckBoxListSoGhe.Items[i].Text.Trim();
                    j++;
                }
            }
        }
    }
}