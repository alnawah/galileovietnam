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

        protected void GetHanhKhachData()
        {
            DatVeControl.listKhach.Clear();
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

            DatVeControl.listKhach.Add(khach);
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
                if (txtDiaChi.Text.Trim() == "")
                {
                    lblMsg.Text = "Bạn phải nhập địa chỉ";
                    txtDiaChi.Focus();
                    isValid = false;
                }
                else
                {
                    if (txtSoDienThoai.Text.Trim() == "")
                    {
                        lblMsg.Text = "Bạn phải nhập số điện thoại";
                        txtSoDienThoai.Focus();
                        isValid = false;
                    }
                    else
                    {
                        if (txtEmail.Text.Trim() == "")
                        {
                            lblMsg.Text = "Bạn phải nhập địa chỉ email";
                            txtEmail.Focus();
                            isValid = false;
                        }
                    }
                }
            }

            return isValid;
        }
    }
}