using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class tasks : System.Web.UI.Page
    {
        string a = "", b = "", c = "", d = "";

        protected void Button3_Click(object sender, EventArgs e)
        {
            a = TextBox4.Text;
            d=TextBox5.Text;
            TextBox4.Text = d;
            TextBox5.Text = a;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            b = TextBox1.Text;
            a = TextBox5.Text;
            TextBox1.Text = a;
            TextBox5.Text = b;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            a = TextBox2.Text;
            c = TextBox4.Text;
            TextBox2.Text = c;
            TextBox4.Text = a;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a = TextBox1.Text;
            b = TextBox2.Text;
            TextBox1.Text = b;
            TextBox2.Text = a;
        }
    }
}