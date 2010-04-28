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
    public class ShipBookingData
    {
        #region Khai báo biến
        protected string strCon;
        protected static SqlConnection con;
        protected static SqlCommand cmd;
        protected static DataSet ds;
        protected static SqlDataAdapter da;
        protected static SqlDataReader dr;
        #endregion

        #region Mở dữ liệu
        public static void OpenData()
        {
            string stringConnection = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ShipBooking.mdf;Integrated Security=True;User Instance=True";
            try
            {
                con = new SqlConnection(stringConnection);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("Lỗi mở dữ liệu: " + ex.ToString());
            }
        }
        #endregion

        #region Đóng dữ liệu
        public static void CloseData()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
                con.Dispose();
            }
        }
        #endregion

        #region Điền dữ liệu vào DataTable từ một thủ tục trong Database
        public static DataTable FillDataTable(string store, string param, string value)
        {
            OpenData();
            DataTable table = new DataTable();
            cmd = new SqlCommand();
            cmd.CommandText = store;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue(param, value);
            try
            {
                da = new SqlDataAdapter(cmd);
                da.Fill(table);
                da.Dispose();
            }
            finally
            {
                CloseData();
            }
            return table;
        }
        #endregion
    }
}
