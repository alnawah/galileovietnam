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

namespace ShipBooking.Module
{
    public class BookingFile
    {
        string _MaBF;
        public string MaBF
        {
            get { return _MaBF; }
            set { _MaBF = value; }
        }

        string _LoaiChuyen;
        public string LoaiChuyen
        {
            get { return _LoaiChuyen; }
            set { _LoaiChuyen = value; }
        }

        string _NoiDi;
        public string NoiDi
        {
            get { return _NoiDi; }
            set { _NoiDi = value; }
        }

        string _NoiDen;
        public string NoiDen
        {
            get { return _NoiDen; }
            set { _NoiDen = value; }
        }

        DateTime _NgayDi;
        public DateTime NgayDi
        {
            get { return _NgayDi; }
            set { _NgayDi = value; }
        }

        DateTime _NgayVe;
        public DateTime NgayVe
        {
            get { return _NgayVe; }
            set { _NgayVe = value; }
        }

        string _ThoiGian;
        public string ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }

        bool _OpenChecking;
        public bool OpenChecking
        {
            get { return _OpenChecking; }
            set { _OpenChecking = value; }
        }

        string _LoaiVe;
        public string LoaiVe
        {
            get { return _LoaiVe; }
            set { _LoaiVe = value; }
        }

        string _SoGhe;
        public string SoGhe
        {
            get { return _SoGhe; }
            set { _SoGhe = value; }
        }

        string _GiaTien;
        public string GiaTien
        {
            get { return _GiaTien; }
            set { _GiaTien = value; }
        }

        string _ThanhToan;
        public string ThanhToan
        {
            get { return _ThanhToan; }
            set { _ThanhToan = value; }
        }

        string _MaNguoiNhan;
        public string MaNguoiNhan
        {
            get { return _MaNguoiNhan; }
            set { _MaNguoiNhan = value; }
        }

        string _HanhTrinh;
        public string HanhTrinh
        {
            get { return _HanhTrinh; }
            set { _HanhTrinh = value; }
        }

        string _TenKhach;
        public string TenKhach
        {
            get { return _TenKhach; }
            set { _TenKhach = value; }
        }

        DateTime _GioKhoiHanh;
        public DateTime GioKhoiHanh
        {
            get { return _GioKhoiHanh; }
            set { _GioKhoiHanh = value; }
        }

        DateTime _GioDen;
        public DateTime GioDen
        {
            get { return _GioDen; }
            set { _GioDen = value; }
        }

        string _SoVe1;
        public string SoVe1
        {
            get { return _SoVe1; }
            set { _SoVe1 = value; }
        }

        string _SoVe2;
        public string SoVe2
        {
            get { return _SoVe2; }
            set { _SoVe2 = value; }
        }

        string _SoVe3;
        public string SoVe3
        {
            get { return _SoVe3; }
            set { _SoVe3 = value; }
        }
    }
}
