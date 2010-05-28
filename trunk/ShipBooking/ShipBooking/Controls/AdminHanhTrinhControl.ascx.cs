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
                InitData();
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
                    FillDataToGrvHanhTrinh();
                    InitData();
                }
                else
                {
                    rblTinhTrangChuyen.SelectedIndex = 1;
                    Panel1.Visible = false;
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
            SaveChang();
            if (rblTinhTrangChuyen.SelectedValue == "Yes")
            {
                Panel1.Visible = true;
                FillDataToGrvHanhTrinh();
            }
            else
            {
                Panel1.Visible = false;
            }
        }

        protected void FillDataToGrvHanhTrinh()
        {
            string MaChang = "";
            MaChang = GetMaChang().Trim();
            DataSet ds = new DataSet();
            ds = HanhTrinhDB.GetDataSetHanhTrinhByChang(MaChang);
            grwHanhTrinh.DataSource = ds;
            grwHanhTrinh.DataBind();
            DateTime dt;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt = DateTime.Parse(ds.Tables[0].Rows[i]["GioKhoiHanh"].ToString().Trim());
                grwHanhTrinh.Rows[i].Cells[1].Text = dt.TimeOfDay.ToString();

                dt = DateTime.Parse(ds.Tables[0].Rows[i]["GioDen"].ToString().Trim());
                grwHanhTrinh.Rows[i].Cells[2].Text = dt.TimeOfDay.ToString();
            }
        }

        protected void FillDetailHanhTrinh(string mahanhtrinh)
        {
            HanhTrinh hanhtrinh = new HanhTrinh();
            hanhtrinh = HanhTrinhDB.GetInfo(mahanhtrinh);
            if (hanhtrinh != null)
            {
                string mahanhtrinh_rutgon = mahanhtrinh.Substring(6);
                txtMaHanhTrinh.Text = mahanhtrinh_rutgon;
                txtSoHieuTau.Text = hanhtrinh.SoHieuChuyenTau.Trim();
                ddlGioKhoiHanh.SelectedIndex = hanhtrinh.GioKhoiHanh.Hour;
                ddlPhutKhoiHanh.SelectedIndex = hanhtrinh.GioKhoiHanh.Minute;
                ddlGioDen.SelectedIndex = hanhtrinh.GioDen.Hour;
                ddlPhutDen.SelectedIndex = hanhtrinh.GioDen.Minute;
                ddlNgayDen.SelectedIndex = GetSelectedNgayDen(hanhtrinh.NgayDen.Trim());
                ddlNgayTrongTuan.SelectedIndex = GetSelectedNgayTrongTuan(hanhtrinh.NgayTrongTuan.Trim());
                ddlSoGhe.SelectedIndex = Convert.ToInt16(hanhtrinh.SoGhe.Trim());
                txtGiaVe1_NguoiLon.Text = hanhtrinh.GiaVeNguoiLon1.Trim();
                txtGiaVe2_NguoiLon.Text = hanhtrinh.GiaVeNguoiLon2.Trim();
                txtGiaVe3_NguoiLon.Text = hanhtrinh.GiaVeNguoiLon3.Trim();
                txtGiaVe1_TreEm.Text = hanhtrinh.GiaVeTreEm1.Trim();
                txtGiaVe2_TreEm.Text = hanhtrinh.GiaVeTreEm2.Trim();
                txtGiaVe3_TreEm.Text = hanhtrinh.GiaVeTreEm3.Trim();
                ddlSoLuongVe1.SelectedIndex = Convert.ToInt16(hanhtrinh.SoLuongVe1.Trim());
                ddlSoLuongVe2.SelectedIndex = Convert.ToInt16(hanhtrinh.SoLuongVe2.Trim());
                ddlSoLuongVe3.SelectedIndex = Convert.ToInt16(hanhtrinh.SoLuongVe3.Trim());
            }
        }

        protected int GetSelectedNgayDen(string ngayden)
        {
            int value = 0;
            switch (ngayden)
            {
                case "Trong ngày":
                {
                    value = 0;
                }
                    break;
                case "Hôm sau":
                {
                    value = 1;
                }
                    break;
                case "Hai ngày sau":
                {
                    value = 2;
                }
                    break;
                case "Ba ngày sau":
                {
                    value = 3;
                }
                    break;
                case "Bốn ngày sau":
                {
                    value = 4;
                }
                    break;
                case "Năm ngày sau":
                {
                    value = 5;
                }
                    break;
                default:
                    break;
            }

            return value;
        }

        protected int GetSelectedNgayTrongTuan(string ngaytrongtuan)
        {
            int value = 0;
            switch (ngaytrongtuan)
            {
                case "Thứ hai":
                    {
                        value = 0;
                    }
                    break;
                case "Thứ ba":
                    {
                        value = 1;
                    }
                    break;
                case "Thứ tư":
                    {
                        value = 2;
                    }
                    break;
                case "Thứ năm":
                    {
                        value = 3;
                    }
                    break;
                case "Thứ sáu":
                    {
                        value = 4;
                    }
                    break;
                case "Thứ bảy":
                    {
                        value = 5;
                    }
                    break;
                case "Chủ nhật":
                    {
                        value = 6;
                    }
                    break;
                default:
                    break;
            }

            return value;
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

        protected void SaveChang()
        {
            string MaChang = "";
            MaChang = GetMaChang().Trim();
            Chang chang;
            chang = ChangDB.GetInfo(MaChang);
            if (chang == null)
            {
                //Insert
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
                //Update
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
                ChangDB.Update(chang);
            }
            InitData();
        }

        protected void btnSaveHanhTrinh_Click(object sender, EventArgs e)
        {
            if (txtMaHanhTrinh.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn phải nhập số hiệu chuyến tàu";
                return;
            }
            else
            {
                if (CheckValidTime() == false)
                {
                    return;
                }
                else
                {
                    SavaHanhTrinhData();
                    FillData();
                }
            }
        }

        protected void SavaHanhTrinhData()
        {
            string machang = "";
            string mahanhtrinh = "";
            machang = GetMaChang().Trim();
            mahanhtrinh = machang + txtMaHanhTrinh.Text.Trim();
            HanhTrinh hanhtrinh;
            hanhtrinh = HanhTrinhDB.GetInfo(mahanhtrinh.Trim());
            if (hanhtrinh == null)
            {
                hanhtrinh = new HanhTrinh();
                
                hanhtrinh.MaHanhTrinh = mahanhtrinh;
                hanhtrinh.MaChang = machang;
                hanhtrinh.SoHieuChuyenTau = txtSoHieuTau.Text.Trim();
                hanhtrinh.GioKhoiHanh = GetTime(ddlGioKhoiHanh, ddlPhutKhoiHanh);
                hanhtrinh.GioDen = GetTime(ddlGioDen, ddlPhutDen);
                hanhtrinh.NgayDen = ddlNgayDen.SelectedItem.Text.Trim();
                hanhtrinh.TongThoiGian = TongThoiGian(hanhtrinh.GioKhoiHanh, hanhtrinh.GioDen, 1);
                hanhtrinh.NgayTrongTuan = ddlNgayTrongTuan.SelectedItem.Text.Trim();
                hanhtrinh.SoGhe = ddlSoGhe.SelectedValue;
                hanhtrinh.GiaVeNguoiLon1 = txtGiaVe1_NguoiLon.Text.Trim();
                hanhtrinh.GiaVeNguoiLon2 = txtGiaVe2_NguoiLon.Text.Trim();
                hanhtrinh.GiaVeNguoiLon3 = txtGiaVe3_NguoiLon.Text.Trim();
                hanhtrinh.GiaVeTreEm1 = txtGiaVe1_TreEm.Text.Trim();
                hanhtrinh.GiaVeTreEm2 = txtGiaVe2_TreEm.Text.Trim();
                hanhtrinh.GiaVeTreEm3 = txtGiaVe3_TreEm.Text.Trim();
                hanhtrinh.SoLuongVe1 = ddlSoLuongVe1.SelectedValue;
                hanhtrinh.SoLuongVe2 = ddlSoLuongVe2.SelectedValue;
                hanhtrinh.SoLuongVe3 = ddlSoLuongVe3.SelectedValue;

                HanhTrinhDB.Insert(hanhtrinh);
            }
            else
            {
                hanhtrinh.MaHanhTrinh = mahanhtrinh;
                hanhtrinh.MaChang = machang;
                hanhtrinh.SoHieuChuyenTau = txtSoHieuTau.Text.Trim();
                hanhtrinh.GioKhoiHanh = GetTime(ddlGioKhoiHanh, ddlPhutKhoiHanh);
                hanhtrinh.GioDen = GetTime(ddlGioDen, ddlPhutDen);
                hanhtrinh.NgayDen = ddlNgayDen.SelectedItem.Text.Trim();
                hanhtrinh.TongThoiGian = TongThoiGian(hanhtrinh.GioKhoiHanh, hanhtrinh.GioDen, 1);
                hanhtrinh.NgayTrongTuan = ddlNgayTrongTuan.SelectedItem.Text.Trim();
                hanhtrinh.SoGhe = ddlSoGhe.SelectedValue;
                hanhtrinh.GiaVeNguoiLon1 = txtGiaVe1_NguoiLon.Text.Trim();
                hanhtrinh.GiaVeNguoiLon2 = txtGiaVe2_NguoiLon.Text.Trim();
                hanhtrinh.GiaVeNguoiLon3 = txtGiaVe3_NguoiLon.Text.Trim();
                hanhtrinh.GiaVeTreEm1 = txtGiaVe1_TreEm.Text.Trim();
                hanhtrinh.GiaVeTreEm2 = txtGiaVe2_TreEm.Text.Trim();
                hanhtrinh.GiaVeTreEm3 = txtGiaVe3_TreEm.Text.Trim();
                hanhtrinh.SoLuongVe1 = ddlSoLuongVe1.SelectedValue;
                hanhtrinh.SoLuongVe2 = ddlSoLuongVe2.SelectedValue;
                hanhtrinh.SoLuongVe3 = ddlSoLuongVe3.SelectedValue;

                HanhTrinhDB.Update(hanhtrinh);
            }
            InitData();
        }

        protected string TongThoiGian(DateTime giokhoihanh, DateTime gioden, int songay)
        {
            string tongthoigian;
            TimeSpan tsp;
            tsp = gioden.TimeOfDay - giokhoihanh.TimeOfDay;
            tongthoigian = tsp.ToString();
            return tongthoigian;
        }

        protected void grwHanhTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahanhtrinh = "";
            mahanhtrinh = grwHanhTrinh.Rows[grwHanhTrinh.SelectedIndex].Cells[0].Text.Trim();
            FillDetailHanhTrinh(mahanhtrinh);
            lblMsg.Text = "";
        }

        protected void grwHanhTrinh_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grwHanhTrinh_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grwHanhTrinh.PageIndex = e.NewPageIndex;
            FillDataToGrvHanhTrinh();
        }

        protected void grwHanhTrinh_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void grwHanhTrinh_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string mahanhtrinh = "";
            mahanhtrinh = grwHanhTrinh.Rows[e.RowIndex].Cells[0].Text.Trim();
            HanhTrinhDB.Delete(mahanhtrinh);
            FillDataToGrvHanhTrinh();
        }

        protected DateTime GetTime(DropDownList ddlGio, DropDownList ddlPhut)
        {
            string time = "";
            DateTime dt;
            time = "01/01/1990 " + ddlGio.SelectedItem.Text + ":" + ddlPhut.SelectedItem.Text;
            dt = DateTime.Parse(time);
            return dt;
        }

        protected void InitData()
        {
            lblMsg.Text = "";
            txtMaHanhTrinh.Text = "";
            txtSoHieuTau.Text = "";
            ddlGioKhoiHanh.SelectedIndex = 0;
            ddlPhutKhoiHanh.SelectedIndex = 0;
            ddlGioDen.SelectedIndex = 0;
            ddlPhutDen.SelectedIndex = 0;
            ddlNgayDen.SelectedIndex = 0;
            ddlNgayTrongTuan.SelectedIndex = 0;
            ddlSoGhe.SelectedIndex = 0;
            txtGiaVe1_NguoiLon.Text = "";
            txtGiaVe2_NguoiLon.Text = "";
            txtGiaVe3_NguoiLon.Text = "";
            txtGiaVe1_TreEm.Text = "";
            txtGiaVe2_TreEm.Text = "";
            txtGiaVe3_TreEm.Text = "";
            ddlSoLuongVe1.SelectedIndex = 0;
            ddlSoLuongVe2.SelectedIndex = 0;
            ddlSoLuongVe3.SelectedIndex = 0;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            InitData();
            txtMaHanhTrinh.Focus();
        }

        protected bool CheckValidTime()
        {
            bool isValid = false;
            DateTime giokhoihanh = GetTime(ddlGioKhoiHanh, ddlPhutKhoiHanh);
            DateTime gioden = GetTime(ddlGioDen, ddlPhutDen);

            if (giokhoihanh >= gioden)
            {
                lblMsg.Text = "Lỗi nhập liệu: Giờ đến phải sau giờ khởi hành";
                isValid = false;
            }
            else
            {
                lblMsg.Text = "";
                isValid = true;
            }
            return isValid;
        }
    }
}