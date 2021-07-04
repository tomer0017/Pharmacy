using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class AddMed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //if(TextBox1.Text.ToString()==""|| TextBox2.Text.ToString()==""|| TextBox3.Text.ToString()==""|| TextBox4.Text.ToString()==""|| TextBox5.Text.ToString()=="" ||TextBox6.Text.ToString()=="" ||TextBox7.Text.ToString()=="" ||TextBox8.Text.ToString()=="" ||TextBox9.Text.ToString()=="" ||TextBox10.Text.ToString()=="")
            Medicine m = new Medicine(TextBox1.Text.ToString(), TextBox2.Text.ToString(), float.Parse(TextBox3.Text.ToString()), TextBox4.Text.ToString(), int.Parse(TextBox8.Text.ToString()), TextBox5.Text.ToString(), TextBox6.Text.ToString(), int.Parse(TextBox7.Text.ToString()));
            m.AddMed();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }



        }
    
}