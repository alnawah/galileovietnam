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

namespace ProductTest
{
    public partial class LeftMenuControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void setMenuData()
        {
            Menu menu = new Menu();
            MenuItem item;

            item = new MenuItem();
            item.Text = "Home Page";
            item.Value = "valueHomePage";
            menu.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Contact Us";
            item.Value = "valueContactUs";
            menu.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Productions";
            item.Value = "valueProductions";
            menu.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Compare";
            item.Value = "valueCompare";
            menu.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Links";
            item.Value = "valueLinks";
            menu.Items.Add(item);
            item = null;
        }
    }
}