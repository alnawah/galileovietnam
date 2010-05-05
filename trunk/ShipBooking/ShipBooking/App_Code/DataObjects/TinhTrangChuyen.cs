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
        //jkghdsjkfh
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

        string _MaSoTau;
        public string MaSoTau
        {
            get { return _MaSoTau; }
            set { _MaSoTau = value; }
        }

    }
}
