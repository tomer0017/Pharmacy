using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class DeleteClientP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["id"] as string))
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.deleteClient(DropDownList3.Text.ToString());

        }

        protected void DropDownList3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Client c = new Client();
            c.findClientId(DropDownList3.Text.ToString());
            TextBox2.Text = c.FirstName;
            TextBox3.Text = c.LastName;

        }
    }
}