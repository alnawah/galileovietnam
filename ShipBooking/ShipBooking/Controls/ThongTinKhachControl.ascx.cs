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
    public partial class ThongTinKhachControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
                FillDataToDdlQuocTich();
                FillDataToDdlDoTuoi();
                SetBookingData();
            }
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

        protected void SetBookingData()
        {
            lblNoiDen1.Text = ThongTinHanhTrinhControl.bf.NoiDen;
            lblNoiDi1.Text = ThongTinHanhTrinhControl.bf.NoiDi;
            lblNgayDi.Text = ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString();
            if (ThongTinHanhTrinhControl.bf.LoaiChuyen.Equals("Một lượt") == true)
            {
                lblNgayVe.Text = "";
            }
            else
            {
                lblNgayVe.Text = ThongTinHanhTrinhControl.bf.NgayVe.ToShortDateString();
            }
            lblThoiGian.Text = ThongTinHanhTrinhControl.bf.ThoiGian;
            lblLoaiHanhTrinh.Text = ThongTinHanhTrinhControl.bf.LoaiChuyen;
            lblLoaiVe.Text = ThongTinHanhTrinhControl.bf.LoaiVe;
            lblSoGhe.Text = ThongTinHanhTrinhControl.bf.SoGhe;
            lblGiaVN.Text = ThongTinHanhTrinhControl.bf.GiaTien;
            lblGioKhoiHanh.Text = ThongTinHanhTrinhControl.bf.GioKhoiHanh.ToShortTimeString();
            lblGioDen.Text = ThongTinHanhTrinhControl.bf.GioDen.ToShortTimeString();
        }

        protected void GetHanhKhachData()
        {
            ThongTinHanhTrinhControl.listKhach.Clear();
            HanhKhach khach = new HanhKhach();
            string maHK = "";
            Random rdm = new Random();
            maHK = "HK" + rdm.Next(10000, 99999).ToString().Trim();

            khach.MaHK = maHK.Trim();
            khach.Ten = txtHoTen.Text;
            khach.DiaChi = txtDiaChi.Text;
            khach.QuocTich = ddlQuocTich.SelectedItem.Text;
            khach.DoTuoi = ddlDoTuoi.SelectedItem.Text;
            khach.DienThoai = txtSoDienThoai.Text;
            khach.Email = txtEmail.Text;
            khach.MaBF = "";

            ThongTinHanhTrinhControl.listKhach.Add(khach);
        }

        protected void InitControl()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            ddlDoTuoi.SelectedIndex = 2;
            lblMsg.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckValidData() == false)
            {
                return;
            }
            else
            {
                GetHanhKhachData();

                TinhTrangChuyen obj = new TinhTrangChuyen();
                obj = TinhTrangChuyenDB.GetInfo(ThongTinHanhTrinhControl.bf.HanhTrinh);

                if (obj != null)
                {
                    if (ddlDoTuoi.SelectedValue == "NguoiLon" || ddlDoTuoi.SelectedValue == "TreEm")
                    {
                        if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng thường")
                        {
                            ThongTinHanhTrinhControl.bf.GiaTien = obj.GiaVe1.Trim();
                        }
                        else if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng doanh nhân")
                        {
                            ThongTinHanhTrinhControl.bf.GiaTien = obj.GiaVe2.Trim();
                        }
                        else
                        {
                            ThongTinHanhTrinhControl.bf.GiaTien = obj.GiaVe3.Trim();
                        }
                    }
                    else
                    {
                        if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng thường")
                        {
                            ThongTinHanhTrinhControl.bf.GiaTien = obj.GiaVe1_TreEm.Trim();
                        }
                        else if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng doanh nhân")
                        {
                            ThongTinHanhTrinhControl.bf.GiaTien = obj.GiaVe2_TreEm.Trim();
                        }
                        else
                        {
                            ThongTinHanhTrinhControl.bf.GiaTien = obj.GiaVe3_TreEm.Trim();
                        }
                    }
                }
                Response.Redirect("DatVe_Step2.aspx");
            }
        }

        protected bool CheckValidData()
        {
            bool isValid = true;

            if (txtHoTen.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn phải nhập họ tên";
                txtHoTen.Focus();
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
    }
}