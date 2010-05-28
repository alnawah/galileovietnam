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
    public class ChangDB : ExecuteDataUtilities
    {
        public ChangDB()
        {
            //Ham tao
        }

        public static void Delete(string MaChang)
        {
            string[] parameters = new string[] { "@MaChang" };
            string[] values = new string[] { MaChang };
            ExecuteData("spChang_DeleteByID", parameters, values);
        }

        public static void Insert(Chang chang)
        {
            string[] parameters = new string[] { "@MaChang", "@TinhTrang", "@MaTPDi", "@MaTPDen" };
            string[] values = new string[] { chang.MaChang, chang.TinhTrang, chang.MaTPDi, chang.MaTPDen };
            ExecuteData("spChang_Insert", parameters, values);
        }

        public static void Update(Chang chang)
        {
            string[] parameters = new string[] { "@MaChang", "@TinhTrang", "@MaTPDi", "@MaTPDen" };
            string[] values = new string[] { chang.MaChang, chang.TinhTrang, chang.MaTPDi, chang.MaTPDen };
            ExecuteData("spChang_UpdateByID", parameters, values);
        }

        public static Chang GetInfo(string MaChang)
        {
            DataTable dt = ShipBookingData.FillDataTable("spChang_SelectByID", "@MaChang", MaChang);
            Chang chang = new Chang();
            if (dt.Rows.Count > 0)
            {
                chang.MaChang = dt.Rows[0]["MaChang"].ToString();
                chang.TinhTrang = dt.Rows[0]["TinhTrang"].ToString();
                chang.MaTPDi = dt.Rows[0]["MaTPDi"].ToString();
                chang.MaTPDen = dt.Rows[0]["MaTPDen"].ToString();
            }
            else
            {
                chang = null;
            }
            return chang;
        }
    }
}
