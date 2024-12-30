using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            TextBox3.Text = Convert.ToString(a + b);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            TextBox3.Text = Convert.ToString(a - b);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            TextBox3.Text = Convert.ToString(a * b);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            TextBox3.Text = Convert.ToString(a / b);
        }
    }
}