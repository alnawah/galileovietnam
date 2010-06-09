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
            Response.Redirect("KetThucBooking.aspx");
        }

        protected void FillBookingData()
        {
            lblLoaiHanhTrinh.Text = ThongTinHanhTrinhControl.bf.LoaiChuyen;
            lblNoiDi.Text = ThongTinHanhTrinhControl.bf.NoiDi;
            lblNoiDen.Text = ThongTinHanhTrinhControl.bf.NoiDen;
            lblNgayDi.Text = ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString();
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
            lblGioKhoiHanh.Text = ThongTinHanhTrinhControl.bf.GioKhoiHanh.ToShortTimeString();
            lblGioDen.Text = ThongTinHanhTrinhControl.bf.GioDen.ToShortTimeString();
            lblLoaiVe.Text = ThongTinHanhTrinhControl.bf.LoaiVe;
            lblSLVe.Text = ThongTinHanhTrinhControl.bf.SoVe;
            string soghe = "";
            for (int i = 0; i < Convert.ToInt16(ThongTinHanhTrinhControl.bf.SoVe); i++)
            {
                if (BookingStep1Control.ListSoGhe[i].Trim() != "")
                {
                    soghe = soghe + BookingStep1Control.ListSoGhe[i].Trim();
                    if ((i + 1) < Convert.ToInt16(ThongTinHanhTrinhControl.bf.SoVe))
                    {
                        soghe = soghe + ", ";
                    }
                }
            }
            lblSoGhe.Text = soghe;
            lblTongGiaVe.Text = ThongTinHanhTrinhControl.bf.GiaTien;
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
            for (int i = 0; i < ThongTinHanhTrinhControl.listKhach.Count(); i++)
            {
                ds.Tables[0].Rows.Add();
                ds.Tables[0].Rows[i].SetField("Stt", i + 1);
                ds.Tables[0].Rows[i].SetField("TenKhach", ThongTinHanhTrinhControl.listKhach[i].Ten);
                ds.Tables[0].Rows[i].SetField("LoaiTuoi", ThongTinHanhTrinhControl.listKhach[i].DoTuoi);
                ds.Tables[0].Rows[i].SetField("GiaVe", ThongTinHanhTrinhControl.listKhach[i].GiaTien.Trim() + " VNĐ");
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

            ThongTinHanhTrinhControl.bf.MaBF = bfID.Trim();
            ThongTinHanhTrinhControl.bf.ThanhToan = DatVe_Step2.NguoiNhan.ThanhToan.Trim();
            ThongTinHanhTrinhControl.bf.MaNguoiNhan = DatVe_Step2.NguoiNhan.MaNguoiNhan.Trim();
        }

        protected void SaveBookingFileData()
        {
            GetBookingFile();
            BookingFileDB.Insert(ThongTinHanhTrinhControl.bf);
        }

        protected void SaveNguoiNhanVeData()
        {
            NguoiNhanVeDB.Insert(DatVe_Step2.NguoiNhan);
        }

        protected void SaveHanhKhachData()
        {
            for (int i = 0; i < ThongTinHanhTrinhControl.listKhach.Count(); i++)
            {
                ThongTinHanhTrinhControl.listKhach[i].MaBF = ThongTinHanhTrinhControl.bf.MaBF.ToUpper().Trim(); 
                HanhKhachDB.Insert(ThongTinHanhTrinhControl.listKhach[i]);
            }
        }
    }
}