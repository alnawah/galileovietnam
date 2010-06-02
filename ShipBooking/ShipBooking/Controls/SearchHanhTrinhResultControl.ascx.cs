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

namespace ShipBooking.Controls
{
    public partial class SearchHanhTrinhResultControl : System.Web.UI.UserControl
    {
        public static HanhTrinh hanhtrinh = new HanhTrinh();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillSearchCondition();
                FillSearchResultToGridView();
            }
        }

        protected void FillSearchCondition()
        {
            lblLoaiChuyen.Text = ThongTinHanhTrinhControl.bf.LoaiChuyen.Trim();
            lblNoiDi.Text = ThongTinHanhTrinhControl.bf.NoiDi.Trim();
            lblNoiDen.Text = ThongTinHanhTrinhControl.bf.NoiDen.Trim();
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
        }

        protected void FillSearchResultToGridView()
        {
            DataSet ds = new DataSet();
            ds = HanhTrinhDB.GetDataSetHanhTrinhByChangAndNgayTrongTuan(ThongTinHanhTrinhControl.gMachang, ThongTinHanhTrinhControl.gNgaytrongtuan);
            grvTinhTrangCho.DataSource = ds;
            grvTinhTrangCho.DataBind();
            DateTime dt;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt = DateTime.Parse(ds.Tables[0].Rows[i]["GioKhoiHanh"].ToString().Trim());
                grvTinhTrangCho.Rows[i].Cells[2].Text = dt.TimeOfDay.ToString();

                dt = DateTime.Parse(ds.Tables[0].Rows[i]["GioDen"].ToString().Trim());
                grvTinhTrangCho.Rows[i].Cells[3].Text = dt.TimeOfDay.ToString();
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                lblMsg.Text = "Tìm được: " + ds.Tables[0].Rows.Count.ToString() + " kết quả";
            }
            else
            {
                lblMsg.Text = "Rất tiếc, không tìm thấy hành trình nào";
            }
        }

        protected void grvTinhTrangCho_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahanhtrinh = "";
            string MaChang = "";

            MaChang = ThongTinHanhTrinhControl.bf.HanhTrinh.Trim();
            DataSet ds = new DataSet();
            ds = HanhTrinhDB.GetDataSetHanhTrinhByChang(MaChang);
            mahanhtrinh = ds.Tables[0].Rows[grvTinhTrangCho.SelectedIndex]["MaHanhTrinh"].ToString().Trim();
            hanhtrinh = HanhTrinhDB.GetInfo(mahanhtrinh);
            if (hanhtrinh != null)
            {
                Response.Redirect("BookingSep1.aspx");
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongTinHanhTrinh.aspx");
        }
    }
}