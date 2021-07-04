using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class UpdateClient : System.Web.UI.Page
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
            Client c = new Client(DropDownList3.Text.ToString(), TextBox2.Text.ToString(), TextBox3.Text.ToString(), TextBox5.Text.ToString(), TextBox6.Text.ToString(), TextBox4.Text.ToString(), TextBox7.Text.ToString(), DropDownList2.Text.ToString(), int.Parse(DropDownList1.Text));
            c.updateClient(DropDownList3.Text.ToString());
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            DropDownList3.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            DropDownList1.SelectedIndex = 0;



        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Client c = new Client();
            if (DropDownList3.Text.ToString() != "-1")
            {
                c.findClientId(DropDownList3.Text.ToString());
                TextBox2.Text = c.FirstName.ToString();
                TextBox3.Text = c.LastName.ToString();
                TextBox5.Text = c.Street.ToString();
                TextBox6.Text = c.PhoneNumber.ToString();
                TextBox4.Text = c.DateOfBirth.ToString();
                TextBox7.Text = c.Email.ToString();
                DropDownList2.Text = c.Gender;
                DropDownList1.Text = c.Classification.ToString();
            }
            else
            {
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                DropDownList3.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
            }
            

            

        }
    }
}