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
using System.Collections.Generic;
using ShipBooking.Library;
using ShipBooking.Module;

namespace ShipBooking
{
    public class HanhKhachDB : ExecuteDataUtilities
    {
        public HanhKhachDB()
        {
            //Hàm tạo
        }

        public static void Delete(string MaHK)
        {
            string[] parameters = new string[] { "@MaHK" };
            string[] values = new string[] { MaHK };
            ExecuteData("spHanhKhach_DeleteByID", parameters, values);
        }

        public static void DeleteFromBookingFile(string MaBF)
        {
            string[] parameters = new string[] { "@MaBF" };
            string[] values = new string[] { MaBF };
            ExecuteData("spHanhKhach_DeleteFromBookingFile", parameters, values);
        }

        public static void Insert(HanhKhach khach)
        {
            string[] parameters = new string[] { "@MaHK", "@Ten", "@DiaChi", "@QuocTich", "@DoTuoi", "@DienThoai", "@Email", "@MaBF", "@GiaTien" };
            string[] values = new string[] { khach.MaHK, khach.Ten, khach.DiaChi, khach.QuocTich, khach.DoTuoi, khach.DienThoai, khach.Email, khach.MaBF, khach.GiaTien };
            ExecuteData("spHanhKhach_Insert", parameters, values);
        }

        public static void Update(HanhKhach khach)
        {
            string[] parameters = new string[] { "@MaHK", "@Ten", "@DiaChi", "@QuocTich", "@DoTuoi", "@DienThoai", "@Email", "@MaBF", "@GiaTien" };
            string[] values = new string[] { khach.MaHK, khach.Ten, khach.DiaChi, khach.QuocTich, khach.DoTuoi, khach.DienThoai, khach.Email, khach.MaBF, khach.GiaTien };
            ExecuteData("spHanhKhach_UpdateByID", parameters, values);
        }

        public static HanhKhach GetInfo(string MaHK)
        {
            DataTable dt = ShipBookingData.FillDataTable("spHanhKhach_SelectByID", "@MaHK", MaHK);
            HanhKhach khach = new HanhKhach();

            if (dt.Rows.Count > 0)
            {
                khach.MaHK = dt.Rows[0]["MaHK"].ToString();
                khach.Ten = dt.Rows[0]["Ten"].ToString();
                khach.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                khach.QuocTich = dt.Rows[0]["QuocTich"].ToString();
                khach.DoTuoi = dt.Rows[0]["DoTuoi"].ToString();
                khach.DienThoai = dt.Rows[0]["DienThoai"].ToString();
                khach.Email = dt.Rows[0]["Email"].ToString();
                khach.MaBF = dt.Rows[0]["MaBF"].ToString();
                khach.GiaTien = dt.Rows[0]["GiaTien"].ToString();
            }
            else
            {
                khach = null;
            }
            return khach;
        }

        public static List<HanhKhach> GetListHanhKhachByName(string name)
        {
            List<HanhKhach> HKList = new List<HanhKhach>();
            HanhKhach khach;
            DataTable dt = ShipBookingData.FillDataTable("spHanhKhach_SelectByName", "@Ten", name);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                khach = new HanhKhach();
                khach.MaHK = dt.Rows[i]["MaHK"].ToString();
                khach.Ten = dt.Rows[i]["Ten"].ToString();
                khach.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khach.QuocTich = dt.Rows[i]["QuocTich"].ToString();
                khach.DoTuoi = dt.Rows[i]["DoTuoi"].ToString();
                khach.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                khach.Email = dt.Rows[i]["Email"].ToString();
                khach.MaBF = dt.Rows[i]["MaBF"].ToString();
                khach.GiaTien = dt.Rows[0]["GiaTien"].ToString();

                HKList.Add(khach);
                khach = null;
            }
            return HKList;
        }

        public static List<HanhKhach> GetListHanhKhachByBookingID(string MaBF)
        {
            List<HanhKhach> HKList = new List<HanhKhach>();
            HanhKhach khach;
            DataTable dt = ShipBookingData.FillDataTable("spHanhKhach_SelectByBookingID", "@MaBF", MaBF);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                khach = new HanhKhach();
                khach.MaHK = dt.Rows[i]["MaHK"].ToString();
                khach.Ten = dt.Rows[i]["Ten"].ToString();
                khach.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khach.QuocTich = dt.Rows[i]["QuocTich"].ToString();
                khach.DoTuoi = dt.Rows[i]["DoTuoi"].ToString();
                khach.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                khach.Email = dt.Rows[i]["Email"].ToString();
                khach.MaBF = dt.Rows[i]["MaBF"].ToString();
                khach.GiaTien = dt.Rows[0]["GiaTien"].ToString();

                HKList.Add(khach);
                khach = null;
            }
            return HKList;
        }
    }
}
