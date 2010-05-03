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

namespace ShipBooking.Controls
{
    public partial class DatVe_Step2 : System.Web.UI.UserControl
    {
        public static NguoiNhanVe NguoiNhan = new NguoiNhanVe();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListControlUtilities.FillDataToDropDownList(ddlThanhPho, "tblThanhPho", "Ten", "MaThanhPho");
                FillDataToDdlThoiGian();
                FillDataToRdbHinhThucThanhToan();
                SetBookingData();
                SetHanhKhachData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequiredFieldValidator1.Visible = true;
            RequiredFieldValidator2.Visible = true;
            RequiredFieldValidator3.Visible = true;
            RequiredFieldValidator4.Visible = true;

            GetNguoiNhanVeData();
            Response.Redirect("DatVe_Review.aspx");
        }

        protected void FillDataToDdlThoiGian()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Buổi sáng";
            item.Value = "Sang";
            ddlThoiGianGiaoVe.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Buổi chiều";
            item.Value = "Chieu";
            ddlThoiGianGiaoVe.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Buổi tối";
            item.Value = "Toi";
            ddlThoiGianGiaoVe.Items.Add(item);
            item = null;
        }

        protected void FillDataToRdbHinhThucThanhToan()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Tại văn phòng đại lý";
            item.Value = "TaiVanPhongDaiLy";
            rblHinhThucThanhToan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Thanh toán khi giao vé";
            item.Value = "ThanhToanKhiGiaoVe";
            rblHinhThucThanhToan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Thanh toán bằng thẻ tín dụng";
            item.Value = "ThanhToanBangTheTinDung";
            rblHinhThucThanhToan.Items.Add(item);
            item = null;

            rblHinhThucThanhToan.SelectedIndex = 0;
        }

        protected void SetBookingData()
        {
            lblNoiDen1.Text = DatVeControl.bf.NoiDen;
            lblNoiDi1.Text = DatVeControl.bf.NoiDi;
            lblNgayDi.Text = DatVeControl.bf.NgayDi;
            lblNgayVe.Text = DatVeControl.bf.NgayVe;
            lblThoiGian.Text = DatVeControl.bf.ThoiGian;
            lblLoaiHanhTrinh.Text = DatVeControl.bf.LoaiChuyen;
            lblLoaiVe.Text = DatVeControl.bf.LoaiVe;
            lblSoGhe.Text = DatVeControl.bf.SoGhe;
            lblGiaVN.Text = DatVeControl.bf.GiaTien;
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
                ds.Tables[0].Rows[i].SetField("GiaVe", "4.500.000 VND");
            }
            grvHanhKhach.DataSource = ds.Tables[0];
            grvHanhKhach.DataBind();
        }

        protected void GetNguoiNhanVeData()
        {
            string strMaNN = "NN";
            Random rdm = new Random();
            strMaNN += rdm.Next(1000, 9999).ToString();


            NguoiNhan.MaNguoiNhan = strMaNN;
            NguoiNhan.Ten = txtTenNguoiNhan.Text;
            NguoiNhan.DiaChi = txtDiaChiNguoiNhan.Text;
            NguoiNhan.MaThanhPho = ddlThanhPho.SelectedItem.Text ;
            NguoiNhan.DienThoai = txtDienThoaiNguoiNhan.Text;
            NguoiNhan.Email = txtEmailNguoiNhan.Text;
            NguoiNhan.YeuCauKhac = txtYeuCauKhac.Text;
            NguoiNhan.ThoiGianGiaoVe = ddlThoiGianGiaoVe.SelectedItem.Text;
            
            NguoiNhan.ThanhToan = rblHinhThucThanhToan.SelectedItem.Text;
        }
    }
}