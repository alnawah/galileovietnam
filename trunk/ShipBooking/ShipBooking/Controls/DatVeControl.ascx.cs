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
                FillDataToRdbLoaiHanhTrinh();
                FillDataToDdlLoaiVe();
                FillDataToRdbSoGhe();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            GetBookingData();
            Response.Redirect("ThongTinKhach.aspx");
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

        protected void FillDataToRdbSoGhe()
        {
            ListItem item;
            for (int i = 1; i <= 10; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                rdbSoGhe.Items.Add(item);
                item = null;
            }
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

        protected void InitData()
        {
            rblLoaiHanhTrinh.SelectedIndex = 0;
            txtNgayDi.Text = "";
            txtNgayVe.Text = "";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void calEventDate_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayDi.Text = calEventDate.SelectedDate.ToString("d");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayVe.Text = Calendar1.SelectedDate.ToString("d");
        }


    }
}