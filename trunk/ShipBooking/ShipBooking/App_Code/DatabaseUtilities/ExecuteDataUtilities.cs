using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace ShipBooking.Library
{
    public class ExecuteDataUtilities : ShipBookingData
    {
        #region Phương thức thực thi dữ liệu (thêm, sửa, xóa) khi đưa vào một tham số Sql
        public static void ExecuteData(string sql)
        {
            OpenData();
            cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                CloseData();
            }
            catch (Exception ex)
            {
                CloseData();
                HttpContext.Current.Response.Write(sql + "<br/>");
                HttpContext.Current.Response.Write("Có lỗi trong quá trình thực thi: " + ex.ToString());
            }
        }
        #endregion

        #region Phương thức thực thi dữ liệu với tham số đưa vào
        public static void ExecuteData(string store, string[] parameters, string[] values)
        {
            OpenData();
            cmd = new SqlCommand();
            cmd.CommandText = store;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue(parameters[i], values[i]);
            }
            try
            {
                cmd.ExecuteNonQuery();
                CloseData();
            }
            catch (Exception ex)
            {
                con.Close();
                HttpContext.Current.Response.Write(ex.ToString());
            }
        }
        #endregion
    }
}
