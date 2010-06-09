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

namespace ShipBooking.Controls
{
    public partial class AdminDetailBookingControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
                FillBookingDetailData(AdminBookingFileControl.BookingID);
                FillHanhKhachData(AdminBookingFileControl.BookingID);
                FillNguoiNhanVeData(AdminBookingFileControl.BookingID);
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_BookingFile.aspx");
        }

        protected void FillBookingDetailData(string MaBF)
        {
            BookingFile booking = new BookingFile();
            booking = BookingFileDB.GetInfo(MaBF);

            if (booking != null)
            {
                lblBookingID.Text = booking.MaBF.Trim();
                lblLoaiChuyen.Text = booking.LoaiChuyen.Trim();
                lblNoiDi.Text = booking.NoiDi.Trim();
                lblNoiDen.Text = booking.NoiDen.Trim();
                lblNgayDi.Text = booking.NgayDi.ToShortDateString();
                lblNgayVe.Text = booking.NgayVe.ToShortDateString();
                lblGioKhoiHanh.Text = booking.GioKhoiHanh.ToShortTimeString();
                lblGioDen.Text = booking.GioDen.ToShortTimeString();
                lblLoaiVe.Text = booking.LoaiVe.Trim();

                List<HanhKhach> HKList = new List<HanhKhach>();
                HKList = HanhKhachDB.GetListHanhKhachByBookingID(booking.MaBF.Trim());
                string soghe = "";
                for (int i = 0; i < HKList.Count; i++)
                {
                    if (HKList[i].SoGhe.Trim() != "")
                    {
                        soghe = soghe + HKList[i].SoGhe.Trim();
                        if ((i + 1) < HKList.Count)
                        {
                            soghe = soghe + ", ";
                        }
                    }
                }
                lblSoGhe.Text = soghe;
                lblGiaTien.Text = booking.GiaTien.Trim();
            }
        }

        protected void FillHanhKhachData(string MaBF)
        {
            DataSet ds = new DataSet();
            ds = HanhKhachDB.GetDataSetHanhKhachByBF(MaBF);
            grvHanhKhach.DataSource = ds;
            grvHanhKhach.DataBind();
        }

        protected void FillNguoiNhanVeData(string MaBF)
        {
            BookingFile booking = new BookingFile();
            booking = BookingFileDB.GetInfo(MaBF);

            if (booking != null)
            {
                string MaNN = "";
                MaNN = booking.MaNguoiNhan.Trim();

                NguoiNhanVe nguoinhan = new NguoiNhanVe();
                nguoinhan = NguoiNhanVeDB.GetInfo(MaNN);

                if (nguoinhan != null)
                {
                    lblMaNN.Text = nguoinhan.MaNguoiNhan.Trim();
                    lblTenNN.Text = nguoinhan.Ten.Trim();
                    lblDiaChiNN.Text = nguoinhan.DiaChi.Trim();
                    lblSoDienThoaiNN.Text = nguoinhan.DienThoai.Trim();
                    lblEmailNN.Text = nguoinhan.Email.Trim();
                    lblYeuCauKhac.Text = nguoinhan.YeuCauKhac.Trim();
                }
            }
        }

        protected void InitControl()
        {
            lblBookingID.Text = "";
            lblLoaiChuyen.Text = "";
            lblNoiDi.Text = "";
            lblNoiDen.Text = "";
            lblNgayDi.Text = "";
            lblNgayVe.Text = "";
            lblGioKhoiHanh.Text = "";
            lblGioDen.Text = "";
            lblLoaiVe.Text = "";
            lblSoGhe.Text = "";
            lblGiaTien.Text = "";

            lblMaNN.Text = "";
            lblTenNN.Text = "";
            lblDiaChiNN.Text = "";
            lblSoDienThoaiNN.Text = "";
            lblEmailNN.Text = "";
            lblYeuCauKhac.Text = "";
        }
    }
}