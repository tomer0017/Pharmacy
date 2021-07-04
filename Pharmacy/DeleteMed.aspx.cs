using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class DeleteMed : System.Web.UI.Page
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
            Medicine m = new Medicine();
           m.deleteMed(DropDownList1.Text.ToString());

        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            m.findMedName(DropDownList1.Text.ToString());
            TextBox4.Text = m.Description.ToString();
            TextBox5.Text = m.Company;

        }
    }
}