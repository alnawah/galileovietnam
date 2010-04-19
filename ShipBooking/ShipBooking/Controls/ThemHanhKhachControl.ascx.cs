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
    public partial class ThemHanhKhachControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void btnHoanTat_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatVe_Step2.aspx");
        }
    }
}