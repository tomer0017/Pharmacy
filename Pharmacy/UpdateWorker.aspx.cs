using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class UpdateWorker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["id"] as string))
            {
                Response.Redirect("home.aspx");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            w.findWorkId(DropDownList3.Text.ToString());
            w.removeBlock(DropDownList3.Text.ToString());
            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Worker w = new Worker(DropDownList3.Text.ToString(), TextBox2.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString(), TextBox5.Text.ToString(), TextBox6.Text.ToString(), TextBox7.Text.ToString(), DropDownList2.Text.ToString(), TextBox9.Text.ToString(), TextBox10.Text.ToString(), DropDownList1.Text.ToString());
            w.updateWork(DropDownList3.Text.ToString());
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            DropDownList3.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            DropDownList1.SelectedIndex = 0;


        }

        protected void DropDownList3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DropDownList3.Text.ToString() != "-1")
            {
                Worker w = new Worker();
                w.findWorkId(DropDownList3.Text.ToString());
                TextBox2.Text = w.FirstName.ToString();
                TextBox3.Text = w.LastName;
                TextBox4.Text = w.DateOfBirth;
                TextBox5.Text = w.Street;
                TextBox6.Text = w.PhoneNumber;
                TextBox7.Text = w.Email;
                DropDownList2.Text = w.Gender;
                TextBox9.Text = w.Username;
                TextBox10.Text = w.Password;
                DropDownList1.Text = w.Premissions;
                if (w.Block == 1)
                {
                    Button3.Visible = true;
                }

            }
            else
            {
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                DropDownList3.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
            }
        }
    }
}