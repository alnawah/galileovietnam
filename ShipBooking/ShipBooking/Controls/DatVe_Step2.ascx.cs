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
    public partial class DatVe_Step2 : System.Web.UI.UserControl
    {
        public static NguoiNhanVe NguoiNhan = new NguoiNhanVe();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListControlUtilities.FillDataToDropDownList(ddlThanhPho, "tblThanhPho", "Ten", "MaThanhPho");
                FillDataToDdlThoiGian();
                SetBookingData();
                SetHanhKhachData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetNguoiNhanVeData();
            Response.Redirect("DatVe_Review.aspx");
        }

        protected void FillDataToDdlThoiGian()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Buổi sáng";
            item.Value = "Sang";
            ddlThoiGianGiaoVe.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Buổi chiều";
            item.Value = "Chieu";
            ddlThoiGianGiaoVe.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Buổi tối";
            item.Value = "Toi";
            ddlThoiGianGiaoVe.Items.Add(item);
            item = null;
        }

        protected void SetBookingData()
        {
            lblNoiDen1.Text = DatVeControl.bf.NoiDen;
            lblNoiDen2.Text = "";
            lblNoiDi1.Text = DatVeControl.bf.NoiDi;
            lblNoiDi2.Text = "";
            lblNgayDi.Text = DatVeControl.bf.NgayDi;
            lblNgayVe.Text = DatVeControl.bf.NgayVe;
            lblLoaiVe.Text = DatVeControl.bf.LoaiVe;
            lblGiaVN.Text = DatVeControl.bf.GiaTien;
            lblGiaNN.Text = "";
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



            ds.Tables[0].Rows.Add();
            ds.Tables[0].Rows[0].SetField("Stt", "1");
            ds.Tables[0].Rows[0].SetField("TenKhach", DatVeControl.khach.Ten);
            ds.Tables[0].Rows[0].SetField("DiaChi", DatVeControl.khach.DiaChi);
            ds.Tables[0].Rows[0].SetField("LoaiQuocTich", DatVeControl.khach.QuocTich);
            ds.Tables[0].Rows[0].SetField("LoaiTuoi", DatVeControl.khach.DoTuoi);
            ds.Tables[0].Rows[0].SetField("GiaVe", "4.500.000 VND");

            grvHanhKhach.DataSource = ds.Tables[0];
            grvHanhKhach.DataBind();
        }

        protected void GetNguoiNhanVeData()
        {
            NguoiNhan.Ten = txtTenNguoiNhan.Text;
            NguoiNhan.DiaChi = txtDiaChiNguoiNhan.Text;
            NguoiNhan.MaThanhPho = ddlThanhPho.SelectedItem.Text ;
            NguoiNhan.DienThoai = txtDienThoaiNguoiNhan.Text;
            NguoiNhan.Email = txtEmailNguoiNhan.Text;
            NguoiNhan.YeuCauKhac = txtYeuCauKhac.Text;
            NguoiNhan.ThoiGianGiaoVe = ddlThoiGianGiaoVe.SelectedItem.Text;
        }
    }
}