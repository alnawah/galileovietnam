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
using System.Collections.Generic;

namespace ShipBooking
{
    public class HanhTrinhDB : ExecuteDataUtilities
    {
        public HanhTrinhDB()
        {
            //Hàm tạo
        }

        public static void Delete(string MaHanhTrinh)
        {
            string[] parameters = new string[] { "@MaHanhTrinh" };
            string[] values = new string[] { MaHanhTrinh };
            ExecuteData("spHanhTrinh_DeleteByID", parameters, values);
        }

        public static void Insert(HanhTrinh hanhtrinh)
        {
            string[] parameters = new string[] { "@MaHanhTrinh", "@MaChang", "@SoHieuChuyenTau", "@GioKhoiHanh", "@GioDen", "@NgayDen", "@NgayTrongTuan", "@SoGhe", "@GiaVeNguoiLon1", "@GiaVeNguoiLon2", "@GiaVeNguoiLon3", "@GiaVeTreEm1", "@GiaVeTreEm2", "@GiaVeTreEm3", "@SoLuongVe1", "@SoLuongVe2", "@SoLuongVe3" };
            string[] values = new string[] { hanhtrinh.MaHanhTrinh, hanhtrinh.MaChang, hanhtrinh.SoHieuChuyenTau, hanhtrinh.GioKhoiHanh.ToString(), hanhtrinh.GioDen.ToString(), hanhtrinh.NgayDen, hanhtrinh.NgayTrongTuan, hanhtrinh.SoGhe.ToString(), hanhtrinh.GiaVeNguoiLon1.ToString(), hanhtrinh.GiaVeNguoiLon2.ToString(), hanhtrinh.GiaVeNguoiLon3.ToString(), hanhtrinh.GiaVeTreEm1.ToString(), hanhtrinh.GiaVeTreEm2.ToString(), hanhtrinh.GiaVeTreEm3.ToString(), hanhtrinh.SoLuongVe1.ToString(), hanhtrinh.SoLuongVe2.ToString(), hanhtrinh.SoLuongVe3.ToString() };
            ExecuteData("spHanhTrinh_Insert", parameters, values);
        }

        public static void Update(HanhTrinh hanhtrinh)
        {
            string[] parameters = new string[] { "@MaHanhTrinh", "@MaChang", "@SoHieuChuyenTau", "@GioKhoiHanh", "@GioDen", "@NgayDen", "@NgayTrongTuan", "@SoGhe", "@GiaVeNguoiLon1", "@GiaVeNguoiLon2", "@GiaVeNguoiLon3", "@GiaVeTreEm1", "@GiaVeTreEm2", "@GiaVeTreEm3", "@SoLuongVe1", "@SoLuongVe2", "@SoLuongVe3" };
            string[] values = new string[] { hanhtrinh.MaHanhTrinh, hanhtrinh.MaChang, hanhtrinh.SoHieuChuyenTau, hanhtrinh.GioKhoiHanh.ToString(), hanhtrinh.GioDen.ToString(), hanhtrinh.NgayDen, hanhtrinh.NgayTrongTuan, hanhtrinh.SoGhe.ToString(), hanhtrinh.GiaVeNguoiLon1.ToString(), hanhtrinh.GiaVeNguoiLon2.ToString(), hanhtrinh.GiaVeNguoiLon3.ToString(), hanhtrinh.GiaVeTreEm1.ToString(), hanhtrinh.GiaVeTreEm2.ToString(), hanhtrinh.GiaVeTreEm3.ToString(), hanhtrinh.SoLuongVe1.ToString(), hanhtrinh.SoLuongVe2.ToString(), hanhtrinh.SoLuongVe3.ToString() };
            ExecuteData("spHanhTrinh_UpdateByID", parameters, values);
        }

        public static HanhTrinh GetInfo(string MaHanhTrinh)
        {
            DataTable dt = ShipBookingData.FillDataTable("spHanhTrinh_SelectByID", "@MaHanhTrinh", MaHanhTrinh);
            HanhTrinh hanhtrinh = new HanhTrinh();

            if (dt.Rows.Count > 0)
            {
                hanhtrinh.MaHanhTrinh = dt.Rows[0]["MaHanhTrinh"].ToString();
                hanhtrinh.MaChang = dt.Rows[0]["MaChang"].ToString();
                hanhtrinh.SoHieuChuyenTau = dt.Rows[0]["SoHieuChuyenTau"].ToString();
                hanhtrinh.GioKhoiHanh = DateTime.Parse(dt.Rows[0]["GioKhoiHanh"].ToString());
                hanhtrinh.GioDen = DateTime.Parse(dt.Rows[0]["GioDen"].ToString());
                hanhtrinh.NgayDen = dt.Rows[0]["NgayDen"].ToString();
                hanhtrinh.NgayTrongTuan = dt.Rows[0]["NgayTrongTuan"].ToString();
                hanhtrinh.SoGhe = Convert.ToInt16(dt.Rows[0]["SoGhe"].ToString());
                hanhtrinh.GiaVeNguoiLon1 = Convert.ToInt16(dt.Rows[0]["GiaVeNguoiLon1"].ToString());
                hanhtrinh.GiaVeNguoiLon2 = Convert.ToInt16(dt.Rows[0]["GiaVeNguoiLon2"].ToString());
                hanhtrinh.GiaVeNguoiLon3 = Convert.ToInt16(dt.Rows[0]["GiaVeNguoiLon3"].ToString());
                hanhtrinh.GiaVeTreEm1 = Convert.ToInt16(dt.Rows[0]["GiaVeTreEm1"].ToString());
                hanhtrinh.GiaVeTreEm2 = Convert.ToInt16(dt.Rows[0]["GiaVeTreEm2"].ToString());
                hanhtrinh.GiaVeTreEm3 = Convert.ToInt16(dt.Rows[0]["GiaVeTreEm3"].ToString());
                hanhtrinh.SoLuongVe1 = Convert.ToInt16(dt.Rows[0]["SoLuongVe1"].ToString());
                hanhtrinh.SoLuongVe2 = Convert.ToInt16(dt.Rows[0]["SoLuongVe2"].ToString());
                hanhtrinh.SoLuongVe3 = Convert.ToInt16(dt.Rows[0]["SoLuongVe3"].ToString());
            }
            else
            {
                hanhtrinh = null;
            }
            return hanhtrinh;
        }

        public static List<HanhTrinh> GetListHanhTrinhByChang(string MaChang)
        {
            List<HanhTrinh> ListHanhTrinh = new List<HanhTrinh>();
            HanhTrinh hanhtrinh;
            DataTable dt = ShipBookingData.FillDataTable("spHanhTrinh_SelectByChang", "@MaChang", MaChang);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                hanhtrinh = new HanhTrinh();
                hanhtrinh.MaHanhTrinh = dt.Rows[0]["MaHanhTrinh"].ToString();
                hanhtrinh.MaChang = dt.Rows[0]["MaChang"].ToString();
                hanhtrinh.SoHieuChuyenTau = dt.Rows[0]["SoHieuChuyenTau"].ToString();
                hanhtrinh.GioKhoiHanh = DateTime.Parse(dt.Rows[0]["GioKhoiHanh"].ToString());
                hanhtrinh.GioDen = DateTime.Parse(dt.Rows[0]["GioDen"].ToString());
                hanhtrinh.NgayDen = dt.Rows[0]["NgayDen"].ToString();
                hanhtrinh.NgayTrongTuan = dt.Rows[0]["NgayTrongTuan"].ToString();
                hanhtrinh.SoGhe = Convert.ToInt16(dt.Rows[0]["SoGhe"].ToString());
                hanhtrinh.GiaVeNguoiLon1 = Convert.ToInt16(dt.Rows[0]["GiaVeNguoiLon1"].ToString());
                hanhtrinh.GiaVeNguoiLon2 = Convert.ToInt16(dt.Rows[0]["GiaVeNguoiLon2"].ToString());
                hanhtrinh.GiaVeNguoiLon3 = Convert.ToInt16(dt.Rows[0]["GiaVeNguoiLon3"].ToString());
                hanhtrinh.GiaVeTreEm1 = Convert.ToInt16(dt.Rows[0]["GiaVeTreEm1"].ToString());
                hanhtrinh.GiaVeTreEm2 = Convert.ToInt16(dt.Rows[0]["GiaVeTreEm2"].ToString());
                hanhtrinh.GiaVeTreEm3 = Convert.ToInt16(dt.Rows[0]["GiaVeTreEm3"].ToString());
                hanhtrinh.SoLuongVe1 = Convert.ToInt16(dt.Rows[0]["SoLuongVe1"].ToString());
                hanhtrinh.SoLuongVe2 = Convert.ToInt16(dt.Rows[0]["SoLuongVe2"].ToString());
                hanhtrinh.SoLuongVe3 = Convert.ToInt16(dt.Rows[0]["SoLuongVe3"].ToString());

                ListHanhTrinh.Add(hanhtrinh);
                hanhtrinh = null;
            }

            return ListHanhTrinh;
        }

        public static DataSet GetDataSetHanhTrinhByChang(string MaChang)
        {
            DataSet ds = new DataSet();
            string[] parameters = new string[] { "@MaChang" };
            string[] values = new string[] { MaChang };
            ds = ShipBookingData.FillDataset("spHanhTrinh_SelectByChang", parameters, values);
            return ds;
        }
    }
}
