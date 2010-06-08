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
using System.Web.UI.MobileControls;
using System.Collections.Generic;

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
            string[] parameters = new string[] { "@MaBF", "@LoaiChuyen", "@NoiDi", "@NoiDen", "@NgayDi", "@NgayVe", "@ThoiGian", "@OpenChecking", "@LoaiVe", "@SoGhe", "@GiaTien", "@ThanhToan", "@MaNguoiNhan", "@HanhTrinh", "@GioKhoiHanh", "@GioDen", "@SoVe" };
            string[] values = new string[] { bf.MaBF, bf.LoaiChuyen, bf.NoiDi, bf.NoiDen, bf.NgayDi.ToString(), bf.NgayVe.ToString(), bf.ThoiGian, bf.OpenChecking.ToString(), bf.LoaiVe, bf.SoGhe, bf.GiaTien, bf.ThanhToan, bf.MaNguoiNhan, bf.MaHanhTrinh, bf.GioKhoiHanh.ToString(), bf.GioDen.ToString(), bf.SoVe };
            ExecuteData("spBookingFile_Insert", parameters, values);
        }

        public static void Update(BookingFile bf)
        {
            string[] parameters = new string[] { "@MaBF", "@LoaiChuyen", "@NoiDi", "@NoiDen", "@NgayDi", "@NgayVe", "@ThoiGian", "@OpenChecking", "@LoaiVe", "@SoGhe", "@GiaTien", "@ThanhToan", "@MaNguoiNhan", "@HanhTrinh", "@GioKhoiHanh", "@GioDen", "@SoVe" };
            string[] values = new string[] { bf.MaBF, bf.LoaiChuyen, bf.NoiDi, bf.NoiDen, bf.NgayDi.ToString(), bf.NgayVe.ToString(), bf.ThoiGian, bf.OpenChecking.ToString(), bf.LoaiVe, bf.SoGhe, bf.GiaTien, bf.ThanhToan, bf.MaNguoiNhan, bf.MaHanhTrinh, bf.GioKhoiHanh.ToString(), bf.GioDen.ToString(), bf.SoVe };
            ExecuteData("spBookingFile_UpdateByID", parameters, values);
        }

        public static BookingFile GetInfo(string MaBF)
        {
            DataTable dt = ShipBookingData.FillDataTable("spBookingFile_SelectByID", "@MaBF", MaBF);
            BookingFile bf = new BookingFile();
            if (dt.Rows.Count > 0)
            {
                bf.MaBF = dt.Rows[0]["MaBF"].ToString();
                bf.LoaiChuyen = dt.Rows[0]["LoaiChuyen"].ToString();
                bf.NoiDi = dt.Rows[0]["NoiDi"].ToString();
                bf.NoiDen = dt.Rows[0]["NoiDen"].ToString();
                bf.NgayDi = DateTime.Parse(dt.Rows[0]["NgayDi"].ToString());
                bf.NgayVe = DateTime.Parse(dt.Rows[0]["NgayVe"].ToString());
                bf.ThoiGian = dt.Rows[0]["ThoiGian"].ToString();
                bf.OpenChecking = Convert.ToBoolean(dt.Rows[0]["OpenChecking"].ToString());
                bf.LoaiVe = dt.Rows[0]["LoaiVe"].ToString();
                bf.SoGhe = dt.Rows[0]["SoGhe"].ToString();
                bf.GiaTien = dt.Rows[0]["GiaTien"].ToString();
                bf.ThanhToan = dt.Rows[0]["ThanhToan"].ToString();
                bf.MaNguoiNhan = dt.Rows[0]["MaNguoiNhan"].ToString();
                bf.MaHanhTrinh = dt.Rows[0]["HanhTrinh"].ToString();
                bf.GioKhoiHanh = DateTime.Parse(dt.Rows[0]["GioKhoiHanh"].ToString());
                bf.GioDen = DateTime.Parse(dt.Rows[0]["GioDen"].ToString());
                bf.SoVe = dt.Rows[0]["SoVe"].ToString();
            }
            else
            {
                bf = null;
            }
            return bf;
        }

        public static List<BookingFile> GetListBookingFileByDate(string date, string hanhtrinh)
        {
            List<BookingFile> BFList = new List<BookingFile>();
            BookingFile BF;
            DataTable dt = ShipBookingData.FillDataTable("spBookingFile_SelectByDate", "@NgayDi", "@HanhTrinh", date, hanhtrinh);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BF = new BookingFile();
                BF.LoaiChuyen = dt.Rows[i]["LoaiChuyen"].ToString();
                BF.NoiDi = dt.Rows[i]["NoiDi"].ToString();
                BF.NoiDen = dt.Rows[i]["NoiDen"].ToString();
                BF.NgayDi = DateTime.Parse(dt.Rows[i]["NgayDi"].ToString());
                BF.NgayVe = DateTime.Parse(dt.Rows[i]["NgayVe"].ToString());
                BF.ThoiGian = dt.Rows[i]["ThoiGian"].ToString();
                BF.OpenChecking = Convert.ToBoolean(dt.Rows[0]["OpenChecking"].ToString());
                BF.LoaiVe = dt.Rows[i]["LoaiVe"].ToString();
                BF.SoGhe = dt.Rows[i]["SoGhe"].ToString();
                BF.GiaTien = dt.Rows[i]["GiaTien"].ToString();
                BF.ThanhToan = dt.Rows[i]["ThanhToan"].ToString();
                BF.MaNguoiNhan = dt.Rows[i]["MaNguoiNhan"].ToString();
                BF.MaHanhTrinh = dt.Rows[i]["HanhTrinh"].ToString();
                BF.GioKhoiHanh = DateTime.Parse(dt.Rows[i]["GioKhoiHanh"].ToString());
                BF.GioDen = DateTime.Parse(dt.Rows[i]["GioDen"].ToString());
                BF.SoVe = dt.Rows[i]["SoVe"].ToString();

                BFList.Add(BF);
                BF = null;
            }

            return BFList;
        }

        public static List<BookingFile> GetListBookingFileByTenKhach(string tenkhach)
        {
            List<BookingFile> BFList = new List<BookingFile>();
            BookingFile BF;
            DataTable dt = ShipBookingData.FillDataTable("spHanhKhach_SelectBookingByKhach", "@Ten", tenkhach);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BF = new BookingFile();
                BF.LoaiChuyen = dt.Rows[i]["LoaiChuyen"].ToString();
                BF.NoiDi = dt.Rows[i]["NoiDi"].ToString();
                BF.NoiDen = dt.Rows[i]["NoiDen"].ToString();
                BF.NgayDi = DateTime.Parse(dt.Rows[i]["NgayDi"].ToString());
                BF.NgayVe = DateTime.Parse(dt.Rows[i]["NgayVe"].ToString());
                BF.ThoiGian = dt.Rows[i]["ThoiGian"].ToString();
                BF.OpenChecking = Convert.ToBoolean(dt.Rows[0]["OpenChecking"].ToString());
                BF.LoaiVe = dt.Rows[i]["LoaiVe"].ToString();
                BF.SoGhe = dt.Rows[i]["SoGhe"].ToString();
                BF.GiaTien = dt.Rows[i]["GiaTien"].ToString();
                BF.ThanhToan = dt.Rows[i]["ThanhToan"].ToString();
                BF.MaNguoiNhan = dt.Rows[i]["MaNguoiNhan"].ToString();
                BF.MaHanhTrinh = dt.Rows[i]["HanhTrinh"].ToString();
                BF.GioKhoiHanh = DateTime.Parse(dt.Rows[i]["GioKhoiHanh"].ToString());
                BF.GioDen = DateTime.Parse(dt.Rows[i]["GioDen"].ToString());
                BF.SoVe = dt.Rows[i]["SoVe"].ToString();

                BFList.Add(BF);
                BF = null;
            }

            return BFList;
        }

        public static DataSet GetDataSetBookingFileByTenKhach(string tenkhach, string stardate, string enddate)
        {
            DataSet ds = new DataSet();
            string[] parameters = new string[] { "@Ten", "@StartDate", "@EndDate" };
            string[] values = new string[] { tenkhach, stardate, enddate }; 
            ds = ShipBookingData.FillDataset("spHanhKhach_SelectBookingByKhach", parameters, values);
            return ds;
        }
    }
}
