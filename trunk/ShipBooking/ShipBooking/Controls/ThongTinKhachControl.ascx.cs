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
        string loaichuyen;
        string noidi;
        string noiden;
        string ngaydi;
        string ngayve;
        string machang;
        string MaHanhTrinh;
        string LoaiVe;
        string SoVe;
        List<HanhKhach> listKhach = new List<HanhKhach>();
        HanhTrinh hanhtrinh = new HanhTrinh();
        protected void Page_Load(object sender, EventArgs e)
        {
            loaichuyen = Request.QueryString["LoaiChuyen"];
            noidi = Request.QueryString["NoiDi"];
            noiden = Request.QueryString["NoiDen"];
            ngaydi = Request.QueryString["NgayDi"];
            ngayve = Request.QueryString["NgayVe"];
            machang = Request.QueryString["MaChang"];
            MaHanhTrinh = Request.QueryString["MaHanhTrinh"];
            LoaiVe = Request.QueryString["LoaiVe"];
            SoVe = Request.QueryString["SoVe"];
            hanhtrinh = HanhTrinhDB.GetInfo(MaHanhTrinh);
            if (!IsPostBack)
            {
                InitControl();
                FillBookingData();
                SetVisibleHanhKhachDataControl();
            }
        }

        protected void FillBookingData()
        {
            lblLoaiHanhTrinh.Text = loaichuyen;
            lblNoiDi.Text = noidi;
            lblNoiDen.Text = noiden;
            lblNgayDi.Text = ngaydi;
            if (loaichuyen == "Khứ hồi")
            {
                lblNgayVeLabel.Visible = true;
                lblNgayVe.Visible = true;
                lblNgayVe.Text = ngayve;
            }
            else
            {
                lblNgayVeLabel.Visible = false;
                lblNgayVe.Visible = false;
            }
            if (hanhtrinh != null)
            {
                lblGioKhoiHanh.Text = hanhtrinh.GioKhoiHanh.ToShortTimeString();
                lblGioDen.Text = hanhtrinh.GioDen.ToShortTimeString();
            }
            lblLoaiVe.Text = LoaiVe;
            lblSLVe.Text = SoVe;

            string soghe = "";
            for (int i = 0; i < Convert.ToInt16(SoVe); i++)
            {
                if (BookingStep1Control.ListSoGhe[i].Trim() != "")
                {
                    soghe = soghe + BookingStep1Control.ListSoGhe[i].Trim();
                    if ((i + 1) < Convert.ToInt16(SoVe))
                    {
                        soghe = soghe + ", ";
                    }
                }
            }
            lblSoGhe.Text = soghe;
        }

        protected void GetHanhKhachData()
        {
            int slKhach = 0;
            string strTextBoxID = "";
            string strDdlID = "";
            TextBox[] textBox = new TextBox[100];
            DropDownList[] ddl = new DropDownList[100];
            HanhKhach khach;
            
            slKhach = Convert.ToInt16(SoVe);
            listKhach = new List<HanhKhach>();
            for (int i = 1; i <= slKhach; i++)
            {
                strTextBoxID = "txtHoTen" + i.ToString();
                strDdlID = "ddlDoTuoi" + i.ToString();
                textBox[i] = (TextBox)this.FindControl(strTextBoxID);
                ddl[i] = (DropDownList)this.FindControl(strDdlID);
                if (textBox[i] != null && ddl[i] != null)
                {
                    khach = new HanhKhach();
                    khach.MaHK = TaoMaHK(textBox[i].Text.Trim());
                    khach.Ten = textBox[i].Text.Trim();
                    khach.DiaChi = "";
                    khach.QuocTich = "";
                    khach.DoTuoi = ddl[i].SelectedItem.Text.Trim();
                    khach.SoGhe = BookingStep1Control.ListSoGhe[i - 1].Trim(); //Trường số điện thoại giờ dùng để lưu trữ số ghế của khách
                    khach.Email = "";
                    khach.MaBF = "";
                    khach.GiaTien = TinhGiaVe(ddl[i].SelectedValue.Trim());

                    listKhach.Add(khach);
                    khach = null;
                }
            }
        }

        protected void InitControl()
        {
            Panel [] panel = new Panel[15];
            string control = "";
            for (int i = 1; i <= 9; i++)
            {
                control = "Panel" + i.ToString();
                panel[i] = (Panel)this.FindControl(control);
                if (panel[i] != null)
                {
                    panel[i].Visible = false;
                }
            }
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
                TinhTongTien();

                string urlValue = "";
                string urlListMaKhach = "";
                string urlListTenKhach = "";
                string urlListTuoiKhach = "";
                string urlListSoGheKhach = "";
                string urlListGiaTienKhach = "";
                for (int i = 0; i < listKhach.Count; i++)
                {
                    urlListMaKhach += "MaKhach" + i.ToString() + "=" + listKhach[i].MaHK + "&";
                    urlListTenKhach += "TenKhach" + i.ToString() + "=" + listKhach[i].Ten + "&";
                    urlListTuoiKhach += "DoTuoiKhach" + i.ToString() + "=" + listKhach[i].DoTuoi + "&";
                    urlListSoGheKhach += "SoGheKhach" + i.ToString() + "=" + listKhach[i].SoGhe + "&";
                    urlListGiaTienKhach += "GiaTienKhach" + i.ToString() + "=" + listKhach[i].GiaTien + "&";
                }
                urlValue = "LoaiChuyen=" + loaichuyen + "&"
                        + "NoiDi=" + noidi + "&"
                        + "NoiDen=" + noiden + "&"
                        + "NgayDi=" + ngaydi + "&"
                        + "NgayVe=" + ngayve + "&"
                        + "MaChang=" + machang + "&"
                        + "MaHanhTrinh=" + MaHanhTrinh + "&"
                        + "LoaiVe=" + LoaiVe + "&"
                        + "SoVe=" + SoVe + "&"
                        + urlListMaKhach
                        + urlListTenKhach
                        + urlListTuoiKhach
                        + urlListSoGheKhach
                        + urlListGiaTienKhach
                        + "GiaTien=" + TinhTongTien();
               
                Response.Redirect("DatVe_Step2.aspx?" + urlValue);
            }
        }

        protected bool CheckValidData()
        {
            bool isValid = false;
            int slKhach = Convert.ToInt16(SoVe);
            TextBox[] textBox = new TextBox[15];
            string control = "";
            for (int i = 1; i <= slKhach; i++)
            {
                control = "txtHoTen" + i.ToString();
                textBox[i] = (TextBox)this.FindControl(control);
                if (textBox[i] != null)
                {
                    if (textBox[i].Text.Trim() == "")
                    {
                        lblMsg.Text = "Bạn phải nhập họ tên";
                        textBox[i].Focus();
                        isValid = false;
                        return isValid;
                    }
                    else if (textBox[i].Text.Trim().Length < 2)
                    {
                        lblMsg.Text = "Tên hành khách phải tối thiểu 2 ký tự";
                        textBox[i].Focus();
                        isValid = false;
                        return isValid;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
            }   
            return isValid;
        }

        protected void SetVisibleHanhKhachDataControl()
        {
            int slKhach = Convert.ToInt16(SoVe);
            Panel[] panel = new Panel[100];
            string control = "";
            for (int i = 1; i <= slKhach; i++)
            {
                control = "Panel" + i.ToString();
                panel[i] = (Panel)this.FindControl(control);
                if (panel[i] != null)
                {
                    panel[i].Visible = true;
                }
            }
        }

        protected string TinhGiaVe(string dotuoikhach)
        {
            string strGiave = "";
            if (loaichuyen == "Khứ hồi")
            {
                long giamgia = 0;
                long giave = 0;
                if (LoaiVe == "Hạng thường")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        try
                        {
                            giave = Convert.ToInt64(hanhtrinh.GiaVeTreEm1);
                            giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                    else
                    {
                        try
                        {
                            giave = Convert.ToInt64(hanhtrinh.GiaVeNguoiLon1);
                            giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                }
                else if (LoaiVe == "Hạng doanh nhân")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        try
                        {
                            giave = Convert.ToInt64(hanhtrinh.GiaVeTreEm2);
                            giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                    else
                    {
                        try
                        {
                            giave = Convert.ToInt64(hanhtrinh.GiaVeNguoiLon2);
                            giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                }
                else
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        try
                        {
                            giave = Convert.ToInt64(hanhtrinh.GiaVeTreEm3);
                            giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                    else
                    {
                        try
                        {
                            giave = Convert.ToInt64(hanhtrinh.GiaVeNguoiLon3);
                            giamgia = Convert.ToInt64(hanhtrinh.GiamGiaKhuHoi);
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                }
            }
            else
            {
                if (LoaiVe == "Hạng thường")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        strGiave = hanhtrinh.GiaVeTreEm1;
                    }
                    else
                    {
                        strGiave = hanhtrinh.GiaVeNguoiLon1;
                    }
                }
                else if (LoaiVe == "Hạng doanh nhân")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        strGiave = hanhtrinh.GiaVeTreEm2;
                    }
                    else
                    {
                        strGiave = hanhtrinh.GiaVeNguoiLon2;
                    }
                }
                else
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        strGiave = hanhtrinh.GiaVeTreEm3;
                    }
                    else
                    {
                        strGiave = hanhtrinh.GiaVeNguoiLon3;
                    }
                }
            }
            return strGiave.Trim();
        }

        protected string TinhTongTien()
        {
            string tongtien;
            long sum = 0;
            for (int i = 0; i < listKhach.Count; i++)
            {
                sum += Convert.ToInt64(listKhach[i].GiaTien);
            }
            tongtien = sum.ToString();
            //ThongTinHanhTrinhControl.bf.GiaTien = sum.ToString();
            return tongtien;
        }

        protected string TaoMaHK(string ten)
        {
            string mahk = "";
            Random rdm = new Random();

            //mahk = ten.Substring(0, 1).ToUpper() + ten.Substring(ten.Length - 1, ten.Length) + ten.Length.ToString() + rdm.Next(100, 999).ToString().Trim();
            mahk = ten[0].ToString().ToUpper() + ten[ten.Length - 1].ToString().ToUpper() + ten.Length.ToString() + rdm.Next(100, 999).ToString().Trim();
            return mahk;
        }

    }
}