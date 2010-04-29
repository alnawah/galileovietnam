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
                InitData();
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
            if (DatVeControl.bf.LoaiChuyen == "Khứ hồi")
            {
                lblNoiDi2.Text = DatVeControl.bf.NoiDen;
                lblNoiDen2.Text = DatVeControl.bf.NoiDi;
            }
            lblNgayDi.Text = DatVeControl.bf.NgayDi;
            lblNgayVe.Text = DatVeControl.bf.NgayVe;
            lblLoaiVe.Text = DatVeControl.bf.LoaiVe;
            lblGiaVN.Text = DatVeControl.bf.GiaTien;
            lblGiaNN.Text = "";
        }

        protected void GetHanhKhachData()
        {
            DatVeControl.listKhach.Clear();
            HanhKhach khach = new HanhKhach();

            khach.MaHK = "HK01";
            khach.Ten = txtHoTen.Text;
            khach.DiaChi = txtDiaChi.Text;
            khach.QuocTich = ddlQuocTich.SelectedItem.Text;
            khach.DoTuoi = ddlDoTuoi.SelectedItem.Text;
            khach.DienThoai = txtSoDienThoai.Text;
            khach.Email = txtEmail.Text;
            khach.MaBF = "BF01";

            DatVeControl.listKhach.Add(khach);
        }

        protected void InitData()
        {
            SetVisibleRequiredValidatorControl();
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetHanhKhachData();
            Response.Redirect("DatVe_Step2.aspx");
        }

    }
}