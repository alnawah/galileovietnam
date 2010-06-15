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
        string loaichuyen;
        string noidi;
        string noiden;
        string ngaydi;
        string ngayve;
        string machang;

        protected void Page_Load(object sender, EventArgs e)
        {
            loaichuyen = Request.QueryString["LoaiChuyen"];
            noidi = Request.QueryString["NoiDi"];
            noiden = Request.QueryString["NoiDen"];
            ngaydi = Request.QueryString["NgayDi"];
            ngayve = Request.QueryString["NgayVe"];
            machang = Request.QueryString["MaChang"];

            if (!IsPostBack)
            {
                FillSearchCondition();
                FillSearchResultToGridView();
            }
        }

        protected void FillSearchCondition()
        {
            lblLoaiChuyen.Text = loaichuyen;
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
        }

        protected void FillSearchResultToGridView()
        {
            string ngaytrongtuan = GetNgayTrongTuan(DateTime.Parse(ngaydi));
            DataSet ds = new DataSet();
            ds = HanhTrinhDB.GetDataSetHanhTrinhByChangAndNgayTrongTuan(machang, ngaytrongtuan);
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

        protected string GetNgayTrongTuan(DateTime dt)
        {
            string ngaytrongtuan = "";

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    {
                        ngaytrongtuan = "Thứ hai";
                    }
                    break;
                case DayOfWeek.Tuesday:
                    {
                        ngaytrongtuan = "Thứ ba";
                    }
                    break;
                case DayOfWeek.Wednesday:
                    {
                        ngaytrongtuan = "Thứ tư";
                    }
                    break;
                case DayOfWeek.Thursday:
                    {
                        ngaytrongtuan = "Thứ năm";
                    }
                    break;
                case DayOfWeek.Friday:
                    {
                        ngaytrongtuan = "Thứ sáu";
                    }
                    break;
                case DayOfWeek.Saturday:
                    {
                        ngaytrongtuan = "Thứ bảy";
                    }
                    break;
                case DayOfWeek.Sunday:
                    {
                        ngaytrongtuan = "Chủ nhật";
                    }
                    break;
                default:
                    break;
            }
            return ngaytrongtuan;
        }

        protected void grvTinhTrangCho_SelectedIndexChanged(object sender, EventArgs e)
        {
            string urlValue = "";
            urlValue = "LoaiChuyen=" + loaichuyen + "&"
                    + "NoiDi=" + noidi + "&"
                    + "NoiDen=" + noiden + "&"
                    + "NgayDi=" + ngaydi + "&"
                    + "NgayVe=" + ngayve + "&"
                    + "MaChang=" + machang + "&"
                    + "MaHanhTrinh=" + grvTinhTrangCho.Rows[grvTinhTrangCho.SelectedIndex].Cells[5].Text.Trim();

            Response.Redirect("BookingSep1.aspx?" + urlValue);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongTinHanhTrinh.aspx");
        }
    }
}