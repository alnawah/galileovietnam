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
        string DiaChi;
        string DienThoai;
        string Email;
        string MaNguoiNhan;
        string MaThanhPho;
        string Ten;
        string ThanhToan;
        string ThoiGianGiaoVe;
        string YeuCauKhac;

        List<HanhKhach> listKhach = new List<HanhKhach>();

        BookingFile booking = new BookingFile();
        HanhTrinh hanhtrinh = new HanhTrinh();
        NguoiNhanVe NguoiNhan = new NguoiNhanVe();
        static bool bSelectAgainSoGhe;
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
            DiaChi = Request.QueryString["DiaChi"];
            DienThoai = Request.QueryString["DienThoai"];
            Email = Request.QueryString["Email"];
            MaNguoiNhan = Request.QueryString["MaNguoiNhan"];
            MaThanhPho = Request.QueryString["MaThanhPho"];
            Ten = Request.QueryString["Ten"];
            ThanhToan = Request.QueryString["ThanhToan"];
            ThoiGianGiaoVe = Request.QueryString["ThoiGianGiaoVe"];
            YeuCauKhac = Request.QueryString["YeuCauKhac"];

            HanhKhach khach = null;
            for (int i = 0; i < Convert.ToInt16(SoVe); i++)
            {
                khach = new HanhKhach();

                khach.MaHK = Request.QueryString["MaKhach" + i.ToString()];
                khach.Ten = Request.QueryString["TenKhach" + i.ToString()];
                khach.DoTuoi = Request.QueryString["DoTuoiKhach" + i.ToString()];
                khach.SoGhe = Request.QueryString["SoGheKhach" + i.ToString()];
                khach.GiaTien = Request.QueryString["GiaTienKhach" + i.ToString()];
                khach.DiaChi = "";
                khach.Email = "";
                khach.MaBF = "";
                khach.QuocTich = "";

                listKhach.Add(khach);
            }

            hanhtrinh = HanhTrinhDB.GetInfo(MaHanhTrinh);
            lblMsg.Text = "";
            bSelectAgainSoGhe = false;
            if (!IsPostBack)
            {
                FillBookingData();
                SetHanhKhachData();
                SetNguoiNhanVeData();
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

        protected void CheckSoGheVuaDuocDat()
        {
            List<HanhKhach> HKList = new List<HanhKhach>();
            HKList = HanhKhachDB.GetListHangKhachByHanhTrinhAndDate(ngaydi, MaHanhTrinh);

            for (int i = 0; i < HKList.Count; i++)
            {
                for (int j = 0; j < listKhach.Count; j++)
                {
                    if (HKList[i].SoGhe.Trim() == listKhach[j].SoGhe.Trim())
                    {
                        lblMsg.Text = "Rất tiếc, số ghế " + listKhach[j].SoGhe.Trim() + " vừa mới được đặt, bạn hãy chọn số ghế khác";
                        CheckBoxListSoGhe.Visible = true;
                        FillCheckBoxListSoGhe();
                        Button2.Visible = false;
                        Button3.Visible = true;
                        bSelectAgainSoGhe = true;
                    }
                }
            }
        }

        protected bool CheckSoGhe()
        {
            lblMsg.Text = "";
            bool isValid = false;
            int sove = 0;
            int soghe = 0;

            sove = Convert.ToInt16(SoVe.Trim());
            for (int i = 0; i < CheckBoxListSoGhe.Items.Count; i++)
            {
                if (CheckBoxListSoGhe.Items[i].Selected == true)
                {
                    soghe += 1;
                }
            }

            if (sove != soghe)
            {
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
                    listKhach[j].SoGhe = CheckBoxListSoGhe.Items[i].Text.Trim();
                    j++;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            CheckSoGheVuaDuocDat();
            if (bSelectAgainSoGhe == false)
            {
                SaveNguoiNhanVeData();
                SaveBookingFileData();
                SaveHanhKhachData();
                Response.Redirect("KetThucBooking.aspx?MaBF=" + booking.MaBF);
            }
            else
            {
                return;
            }
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
                if (listKhach[i].SoGhe.Trim() != "")
                {
                    soghe = soghe + listKhach[i].SoGhe.Trim();
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
            for (int i = 0; i < listKhach.Count(); i++)
            {
                ds.Tables[0].Rows.Add();
                ds.Tables[0].Rows[i].SetField("Stt", i + 1);
                ds.Tables[0].Rows[i].SetField("TenKhach", listKhach[i].Ten);
                ds.Tables[0].Rows[i].SetField("LoaiTuoi", listKhach[i].DoTuoi);
                ds.Tables[0].Rows[i].SetField("GiaVe", listKhach[i].GiaTien.Trim() + " VNĐ");
            }
            grvHanhKhach.DataSource = ds.Tables[0];
            grvHanhKhach.DataBind();
        }

        protected void SetNguoiNhanVeData()
        {
            lblTenNguoiNhan.Text = Ten;
            lblDiaChiNguoiNhan.Text = DiaChi;
            lblThanhPho.Text = MaThanhPho;
            lblSoDienThoai.Text = DienThoai;
            lblEmail.Text = Email;
            lblYeuCauKhac.Text = YeuCauKhac;
            lblThoiGianGiaoVe.Text = ThoiGianGiaoVe;
            lblThanhToan.Text = ThanhToan;
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
            booking.MaNguoiNhan = MaNguoiNhan.Trim();
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
            booking.ThanhToan = ThanhToan.Trim();
            booking.ThoiGian = "Buổi sáng";
        }

        protected void GetNguoiNhanVeData()
        {
            NguoiNhan.DiaChi = DiaChi;
            NguoiNhan.DienThoai = DienThoai;
            NguoiNhan.Email = Email;
            NguoiNhan.MaNguoiNhan = MaNguoiNhan;
            NguoiNhan.MaThanhPho = MaThanhPho;
            NguoiNhan.Ten = Ten;
            NguoiNhan.ThanhToan = ThanhToan;
            NguoiNhan.ThoiGianGiaoVe = ThoiGianGiaoVe;
            NguoiNhan.YeuCauKhac = YeuCauKhac;
        }

        protected void SaveBookingFileData()
        {
            GetBookingFile();
            BookingFileDB.Insert(booking);
        }

        protected void SaveNguoiNhanVeData()
        {
            GetNguoiNhanVeData();
            NguoiNhanVeDB.Insert(NguoiNhan);
        }

        protected void SaveHanhKhachData()
        {
            for (int i = 0; i < listKhach.Count(); i++)
            {
                listKhach[i].MaBF = booking.MaBF.ToUpper().Trim();
                HanhKhachDB.Insert(listKhach[i]);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (CheckSoGhe() == true)
            {
                GetListSoGhe();
                SaveNguoiNhanVeData();
                SaveBookingFileData();
                SaveHanhKhachData();
                Response.Redirect("KetThucBooking.aspx?MaBF=" + booking.MaBF);
            }
            else
            {
                lblMsg.Text = "Chú ý: Số lượng ghế được chọn phải bằng số lượng vé";
                return;
            }
        }
    }
}