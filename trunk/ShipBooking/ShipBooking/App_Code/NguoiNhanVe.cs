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
    public class NguoiNhanVe
    {
        string _MaNguoiNhan;
        public string MaNguoiNhan
        {
            get { return _MaNguoiNhan; }
            set { _MaNguoiNhan = value; }
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

        string _MaThanhPho;
        public string MaThanhPho
        {
            get { return _MaThanhPho; }
            set { _MaThanhPho = value; }
        }

        string _DienThoai;
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        string _YeuCauKhac;
        public string YeuCauKhac
        {
            get { return _YeuCauKhac; }
            set { _YeuCauKhac = value; }
        }

        string _ThanhToan;
        public string ThanhToan
        {
            get { return _ThanhToan; }
            set { _ThanhToan = value; }
        }

        string _ThoiGianGiaoVe;
        public string ThoiGianGiaoVe
        {
            get { return _ThoiGianGiaoVe; }
            set { _ThoiGianGiaoVe = value; }
        }
    }
}
