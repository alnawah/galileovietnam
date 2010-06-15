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

namespace ShipBooking.Controls
{
    public partial class DatVeReviewControl : System.Web.UI.UserControl
    {
        string loaichuyen;
        string noidi;
        string noiden;
        string ngaydi;
        string ngayve;
        string machang;
        string MaHanhTrinh;
        string LoaiVe;
        string SoVe;
        string GiaTien;

        BookingFile booking = new BookingFile();
        HanhTrinh hanhtrinh = new HanhTrinh();
        protected void Page_Load(object sender, EventArgs e)
        {
            loaichuyen = Request.QueryString["LoaiChuyen"];
            noidi = Request.QueryString["NoiDi"];
            noiden = Request.QueryString["NoiDen"];
            ngaydi = Request.QueryString["NgayDi"];
            ngayve = Request.QueryString["NgayVe"];
            machang = Request.QueryString["MaChang"];
            MaHanhTrinh = Request.QueryString["MaHanhTrinh"];
            LoaiVe = Request.QueryString["LoaiVe"];
            SoVe = Request.QueryString["SoVe"];
            GiaTien = Request.QueryString["GiaTien"];
            hanhtrinh = HanhTrinhDB.GetInfo(MaHanhTrinh);
            if (!IsPostBack)
            {
                FillBookingData();
                SetHanhKhachData();
                SetNguoiNhanVeData();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SaveNguoiNhanVeData();
            SaveBookingFileData();
            SaveHanhKhachData();
            Response.Redirect("KetThucBooking.aspx?MaBF=" + booking.MaBF);
        }

        protected void FillBookingData()
        {
            lblLoaiHanhTrinh.Text = loaichuyen;
            lblNoiDi.Text = noidi;
            lblNoiDen.Text = noiden;
            lblNgayDi.Text = ngaydi;
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
            lblLoaiVe.Text = LoaiVe;
            lblSLVe.Text = SoVe;
            string soghe = "";
            for (int i = 0; i < Convert.ToInt16(SoVe); i++)
            {
                if (BookingStep1Control.ListSoGhe[i].Trim() != "")
                {
                    soghe = soghe + BookingStep1Control.ListSoGhe[i].Trim();
                    if ((i + 1) < Convert.ToInt16(SoVe))
                    {
                        soghe = soghe + ", ";
                    }
                }
            }
            lblSoGhe.Text = soghe;
            lblTongGiaVe.Text = GiaTien;
        }

        protected void SetHanhKhachData()
        {
            DataTable dt = new DataTable("HanhKhach");
            dt.Columns.Add("Stt");
            dt.Columns.Add("TenKhach");
            dt.Columns.Add("LoaiTuoi");
            dt.Columns.Add("GiaVe");

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            for (int i = 0; i < ThongTinKhachControl.listKhach.Count(); i++)
            {
                ds.Tables[0].Rows.Add();
                ds.Tables[0].Rows[i].SetField("Stt", i + 1);
                ds.Tables[0].Rows[i].SetField("TenKhach", ThongTinKhachControl.listKhach[i].Ten);
                ds.Tables[0].Rows[i].SetField("LoaiTuoi", ThongTinKhachControl.listKhach[i].DoTuoi);
                ds.Tables[0].Rows[i].SetField("GiaVe", ThongTinKhachControl.listKhach[i].GiaTien.Trim() + " VNĐ");
            }
            grvHanhKhach.DataSource = ds.Tables[0];
            grvHanhKhach.DataBind();
        }

        protected void SetNguoiNhanVeData()
        {
            lblTenNguoiNhan.Text = DatVe_Step2.NguoiNhan.Ten;
            lblDiaChiNguoiNhan.Text = DatVe_Step2.NguoiNhan.DiaChi;
            lblThanhPho.Text = DatVe_Step2.NguoiNhan.MaThanhPho;
            lblSoDienThoai.Text = DatVe_Step2.NguoiNhan.DienThoai;
            lblEmail.Text = DatVe_Step2.NguoiNhan.Email;
            lblYeuCauKhac.Text = DatVe_Step2.NguoiNhan.YeuCauKhac;
            lblThoiGianGiaoVe.Text = DatVe_Step2.NguoiNhan.ThoiGianGiaoVe;
            lblThanhToan.Text = DatVe_Step2.NguoiNhan.ThanhToan;
        }

        protected void GetBookingFile()
        {
            string bfID = "";
            Random rdm = new Random();
            bfID = "BF" + rdm.Next(10000, 99999).ToString().Trim();

            booking.GiaTien = GiaTien;
            booking.GioDen = hanhtrinh.GioDen;
            booking.GioKhoiHanh = hanhtrinh.GioKhoiHanh;
            booking.LoaiChuyen = loaichuyen;
            booking.LoaiVe = LoaiVe;
            booking.MaBF = bfID.Trim();
            booking.MaHanhTrinh = MaHanhTrinh;
            booking.MaNguoiNhan = DatVe_Step2.NguoiNhan.MaNguoiNhan.Trim();
            booking.NgayDi = DateTime.Parse(ngaydi);
            if (loaichuyen == "Khứ hồi")
            {
                booking.NgayVe = DateTime.Parse(ngayve);
            }
            else
            {
                booking.NgayVe = DateTime.Parse(ngaydi);
            }
            booking.NoiDen = noiden;
            booking.NoiDi = noidi;
            booking.OpenChecking = false;
            booking.SoGhe = "0";
            booking.SoVe = SoVe;
            booking.TenKhach = "";
            booking.ThanhToan = DatVe_Step2.NguoiNhan.ThanhToan.Trim();
            booking.ThoiGian = "Buổi sáng";
        }

        protected void SaveBookingFileData()
        {
            GetBookingFile();
            BookingFileDB.Insert(booking);
        }

        protected void SaveNguoiNhanVeData()
        {
            NguoiNhanVeDB.Insert(DatVe_Step2.NguoiNhan);
        }

        protected void SaveHanhKhachData()
        {
            for (int i = 0; i < ThongTinKhachControl.listKhach.Count(); i++)
            {
                ThongTinKhachControl.listKhach[i].MaBF = booking.MaBF.ToUpper().Trim();
                HanhKhachDB.Insert(ThongTinKhachControl.listKhach[i]);
            }
        }
    }
}