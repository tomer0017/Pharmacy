using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class DeleteWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["id"] as string))
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            w.deleteWork(DropDownList3.Text.ToString());
            
        }

        protected void DropDownList3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DropDownList3.Text.ToString() != "-1")
            {
                Worker w = new Worker();
                w.findWorkId(DropDownList3.Text.ToString());
                TextBox2.Text = w.FirstName.ToString();
                TextBox3.Text = w.LastName;

            }
            else
            {
                TextBox2.Text = "";
                TextBox3.Text = "";
            }

        }
    }
}