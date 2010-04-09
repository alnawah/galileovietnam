using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ProductTest.Library
{
    public class ExcuteDataHelper : iTechProData
    {
        //Chồng phương thức thực thi dữ liệu executeData()

        #region Phương thức thực thi dữ liệu (thêm, sửa, xóa) khi đưa vào một tham số Sql
        public static void executeData(string sql)
        {
            opendata();
            sqlcom = new SqlCommand(sql, sqlconn);
            try
            {
                sqlcom.ExecuteNonQuery();
                closedata();
            }
            catch (Exception ex)
            {
                closedata();
                HttpContext.Current.Response.Write(sql + "<br/>");
                HttpContext.Current.Response.Write("Có lỗi trong quá trình thực thi: " + ex.ToString());
            }
        }
        #endregion

        #region Phương thức thực thi dữ liệu với tham số đưa vào
        public static void executeData(string store, string[] Parameter, string[] Values)
        {
            opendata();
            sqlcom = new SqlCommand();
            sqlcom.CommandText = store;
            sqlcom.Connection = sqlconn;
            sqlcom.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Parameter.Length; i++)
            {
                sqlcom.Parameters.AddWithValue(Parameter[i], Values[i]);
            }
            try
            {
                sqlcom.ExecuteNonQuery();
                closedata();
            }
            catch (Exception ex)
            {
                sqlconn.Close();
                HttpContext.Current.Response.Write(ex.ToString());
            }
        }
        #endregion
    }
}
