using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pharmacy.App_Code;



namespace Pharmacy
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         //   Encryption1 a = new Encryption1();
         //   string name = "abc";
          //  name = a.ComputeSha256Hash(name);
         //   TextBox1.Text = name;
            //string message = "Your request is being processed.";
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //sb.Append("alert('");
            //sb.Append(message);
            //sb.Append("');");
            //ClientScript.RegisterOnSubmitStatement(this.GetType(), "alert", sb.ToString());
        }

        

        protected void Button3_Click(object sender, EventArgs e)
        {
           // Response.Redirect("Admin.aspx");
            Worker w = new Worker();
            w.findWork(TextBox1.Text.ToString());
            Encryption1 temp = new Encryption1();
            string pass = temp.ComputeSha256Hash(TextBox3.Text.ToString());
            if (w.Block == 0)
            {
                if (pass == w.Password)
                {
                    if (w.Premissions == "מנהל")
                    {
                        Session["Id"] = w.Wid;

                        Response.Redirect("Admin.aspx");
                    }

                    if (w.Premissions == "רוקח")
                    {
                        Session["Id"] = w.Wid;

                        Response.Redirect("Pharmacist.aspx");
                    }
                }

                else
                {
                    w.upCount(TextBox1.Text.ToString());
                    if (w.Count == 5)
                    {
                        w.blockWorker(TextBox1.Text.ToString());
                    }
                }
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('המשתמש חסום');", true);
            }
            


        }

      




    }
}