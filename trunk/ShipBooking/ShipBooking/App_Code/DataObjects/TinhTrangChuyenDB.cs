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
    public class TinhTrangChuyenDB : ExecuteDataUtilities
    {
        public TinhTrangChuyenDB()
        {
            //Hàm tạo
        }

        public static void Delete(string HanhTrinh)
        {
            string[] parameters = new string[] { "@HanhTrinh" };
            string[] values = new string[] { HanhTrinh };
            ExecuteData("spTinhTrangChuyen_DeleteByID", parameters, values);
        }

        public static void Insert(TinhTrangChuyen obj)
        {
            string[] parameters = new string[] { "@HanhTrinh", "@TinhTrang", "@MaTPDi", "@MaTPDen", "@GiaVe1", "@GiaVe2", "@GiaVe3", "@MaSoTau" };
            string[] values = new string[] { obj.HanhTrinh, obj.TinhTrang, obj.MaTPDi, obj.MaTPDen, obj.GiaVe1, obj.GiaVe2, obj.GiaVe3, obj.MaSoTau };
            ExecuteData("spTinhTrangChuyen_Insert", parameters, values);
        }

        public static void Update(TinhTrangChuyen obj)
        {
            string[] parameters = new string[] { "@HanhTrinh", "@TinhTrang", "@MaTPDi", "@MaTPDen", "@GiaVe1", "@GiaVe2", "@GiaVe3", "@MaSoTau" };
            string[] values = new string[] { obj.HanhTrinh, obj.TinhTrang, obj.MaTPDi, obj.MaTPDen, obj.GiaVe1, obj.GiaVe2, obj.GiaVe3, obj.MaSoTau };
            ExecuteData("spTinhTrangChuyen_UpdateByID", parameters, values);
        }

        public static TinhTrangChuyen GetInfo(string HanhTrinh)
        {
            DataTable dt = ShipBookingData.FillDataTable("spTinhTrangChuyen_SelectByID", "@HanhTrinh", HanhTrinh);
            TinhTrangChuyen obj = new TinhTrangChuyen();
            if (dt.Rows.Count > 0)
            {
                obj.HanhTrinh = dt.Rows[0]["HanhTrinh"].ToString();
                obj.TinhTrang = dt.Rows[0]["TinhTrang"].ToString();
                obj.MaTPDi = dt.Rows[0]["MaTPDi"].ToString();
                obj.MaTPDen = dt.Rows[0]["MaTPDen"].ToString();
                obj.GiaVe1 = dt.Rows[0]["GiaVe1"].ToString();
                obj.GiaVe2 = dt.Rows[0]["GiaVe2"].ToString();
                obj.GiaVe3 = dt.Rows[0]["GiaVe3"].ToString();
                obj.MaSoTau = dt.Rows[0]["MaSoTau"].ToString();
            }
            return obj;
        }
    }
}
