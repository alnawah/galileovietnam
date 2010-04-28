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
using ShipBooking.Library;
using ShipBooking.Module;

namespace ShipBooking
{
    public class NguoiNhanVeDB : ExecuteDataUtilities
    {
        public NguoiNhanVeDB()
        {
            //Hàm tạo
        }

        public static void Delete(string MaNguoiNhan)
        {
            string[] parameters = new string[] { "@MaNguoiNhan" };
            string[] values = new string[] { MaNguoiNhan };
            ExecuteData("spNguoiNhan_DeleteByID", parameters, values);
        }

        public static void Insert(NguoiNhanVe NguoiNhan)
        {
            string[] parameters = new string[] { "@MaNguoiNhan", "@Ten", "@DiaChi", "@MaThanhPho", "@DienThoai", "@Email", "@YeuCauKhac", "@ThoiGianGiaoVe" };
            string[] values = new string[] { NguoiNhan.MaNguoiNhan, NguoiNhan.Ten, NguoiNhan.DiaChi, NguoiNhan.MaThanhPho, NguoiNhan.DienThoai, NguoiNhan.Email, NguoiNhan.YeuCauKhac, NguoiNhan.ThoiGianGiaoVe };
            ExecuteData("spNguoiNhan_Insert", parameters, values);
        }

        public static void Update(NguoiNhanVe NguoiNhan)
        {
            string[] parameters = new string[] { "@MaNguoiNhan", "@Ten", "@DiaChi", "@MaThanhPho", "@DienThoai", "@Email", "@YeuCauKhac", "@ThoiGianGiaoVe" };
            string[] values = new string[] { NguoiNhan.MaNguoiNhan, NguoiNhan.Ten, NguoiNhan.DiaChi, NguoiNhan.MaThanhPho, NguoiNhan.DienThoai, NguoiNhan.Email, NguoiNhan.YeuCauKhac, NguoiNhan.ThoiGianGiaoVe };
            ExecuteData("spNguoiNhan_UpdateByID", parameters, values);
        }

        public static NguoiNhanVe GetInfo(string MaNguoiNhan)
        {
            DataTable dt = ShipBookingData.FillDataTable("spNguoiNhan_SelectByID", "@MaNguoiNhan", MaNguoiNhan);
            NguoiNhanVe NguoiNhan = new NguoiNhanVe();

            NguoiNhan.Ten = dt.Rows[0]["Ten"].ToString();
            NguoiNhan.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            NguoiNhan.MaThanhPho = dt.Rows[0]["MaThanhPho"].ToString();
            NguoiNhan.DienThoai = dt.Rows[0]["DienThoai"].ToString();
            NguoiNhan.Email = dt.Rows[0]["Email"].ToString();
            NguoiNhan.YeuCauKhac = dt.Rows[0]["YeuCauKhac"].ToString();
            NguoiNhan.ThoiGianGiaoVe = dt.Rows[0]["ThoiGianGiaoVe"].ToString();
           
            return NguoiNhan;
        }
    }
}
