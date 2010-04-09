using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace TestDatabase
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BinDataToGridView();
        }

        protected SqlConnection GetConnection()
        {
            string strCon = "Data Source=NQMINH\\SQLEXPRESS;Initial Catalog=TestDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            return con;
        }

        protected void BinDataToGridView()
        {
            SqlConnection con = new SqlConnection();
            con = GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT *FROM tblUser";
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }
    }
}
