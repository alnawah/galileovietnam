using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace LeisureDemo
{
    public partial class IndexPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillDataToDdlContry();
        }

        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NQMINH\\SQLEXPRESS;Initial Catalog=LeisureDemo;Integrated Security=True";
            return con;
        }
        
        protected void FillDataToDdlContry()
        {
            SqlConnection con = new SqlConnection();
            con = getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT pkCountryID, CountryName FROM tblCountry";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ddlCountry.DataSource = ds.Tables[0];
            ddlCountry.DataTextField = ds.Tables[0].Columns[1].ToString();
            ddlCountry.DataValueField = ds.Tables[0].Columns[0].ToString();
            ddlCountry.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
         
    }
}
