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
                InitControl();
                ListControlUtilities.FillDataToDropDownList(ddlThanhPho, "tblThanhPho", "Ten", "MaThanhPho");
                FillDataToDdlThoiGian();
                FillDataToRdbHinhThucThanhToan();
                FillBookingData();
                SetHanhKhachData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckValidData() == false)
            {
                return;
            }
            else
            {
                GetNguoiNhanVeData();
                Response.Redirect("DatVe_Review.aspx");
            }
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

        protected void FillDataToRdbHinhThucThanhToan()
        {
            ListItem item;

            item = new ListItem();
            item.Text = "Tại văn phòng đại lý";
            item.Value = "TaiVanPhongDaiLy";
            rblHinhThucThanhToan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Thanh toán khi giao vé";
            item.Value = "ThanhToanKhiGiaoVe";
            rblHinhThucThanhToan.Items.Add(item);
            item = null;

            item = new ListItem();
            item.Text = "Thanh toán bằng thẻ tín dụng";
            item.Value = "ThanhToanBangTheTinDung";
            rblHinhThucThanhToan.Items.Add(item);
            item = null;

            rblHinhThucThanhToan.SelectedIndex = 0;
        }

        protected void FillBookingData()
        {
            lblLoaiHanhTrinh.Text = ThongTinHanhTrinhControl.bf.LoaiChuyen;
            lblNoiDi.Text = ThongTinHanhTrinhControl.bf.NoiDi;
            lblNoiDen.Text = ThongTinHanhTrinhControl.bf.NoiDen;
            lblNgayDi.Text = ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString();
            if (ThongTinHanhTrinhControl.bf.LoaiChuyen == "Khứ hồi")
            {
                lblNgayVeLabel.Visible = true;
                lblNgayVe.Visible = true;
                lblNgayVe.Text = ThongTinHanhTrinhControl.bf.NgayVe.ToShortDateString();
            }
            else
            {
                lblNgayVeLabel.Visible = false;
                lblNgayVe.Visible = false;
            }
            lblGioKhoiHanh.Text = ThongTinHanhTrinhControl.bf.GioKhoiHanh.ToShortTimeString();
            lblGioDen.Text = ThongTinHanhTrinhControl.bf.GioDen.ToShortTimeString();
            lblLoaiVe.Text = ThongTinHanhTrinhControl.bf.LoaiVe;
            lblSLVe.Text = ThongTinHanhTrinhControl.bf.SoVe;
            string soghe = "";
            for (int i = 0; i < Convert.ToInt16(ThongTinHanhTrinhControl.bf.SoVe); i++)
            {
                if (BookingStep1Control.ListSoGhe[i].Trim() != "")
                {
                    soghe = soghe + BookingStep1Control.ListSoGhe[i].Trim();
                    if ((i + 1) < Convert.ToInt16(ThongTinHanhTrinhControl.bf.SoVe))
                    {
                        soghe = soghe + ", ";
                    }
                }
            }
            lblSoGhe.Text = soghe;
            lblTongGiaVe.Text = ThongTinHanhTrinhControl.bf.GiaTien;
        }

        protected void SetHanhKhachData()
        {
            DataTable dt = new DataTable("HanhKhach");
            dt.Columns.Add("Stt");
            dt.Columns.Add("TenKhach");
            dt.Columns.Add("LoaiTuoi");
            dt.Columns.Add("GiaVe");
            
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            for (int i = 0; i < ThongTinHanhTrinhControl.listKhach.Count(); i++)
            {
                ds.Tables[0].Rows.Add();
                ds.Tables[0].Rows[i].SetField("Stt", i + 1);
                ds.Tables[0].Rows[i].SetField("TenKhach", ThongTinHanhTrinhControl.listKhach[i].Ten);
                ds.Tables[0].Rows[i].SetField("LoaiTuoi", ThongTinHanhTrinhControl.listKhach[i].DoTuoi);
                ds.Tables[0].Rows[i].SetField("GiaVe", ThongTinHanhTrinhControl.listKhach[i].GiaTien.Trim() + " VNĐ");
            }
            grvHanhKhach.DataSource = ds.Tables[0];
            grvHanhKhach.DataBind();
        }

        protected void GetNguoiNhanVeData()
        {
            string strMaNN = "NN";
            Random rdm = new Random();
            strMaNN += rdm.Next(1000, 9999).ToString();

            NguoiNhan.MaNguoiNhan = strMaNN;
            NguoiNhan.Ten = txtTenNguoiNhan.Text;
            NguoiNhan.DiaChi = txtDiaChiNguoiNhan.Text;
            NguoiNhan.MaThanhPho = ddlThanhPho.SelectedItem.Text ;
            NguoiNhan.DienThoai = txtDienThoaiNguoiNhan.Text;
            NguoiNhan.Email = txtEmailNguoiNhan.Text;
            NguoiNhan.YeuCauKhac = txtYeuCauKhac.Text;
            NguoiNhan.ThoiGianGiaoVe = ddlThoiGianGiaoVe.SelectedItem.Text;            
            NguoiNhan.ThanhToan = rblHinhThucThanhToan.SelectedItem.Text;
        }

        protected bool CheckValidData()
        {
            bool isValid = true;

            if (txtTenNguoiNhan.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn phải nhập tên người nhận vé";
                txtTenNguoiNhan.Focus();
                isValid = false;
            }
            else
            {
                if (txtDiaChiNguoiNhan.Text.Trim() == "")
                {
                    lblMsg.Text = "Bạn phải nhập địa chỉ người nhận";
                    txtDiaChiNguoiNhan.Focus();
                    isValid = false;
                }
                else
                {
                    if (txtDienThoaiNguoiNhan.Text.Trim() == "")
                    {
                        lblMsg.Text = "Bạn phải nhập số điện thoại người nhận";
                        txtDienThoaiNguoiNhan.Focus();
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        protected void InitControl()
        {
            lblMsg.Text = "";
            txtTenNguoiNhan.Text = "";
            txtDiaChiNguoiNhan.Text = "";
            txtDienThoaiNguoiNhan.Text = "";
            txtEmailNguoiNhan.Text = "";
            txtYeuCauKhac.Text = "";
        }
    }
}