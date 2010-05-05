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
        public class iTechProData
        {
            #region Khai báo biến
            protected string ssql;
            protected static SqlConnection sqlconn;
            protected static SqlCommand sqlcom;
            protected static SqlDataAdapter sqladapter;
            protected static DataSet mydata;
            protected static SqlDataReader sqlreader;
            #endregion

            #region Mở dữ liệu
            public static void opendata()
            {
                System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
                string driver = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Product.mdf;Integrated Security=True;User Instance=True";
                try
                {
                    sqlconn = new SqlConnection(driver);
                    if (sqlconn.State != ConnectionState.Open)
                    {
                        sqlconn.Open();
                    }
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write("Lỗi mở dữ liệu: " + ex.ToString());
                }
            }
            #endregion

            #region Đóng dữ liệu
            public static void closedata()
            {
                if (sqlconn.State != ConnectionState.Closed)
                {
                    sqlconn.Close();
                    sqlconn.Dispose();
                }
            }
            #endregion

            #region Điền dữ liệu vào DataTable từ một thủ tục trong Database
            public static DataTable FillDataTable(string store, string _thamso, string _giatri)
            {
                opendata();
                DataTable datatable = new DataTable();
                sqlcom = new SqlCommand();
                sqlcom.CommandText = store;
                sqlcom.Connection = sqlconn;
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.Parameters.AddWithValue(_thamso, _giatri);
                try
                {
                    //sqlcom.ExecuteNonQuery();
                    sqladapter = new SqlDataAdapter(sqlcom);
                    sqladapter.Fill(datatable);
                    sqladapter.Dispose();
                }
                finally
                {
                    closedata();
                }
                return datatable;
            }
            #endregion
        }
}
