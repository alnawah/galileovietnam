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
using System.Drawing;

namespace ShipBooking.Controls
{
    public partial class BookingStep1Control : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResetRdbSoGhe();
                FillBookingData();
                FillTinhTrangVe();
                FillRdbSoGhe();
            }
        }

        protected void FillBookingData()
        {
            lblLoaiHanhTrinh.Text = ThongTinHanhTrinhControl.bf.LoaiChuyen.Trim();
            lblNoiDi.Text = ThongTinHanhTrinhControl.bf.NoiDi.Trim();
            lblNoiDen.Text = ThongTinHanhTrinhControl.bf.NoiDen.Trim();
            lblNgayKhoiHanh.Text = ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString();
            lblNgayVe.Text = ThongTinHanhTrinhControl.bf.NgayVe.ToShortDateString();
            lblGioKhoiHanh.Text = SearchHanhTrinhResultControl.hanhtrinh.GioKhoiHanh.ToShortTimeString();
            lblGioDen.Text = SearchHanhTrinhResultControl.hanhtrinh.GioDen.ToShortTimeString();
        }

        protected void FillRdbSoGhe()
        {
            int SoGhe = 0;
            ListItem item;
            List<BookingFile> BFList = new List<BookingFile>();
            BFList = BookingFileDB.GetListBookingFileByDate(ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString(), ThongTinHanhTrinhControl.bf.HanhTrinh.Trim());

            SoGhe = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoGhe.Trim());
            for (int i = 1; i <= SoGhe; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);
                rdbSoGhe.Items.Add(item);
                item = null;
            }

            //Remove những ghế đã được chọn trong ngày
            int SoGheDaDat = 0;
            for (int i = 1; i <= SoGhe; i++)
            {
                item = new ListItem();
                item.Text = Convert.ToString(i);
                item.Value = Convert.ToString(i);

                for (int j = 0; j < BFList.Count; j++)
                {
                    SoGheDaDat = Convert.ToInt16(BFList[j].SoGhe.Trim());
                    if (i == SoGheDaDat)
                    {
                        rdbSoGhe.Items.Remove(item);
                    }
                }
                item = null;
            }
        }

        protected void FillTinhTrangVe()
        {
            List<BookingFile> BFList = new List<BookingFile>();
            BFList = BookingFileDB.GetListBookingFileByDate(ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString(), ThongTinHanhTrinhControl.bf.HanhTrinh.Trim());
            ListItem item;

            lblGiaNL1.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon1.Trim() + " VNĐ";
            lblGiaNL2.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon2.Trim() + " VNĐ";
            lblGiaNL3.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon3.Trim() + " VNĐ";
            lblGiaTE1.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm1.Trim() + " VNĐ";
            lblGiaTE2.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm2.Trim() + " VNĐ";
            lblGiaTE3.Text = SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm3.Trim() + " VNĐ";

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int SLVe1 = 0;
            int SLVe2 = 0;
            int SLVe3 = 0;

            //------------------------------------------------------------------------------
            for (int i = 0; i < BFList.Count; i++)
            {
                if (BFList[i].LoaiVe.Equals("Hạng thường") == true)
                {
                    count1 += Convert.ToInt16(BFList[i].SoVe1);
                }
            }
            SLVe1 = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoLuongVe1);
            SLVe1 -= count1;
            if (SLVe1 > 0)
            {
                lblSLVe1.Text = Convert.ToString(SLVe1) + " vé";
                lblSLVe1.ForeColor = Color.Blue;
                for (int i = 1; i <= SLVe1; i++)
                {
                    item = new ListItem();
                    item.Text = Convert.ToString(i);
                    item.Value = Convert.ToString(i);
                    ddlSLVe1.Items.Add(item);
                    item = null;
                }
            }
            else
            {
                lblSLVe1.Text = "Đã hết vé";
                lblSLVe1.ForeColor = Color.Red;
            }
            //------------------------------------------------------------------------------
            for (int i = 0; i < BFList.Count; i++)
            {
                if (BFList[i].LoaiVe.Equals("Hạng thường") == true)
                {
                    count2 += Convert.ToInt16(BFList[i].SoVe2);
                }
            }
            SLVe2 = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoLuongVe2);
            SLVe2 -= count2;
            if (SLVe2 > 0)
            {
                lblSLVe2.Text = Convert.ToString(SLVe2) + " vé";
                lblSLVe2.ForeColor = Color.Blue;
                for (int i = 1; i <= SLVe2; i++)
                {
                    item = new ListItem();
                    item.Text = Convert.ToString(i);
                    item.Value = Convert.ToString(i);
                    ddlSLVe2.Items.Add(item);
                    item = null;
                }
            }
            else
            {
                lblSLVe2.Text = "Đã hết vé";
                lblSLVe2.ForeColor = Color.Red;
            }
            //------------------------------------------------------------------------------
            for (int i = 0; i < BFList.Count; i++)
            {
                if (BFList[i].LoaiVe.Equals("Hạng thường") == true)
                {
                    count3 += Convert.ToInt16(BFList[i].SoVe3);
                }
            }
            SLVe3 = Convert.ToInt16(SearchHanhTrinhResultControl.hanhtrinh.SoLuongVe3);
            SLVe3 -= count3;
            if (SLVe3 > 0)
            {
                lblSLVe3.Text = Convert.ToString(SLVe3) + " vé";
                lblSLVe3.ForeColor = Color.Blue;
                for (int i = 1; i <= SLVe3; i++)
                {
                    item = new ListItem();
                    item.Text = Convert.ToString(i);
                    item.Value = Convert.ToString(i);
                    ddlSLVe3.Items.Add(item);
                    item = null;
                }
            }
            else
            {
                lblSLVe3.Text = "Đã hết vé";
                lblSLVe3.ForeColor = Color.Red;
            }
        }

        protected void ddlLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRdbSoGhe();
            FillTinhTrangVe();
            FillRdbSoGhe();
        }

        protected void ResetRdbSoGhe()
        {
            rdbSoGhe.Items.Clear();
        }

        protected void chkHangThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHangThuong.Checked == true)
            {
                ddlSLVe1.Enabled = true;
            }
            else
            {
                ddlSLVe1.Enabled = false;
            }
        }

        protected void chkHangDoanhNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHangDoanhNhan.Checked == true)
            {
                ddlSLVe2.Enabled = true;
            }
            else
            {
                ddlSLVe2.Enabled = false;
            }
        }

        protected void chkHangVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHangVIP.Checked == true)
            {
                ddlSLVe3.Enabled = true;
            }
            else
            {
                ddlSLVe3.Enabled = false;
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            GetBookingFileData();
            Response.Redirect("ThongTinKhach.aspx");
        }

        protected void GetBookingFileData()
        {
            ThongTinHanhTrinhControl.bf.MaBF = "";
            ThongTinHanhTrinhControl.bf.ThoiGian = "Buổi sáng";
            ThongTinHanhTrinhControl.bf.OpenChecking = true;
            ThongTinHanhTrinhControl.bf.LoaiVe = "None";
            ThongTinHanhTrinhControl.bf.SoGhe = rdbSoGhe.SelectedValue;
            ThongTinHanhTrinhControl.bf.GiaTien = "";
            ThongTinHanhTrinhControl.bf.ThanhToan = "";
            ThongTinHanhTrinhControl.bf.MaNguoiNhan = "";
            ThongTinHanhTrinhControl.bf.GioKhoiHanh = SearchHanhTrinhResultControl.hanhtrinh.GioKhoiHanh;
            ThongTinHanhTrinhControl.bf.GioDen = SearchHanhTrinhResultControl.hanhtrinh.GioDen;

            if (chkHangThuong.Checked == true)
            {
                ThongTinHanhTrinhControl.bf.SoVe1 = ddlSLVe1.SelectedValue;
            }
            else
            {
                ThongTinHanhTrinhControl.bf.SoVe1 = "0";
            }

            if (chkHangDoanhNhan.Checked == true)
            {
                ThongTinHanhTrinhControl.bf.SoVe2 = ddlSLVe2.SelectedValue;
            }
            else
            {
                ThongTinHanhTrinhControl.bf.SoVe2 = "0";
            }

            if (chkHangVIP.Checked == true)
            {
                ThongTinHanhTrinhControl.bf.SoVe3 = ddlSLVe3.SelectedValue;
            }
            else
            {
                ThongTinHanhTrinhControl.bf.SoVe3 = "0";
            }
        }

        protected string TongTien()
        {
            string values = "";
            int tongtien = 0;

        }
    }
}