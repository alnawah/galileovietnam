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
    public class TauDB : ExecuteDataUtilities
    {
        public TauDB()
        {
            //Ham tao
        }

        public static void Delete(string MaSoTau)
        {
            string[] parameters = new string[] { "@MaSoTau" };
            string[] values = new string[] { MaSoTau };
            ExecuteData("spTau_DeleteByID", parameters, values);
        }

        public static void Insert(Tau tau)
        {
            string[] parameters = new string[] { "@MaSoTau", "@Ten", "@SoGhe", "@ThongTin" };
            string[] values = new string[] { tau.MaSoTau, tau.Ten, tau.SoGhe, tau.ThongTin };
            ExecuteData("spTau_Insert", parameters, values);
        }
        public static void Update(Tau tau)
        {
            string[] parameters = new string[] { "@MaSoTau", "@Ten", "@SoGhe", "@ThongTin" };
            string[] values = new string[] { tau.MaSoTau, tau.Ten, tau.SoGhe, tau.ThongTin };
            ExecuteData("spTau_UpdateByID", parameters, values);
        }

        public static Tau GetInfo(string MaSoTau)
        {
            DataTable dt = ShipBookingData.FillDataTable("spTau_SelectByID", "@MaSoTau", MaSoTau);
            Tau tau = new Tau();

            if (dt.Rows.Count > 0)
            {
                tau.MaSoTau = dt.Rows[0]["MaSoTau"].ToString();
                tau.Ten = dt.Rows[0]["Ten"].ToString();
                tau.SoGhe = dt.Rows[0]["SoGhe"].ToString();
                tau.ThongTin = dt.Rows[0]["ThongTin"].ToString();
            }
            else
            {
                tau = null;
            }
            return tau;
        }
    }
}
