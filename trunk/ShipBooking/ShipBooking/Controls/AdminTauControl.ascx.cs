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
    public partial class AdminTauControl : System.Web.UI.UserControl
    {
        static bool CheckStatus = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
                FillDataGridView();
            }
        }

        protected void FillDataGridView()
        {
            string cmd = "SELECT *FROM tblTau";
            DataSet ds = new DataSet();
            ds = ShipBookingData.FillDataset(cmd);
            grvTau.DataSource = ds.Tables[0];
            grvTau.DataBind();

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtMaSoTau.Text = "";
            txtTenTau.Text = "";
            txtSoGhe.Text = "";
            txtThongTinKhac.Text = "";

            txtMaSoTau.Enabled = true;
            txtTenTau.Enabled = true;
            txtSoGhe.Enabled = true;
            txtThongTinKhac.Enabled = true;

            btnEdit.Enabled = false;
            btnSave.Enabled = true;

            CheckStatus = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaSoTau.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn hãy nhập mã số tàu";
                txtMaSoTau.Focus();
                return;
            }

            if (txtTenTau.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn hãy nhập tên tàu";
                txtTenTau.Focus();
                return;
            }

            if (txtSoGhe.Text.Trim() == "")
            {
                lblMsg.Text = "Bạn hãy nhập số ghế";
                txtSoGhe.Focus();
                return;
            }
            
            string MaSoTau = txtMaSoTau.Text.Trim();
            Tau tau = new Tau();

            tau = TauDB.GetInfo(MaSoTau);
            if (CheckStatus == true)
            {
                //Insert
                if (tau == null)
                {
                    tau = new Tau();
                    tau.MaSoTau = txtMaSoTau.Text.Trim();
                    tau.Ten = txtTenTau.Text.Trim();
                    tau.SoGhe = txtSoGhe.Text.Trim();
                    tau.ThongTin = txtThongTinKhac.Text.Trim();
                    TauDB.Insert(tau);
                }
                else 
                {
                    lblMsg.Text = "Mã số tàu đã tồn tại, bạn hãy nhập mã số khác!";
                    return;
                }
            }
            else
            {
                tau.MaSoTau = txtMaSoTau.Text.Trim();
                tau.Ten = txtTenTau.Text.Trim();
                tau.SoGhe = txtSoGhe.Text.Trim();
                tau.ThongTin = txtThongTinKhac.Text.Trim();
                TauDB.Update(tau);
            }

            InitControl();
            FillDataGridView();
            btnEdit.Enabled = true;
        }

        protected void grvTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd = "SELECT *FROM tblTau";
            DataSet ds = new DataSet();
            ds = ShipBookingData.FillDataset(cmd);

            txtMaSoTau.Text = ds.Tables[0].Rows[grvTau.SelectedIndex][0].ToString();
            txtTenTau.Text = ds.Tables[0].Rows[grvTau.SelectedIndex][1].ToString();
            txtSoGhe.Text = ds.Tables[0].Rows[grvTau.SelectedIndex][2].ToString();
            txtThongTinKhac.Text = ds.Tables[0].Rows[grvTau.SelectedIndex][3].ToString();

            InitControl();
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        protected void InitControl()
        {
            lblMsg.Text = "";
            btnSave.Enabled = false;
            btnEdit.Enabled = false;

            txtMaSoTau.Enabled = false;
            txtTenTau.Enabled = false;
            txtSoGhe.Enabled = false;
            txtThongTinKhac.Enabled = false;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtMaSoTau.Enabled = false;
            txtTenTau.Enabled = true;
            txtSoGhe.Enabled = true;
            txtThongTinKhac.Enabled = true;

            btnSave.Enabled = true;
            CheckStatus = false;
        }

        protected void grvTau_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grvTau_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvTau.PageIndex = e.NewPageIndex;
            FillDataGridView();
        }

        protected void grvTau_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
        }

        protected void grvTau_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strMaso = "";
            strMaso =  grvTau.Rows[e.RowIndex].Cells[0].Text.Trim();
            TauDB.Delete(strMaso.Trim());
            FillDataGridView();
        }
    }
}