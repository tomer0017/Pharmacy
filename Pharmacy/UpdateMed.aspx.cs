using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class UpdateMed : System.Web.UI.Page
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
            Medicine m = new Medicine(DropDownList1.Text.ToString(), TextBox2.Text.ToString(), float.Parse(TextBox3.Text.ToString()),  TextBox4.Text.ToString() , int.Parse(TextBox1.Text.ToString()), TextBox5.Text.ToString(), TextBox6.Text.ToString(), int.Parse(TextBox7.Text.ToString()));
            m.updateMed(DropDownList1.Text.ToString());
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;



        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            if (DropDownList1.Text.ToString() != "-1")
            {
                m.findMedName(DropDownList1.Text.ToString());
                TextBox2.Text = m.Type;
                TextBox3.Text = m.Price.ToString();
                TextBox4.Text = m.Description;
                TextBox1.Text = m.Quantity.ToString();
                TextBox5.Text = m.Company;
                TextBox6.Text = m.Picture;
                TextBox7.Text = m.Classification.ToString();
            }
            else
            {
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox1.Text = "";
                DropDownList1.SelectedIndex = 0;
            }
          
        }
    }
}