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
                InitControl();
                FillData();
                ListControlUtilities.FillDataToDropDownList(ddlSoHieuTau, "tblTau", "MaSoTau", "MaSoTau");
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

            if (obj != null)
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
                if (obj != null)
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

            TinhTrangChuyen obj;
            obj = TinhTrangChuyenDB.GetInfo(strHanhTrinh);

            if (obj == null)
            {
                obj = new TinhTrangChuyen();
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
                obj.MaSoTau = ddlSoHieuTau.SelectedValue.Trim();
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
                obj.MaSoTau = ddlSoHieuTau.SelectedValue.Trim();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Functions.aspx");
        }

        protected void btnDanhSachTP_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_ThanhPho.aspx");
        }

        protected void chkThu2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThu2.Checked == true)
            {
                txtGioKhoiHanh_Thu2.Enabled = true;
                txtGioDen_Thu2.Enabled = true;
                txtGioKhoiHanh_Thu2.Focus();
            }
            else
            {
                txtGioKhoiHanh_Thu2.Enabled = false;
                txtGioDen_Thu2.Enabled = false;
            }
        }

        protected void chkThu3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThu3.Checked == true)
            {
                txtGioKhoiHanh_Thu3.Enabled = true;
                txtGioDen_Thu3.Enabled = true;
                txtGioKhoiHanh_Thu3.Focus();
            }
            else
            {
                txtGioKhoiHanh_Thu3.Enabled = false;
                txtGioDen_Thu3.Enabled = false;
            }
        }

        protected void chkThu4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThu4.Checked == true)
            {
                txtGioKhoiHanh_Thu4.Enabled = true;
                txtGioDen_Thu4.Enabled = true;
                txtGioKhoiHanh_Thu4.Focus();
            }
            else
            {
                txtGioKhoiHanh_Thu4.Enabled = false;
                txtGioDen_Thu4.Enabled = false;
            }
        }

        protected void chkThu5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThu5.Checked == true)
            {
                txtGioKhoiHanh_Thu5.Enabled = true;
                txtGioDen_Thu5.Enabled = true;
                txtGioKhoiHanh_Thu5.Focus();
            }
            else
            {
                txtGioKhoiHanh_Thu5.Enabled = false;
                txtGioDen_Thu5.Enabled = false;
            }
        }

        protected void chkThu6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThu6.Checked == true)
            {
                txtGioKhoiHanh_Thu6.Enabled = true;
                txtGioDen_Thu6.Enabled = true;
                txtGioKhoiHanh_Thu6.Focus();
            }
            else
            {
                txtGioKhoiHanh_Thu6.Enabled = false;
                txtGioDen_Thu6.Enabled = false;
            }
        }

        protected void chkThu7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThu7.Checked == true)
            {
                txtGioKhoiHanh_Thu7.Enabled = true;
                txtGioDen_Thu7.Enabled = true;
                txtGioKhoiHanh_Thu7.Focus();
            }
            else
            {
                txtGioKhoiHanh_Thu7.Enabled = false;
                txtGioDen_Thu7.Enabled = false;
            }
        }

        protected void chkCN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCN.Checked == true)
            {
                txtGioKhoiHanh_ChuNhat.Enabled = true;
                txtGioDen_ChuNhat.Enabled = true;
                txtGioKhoiHanh_ChuNhat.Focus();
            }
            else
            {
                txtGioKhoiHanh_ChuNhat.Enabled = false;
                txtGioDen_ChuNhat.Enabled = false;
            }
        }

        protected void InitControl()
        {
            if (chkThu2.Checked == true)
            {
                txtGioKhoiHanh_Thu2.Enabled = true;
                txtGioDen_Thu2.Enabled = true;
            }
            else
            {
                txtGioKhoiHanh_Thu2.Enabled = false;
                txtGioDen_Thu2.Enabled = false;
            }

            if (chkThu3.Checked == true)
            {
                txtGioKhoiHanh_Thu3.Enabled = true;
                txtGioDen_Thu3.Enabled = true;
            }
            else
            {
                txtGioKhoiHanh_Thu3.Enabled = false;
                txtGioDen_Thu3.Enabled = false;
            }

            if (chkThu4.Checked == true)
            {
                txtGioKhoiHanh_Thu4.Enabled = true;
                txtGioDen_Thu4.Enabled = true;
            }
            else
            {
                txtGioKhoiHanh_Thu4.Enabled = false;
                txtGioDen_Thu4.Enabled = false;
            }

            if (chkThu5.Checked == true)
            {
                txtGioKhoiHanh_Thu5.Enabled = true;
                txtGioDen_Thu5.Enabled = true;
            }
            else
            {
                txtGioKhoiHanh_Thu5.Enabled = false;
                txtGioDen_Thu5.Enabled = false;
            }

            if (chkThu6.Checked == true)
            {
                txtGioKhoiHanh_Thu6.Enabled = true;
                txtGioDen_Thu6.Enabled = true;
            }
            else
            {
                txtGioKhoiHanh_Thu6.Enabled = false;
                txtGioDen_Thu6.Enabled = false;
            }

            if (chkThu7.Checked == true)
            {
                txtGioKhoiHanh_Thu7.Enabled = true;
                txtGioDen_Thu7.Enabled = true;
            }
            else
            {
                txtGioKhoiHanh_Thu7.Enabled = false;
                txtGioDen_Thu7.Enabled = false;
            }

            if (chkCN.Checked == true)
            {
                txtGioKhoiHanh_ChuNhat.Enabled = true;
                txtGioDen_ChuNhat.Enabled = true;
            }
            else
            {
                txtGioKhoiHanh_ChuNhat.Enabled = false;
                txtGioDen_ChuNhat.Enabled = false;
            }
        }
    }
}