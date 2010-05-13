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
    public class ThanhPho
    {
        string _MaThanhPho;
        public string MaThanhPho
        {
            get { return _MaThanhPho; }
            set { _MaThanhPho = value; }
        }

        string _Ten;
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
    }
}
