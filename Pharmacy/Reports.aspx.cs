using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["id"] as string))
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("R2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("R1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}