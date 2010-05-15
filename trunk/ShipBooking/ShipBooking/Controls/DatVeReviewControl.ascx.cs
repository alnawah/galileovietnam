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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetBookingData();
                SetHanhKhachData();
                SetNguoiNhanVeData();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SaveNguoiNhanVeData();
            SaveBookingFileData();
            SaveHanhKhachData();
            Response.Redirect("KetThucBooking.aspx");
        }

        protected void SetBookingData()
        {
            lblNoiDen1.Text = DatVeControl.bf.NoiDen;
            lblNoiDi1.Text = DatVeControl.bf.NoiDi;
            lblNgayDi.Text = DatVeControl.bf.NgayDi.ToShortDateString();
            if (DatVeControl.bf.LoaiChuyen.Equals("Một lượt") == true)
            {
                lblNgayVe.Text = "";
            }
            else
            {
                lblNgayVe.Text = DatVeControl.bf.NgayVe.ToShortDateString();
            }
            lblThoiGian.Text = DatVeControl.bf.ThoiGian;
            lblLoaiHanhTrinh.Text = DatVeControl.bf.LoaiChuyen;
            lblLoaiVe.Text = DatVeControl.bf.LoaiVe;
            lblSoGhe.Text = DatVeControl.bf.SoGhe;
            lblGiaVN.Text = DatVeControl.bf.GiaTien;
            lblGioKhoiHanh.Text = DatVeControl.bf.GioKhoiHanh.ToShortTimeString();
            lblGioDen.Text = DatVeControl.bf.GioDen.ToShortTimeString();
        }

        protected void SetHanhKhachData()
        {
            DataTable dt = new DataTable("HanhKhach");
            dt.Columns.Add("Stt");
            dt.Columns.Add("TenKhach");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("LoaiQuocTich");
            dt.Columns.Add("LoaiTuoi");
            dt.Columns.Add("GiaVe");

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            for (int i = 0; i < DatVeControl.listKhach.Count(); i++)
            {
                ds.Tables[0].Rows.Add();
                ds.Tables[0].Rows[i].SetField("Stt", i + 1);
                ds.Tables[0].Rows[i].SetField("TenKhach", DatVeControl.listKhach[i].Ten);
                ds.Tables[0].Rows[i].SetField("DiaChi", DatVeControl.listKhach[i].DiaChi);
                ds.Tables[0].Rows[i].SetField("LoaiQuocTich", DatVeControl.listKhach[i].QuocTich);
                ds.Tables[0].Rows[i].SetField("LoaiTuoi", DatVeControl.listKhach[i].DoTuoi);
                ds.Tables[0].Rows[i].SetField("GiaVe", DatVeControl.bf.GiaTien.Trim());
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

            DatVeControl.bf.MaBF = bfID.Trim();
            DatVeControl.bf.ThanhToan = DatVe_Step2.NguoiNhan.ThanhToan.Trim();
            DatVeControl.bf.MaNguoiNhan = DatVe_Step2.NguoiNhan.MaNguoiNhan.Trim();
        }

        protected void SaveBookingFileData()
        {
            GetBookingFile();
            BookingFileDB.Insert(DatVeControl.bf);
        }

        protected void SaveNguoiNhanVeData()
        {
            NguoiNhanVeDB.Insert(DatVe_Step2.NguoiNhan);
        }

        protected void SaveHanhKhachData()
        {
            for (int i = 0; i < DatVeControl.listKhach.Count(); i++)
            {
                DatVeControl.listKhach[i].MaBF = DatVeControl.bf.MaBF.ToUpper().Trim(); 
                HanhKhachDB.Insert(DatVeControl.listKhach[i]);
            }
        }
    }
}