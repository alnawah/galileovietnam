using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ProductTest.Modules.Introdure
{
    public class IntrodureInfo
    {
        int _pkIntrodureID;
        public int pkIntrodureID
        {
            get { return _pkIntrodureID; }
            set { _pkIntrodureID = value; }
        }

        string _sTitle;
        public string sTitle
        {
            get { return _sTitle; }
            set { _sTitle = value; }
        }
        
        string _sImage;
        public string sImage
        {
            get { return _sImage; }
            set { _sImage = value; }
        }

        string _sSumary;
        public string sSumary
        {
            get { return _sSumary; }
            set { _sSumary = value; }
        }
        
        string _sComment;
        public string sComment
        {
            get { return _sComment; }
            set { _sComment = value; }
        }
        
        string _sPage;
        public string sPage
        {
            get { return _sPage; }
            set { _sPage = value; }
        }

        string _sLang;
        public string sLang
        {
            get { return _sLang; }
            set { _sLang = value; }
        }

        int _iPosition;
        public int iPosition
        {
            get { return _iPosition; }
            set { _iPosition = value; }
        }
    }
}
