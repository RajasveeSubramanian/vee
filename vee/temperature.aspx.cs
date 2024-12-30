using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class temperature : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            double n=Convert.ToDouble(TextBox1.Text);
            double f = ((n*9 / 5 )+ 32);
            Label1.Text = f.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TextBox1.Text);
            double f = (n-32)*5/9;
            Label2.Text = f.ToString();
        }
    }
}