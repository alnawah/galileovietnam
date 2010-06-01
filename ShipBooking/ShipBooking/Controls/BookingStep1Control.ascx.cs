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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMsg.Text = "";
                FillDataToDdlLoaiVe();
                ResetRdbSoGhe();
                FillBookingData();
                FillTinhTrangVe();
                FillRdbSoGhe();
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
            lblLoaiHanhTrinh.Text = ThongTinHanhTrinhControl.bf.LoaiChuyen.Trim();
            lblNoiDi.Text = ThongTinHanhTrinhControl.bf.NoiDi.Trim();
            lblNoiDen.Text = ThongTinHanhTrinhControl.bf.NoiDen.Trim();
            lblNgayKhoiHanh.Text = ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString();
            if (ThongTinHanhTrinhControl.bf.LoaiChuyen == "Khứ hồi")
            {
                lblNgayVeLabel.Visible = true;
                lblNgayVe.Visible = true;
                lblNgayVe.Text = ThongTinHanhTrinhControl.bf.NgayVe.ToShortDateString();
            }
            else
            {
                lblNgayVeLabel.Visible = false;
                lblNgayVe.Visible = false;
            }
            lblGioKhoiHanh.Text = SearchHanhTrinhResultControl.hanhtrinh.GioKhoiHanh.ToShortTimeString();
            lblGioDen.Text = SearchHanhTrinhResultControl.hanhtrinh.GioDen.ToShortTimeString();
        }

        protected void FillRdbSoGhe()
        {
            int SoGhe = 0;
            ListItem item;
            List<BookingFile> BFList = new List<BookingFile>();
            BFList = BookingFileDB.GetListBookingFileByDate(ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString(), ThongTinHanhTrinhControl.bf.HanhTrinh.Trim());

            SoGhe = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoGhe.Trim());
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
        }

        protected void FillTinhTrangVe()
        {
            List<BookingFile> BFList = new List<BookingFile>();
            BFList = BookingFileDB.GetListBookingFileByDate(ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString(), ThongTinHanhTrinhControl.bf.HanhTrinh.Trim());
            ListItem item;

            int count = 0;
            int SoLuongVeConLai = 0;

            switch (ddlLoaiVe.SelectedValue)
            {
                case "HangThuong":
                    {
                        if (ThongTinHanhTrinhControl.bf.LoaiChuyen == "Khứ hồi")
                        {
                            long giamgia = 0;
                            long giave = 0;
                            try
                            {
                                giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon1.Trim());
                                giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
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
                            lblGiaVe.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon1.Trim() + " VNĐ";
                        }
                        for (int i = 0; i < BFList.Count; i++)
                        {
                            if (BFList[i].LoaiVe.Equals("Hạng thường") == true)
                            {
                                count += Convert.ToInt16(BFList[i].SoVe);
                            }
                        }
                        SoLuongVeConLai = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoLuongVe1);
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
                        if (ThongTinHanhTrinhControl.bf.LoaiChuyen == "Khứ hồi")
                        {
                            long giamgia = 0;
                            long giave = 0;
                            try
                            {
                                giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon1.Trim());
                                giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
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
                            lblGiaVe.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon2.Trim() + " VNĐ";
                        }
                        for (int i = 0; i < BFList.Count; i++)
                        {
                            if (BFList[i].LoaiVe.Equals("Hạng doanh nhân") == true)
                            {
                                count += Convert.ToInt16(BFList[i].SoVe);
                            }
                        }
                        SoLuongVeConLai = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoLuongVe2);
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
                        if (ThongTinHanhTrinhControl.bf.LoaiChuyen == "Khứ hồi")
                        {
                            long giamgia = 0;
                            long giave = 0;
                            try
                            {
                                giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon1.Trim());
                                giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
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
                            lblGiaVe.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon3.Trim() + " VNĐ";
                        }
                        for (int i = 0; i < BFList.Count; i++)
                        {
                            if (BFList[i].LoaiVe.Equals("Hạng VIP") == true)
                            {
                                count += Convert.ToInt16(BFList[i].SoVe);
                            }
                        }
                        SoLuongVeConLai = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoLuongVe3);
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
            ResetRdbSoGhe();
            FillTinhTrangVe();
            FillRdbSoGhe();
        }

        protected void ResetRdbSoGhe()
        {
            rdbSoGhe.Items.Clear();
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
                if (rdbSoGhe.SelectedValue == "")
                {
                    lblMsg.Text = "Bạn hãy chọn số ghế";
                    return;
                }
                else
                {
                    GetBookingFileData();
                    Response.Redirect("ThongTinKhach.aspx");
                }
            }
        }

        protected void GetBookingFileData()
        {
            ThongTinHanhTrinhControl.bf.MaBF = "";
            ThongTinHanhTrinhControl.bf.ThoiGian = "Buổi sáng";
            ThongTinHanhTrinhControl.bf.OpenChecking = true;
            ThongTinHanhTrinhControl.bf.LoaiVe = ddlLoaiVe.SelectedItem.Text.Trim();
            ThongTinHanhTrinhControl.bf.SoGhe = rdbSoGhe.SelectedValue;
            ThongTinHanhTrinhControl.bf.GiaTien = "";
            ThongTinHanhTrinhControl.bf.ThanhToan = "";
            ThongTinHanhTrinhControl.bf.MaNguoiNhan = "";
            ThongTinHanhTrinhControl.bf.GioKhoiHanh = SearchHanhTrinhResultControl.hanhtrinh.GioKhoiHanh;
            ThongTinHanhTrinhControl.bf.GioDen = SearchHanhTrinhResultControl.hanhtrinh.GioDen;
            ThongTinHanhTrinhControl.bf.SoVe = ddlSLVe.SelectedValue;
        }
    }
}