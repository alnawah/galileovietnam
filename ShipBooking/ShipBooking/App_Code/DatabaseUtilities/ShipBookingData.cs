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
            string stringConnection = "Data Source=112.78.2.84,1455;Initial Catalog=smartgate_vn_sb;Persist Security Info=True;User ID=smartgate_vn_sb;Password=MKfb8h5?lH9g";
            //string stringConnection = "Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Working\\GalileoData\\ShipBooking\\ShipBooking\\App_Data\\ShipBooking.mdf;Integrated Security=True;User Instance=True";
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
            cmd.CommandType = CommandType.StoredProcedure;
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

        #region Điền dữ liệu vào DataTable từ một thủ tục trong Database (overloading 2 params)
        public static DataTable FillDataTable(string store, string param1, string param2, string value1, string value2)
        {
            OpenData();
            DataTable table = new DataTable();
            cmd = new SqlCommand();
            cmd.CommandText = store;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue(param1, value1);
            cmd.Parameters.AddWithValue(param2, value2);
            cmd.CommandType = CommandType.StoredProcedure;
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

        #region Phương thức điền dữ liệu vào DataSet bằng lệnh truy vấn trực tiếp
        public static DataSet FillDataset(string ssql)
        {
            DataSet ds = new DataSet();
            OpenData();
            try
            {
                da = new SqlDataAdapter(ssql, con);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception exp)
            {
                CloseData();
                System.Web.HttpContext.Current.Response.Write(exp.ToString());
            }
            CloseData();
            return ds;
        }
        #endregion

        #region Phương thức điền dữ liệu vào DataSet bằng thủ tục truy vấn với tham số
        public static DataSet FillDataset(string store, string[] parameters, string[] values)
        {
            OpenData();
            DataSet ds = new DataSet();
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
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            finally
            {
                CloseData();
            }
            return ds;
        }
        #endregion

    }
}
