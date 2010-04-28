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
    public class BookingFileDB : ExecuteDataUtilities
    {
        public BookingFileDB()
        {
            //Hàm tạo
        }

        public static void Delete(string MaBF)
        {
            string[] parameters = new string[] { "@MaBF" };
            string[] values = new string[] { MaBF };
            ExecuteData("spBookingFile_DeleteByID", parameters, values);
        }

        public static void Insert(BookingFile bf)
        {
            string[] parameters = new string[] { "@MaBF", "@LoaiChuyen", "@NoiDi", "@NoiDen", "@NgayDi", "@NgayVe", "@ThoiGian", "@OpenChecking", "@LoaiVe", "@SoGhe", "@GiaTien", "@ThanhToan", "@MaNguoiNhan" };
            string[] values = new string[] { bf.MaBF, bf.LoaiChuyen, bf.NoiDi, bf.NoiDen, bf.NgayDi, bf.NgayVe, bf.ThoiGian, bf.OpenChecking.ToString(), bf.LoaiVe, bf.SoGhe, bf.GiaTien, bf.ThanhToan, bf.MaNguoiNhan };
            ExecuteData("spBookingFile_Insert", parameters, values);
        }

        public static void Update(BookingFile bf)
        {
            string[] parameters = new string[] { "@MaBF", "@LoaiChuyen", "@NoiDi", "@NoiDen", "@NgayDi", "@NgayVe", "@ThoiGian", "@OpenChecking", "@LoaiVe", "@SoGhe", "@GiaTien", "@ThanhToan", "@MaNguoiNhan" };
            string[] values = new string[] { bf.MaBF, bf.LoaiChuyen, bf.NoiDi, bf.NoiDen, bf.NgayDi, bf.NgayVe, bf.ThoiGian, bf.OpenChecking.ToString(), bf.LoaiVe, bf.SoGhe, bf.GiaTien, bf.ThanhToan, bf.MaNguoiNhan };
            ExecuteData("spBookingFile_UpdateByID", parameters, values);
        }

        public static BookingFile GetInfo(string MaBF)
        {
            DataTable dt = ShipBookingData.FillDataTable("spBookingFile_SelectByID", "@MaBF", MaBF);
            BookingFile bf = new BookingFile();
            bf.LoaiChuyen = dt.Rows[0]["LoaiChuyen"].ToString();
            bf.NoiDi = dt.Rows[0]["NoiDi"].ToString();
            bf.NoiDen = dt.Rows[0]["NoiDen"].ToString();
            bf.NgayDi = dt.Rows[0]["NgayDi"].ToString();
            bf.NgayVe = dt.Rows[0]["NgayVe"].ToString();
            bf.ThoiGian = dt.Rows[0]["ThoiGian"].ToString();
            bf.OpenChecking = Convert.ToBoolean(dt.Rows[0]["OpenChecking"].ToString());
            bf.LoaiVe = dt.Rows[0]["LoaiVe"].ToString();
            bf.SoGhe = dt.Rows[0]["SoGhe"].ToString();
            bf.GiaTien = dt.Rows[0]["GiaTien"].ToString();
            bf.ThanhToan = dt.Rows[0]["ThanhToan"].ToString();
            bf.MaNguoiNhan = dt.Rows[0]["MaNguoiNhan"].ToString();
            return bf;
        }
    }
}
