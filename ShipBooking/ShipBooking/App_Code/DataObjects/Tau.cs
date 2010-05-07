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
    public class Tau
    {
        string _MaSoTau;
        public string MaSoTau
        {
            get { return _MaSoTau; }
            set { _MaSoTau = value; }
        }

        string _Ten;
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        string _SoGhe;
        public string SoGhe
        {
            get { return _SoGhe; }
            set { _SoGhe = value; }
        }

        string _ThongTin;
        public string ThongTin
        {
            get { return _ThongTin; }
            set { _ThongTin = value; }
        } 
    }
}
