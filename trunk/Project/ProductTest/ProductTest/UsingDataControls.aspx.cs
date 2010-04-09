using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ProductTest.Library;


namespace ProductTest
{
    public partial class UsingDataControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListControlHelper.FillDataToDropDownList(ddlCompany, "Company", "CompanyName", "pkCompanyID");
                ListControlHelper.FillDataToRadioButtonList(RadioButtonList1, "Company", "CompanyName", "pkCompanyID");
                ListControlHelper.FillDataToListBox(ListBox1, "tblUser", "Name", "pkUserID");
                ListControlHelper.FillDataToCheckBoxList(CheckBoxList1, "Company", "CompanyName", "pkCompanyID");

                setMenuTest();
            }
        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCompany.Text = "Text: " + ddlCompany.SelectedItem.Text + ", giá trị: " + ddlCompany.SelectedValue.ToString();
        }

        protected void lkbtnVote_Click(object sender, EventArgs e)
        {
            lblResultRadioBtn.Text = "Text: " + RadioButtonList1.SelectedItem.Text + ", giá trị: " + RadioButtonList1.SelectedValue.ToString();
        }

        protected void btnSelectListBox_Click(object sender, EventArgs e)
        {
            lblSelectListBox.Text = "";
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    lblSelectListBox.Text += "<li>" + item.Text;
                }
            }
        }

        protected void btnChon_Click(object sender, EventArgs e)
        {
            lblSelectedCheckBoxList.Text = "";
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    lblSelectedCheckBoxList.Text += "<li>" + item.Text;
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            Menu menuPager = (Menu)this.GridView1.BottomPagerRow.FindControl("menuPager");
            for (int i = 0; i < GridView1.PageCount; i++)
            {
                MenuItem item = new MenuItem();
                item.Text = Convert.ToString(i + 1);
                item.Value = i.ToString();
                if (GridView1.PageIndex == i)
                {
                    item.Selected = true;
                }
                menuPager.Items.Add(item);
                menuPager.DataBind();
            }
        }

        protected void menuPager_MenuItemClick(object sender, MenuEventArgs e)
        {
            GridView1.PageIndex = Int32.Parse(e.Item.Value);
        }

        protected void mnuTest_MenuItemClick(object sender, MenuEventArgs e)
        {
            lblMenuTest.Text = "Bạn vừa chọn menu: " + e.Item.Text;
        }

        protected void setMenuTest()
        {
            Menu menuTest = (Menu)this.FindControl("mnuTest");
            MenuItem item;

            item = new MenuItem();
            item.Text = "Home";
            item.Value = "valueHome";
            menuTest.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Productions";
            item.Value = "valueProductions";
            menuTest.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Contact";
            item.Value = "valueContact";
            menuTest.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Preferences";
            item.Value = "valuePreferences";
            menuTest.Items.Add(item);
            item = null;

            menuTest.DataBind();
        }
    }
}
