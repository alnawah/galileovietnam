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
using ShipBooking.Library;
using ShipBooking.Module;

namespace ShipBooking.Controls
{
    public partial class Admin_ThanhPhoControl : System.Web.UI.UserControl
    {
        static bool CheckStatus = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
                FillDataToGridView();
            }
        }

        private void InitControl()
        {
            lblMsg.Text = "";
            btnSave.Enabled = false;
            btnEdit.Enabled = false;

            txtMaTP.Enabled = false;
            txtTenTP.Enabled = false;
        }

        protected void FillDataToGridView()
        {
            string cmd = "SELECT *FROM tblThanhPho";
            DataSet ds = new DataSet();
            ds = ShipBookingData.FillDataset(cmd);
            grvThanhPho.DataSource = ds.Tables[0];
            grvThanhPho.DataBind();
        }

        protected void grvThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd = "SELECT *FROM tblThanhPho";
            DataSet ds = new DataSet();
            ds = ShipBookingData.FillDataset(cmd);

            txtMaTP.Text = ds.Tables[0].Rows[grvThanhPho.SelectedIndex][0].ToString().Trim();
            txtTenTP.Text = ds.Tables[0].Rows[grvThanhPho.SelectedIndex][1].ToString().Trim();

            InitControl();
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        protected void grvThanhPho_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvThanhPho.PageIndex = e.NewPageIndex;
            FillDataToGridView();
        }

        protected void grvThanhPho_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strMaso = "";
            strMaso = grvThanhPho.Rows[e.RowIndex].Cells[0].Text.Trim();
            ThanhPhoDB.Delete(strMaso.Trim());
            FillDataToGridView();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtMaTP.Enabled = false;
            txtTenTP.Enabled = true;

            btnSave.Enabled = true;
            CheckStatus = false;
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtMaTP.Text = "";
            txtTenTP.Text = "";

            txtMaTP.Enabled = true;
            txtTenTP.Enabled = true;

            btnEdit.Enabled = false;
            btnSave.Enabled = true;

            CheckStatus = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaTP.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn hãy nhập mã thành phố";
                txtMaTP.Focus();
                return;
            }

            if (txtTenTP.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn hãy nhập tên tên thành phố";
                txtTenTP.Focus();
                return;
            }

            string MaThanhPho = txtMaTP.Text.Trim();
            ThanhPho TP = new ThanhPho();

            TP = ThanhPhoDB.GetInfo(MaThanhPho);
            if (CheckStatus == true)
            {
                //Insert
                if (TP == null)
                {
                    TP = new ThanhPho();
                    TP.MaThanhPho = txtMaTP.Text.Trim();
                    TP.Ten = txtTenTP.Text.Trim();
                    ThanhPhoDB.Insert(TP);
                }
                else
                {
                    lblMsg.Text = "Mã số thành phố đã tồn tại, bạn hãy nhập mã số khác!";
                    return;
                }
            }
            else
            {
                TP.MaThanhPho = txtMaTP.Text.Trim();
                TP.Ten = txtTenTP.Text.Trim();
                ThanhPhoDB.Update(TP);
            }

            InitControl();
            FillDataToGridView();
            btnEdit.Enabled = true;
        }
    }
}