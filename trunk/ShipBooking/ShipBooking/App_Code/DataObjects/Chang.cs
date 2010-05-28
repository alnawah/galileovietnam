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

namespace ShipBooking
{
    public class Chang
    {
        string _MaChang;
        public string MaChang
        {
            get { return _MaChang; }
            set { _MaChang = value; }
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
    }
}
