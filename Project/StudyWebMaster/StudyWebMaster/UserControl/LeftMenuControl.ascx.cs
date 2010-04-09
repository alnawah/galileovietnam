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

namespace StudyWebMaster
{
    public partial class LeftMenuControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setMenuItem();
        }

        protected void setMenuItem()
        {
            Menu menu = (Menu)this.FindControl("mnuLeft");
            MenuItem item;

            item = new MenuItem();
            item.Text = "MacBook";
            item.Value = "valueMacBook";
            menu.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "MacBook Pro";
            item.Value = "valueMacBookPro";
            menu.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "MacBook Air";
            item.Value = "valueMacBookAir";
            menu.Items.Add(item);
            item = null;

            item = new MenuItem();
            item.Text = "Mac mini";
            item.Value = "valueMacMini";
            menu.Items.Add(item);
            item = null;


        }

        protected void mnuLeft_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}