using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ProductTest.Library
{
    public class ListControlHelper : iTechProData
    {
        #region Phương thức điền dữ liệu vào DropDownList
        public static void FillDataToDropDownList(DropDownList control, string table, string dataTextField, string dataValueField)
        {
            opendata();
            string strCommand = "SELECT " + dataTextField + ", " + dataValueField + " FROM " + table;
            sqladapter = new SqlDataAdapter(strCommand, sqlconn);
            mydata = new DataSet();
            sqladapter.Fill(mydata, strCommand);
            control.DataSource = mydata;
            control.DataTextField = dataTextField;
            control.DataValueField = dataValueField;
            control.DataBind();
            closedata();
        }
        #endregion

        #region Phương thức điền dữ liệu vào RadioButtonList
        public static void FillDataToRadioButtonList(RadioButtonList control, string table, string dataTextField, string dataValueField)
        {
            opendata();
            string strCommand = "SELECT " + dataTextField + ", " + dataValueField + " FROM " + table;
            sqladapter = new SqlDataAdapter(strCommand, sqlconn);
            mydata = new DataSet();
            sqladapter.Fill(mydata, strCommand);
            control.DataSource = mydata;
            control.DataTextField = dataTextField;
            control.DataValueField = dataValueField;
            control.DataBind();
            closedata();
        }
        #endregion

        #region Phương thức điền dữ liệu vào ListBox
        public static void FillDataToListBox(ListBox control, string table, string dataTextField, string dataValueField)
        {
            opendata();
            string strCommand = "SELECT " + dataTextField + ", " + dataValueField + " FROM " + table;
            sqladapter = new SqlDataAdapter(strCommand, sqlconn);
            mydata = new DataSet();
            sqladapter.Fill(mydata, strCommand);
            control.DataSource = mydata;
            control.DataTextField = dataTextField;
            control.DataValueField = dataValueField;
            control.DataBind();
            closedata();
        }
        #endregion

        #region Phương thức điền dữ liệu vào CheckBoxList
        public static void FillDataToCheckBoxList(CheckBoxList control, string table, string dataTextField, string dataValueField)
        {
            opendata();
            string strCommand = "SELECT " + dataTextField + ", " + dataValueField + " FROM " + table;
            sqladapter = new SqlDataAdapter(strCommand, sqlconn);
            mydata = new DataSet();
            sqladapter.Fill(mydata, strCommand);
            control.DataSource = mydata;
            control.DataTextField = dataTextField;
            control.DataValueField = dataValueField;
            control.DataBind();
            closedata();
        }
        #endregion
    }
}
