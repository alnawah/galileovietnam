﻿using System;
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
    public partial class ThemHanhKhachControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
                SetVisibleRequiredValidatorControl();
                FillDataToDdlQuocTich();
                FillDataToDdlDoTuoi();
                SetHanhKhachData();
            }
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
                ds.Tables[0].Rows[i].SetField("GiaVe", DatVeControl.bf.GiaTien.Trim());
            }
            grvHanhKhach.DataSource = ds.Tables[0];
            grvHanhKhach.DataBind();
        }

        protected void btnHoanTat_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatVe_Step2.aspx");
        }

        protected void btnThemKhach_Click(object sender, EventArgs e)
        {
            GetHanhKhachData();
            SetHanhKhachData();
            InitData();
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

        protected void GetHanhKhachData()
        {
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
            khach = null;
        }

        protected void InitData()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            ddlQuocTich.SelectedIndex = 0;
            ddlDoTuoi.SelectedIndex = 0;
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

    }
} 