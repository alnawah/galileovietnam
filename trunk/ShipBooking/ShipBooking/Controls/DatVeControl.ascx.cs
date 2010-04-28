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
                ListControlUtilities.FillDataToDropDownList(ddlNoiDen, "tblThanhPho", "Ten", "MaThanhPho");
                FillDataToDdlThoiGian();
                FillDataToDdlQuocTich();
                FillDataToDdlDoTuoi();
                FillDataToRdbLoaiHanhTrinh();
                FillDataToDdlLoaiVe();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            RequiredFieldValidator1.Visible = true;
            RequiredFieldValidator2.Visible = true;
            RequiredFieldValidator3.Visible = true;
            RequiredFieldValidator4.Visible = true;
            RequiredFieldValidator5.Visible = true;
            RequiredFieldValidator6.Visible = true;
            RequiredFieldValidator7.Visible = true;

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

        protected void FillDataToRdbLoaiHanhTrinh()
        {
            ListItem item;
            
            item = new ListItem();
            item.Text = "Khứ hồi";
            item.Value = "KhuHoi";
            rblLoaiHanhTrinh.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Một lượt";
            item.Value = "MotLuot";
            rblLoaiHanhTrinh.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Nhiều lượt";
            item.Value = "NhieuLuot";
            rblLoaiHanhTrinh.Items.Add(item);
            item = null;

            rblLoaiHanhTrinh.SelectedIndex = 0;
        }

        protected void GetBookingData()
        {
            bf.LoaiChuyen = rblLoaiHanhTrinh.SelectedItem.Text;
            bf.NoiDi = ddlNoiDi.SelectedItem.Text;
            bf.NoiDen = ddlNoiDen.SelectedItem.Text;
            bf.NgayDi = txtNgayDi.Text;
            bf.NgayVe = txtNgayVe.Text;
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
            bf.SoGhe = "30";
            bf.GiaTien = "4500000";
        }

        protected void GetHanhKhachData()
        {
            HanhKhach khach = new HanhKhach();

            khach.MaHK = "HK01";
            khach.Ten = txtHoTen.Text;
            khach.DiaChi = txtDiaChi.Text;
            khach.QuocTich = ddlQuocTich.SelectedItem.Text;
            khach.DoTuoi = ddlDoTuoi.SelectedItem.Text;
            khach.DienThoai = txtSoDienThoai.Text;
            khach.Email = txtEmail.Text;
            khach.MaBF = "BF01";

            listKhach.Add(khach);
        }

        protected void InitData()
        {
            SetVisibleRequiredValidatorControl();
            rblLoaiHanhTrinh.SelectedIndex = 0;
            txtNgayDi.Text = "";
            txtNgayVe.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            ddlDoTuoi.SelectedIndex = 2;
        }

        protected void SetVisibleRequiredValidatorControl()
        {
            RequiredFieldValidator1.Visible = false;
            RequiredFieldValidator2.Visible = false;
            RequiredFieldValidator3.Visible = false;
            RequiredFieldValidator4.Visible = false;
            RequiredFieldValidator5.Visible = false;
            RequiredFieldValidator6.Visible = false;
            RequiredFieldValidator7.Visible = false;
        }
    }
}