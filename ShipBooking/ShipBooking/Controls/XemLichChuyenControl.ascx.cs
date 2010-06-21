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

namespace ShipBooking.Controls
{
    public partial class XemLichChuyenControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListControlUtilities.FillDataToDropDownList(ddlNoiDi, "tblThanhPho", "Ten", "MaThanhPho");
                ListControlUtilities.FillCityData(ddlNoiDen, ddlNoiDi.SelectedValue);
            }
        }

        protected void ddlNoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListControlUtilities.FillCityData(ddlNoiDen, ddlNoiDi.SelectedValue);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (ddlNoiDi.SelectedValue == "" || ddlNoiDen.SelectedValue == "")
            {
                grwHanhTrinh.DataSource = null;
                grwHanhTrinh.DataBind();
                return;
            }
            else
            {
                
                SearchHanhTrinh();
            }
        }

        protected string GetMaChang()
        {
            string strNoiDi = "";
            string strNoiDen = "";
            string strHanhTrinh = "";

            strNoiDi = ddlNoiDi.SelectedValue.ToUpper();
            strNoiDen = ddlNoiDen.SelectedValue.ToUpper();
            strHanhTrinh = strNoiDi.Trim() + strNoiDen.Trim();

            return strHanhTrinh;
        }

        protected void SearchHanhTrinh()
        {
            string MaChang = "";
            MaChang = GetMaChang().Trim();
            DataSet ds = new DataSet();
            ds = HanhTrinhDB.GetDataSetHanhTrinhByChang(MaChang);
            grwHanhTrinh.DataSource = ds;
            grwHanhTrinh.DataBind();
            DateTime dt;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt = DateTime.Parse(ds.Tables[0].Rows[i]["GioKhoiHanh"].ToString().Trim());
                grwHanhTrinh.Rows[i].Cells[1].Text = dt.TimeOfDay.ToString();

                dt = DateTime.Parse(ds.Tables[0].Rows[i]["GioDen"].ToString().Trim());
                grwHanhTrinh.Rows[i].Cells[2].Text = dt.TimeOfDay.ToString();
            }
        }

        protected void grwHanhTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahanhtrinh = "";
            string MaChang = "";
            
            MaChang = GetMaChang().Trim();
            DataSet ds = new DataSet();
            ds = HanhTrinhDB.GetDataSetHanhTrinhByChang(MaChang);
            mahanhtrinh = ds.Tables[0].Rows[grwHanhTrinh.SelectedIndex]["MaHanhTrinh"].ToString().Trim();
        }
    }
}