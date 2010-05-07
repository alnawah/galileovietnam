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
    public partial class AdminControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
                ListControlUtilities.FillDataToDropDownList(ddlSoHieuTau, "tblTau", "Ten", "MaSoTau");
                ListControlUtilities.FillDataToDropDownList(ddlNoiDi, "tblThanhPho", "Ten", "MaThanhPho");
                ListControlUtilities.FillDataToDropDownList(ddlNoiDen, "tblThanhPho", "Ten", "MaThanhPho");
            }
        }

        protected void FillData()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            TinhTrangChuyen obj = new TinhTrangChuyen();
            obj = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            if (obj.TinhTrang != null)
            {
                if (obj.TinhTrang.Trim() == "yes")
                {
                    rblTinhTrangChuyen.SelectedIndex = 0;
                    Panel1.Visible = true;
                    txtGiaVeThuong.Text = obj.GiaVe1.ToLower().Trim();
                    txtGiaVeDoanhNhan.Text = obj.GiaVe2.ToLower().Trim();
                    txtGiaVeVIP.Text = obj.GiaVe3.ToLower().Trim();
                    txtSoHieuTau.Text = obj.MaSoTau.Trim();
                }
                else
                {
                    rblTinhTrangChuyen.SelectedIndex = 1;
                    Panel1.Visible = false;
                }
            }
            else
            {
                rblTinhTrangChuyen.SelectedIndex = 1;
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

        protected void rblTinhTrangChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            TinhTrangChuyen obj = new TinhTrangChuyen();
            obj = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            if (rblTinhTrangChuyen.SelectedValue == "Yes")
            {
                Panel1.Visible = true;
                if (obj.TinhTrang != null)
                {
                    txtGiaVeThuong.Text = obj.GiaVe1.ToLower().Trim();
                    txtGiaVeDoanhNhan.Text = obj.GiaVe2.ToLower().Trim();
                    txtGiaVeVIP.Text = obj.GiaVe3.ToLower().Trim();
                    txtSoHieuTau.Text = obj.MaSoTau.Trim();
                }
            }
            else
            {
                Panel1.Visible = false;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        protected void SaveData()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            TinhTrangChuyen obj = new TinhTrangChuyen();
            obj = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            if (obj.HanhTrinh == null)
            {
                obj.HanhTrinh = strHanhTrinh;
                if (rblTinhTrangChuyen.SelectedValue == "Yes")
                {
                    obj.TinhTrang = "yes";
                }
                else
                {
                    obj.TinhTrang = "no";
                }
                obj.MaTPDi = ddlNoiDi.SelectedValue.ToUpper().Trim();
                obj.MaTPDen = ddlNoiDen.SelectedValue.ToUpper().Trim();
                obj.GiaVe1 = txtGiaVeThuong.Text.ToLower().Trim();
                obj.GiaVe2 = txtGiaVeDoanhNhan.Text.ToLower().Trim();
                obj.GiaVe3 = txtGiaVeVIP.Text.ToLower().Trim();
                obj.MaSoTau = txtSoHieuTau.Text.Trim();
                TinhTrangChuyenDB.Insert(obj);
            }
            else
            {
                obj.HanhTrinh = strHanhTrinh;
                if (rblTinhTrangChuyen.SelectedValue == "Yes")
                {
                    obj.TinhTrang = "yes";
                }
                else
                {
                    obj.TinhTrang = "no";
                }
                obj.MaTPDi = ddlNoiDi.SelectedValue.ToUpper().Trim();
                obj.MaTPDen = ddlNoiDen.SelectedValue.ToUpper().Trim();
                obj.GiaVe1 = txtGiaVeThuong.Text.ToLower().Trim();
                obj.GiaVe2 = txtGiaVeDoanhNhan.Text.ToLower().Trim();
                obj.GiaVe3 = txtGiaVeVIP.Text.ToLower().Trim();
                obj.MaSoTau = txtSoHieuTau.Text.Trim();
                TinhTrangChuyenDB.Update(obj);
            }
        }

        protected void FillDataToDdlSoHieuTau()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            TinhTrangChuyen obj = new TinhTrangChuyen();
            obj = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            ListControlUtilities.FillDataToDropDownList(ddlSoHieuTau, "tblTau", "Ten", "MaSoTau");
            ddlSoHieuTau.DataValueField = obj.MaSoTau;
        }

        protected void ddlSoHieuTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoHieuTau.Text = ddlSoHieuTau.SelectedItem.Text.Trim();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Tau.aspx");
        }


    }
}