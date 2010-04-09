using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ProductTest.Library;

namespace ProductTest.Modules.Introdure
{
    public class IntrodureDB : ExcuteDataHelper
    {
        public IntrodureDB()
        {
            //Hàm tạo
        }
        public static void Delete(string _pkIntrodureID)
        {
            string[] Parameters = new string[] { "@pkIntrodureID" };
            string[] Values = new string[] { _pkIntrodureID };
            executeData("spIntrodure_deletebyID", Parameters, Values);
        }
        public static void Insert(IntrodureInfo _introdure)
        {
            string[] Parameters = new string[7] { "@pkIntrodureID", "@sTitle", "@sImage", "@sSumary", "@sComment", "@sPage", "@iPosition" };
            string[] Values = new string[7] { _introdure.sTitle, _introdure.sImage, _introdure.sSumary, _introdure.sComment, _introdure.sPage, _introdure.sLang, _introdure.iPosition.ToString() };
            executeData("spIntrodure_edit", Parameters, Values);
        }
        public static void Update(IntrodureInfo _introdure)
        {
            string[] Parameters = new string[7] { "@pkIntrodureID", "@sTitle", "@sImage", "@sSumary", "@sComment", "@sPage", "@iPosition" };
            string[] Values = new string[7] { _introdure.sTitle, _introdure.sImage, _introdure.sSumary, _introdure.sComment, _introdure.sPage, _introdure.sLang, _introdure.iPosition.ToString() };
            executeData("spIntrodure_edit", Parameters, Values);
        }
        public static void UpdateIndex(string _pkIntrodureID, string _giatri)
        {
            string ssql = "UPDATE tblIntrodure SET iPosition=" + _giatri + " WHERE pkIntrodureID=" + _pkIntrodureID;
            executeData(ssql);
        }
        public static IntrodureInfo getInfo(string pkIntrodureID)
        {
            DataTable mydata = iTechProData.FillDataTable("spIntrodure_selectbyID", "@pkIntrodureID", pkIntrodureID);
            IntrodureInfo _introdure = new IntrodureInfo();
            _introdure.sTitle = mydata.Rows[0]["sTitle"].ToString();
            _introdure.sImage = mydata.Rows[0]["sImage"].ToString();
            _introdure.sSumary = mydata.Rows[0]["sSumary"].ToString();
            _introdure.sComment = mydata.Rows[0]["sComment"].ToString();
            _introdure.sPage = mydata.Rows[0]["sPage"].ToString();
            _introdure.sLang = mydata.Rows[0]["sLang"].ToString();
            _introdure.iPosition = int.Parse(mydata.Rows[0]["iPosition"].ToString());
            return _introdure;
        }
    }
}
