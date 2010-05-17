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

                    txtSoLuongVe1.Text = obj.SoLuongVe1.Trim();
                    txtSoLuongVe2.Text = obj.SoLuongVe2.Trim();
                    txtSoLuongVe3.Text = obj.SoLuongVe3.Trim();

                    #region Điền dữ liệu giờ khởi hành
                    if (obj.GioKhoiHanh_Thu2.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioKhoiHanh_Thu2.Text = obj.GioKhoiHanh_Thu2.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu2.Minute.ToString();
                        chkThu2.Checked = true;
                    }
                    else
                    {
                        txtGioKhoiHanh_Thu2.Text = "";
                        chkThu2.Checked = false;
                    }

                    if (obj.GioKhoiHanh_Thu3.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioKhoiHanh_Thu3.Text = obj.GioKhoiHanh_Thu3.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu3.Minute.ToString();
                        chkThu3.Checked = true;
                    }
                    else
                    {
                        txtGioKhoiHanh_Thu3.Text = "";
                        chkThu3.Checked = false;
                    }

                    if (obj.GioKhoiHanh_Thu4.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioKhoiHanh_Thu4.Text = obj.GioKhoiHanh_Thu4.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu4.Minute.ToString();
                        chkThu4.Checked = true;
                    }
                    else
                    {
                        txtGioKhoiHanh_Thu4.Text = "";
                        chkThu4.Checked = false;
                    }

                    if (obj.GioKhoiHanh_Thu5.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioKhoiHanh_Thu5.Text = obj.GioKhoiHanh_Thu5.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu5.Minute.ToString();
                        chkThu5.Checked = true;
                    }
                    else
                    {
                        txtGioKhoiHanh_Thu5.Text = "";
                        chkThu5.Checked = false;
                    }

                    if (obj.GioKhoiHanh_Thu6.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioKhoiHanh_Thu6.Text = obj.GioKhoiHanh_Thu6.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu6.Minute.ToString();
                        chkThu6.Checked = true;
                    }
                    else
                    {
                        txtGioKhoiHanh_Thu6.Text = "";
                        chkThu6.Checked = false;
                    }

                    if (obj.GioKhoiHanh_Thu7.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioKhoiHanh_Thu7.Text = obj.GioKhoiHanh_Thu7.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu7.Minute.ToString();
                        chkThu7.Checked = true;
                    }
                    else
                    {
                        txtGioKhoiHanh_Thu7.Text = "";
                        chkThu7.Checked = false;
                    }

                    if (obj.GioKhoiHanh_ChuNhat.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioKhoiHanh_ChuNhat.Text = obj.GioKhoiHanh_ChuNhat.Hour.ToString() + ":" + obj.GioKhoiHanh_ChuNhat.Minute.ToString();
                        chkCN.Checked = true;
                    }
                    else
                    {
                        txtGioKhoiHanh_ChuNhat.Text = "";
                        chkCN.Checked = false;
                    }
                    #endregion

                    #region Điền dữ liệu giờ khởi hành
                    if (obj.GioDen_Thu2.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioDen_Thu2.Text = obj.GioDen_Thu2.Hour.ToString() + ":" + obj.GioDen_Thu2.Minute.ToString();
                        chkThu2.Checked = true;
                    }
                    else
                    {
                        txtGioDen_Thu2.Text = "";
                        chkThu2.Checked = false;
                    }

                    if (obj.GioDen_Thu3.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioDen_Thu3.Text = obj.GioDen_Thu3.Hour.ToString() + ":" + obj.GioDen_Thu3.Minute.ToString();
                        chkThu3.Checked = true;
                    }
                    else
                    {
                        txtGioDen_Thu3.Text = "";
                        chkThu3.Checked = false;
                    }

                    if (obj.GioDen_Thu4.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioDen_Thu4.Text = obj.GioDen_Thu4.Hour.ToString() + ":" + obj.GioDen_Thu4.Minute.ToString();
                        chkThu4.Checked = true;
                    }
                    else
                    {
                        txtGioDen_Thu4.Text = "";
                        chkThu4.Checked = false;
                    }

                    if (obj.GioDen_Thu5.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioDen_Thu5.Text = obj.GioDen_Thu5.Hour.ToString() + ":" + obj.GioDen_Thu5.Minute.ToString();
                        chkThu5.Checked = true;
                    }
                    else
                    {
                        txtGioDen_Thu5.Text = "";
                        chkThu5.Checked = false;
                    }

                    if (obj.GioDen_Thu6.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioDen_Thu6.Text = obj.GioDen_Thu6.Hour.ToString() + ":" + obj.GioDen_Thu6.Minute.ToString();
                        chkThu6.Checked = true;
                    }
                    else
                    {
                        txtGioDen_Thu6.Text = "";
                        chkThu6.Checked = false;
                    }

                    if (obj.GioDen_Thu7.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioDen_Thu7.Text = obj.GioDen_Thu7.Hour.ToString() + ":" + obj.GioDen_Thu7.Minute.ToString();
                        chkThu7.Checked = true;
                    }
                    else
                    {
                        txtGioDen_Thu7.Text = "";
                        chkThu7.Checked = false;
                    }

                    if (obj.GioDen_ChuNhat.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                    {
                        txtGioDen_ChuNhat.Text = obj.GioDen_ChuNhat.Hour.ToString() + ":" + obj.GioDen_ChuNhat.Minute.ToString();
                        chkCN.Checked = true;
                    }
                    else
                    {
                        txtGioDen_ChuNhat.Text = "";
                        chkCN.Checked = false;
                    }
                    #endregion

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
            InitControl();
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
                rblTinhTrangChuyen.SelectedIndex = 0;
                Panel1.Visible = true;
                txtGiaVeThuong.Text = obj.GiaVe1.ToLower().Trim();
                txtGiaVeDoanhNhan.Text = obj.GiaVe2.ToLower().Trim();
                txtGiaVeVIP.Text = obj.GiaVe3.ToLower().Trim();
                txtSoHieuTau.Text = obj.MaSoTau.Trim();

                txtSoLuongVe1.Text = obj.SoLuongVe1.Trim();
                txtSoLuongVe2.Text = obj.SoLuongVe2.Trim();
                txtSoLuongVe3.Text = obj.SoLuongVe3.Trim();

                #region Điền dữ liệu giờ khởi hành
                if (obj.GioKhoiHanh_Thu2.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioKhoiHanh_Thu2.Text = obj.GioKhoiHanh_Thu2.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu2.Minute.ToString();
                    chkThu2.Checked = true;
                }
                else
                {
                    txtGioKhoiHanh_Thu2.Text = "";
                    chkThu2.Checked = false;
                }

                if (obj.GioKhoiHanh_Thu3.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioKhoiHanh_Thu3.Text = obj.GioKhoiHanh_Thu3.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu3.Minute.ToString();
                    chkThu3.Checked = true;
                }
                else
                {
                    txtGioKhoiHanh_Thu3.Text = "";
                    chkThu3.Checked = false;
                }

                if (obj.GioKhoiHanh_Thu4.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioKhoiHanh_Thu4.Text = obj.GioKhoiHanh_Thu4.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu4.Minute.ToString();
                    chkThu4.Checked = true;
                }
                else
                {
                    txtGioKhoiHanh_Thu4.Text = "";
                    chkThu4.Checked = false;
                }

                if (obj.GioKhoiHanh_Thu5.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioKhoiHanh_Thu5.Text = obj.GioKhoiHanh_Thu5.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu5.Minute.ToString();
                    chkThu5.Checked = true;
                }
                else
                {
                    txtGioKhoiHanh_Thu5.Text = "";
                    chkThu5.Checked = false;
                }

                if (obj.GioKhoiHanh_Thu6.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioKhoiHanh_Thu6.Text = obj.GioKhoiHanh_Thu6.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu6.Minute.ToString();
                    chkThu6.Checked = true;
                }
                else
                {
                    txtGioKhoiHanh_Thu6.Text = "";
                    chkThu6.Checked = false;
                }

                if (obj.GioKhoiHanh_Thu7.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioKhoiHanh_Thu7.Text = obj.GioKhoiHanh_Thu7.Hour.ToString() + ":" + obj.GioKhoiHanh_Thu7.Minute.ToString();
                    chkThu7.Checked = true;
                }
                else
                {
                    txtGioKhoiHanh_Thu7.Text = "";
                    chkThu7.Checked = false;
                }

                if (obj.GioKhoiHanh_ChuNhat.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioKhoiHanh_ChuNhat.Text = obj.GioKhoiHanh_ChuNhat.Hour.ToString() + ":" + obj.GioKhoiHanh_ChuNhat.Minute.ToString();
                    chkCN.Checked = true;
                }
                else
                {
                    txtGioKhoiHanh_ChuNhat.Text = "";
                    chkCN.Checked = false;
                }
                #endregion

                #region Điền dữ liệu giờ khởi hành
                if (obj.GioDen_Thu2.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioDen_Thu2.Text = obj.GioDen_Thu2.Hour.ToString() + ":" + obj.GioDen_Thu2.Minute.ToString();
                    chkThu2.Checked = true;
                }
                else
                {
                    txtGioDen_Thu2.Text = "";
                    chkThu2.Checked = false;
                }

                if (obj.GioDen_Thu3.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioDen_Thu3.Text = obj.GioDen_Thu3.Hour.ToString() + ":" + obj.GioDen_Thu3.Minute.ToString();
                    chkThu3.Checked = true;
                }
                else
                {
                    txtGioDen_Thu3.Text = "";
                    chkThu3.Checked = false;
                }

                if (obj.GioDen_Thu4.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioDen_Thu4.Text = obj.GioDen_Thu4.Hour.ToString() + ":" + obj.GioDen_Thu4.Minute.ToString();
                    chkThu4.Checked = true;
                }
                else
                {
                    txtGioDen_Thu4.Text = "";
                    chkThu4.Checked = false;
                }

                if (obj.GioDen_Thu5.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioDen_Thu5.Text = obj.GioDen_Thu5.Hour.ToString() + ":" + obj.GioDen_Thu5.Minute.ToString();
                    chkThu5.Checked = true;
                }
                else
                {
                    txtGioDen_Thu5.Text = "";
                    chkThu5.Checked = false;
                }

                if (obj.GioDen_Thu6.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioDen_Thu6.Text = obj.GioDen_Thu6.Hour.ToString() + ":" + obj.GioDen_Thu6.Minute.ToString();
                    chkThu6.Checked = true;
                }
                else
                {
                    txtGioDen_Thu6.Text = "";
                    chkThu6.Checked = false;
                }

                if (obj.GioDen_Thu7.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioDen_Thu7.Text = obj.GioDen_Thu7.Hour.ToString() + ":" + obj.GioDen_Thu7.Minute.ToString();
                    chkThu7.Checked = true;
                }
                else
                {
                    txtGioDen_Thu7.Text = "";
                    chkThu7.Checked = false;
                }

                if (obj.GioDen_ChuNhat.Date != DateTime.Parse("1/1/1900 12:00:00 AM"))
                {
                    txtGioDen_ChuNhat.Text = obj.GioDen_ChuNhat.Hour.ToString() + ":" + obj.GioDen_ChuNhat.Minute.ToString();
                    chkCN.Checked = true;
                }
                else
                {
                    txtGioDen_ChuNhat.Text = "";
                    chkCN.Checked = false;
                }
                #endregion
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

        protected bool CheckValidTime(TextBox control)
        {
            bool isValid = false;
            string strDate = "";

            if (control != null)
            {
                if (control.Enabled == true)
                {
                    strDate = control.Text.Trim();
                    try
                    {
                        DateTime dt = DateTime.Parse(strDate);
                        isValid = true;
                    }
                    catch
                    {
                        lblMsg2.Text = "Giờ không hợp lệ";
                        control.Focus();
                        isValid = false;
                    }
                }
                else
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        protected string GetMaHanhTrinh()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            return strHanhTrinh;
        }

        protected void SaveData()
        {
            string strHanhTrinh = GetMaHanhTrinh();
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

                obj.SoLuongVe1 = txtSoLuongVe1.Text.Trim();
                obj.SoLuongVe2 = txtSoLuongVe2.Text.Trim();
                obj.SoLuongVe3 = txtSoLuongVe3.Text.Trim();

                #region Check & get giờ khởi hành
                if (CheckValidTime(txtGioKhoiHanh_Thu2) == true)
                {
                    if (txtGioKhoiHanh_Thu2.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu2 = DateTime.Parse(txtGioKhoiHanh_Thu2.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu2 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu3) == true)
                {
                    if (txtGioKhoiHanh_Thu3.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu3 = DateTime.Parse(txtGioKhoiHanh_Thu3.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu3 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu4) == true)
                {
                    if (txtGioKhoiHanh_Thu4.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu4 = DateTime.Parse(txtGioKhoiHanh_Thu4.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu4 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu5) == true)
                {
                    if (txtGioKhoiHanh_Thu5.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu5 = DateTime.Parse(txtGioKhoiHanh_Thu5.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu5 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu6) == true)
                {
                    if (txtGioKhoiHanh_Thu6.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu6 = DateTime.Parse(txtGioKhoiHanh_Thu6.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu6 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu7) == true)
                {
                    if (txtGioKhoiHanh_Thu7.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu7 = DateTime.Parse(txtGioKhoiHanh_Thu7.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu7 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_ChuNhat) == true)
                {
                    if (txtGioKhoiHanh_ChuNhat.Enabled == true)
                    {
                        obj.GioKhoiHanh_ChuNhat = DateTime.Parse(txtGioKhoiHanh_ChuNhat.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_ChuNhat = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }
                #endregion

                #region Check & get giờ đến
                if (CheckValidTime(txtGioDen_Thu2) == true)
                {
                    if (txtGioDen_Thu2.Enabled == true)
                    {
                        obj.GioDen_Thu2 = DateTime.Parse(txtGioDen_Thu2.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu2 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu3) == true)
                {
                    if (txtGioDen_Thu3.Enabled == true)
                    {
                        obj.GioDen_Thu3 = DateTime.Parse(txtGioDen_Thu3.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu3 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu4) == true)
                {
                    if (txtGioDen_Thu4.Enabled == true)
                    {
                        obj.GioDen_Thu4 = DateTime.Parse(txtGioDen_Thu4.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu4 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu5) == true)
                {
                    if (txtGioDen_Thu5.Enabled == true)
                    {
                        obj.GioDen_Thu5 = DateTime.Parse(txtGioDen_Thu5.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu5 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu6) == true)
                {
                    if (txtGioDen_Thu6.Enabled == true)
                    {
                        obj.GioDen_Thu6 = DateTime.Parse(txtGioDen_Thu6.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu6 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu7) == true)
                {
                    if (txtGioDen_Thu7.Enabled == true)
                    {
                        obj.GioDen_Thu7 = DateTime.Parse(txtGioDen_Thu7.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu7 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_ChuNhat) == true)
                {
                    if (txtGioDen_ChuNhat.Enabled == true)
                    {
                        obj.GioDen_ChuNhat = DateTime.Parse(txtGioDen_ChuNhat.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_ChuNhat = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }
                #endregion

                TinhTrangChuyenDB.Insert(obj);
                lblMsg.Text = "";
                lblMsg2.Text = "";
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

                obj.SoLuongVe1 = txtSoLuongVe1.Text.Trim();
                obj.SoLuongVe2 = txtSoLuongVe2.Text.Trim();
                obj.SoLuongVe3 = txtSoLuongVe3.Text.Trim();

                #region Check & get giờ khởi hành
                if (CheckValidTime(txtGioKhoiHanh_Thu2) == true)
                {
                    if (txtGioKhoiHanh_Thu2.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu2 = DateTime.Parse(txtGioKhoiHanh_Thu2.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu2 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu3) == true)
                {
                    if (txtGioKhoiHanh_Thu3.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu3 = DateTime.Parse(txtGioKhoiHanh_Thu3.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu3 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu4) == true)
                {
                    if (txtGioKhoiHanh_Thu4.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu4 = DateTime.Parse(txtGioKhoiHanh_Thu4.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu4 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu5) == true)
                {
                    if (txtGioKhoiHanh_Thu5.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu5 = DateTime.Parse(txtGioKhoiHanh_Thu5.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu5 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu6) == true)
                {
                    if (txtGioKhoiHanh_Thu6.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu6 = DateTime.Parse(txtGioKhoiHanh_Thu6.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu6 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_Thu7) == true)
                {
                    if (txtGioKhoiHanh_Thu7.Enabled == true)
                    {
                        obj.GioKhoiHanh_Thu7 = DateTime.Parse(txtGioKhoiHanh_Thu7.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_Thu7 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioKhoiHanh_ChuNhat) == true)
                {
                    if (txtGioKhoiHanh_ChuNhat.Enabled == true)
                    {
                        obj.GioKhoiHanh_ChuNhat = DateTime.Parse(txtGioKhoiHanh_ChuNhat.Text.Trim());
                    }
                    else
                    {
                        obj.GioKhoiHanh_ChuNhat = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }
                #endregion

                #region Check & get giờ đến
                if (CheckValidTime(txtGioDen_Thu2) == true)
                {
                    if (txtGioDen_Thu2.Enabled == true)
                    {
                        obj.GioDen_Thu2 = DateTime.Parse(txtGioDen_Thu2.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu2 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu3) == true)
                {
                    if (txtGioDen_Thu3.Enabled == true)
                    {
                        obj.GioDen_Thu3 = DateTime.Parse(txtGioDen_Thu3.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu3 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu4) == true)
                {
                    if (txtGioDen_Thu4.Enabled == true)
                    {
                        obj.GioDen_Thu4 = DateTime.Parse(txtGioDen_Thu4.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu4 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu5) == true)
                {
                    if (txtGioDen_Thu5.Enabled == true)
                    {
                        obj.GioDen_Thu5 = DateTime.Parse(txtGioDen_Thu5.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu5 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu6) == true)
                {
                    if (txtGioDen_Thu6.Enabled == true)
                    {
                        obj.GioDen_Thu6 = DateTime.Parse(txtGioDen_Thu6.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu6 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_Thu7) == true)
                {
                    if (txtGioDen_Thu7.Enabled == true)
                    {
                        obj.GioDen_Thu7 = DateTime.Parse(txtGioDen_Thu7.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_Thu7 = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }

                if (CheckValidTime(txtGioDen_ChuNhat) == true)
                {
                    if (txtGioDen_ChuNhat.Enabled == true)
                    {
                        obj.GioDen_ChuNhat = DateTime.Parse(txtGioDen_ChuNhat.Text.Trim());
                    }
                    else
                    {
                        obj.GioDen_ChuNhat = DateTime.Parse("01/01/1900");
                    }
                }
                else
                {
                    return;
                }
                #endregion

                TinhTrangChuyenDB.Update(obj);
                lblMsg.Text = "";
                lblMsg2.Text = "";
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