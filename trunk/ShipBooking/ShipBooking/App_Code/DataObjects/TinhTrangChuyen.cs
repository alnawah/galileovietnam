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
    public class TinhTrangChuyen
    {
        string _HanhTrinh;
        public string HanhTrinh
        {
            get { return _HanhTrinh; }
            set { _HanhTrinh = value; }
        }

        string _TinhTrang;
        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        string _MaTPDi;
        public string MaTPDi
        {
            get { return _MaTPDi; }
            set { _MaTPDi = value; }
        }

        string _MaTPDen;
        public string MaTPDen
        {
            get { return _MaTPDen; }
            set { _MaTPDen = value; }
        }
        
        string _GiaVe1;
        public string GiaVe1
        {
            get { return _GiaVe1; }
            set { _GiaVe1 = value; }
        }

        string _GiaVe2;
        public string GiaVe2
        {
            get { return _GiaVe2; }
            set { _GiaVe2 = value; }
        }

        string _GiaVe3;
        public string GiaVe3
        {
            get { return _GiaVe3; }
            set { _GiaVe3 = value; }
        }

        string _GiaVe1_TreEm;
        public string GiaVe1_TreEm
        {
            get { return _GiaVe1_TreEm; }
            set { _GiaVe1_TreEm = value; }
        }

        string _GiaVe2_TreEm;
        public string GiaVe2_TreEm
        {
            get { return _GiaVe2_TreEm; }
            set { _GiaVe2_TreEm = value; }
        }

        string _GiaVe3_TreEm;
        public string GiaVe3_TreEm
        {
            get { return _GiaVe3_TreEm; }
            set { _GiaVe3_TreEm = value; }
        }

        string _MaSoTau;
        public string MaSoTau
        {
            get { return _MaSoTau; }
            set { _MaSoTau = value; }
        }

        string _SoLuongVe1;
        public string SoLuongVe1
        {
            get { return _SoLuongVe1; }
            set { _SoLuongVe1 = value; }
        }

        string _SoLuongVe2;
        public string SoLuongVe2
        {
            get { return _SoLuongVe2; }
            set { _SoLuongVe2 = value; }
        }

        string _SoLuongVe3;
        public string SoLuongVe3
        {
            get { return _SoLuongVe3; }
            set { _SoLuongVe3 = value; }
        }

        DateTime _GioKhoiHanh_Thu2;
        public DateTime GioKhoiHanh_Thu2
        {
            get { return _GioKhoiHanh_Thu2; }
            set { _GioKhoiHanh_Thu2 = value; }
        }

        DateTime _GioKhoiHanh_Thu3;
        public DateTime GioKhoiHanh_Thu3
        {
            get { return _GioKhoiHanh_Thu3; }
            set { _GioKhoiHanh_Thu3 = value; }
        }

        DateTime _GioKhoiHanh_Thu4;
        public DateTime GioKhoiHanh_Thu4
        {
            get { return _GioKhoiHanh_Thu4; }
            set { _GioKhoiHanh_Thu4 = value; }
        }

        DateTime _GioKhoiHanh_Thu5;
        public DateTime GioKhoiHanh_Thu5
        {
            get { return _GioKhoiHanh_Thu5; }
            set { _GioKhoiHanh_Thu5 = value; }
        }

        DateTime _GioKhoiHanh_Thu6;
        public DateTime GioKhoiHanh_Thu6
        {
            get { return _GioKhoiHanh_Thu6; }
            set { _GioKhoiHanh_Thu6 = value; }
        }

        DateTime _GioKhoiHanh_Thu7;
        public DateTime GioKhoiHanh_Thu7
        {
            get { return _GioKhoiHanh_Thu7; }
            set { _GioKhoiHanh_Thu7 = value; }
        }

        DateTime _GioKhoiHanh_ChuNhat;
        public DateTime GioKhoiHanh_ChuNhat
        {
            get { return _GioKhoiHanh_ChuNhat; }
            set { _GioKhoiHanh_ChuNhat = value; }
        }

        DateTime _GioDen_Thu2;
        public DateTime GioDen_Thu2
        {
            get { return _GioDen_Thu2; }
            set { _GioDen_Thu2 = value; }
        }

        DateTime _GioDen_Thu3;
        public DateTime GioDen_Thu3
        {
            get { return _GioDen_Thu3; }
            set { _GioDen_Thu3 = value; }
        }

        DateTime _GioDen_Thu4;
        public DateTime GioDen_Thu4
        {
            get { return _GioDen_Thu4; }
            set { _GioDen_Thu4 = value; }
        }

        DateTime _GioDen_Thu5;
        public DateTime GioDen_Thu5
        {
            get { return _GioDen_Thu5; }
            set { _GioDen_Thu5 = value; }
        }

        DateTime _GioDen_Thu6;
        public DateTime GioDen_Thu6
        {
            get { return _GioDen_Thu6; }
            set { _GioDen_Thu6 = value; }
        }

        DateTime _GioDen_Thu7;
        public DateTime GioDen_Thu7
        {
            get { return _GioDen_Thu7; }
            set { _GioDen_Thu7 = value; }
        }

        DateTime _GioDen_ChuNhat;
        public DateTime GioDen_ChuNhat
        {
            get { return _GioDen_ChuNhat; }
            set { _GioDen_ChuNhat = value; }
        }

        string _SoGhe;
        public string SoGhe
        {
            get { return _SoGhe; }
            set { _SoGhe = value; }
        }
    }
}
