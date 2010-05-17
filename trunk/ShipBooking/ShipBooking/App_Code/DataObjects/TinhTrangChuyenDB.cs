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
            string[] parameters = new string[] { "@HanhTrinh", "@TinhTrang", "@MaTPDi", "@MaTPDen", "@GiaVe1", "@GiaVe2", "@GiaVe3", "@GiaVe1_TreEm", "@GiaVe2_TreEm", "@GiaVe3_TreEm", "@MaSoTau", "@SoLuongVe1", "@SoLuongVe2", "@SoLuongVe3", "@GioKhoiHanh_Thu2", "@GioKhoiHanh_Thu3", "@GioKhoiHanh_Thu4", "@GioKhoiHanh_Thu5", "@GioKhoiHanh_Thu6", "@GioKhoiHanh_Thu7", "@GioKhoiHanh_ChuNhat", "@GioDen_Thu2", "@GioDen_Thu3", "@GioDen_Thu4", "@GioDen_Thu5", "@GioDen_Thu6", "@GioDen_Thu7", "@GioDen_ChuNhat", "@SoGhe" };
            string[] values = new string[] { obj.HanhTrinh, obj.TinhTrang, obj.MaTPDi, obj.MaTPDen, obj.GiaVe1, obj.GiaVe2, obj.GiaVe3, obj.GiaVe1_TreEm, obj.GiaVe2_TreEm, obj.GiaVe3_TreEm, obj.MaSoTau, obj.SoLuongVe1, obj.SoLuongVe2, obj.SoLuongVe3, obj.GioKhoiHanh_Thu2.ToString(), obj.GioKhoiHanh_Thu3.ToString(), obj.GioKhoiHanh_Thu4.ToString(), obj.GioKhoiHanh_Thu5.ToString(), obj.GioKhoiHanh_Thu6.ToString(), obj.GioKhoiHanh_Thu7.ToString(), obj.GioKhoiHanh_ChuNhat.ToString(), obj.GioDen_Thu2.ToString(), obj.GioDen_Thu3.ToString(), obj.GioDen_Thu4.ToString(), obj.GioDen_Thu5.ToString(), obj.GioDen_Thu6.ToString(), obj.GioDen_Thu7.ToString(), obj.GioDen_ChuNhat.ToString(), obj.SoGhe };
            ExecuteData("spTinhTrangChuyen_Insert", parameters, values);
        }

        public static void Update(TinhTrangChuyen obj)
        {
            string[] parameters = new string[] { "@HanhTrinh", "@TinhTrang", "@MaTPDi", "@MaTPDen", "@GiaVe1", "@GiaVe2", "@GiaVe3", "@GiaVe1_TreEm", "@GiaVe2_TreEm", "@GiaVe3_TreEm", "@MaSoTau", "@SoLuongVe1", "@SoLuongVe2", "@SoLuongVe3", "@GioKhoiHanh_Thu2", "@GioKhoiHanh_Thu3", "@GioKhoiHanh_Thu4", "@GioKhoiHanh_Thu5", "@GioKhoiHanh_Thu6", "@GioKhoiHanh_Thu7", "@GioKhoiHanh_ChuNhat", "@GioDen_Thu2", "@GioDen_Thu3", "@GioDen_Thu4", "@GioDen_Thu5", "@GioDen_Thu6", "@GioDen_Thu7", "@GioDen_ChuNhat", "@SoGhe" };
            string[] values = new string[] { obj.HanhTrinh, obj.TinhTrang, obj.MaTPDi, obj.MaTPDen, obj.GiaVe1, obj.GiaVe2, obj.GiaVe3, obj.GiaVe1_TreEm, obj.GiaVe2_TreEm, obj.GiaVe3_TreEm, obj.MaSoTau, obj.SoLuongVe1, obj.SoLuongVe2, obj.SoLuongVe3, obj.GioKhoiHanh_Thu2.ToString(), obj.GioKhoiHanh_Thu3.ToString(), obj.GioKhoiHanh_Thu4.ToString(), obj.GioKhoiHanh_Thu5.ToString(), obj.GioKhoiHanh_Thu6.ToString(), obj.GioKhoiHanh_Thu7.ToString(), obj.GioKhoiHanh_ChuNhat.ToString(), obj.GioDen_Thu2.ToString(), obj.GioDen_Thu3.ToString(), obj.GioDen_Thu4.ToString(), obj.GioDen_Thu5.ToString(), obj.GioDen_Thu6.ToString(), obj.GioDen_Thu7.ToString(), obj.GioDen_ChuNhat.ToString(), obj.SoGhe };
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
                obj.GiaVe1_TreEm = dt.Rows[0]["GiaVe1_TreEm"].ToString();
                obj.GiaVe2_TreEm = dt.Rows[0]["GiaVe2_TreEm"].ToString();
                obj.GiaVe3_TreEm = dt.Rows[0]["GiaVe3_TreEm"].ToString();
                obj.MaSoTau = dt.Rows[0]["MaSoTau"].ToString();
                obj.SoLuongVe1 = dt.Rows[0]["SoLuongVe1"].ToString();
                obj.SoLuongVe2 = dt.Rows[0]["SoLuongVe2"].ToString();
                obj.SoLuongVe3 = dt.Rows[0]["SoLuongVe3"].ToString();
                obj.GioKhoiHanh_Thu2 = DateTime.Parse(dt.Rows[0]["GioKhoiHanh_Thu2"].ToString());
                obj.GioKhoiHanh_Thu3 = DateTime.Parse(dt.Rows[0]["GioKhoiHanh_Thu3"].ToString());
                obj.GioKhoiHanh_Thu4 = DateTime.Parse(dt.Rows[0]["GioKhoiHanh_Thu4"].ToString());
                obj.GioKhoiHanh_Thu5 = DateTime.Parse(dt.Rows[0]["GioKhoiHanh_Thu5"].ToString());
                obj.GioKhoiHanh_Thu6 = DateTime.Parse(dt.Rows[0]["GioKhoiHanh_Thu6"].ToString());
                obj.GioKhoiHanh_Thu7 = DateTime.Parse(dt.Rows[0]["GioKhoiHanh_Thu7"].ToString());
                obj.GioKhoiHanh_ChuNhat = DateTime.Parse(dt.Rows[0]["GioKhoiHanh_ChuNhat"].ToString());
                obj.GioDen_Thu2 = DateTime.Parse(dt.Rows[0]["GioDen_Thu2"].ToString());
                obj.GioDen_Thu3 = DateTime.Parse(dt.Rows[0]["GioDen_Thu3"].ToString());
                obj.GioDen_Thu4 = DateTime.Parse(dt.Rows[0]["GioDen_Thu4"].ToString());
                obj.GioDen_Thu5 = DateTime.Parse(dt.Rows[0]["GioDen_Thu5"].ToString());
                obj.GioDen_Thu6 = DateTime.Parse(dt.Rows[0]["GioDen_Thu6"].ToString());
                obj.GioDen_Thu7 = DateTime.Parse(dt.Rows[0]["GioDen_Thu7"].ToString());
                obj.GioDen_ChuNhat = DateTime.Parse(dt.Rows[0]["GioDen_ChuNhat"].ToString());
                obj.SoGhe = dt.Rows[0]["SoGhe"].ToString();
            }
            else
            {
                obj = null;
            }
            return obj;
        }
    }
}
