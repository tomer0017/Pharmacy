using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class AddWorker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddWorker.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //if(TextBox1.Text.ToString()==""|| TextBox2.Text.ToString()==""|| TextBox3.Text.ToString()==""|| TextBox4.Text.ToString()==""|| TextBox5.Text.ToString()=="" ||TextBox6.Text.ToString()=="" ||TextBox7.Text.ToString()=="" ||TextBox8.Text.ToString()=="" ||TextBox9.Text.ToString()=="" ||TextBox10.Text.ToString()=="")

            Worker w = new Worker(TextBox1.Text.ToString(), TextBox2.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString(), TextBox5.Text.ToString(), TextBox6.Text.ToString(), TextBox7.Text.ToString(), DropDownList2.Text.ToString(), TextBox9.Text.ToString(), TextBox10.Text.ToString(), DropDownList1.Text.ToString());
            w.addWork();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
    
            TextBox9.Text = "";
            TextBox10.Text = "";

        }
    }
}