using Pharmacy.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class Order : System.Web.UI.Page

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
            if (TextBox22.Text.ToString() != "-1")
            {
                Client c = new Client();
                try
                {
                    c.findClientId(TextBox22.Text.ToString());
                    TextBox23.Text = c.FirstName.ToString();
                    TextBox24.Text = c.LastName.ToString();
                }
                catch
                {
                    Response.Write("<script>alert('תעודת הזהות הנתונה אינה קיימת במערכת');</script>");
                }


                


            }
            else
            {
                TextBox23.Text = "";
                TextBox24.Text = "";
              
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = (0).ToString();
            if (TextBox22.Text.ToString() != "")
            {
                if (TextBox3.Text.ToString() != "")
                {
                    Medicine m = new Medicine();
                    m.findMedByBar(TextBox3.Text.ToString());
                    TextBox2.Text = m.Name.ToString();
                    Label1.Text = (float.Parse(Label1.Text) + m.Price * float.Parse(TextBox1.Text)).ToString();
                }
                if (TextBox6.Text.ToString() != "")
                {
                    Medicine m1 = new Medicine();
                    m1.findMedByBar(TextBox6.Text.ToString());
                    TextBox5.Text = m1.Name.ToString();
                    Label1.Text = (float.Parse(Label1.Text) + m1.Price * float.Parse(TextBox4.Text)).ToString();
                }

                if (TextBox9.Text.ToString() != "")
                {
                    Medicine m2 = new Medicine();
                    m2.findMedByBar(TextBox9.Text.ToString());
                    TextBox8.Text = m2.Name.ToString();
                    Label1.Text = (float.Parse(Label1.Text) + m2.Price * float.Parse(TextBox7.Text)).ToString();
                }

                if (TextBox12.Text.ToString() != "")
                {
                    Medicine m3 = new Medicine();
                    m3.findMedByBar(TextBox12.Text.ToString());
                    TextBox11.Text = m3.Name.ToString();
                    Label1.Text = (float.Parse(Label1.Text) + m3.Price * float.Parse(TextBox10.Text)).ToString();
                }

                if (TextBox15.Text.ToString() != "")
                {
                    Medicine m4 = new Medicine();
                    m4.findMedByBar(TextBox15.Text.ToString());
                    TextBox14.Text = m4.Name.ToString();
                    Label1.Text = (float.Parse(Label1.Text) + m4.Price * float.Parse(TextBox13.Text)).ToString();
                }


                if (TextBox18.Text.ToString() != "")
                {
                    Medicine m5 = new Medicine();
                    m5.findMedByBar(TextBox18.Text.ToString());
                    TextBox17.Text = m5.Name.ToString();
                    Label1.Text = (float.Parse(Label1.Text) + m5.Price * float.Parse(TextBox16.Text)).ToString();
                }

                if (TextBox21.Text.ToString() != "")
                {

                    Medicine m6 = new Medicine();
                    m6.findMedByBar(TextBox21.Text.ToString());
                    TextBox20.Text = m6.Name.ToString();
                    Label1.Text = (float.Parse(Label1.Text) + m6.Price * float.Parse(TextBox19.Text)).ToString();
                }

                Button3.Visible = true;
                Order1 o = new Order1(TextBox22.Text.ToString(),Session["Id"].ToString());
                o.addOrder();

            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Order1 o = new Order1(TextBox22.Text.ToString(), Session["Id"].ToString());
            o.findOrder();
            if (o.Flag == 1)
            {
                Response.Write("<script>alert('ההזמנה שולמה');</script>");
            }
            else
                o.updateOrder();

        }
        [System.Web.Services.WebMethod]

        protected void textBox22_Leave(object sender, EventArgs e)
        {
            if (TextBox22.Text.ToString() != "-1")
            {
                Client c = new Client();
                try
                {
                    c.findClientId(TextBox22.Text.ToString());
                    TextBox23.Text = c.FirstName.ToString();
                    TextBox24.Text = c.LastName.ToString();
                }
                catch
                {
                    Response.Write("<script>alert('תעודת הזהות הנתונה אינה קיימת במערכת');</script>");
                }

            }
            else
            {
                TextBox23.Text = "";
                TextBox24.Text = "";
              
            }

        }

        protected void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                Medicine m = new Medicine();
                m.findMedByBar(TextBox3.Text.ToString());
                TextBox2.Text = m.Name.ToString();
                Label1.Text = (float.Parse(Label1.Text) + m.Price * float.Parse(TextBox1.Text)).ToString();
            }
            catch
            {
                Response.Write("<script>alert('לא קיים הברקוד שהוזן ');</script>");
            }
        }


        protected void textBox6_Leave(object sender, EventArgs e)
        {
            Medicine m1 = new Medicine();
            m1.findMedByBar(TextBox6.Text.ToString());
            TextBox5.Text = m1.Name.ToString();
            Label1.Text = (float.Parse(Label1.Text) + m1.Price * float.Parse(TextBox4.Text)).ToString();
        }

        protected void textBox9_Leave(object sender, EventArgs e)
        {
            Medicine m2 = new Medicine();
            m2.findMedByBar(TextBox9.Text.ToString());
            TextBox8.Text = m2.Name.ToString();
            Label1.Text = (float.Parse(Label1.Text) + m2.Price * float.Parse(TextBox7.Text)).ToString();
        }

        protected void textBox12_Leave(object sender, EventArgs e)
        {
            Medicine m3 = new Medicine();
            m3.findMedByBar(TextBox12.Text.ToString());
            TextBox11.Text = m3.Name.ToString();
            Label1.Text = (float.Parse(Label1.Text) + m3.Price * float.Parse(TextBox10.Text)).ToString();
        }

        protected void textBox15_Leave(object sender, EventArgs e)
        {
            Medicine m4 = new Medicine();
            m4.findMedByBar(TextBox15.Text.ToString());
            TextBox14.Text = m4.Name.ToString();
            Label1.Text = (float.Parse(Label1.Text) + m4.Price * float.Parse(TextBox13.Text)).ToString();
        }

        protected void textBox18_Leave(object sender, EventArgs e)
        {
            Medicine m5 = new Medicine();
            m5.findMedByBar(TextBox18.Text.ToString());
            TextBox17.Text = m5.Name.ToString();
            Label1.Text = (float.Parse(Label1.Text) + m5.Price * float.Parse(TextBox16.Text)).ToString();
        }

        protected void textBox21_Leave(object sender, EventArgs e)
        {
            Medicine m6 = new Medicine();
            m6.findMedByBar(TextBox21.Text.ToString());
            TextBox20.Text = m6.Name.ToString();
            Label1.Text = (float.Parse(Label1.Text) + m6.Price * float.Parse(TextBox19.Text)).ToString();
        }

        




    }
}