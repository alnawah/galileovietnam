using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ShipBooking.Library
{
    public class ListControlUtilities : ShipBookingData
    {
        #region Phương thức điền dữ liệu vào DropDownList
        public static void FillDataToDropDownList(DropDownList control, string table, string dataTextField, string dataValueField)
        {
            OpenData();
            string strCommand = "SELECT " + dataTextField + ", " + dataValueField + " FROM " + table;
            da = new SqlDataAdapter(strCommand, con);
            ds = new DataSet();
            da.Fill(ds, strCommand);
            control.DataSource = ds;
            control.DataTextField = dataTextField;
            control.DataValueField = dataValueField;
            control.DataBind();
            CloseData();
        }
        #endregion

        #region Phương thức điền dữ liệu vào Checkbox List
        public static void FillDataToCheckboxList(CheckBoxList control, string table, string dataTextField, string dataValueField)
        {
            OpenData();
            string strCommand = "SELECT " + dataTextField + ", " + dataValueField + " FROM " + table;
            da = new SqlDataAdapter(strCommand, con);
            ds = new DataSet();
            da.Fill(ds, strCommand);
            control.DataSource = ds;
            control.DataTextField = dataTextField;
            control.DataValueField = dataValueField;
            control.DataBind();
            CloseData();
        }
        #endregion

        #region Phương thức điền dữ liệu vào DropDownList
        public static void FillCityData(DropDownList control, string MaTP)
        {
            OpenData();
            string strCommand = "SELECT tblThanhPho.Ten, tblThanhPho.MaThanhPho FROM tblTinhTrangChuyen CROSS JOIN tblThanhPho WHERE (tblThanhPho.MaThanhPho IN (SELECT tblTinhTrangChuyen.MaTPDen WHERE (tblTinhTrangChuyen.MaTPDi = '" + MaTP.ToUpper().Trim() + "') AND (tblTinhTrangChuyen.TinhTrang = 'yes')))";
            da = new SqlDataAdapter(strCommand, con);
            ds = new DataSet();
            da.Fill(ds, strCommand);
            control.DataSource = ds;
            control.DataTextField = "Ten";
            control.DataValueField = "MaThanhPho";
            control.DataBind();
            CloseData();
        }
        #endregion
    }
}
