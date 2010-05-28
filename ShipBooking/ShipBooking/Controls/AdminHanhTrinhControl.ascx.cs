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
using System.Collections.Generic;

namespace ShipBooking.Controls
{
    public partial class AdminHanhTrinhControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillTimeData();
                FillDataToDdlNgayTrongTuan();
                FillDataToDdlSoLuongVe();
                FillDataToDdlNgayDen();
                FillDataToDdlSoGhe();
                ListControlUtilities.FillDataToDropDownList(ddlNoiDi, "tblThanhPho", "Ten", "MaThanhPho");
                ListControlUtilities.FillDataToDropDownList(ddlNoiDen, "tblThanhPho", "Ten", "MaThanhPho");
                FillData();
            }
        }

        protected void FillData()
        {
            string MaChang = "";

            MaChang = GetMaChang().Trim();
            Chang chang = new Chang();
            chang = ChangDB.GetInfo(MaChang);
            if (chang != null)
            {
                if (chang.TinhTrang.Trim() == "yes")
                {
                    rblTinhTrangChuyen.SelectedIndex = 0;
                    Panel1.Visible = true;
                    List<HanhTrinh> ListHanhTrinh = new List<HanhTrinh>();
                    ListHanhTrinh = HanhTrinhDB.GetListHanhTrinhByChang(MaChang);

                    DataSet ds = new DataSet();
                    ds = HanhTrinhDB.GetDataSetHanhTrinhByChang(MaChang);
                    grwHanhTrinh.DataSource = ds;
                    grwHanhTrinh.DataBind();
                }
            }
            else
            {
                Panel1.Visible = false;
                rblTinhTrangChuyen.SelectedIndex = 1;
            }
        }

        protected string GetMaChang()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            return strHanhTrinh;
        }

        protected void FillTimeData()
        {
            ListItem item;
            for (int i = 0; i <= 23; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                ddlGioKhoiHanh.Items.Add(item);
                ddlGioDen.Items.Add(item);
                item = null;
            }

            for (int i = 0; i <= 59; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                ddlPhutKhoiHanh.Items.Add(item);
                ddlPhutDen.Items.Add(item);
                item = null;
            }
        }

        protected void FillDataToDdlNgayTrongTuan()
        {
            ListItem item;
            
            item = new ListItem();
            item.Value = "ThuHai";
            item.Text = "Thứ hai";
            ddlNgayTrongTuan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "ThuBa";
            item.Text = "Thứ ba";
            ddlNgayTrongTuan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "ThuTu";
            item.Text = "Thứ tư";
            ddlNgayTrongTuan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "ThuNam";
            item.Text = "Thứ năm";
            ddlNgayTrongTuan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "ThuSau";
            item.Text = "Thứ sáu";
            ddlNgayTrongTuan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "ThuBay";
            item.Text = "Thứ bảy";
            ddlNgayTrongTuan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "ChuNhat";
            item.Text = "Chủ nhật";
            ddlNgayTrongTuan.Items.Add(item);
            item = null;
        }

        protected void FillDataToDdlSoGhe()
        {
            ListItem item;
            for (int i = 0; i <= 500; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                ddlSoGhe.Items.Add(item);
                item = null;
            }
        }

        protected void FillDataToDdlNgayDen()
        {
            ListItem item;

            item = new ListItem();
            item.Value = "TrongNgay";
            item.Text = "Trong ngày";
            ddlNgayDen.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "HomSau";
            item.Text = "Hôm sau";
            ddlNgayDen.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "HaiNgaySau";
            item.Text = "Hai ngày sau";
            ddlNgayDen.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "BaNgaySau";
            item.Text = "Ba ngày sau";
            ddlNgayDen.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "BonNgaySau";
            item.Text = "Bốn ngày sau";
            ddlNgayDen.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Value = "NamNgaySau";
            item.Text = "Năm ngày sau";
            ddlNgayDen.Items.Add(item);
            item = null;
        }

        protected void FillDataToDdlSoLuongVe()
        {
            ListItem item;
            for (int i = 0; i <= 500; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                ddlSoLuongVe1.Items.Add(item);
                ddlSoLuongVe2.Items.Add(item);
                ddlSoLuongVe3.Items.Add(item);
                item = null;
            }
        }

        protected void rblTinhTrangChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblTinhTrangChuyen.SelectedValue == "Yes")
            {
                string MaChang = "";
               
                MaChang = GetMaChang().Trim();
                rblTinhTrangChuyen.SelectedIndex = 0;
                Panel1.Visible = true;
                Chang chang = new Chang();
                chang = ChangDB.GetInfo(MaChang);
                if (chang != null)
                {
                    rblTinhTrangChuyen.SelectedIndex = 0;
                    Panel1.Visible = true;
                    List<HanhTrinh> ListHanhTrinh = new List<HanhTrinh>();
                    ListHanhTrinh = HanhTrinhDB.GetListHanhTrinhByChang(MaChang);

                    DataSet ds = new DataSet();
                    ds = HanhTrinhDB.GetDataSetHanhTrinhByChang(MaChang);
                    grwHanhTrinh.DataSource = ds;
                    grwHanhTrinh.DataBind();
                }
            }
            else
            {
                Panel1.Visible = false;
            }
        }

        protected void ddlNoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        protected void ddlNoiDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        protected void btnDanhSachTP_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_ThanhPho.aspx");
        }

        protected void btnXemTTTau_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Tau.aspx");
        }

        protected void SaveData()
        {
            string MaChang = "";
            MaChang = GetMaChang().Trim();
            Chang chang;
            chang = ChangDB.GetInfo(MaChang);
            if (chang == null)
            {
                //Insert thông tin chặng
                chang = new Chang();
                chang.MaChang = MaChang;
                if (rblTinhTrangChuyen.SelectedValue == "Yes")
                {
                    chang.TinhTrang = "yes";
                }
                else
                {
                    chang.TinhTrang = "no";
                }
                chang.MaTPDi = ddlNoiDi.SelectedValue.ToUpper().Trim();
                chang.MaTPDen = ddlNoiDen.SelectedValue.ToUpper().Trim();
                ChangDB.Insert(chang);
            }
            else
            {
 
            }
        }

        protected void btnSaveHanhTrinh_Click(object sender, EventArgs e)
        {
            SaveData();
            SavaHanhTrinhData();
        }

        protected void SavaHanhTrinhData()
        {
            //Update thông tin hành trình
            string MaChang = "";
            MaChang = GetMaChang().Trim();
            HanhTrinh hanhtrinh;
            hanhtrinh = HanhTrinhDB.GetInfo(txtSoHieuTau.Text.Trim());
            if (hanhtrinh == null)
            {
                hanhtrinh = new HanhTrinh();
                string giokhoihanh;
                string gioden;

                hanhtrinh.MaHanhTrinh = txtSoHieuTau.Text.Trim();
                hanhtrinh.MaChang = MaChang;
                hanhtrinh.SoHieuChuyenTau = txtSoHieuTau.Text.Trim();

                giokhoihanh = "01/01/1990 " + ddlGioKhoiHanh.SelectedItem.Text + ":" + ddlPhutKhoiHanh.SelectedItem.Text;
                hanhtrinh.GioKhoiHanh = DateTime.Parse(giokhoihanh);

                gioden = "01/01/1990 " + ddlGioDen.SelectedItem.Text + ":" + ddlPhutDen.SelectedItem.Text;
                hanhtrinh.GioDen = DateTime.Parse(gioden);

                hanhtrinh.NgayDen = ddlNgayDen.SelectedValue;
                hanhtrinh.NgayTrongTuan = ddlNgayTrongTuan.SelectedValue;
                hanhtrinh.SoGhe = ddlSoGhe.SelectedIndex;
                hanhtrinh.GiaVeNguoiLon1 = Convert.ToInt16(txtGiaVe1_NguoiLon.Text);
                hanhtrinh.GiaVeNguoiLon2 = Convert.ToInt16(txtGiaVe2_NguoiLon.Text);
                hanhtrinh.GiaVeNguoiLon3 = Convert.ToInt16(txtGiaVe3_NguoiLon.Text);
                hanhtrinh.GiaVeTreEm1 = Convert.ToInt16(txtGiaVe1_TreEm.Text);
                hanhtrinh.GiaVeTreEm2 = Convert.ToInt16(txtGiaVe2_TreEm.Text);
                hanhtrinh.GiaVeTreEm3 = Convert.ToInt16(txtGiaVe3_TreEm.Text);
                hanhtrinh.SoLuongVe1 = ddlSoLuongVe1.SelectedIndex;
                hanhtrinh.SoLuongVe2 = ddlSoLuongVe1.SelectedIndex;
                hanhtrinh.SoLuongVe3 = ddlSoLuongVe1.SelectedIndex;
            }
            else
            {
                lblMsg.Text = "Hành trình này đã tồn tại!";
            }
        }
    }
}