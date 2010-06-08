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
    public class HanhKhach
    {
        string _MaHK;
        public string MaHK
        {
            get { return _MaHK; }
            set { _MaHK = value; }
        }

        string _Ten;
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        string _QuocTich;
        public string QuocTich
        {
            get { return _QuocTich; }
            set { _QuocTich = value; }
        }

        string _DoTuoi;
        public string DoTuoi
        {
            get { return _DoTuoi; }
            set { _DoTuoi = value; }
        }

        string _SoGhe;
        public string SoGhe
        {
            get { return _SoGhe; }
            set { _SoGhe = value; }
        }

        string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        string _MaBF;
        public string MaBF
        {
            get { return _MaBF; }
            set { _MaBF = value; }
        }

        string _GiaTien;
        public string GiaTien
        {
            get { return _GiaTien; }
            set { _GiaTien = value; }
        }
    }
}
