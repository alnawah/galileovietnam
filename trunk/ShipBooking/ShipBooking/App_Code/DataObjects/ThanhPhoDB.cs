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
using ShipBooking.Library;
using ShipBooking.Module;

namespace ShipBooking
{
    public class ThanhPhoDB : ExecuteDataUtilities
    {
        public ThanhPhoDB()
        {
            //Hàm tạo
        }

        public static void Delete(string MaThanhPho)
        {
            string[] parameters = new string[] { "@MaThanhPho" };
            string[] values = new string[] { MaThanhPho };
            ExecuteData("spThanhPho_DeleteByID", parameters, values);
        }

        public static void Insert(ThanhPho TP)
        {
            string[] parameters = new string[] { "@MaThanhPho", "@Ten" };
            string[] values = new string[] { TP.MaThanhPho, TP.Ten };
            ExecuteData("spThanhPho_Insert", parameters, values);
        }

        public static void Update(ThanhPho TP)
        {
            string[] parameters = new string[] { "@MaThanhPho", "@Ten" };
            string[] values = new string[] { TP.MaThanhPho, TP.Ten };
            ExecuteData("spThanhPho_UpdateByID", parameters, values);
        }

        public static ThanhPho GetInfo(string MaThanhPho)
        {
            DataTable dt = ShipBookingData.FillDataTable("spThanhPho_SelectByID", "@MaThanhPho", MaThanhPho);
            ThanhPho TP = new ThanhPho();
            if (dt.Rows.Count > 0)
            {
                TP.MaThanhPho = dt.Rows[0]["MaThanhPho"].ToString();
                TP.Ten = dt.Rows[0]["Ten"].ToString();
            }
            else
            {
                TP = null;
            }
            return TP;
        }
    }
}
