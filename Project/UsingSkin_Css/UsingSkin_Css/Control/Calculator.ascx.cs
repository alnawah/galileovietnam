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

namespace UsingSkin_Css.Control
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calculator(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "cal")
            {
                switch (e.CommandArgument.ToString())
                {
                    case "sum":
                    {
                        lblResult.Text = Convert.ToString(int.Parse(txta.Text) + int.Parse(txtb.Text));
                    }
                    break;
                    case "sub":
                    {
                        lblResult.Text = Convert.ToString(int.Parse(txta.Text) - int.Parse(txtb.Text));
                    }
                    break;
                    case "mul":
                    {
                        lblResult.Text = Convert.ToString(int.Parse(txta.Text) * int.Parse(txtb.Text));
                    }
                    break;
                    case "div":
                    {
                        if (int.Parse(txtb.Text) != 0)
                        {
                            lblResult.Text = Convert.ToString(int.Parse(txta.Text) / int.Parse(txtb.Text));
                        }
                    }
                    break;
                    default:
                        break;
                }
            }
        }
    }
}