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
    public partial class DatVeControl : System.Web.UI.UserControl
    {
        public static BookingFile bf = new BookingFile();
        public static HanhKhach[] khach;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListControlUtilities.FillDataToDropDownList(ddlNoiDi, "tblThanhPho", "Ten", "MaThanhPho");
                ListControlUtilities.FillDataToDropDownList(ddlNoiDen, "tblThanhPho", "Ten", "MaThanhPho");
                FillDataToDdlThoiGian();
                FillDataToDdlQuocTich();
                FillDataToDdlDoTuoi();
                FillDataToDdlLoaiVe();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            GetBookingData();
            GetHanhKhachData();
            Response.Redirect("Datve_Step2.aspx");
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

        protected void FillDataToDdlQuocTich()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Việt Nam";
            item.Value = "VietNam";
            ddlQuocTich.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Nước ngoài";
            item.Value = "NuocNgoai";
            ddlQuocTich.Items.Add(item);
            item = null;
        }

        protected void FillDataToDdlDoTuoi()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Trẻ sơ sinh";
            item.Value = "TreSoSinh";
            ddlDoTuoi.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Trẻ em";
            item.Value = "TreEm";
            ddlDoTuoi.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Người lớn";
            item.Value = "NguoiLon";
            ddlDoTuoi.Items.Add(item);
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

        protected void GetBookingData()
        {
            bf.MaBF = "123";
            bf.LoaiChuyen = "Khứ hồi";
            bf.NoiDi = ddlNoiDi.SelectedItem.Text;
            bf.NoiDen = ddlNoiDen.SelectedItem.Text;
            bf.NgayDi = txtNgayDi.Text;
            bf.NgayVe = txtNgayVe.Text;
            bf.ThoiGian = ddlThoiGian.SelectedItem.Text;
            bf.OpenChecking = true;
            bf.LoaiVe = ddlLoaiVe.SelectedItem.Text;
            bf.SoGhe = "30";
            bf.GiaTien = "4500000";
            bf.ThanhToan = "Chuyển khoản";
            bf.MaNguoiNhan = "NN01";
        }

        protected void GetHanhKhachData()
        {
            khach[0] = new HanhKhach();
            khach[0].MaHK = "HK01";
            khach[0].Ten = txtHoTen.Text;
            khach[0].DiaChi = txtDiaChi.Text;
            khach[0].QuocTich = ddlQuocTich.SelectedItem.Text;
            khach[0].DoTuoi = ddlDoTuoi.SelectedItem.Text;
            khach[0].DienThoai = txtSoDienThoai.Text;
            khach[0].Email = txtEmail.Text;
            khach[0].MaBF = "BF01";
        }
    }
}