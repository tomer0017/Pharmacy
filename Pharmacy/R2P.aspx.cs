using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class R2P : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["id"] as string))
            {
                Response.Redirect("Home.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportsP.aspx");
        }
    }
}