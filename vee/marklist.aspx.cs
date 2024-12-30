using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class marklist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string regno=TextBox2.Text;
            string dept = TextBox3.Text;
            int m1=Convert.ToInt32(TextBox4.Text);
            int m2 = Convert.ToInt32(TextBox5.Text);
            int m3 = Convert.ToInt32(TextBox6.Text);
            int m4 = Convert.ToInt32(TextBox7.Text);
            int m5 = Convert.ToInt32(TextBox8.Text);
            //TextBox9.Text = (m1 + m2 + m3 + m4 + m5);
            //int avg= (m1 + m2 + m3 + m4 + m5) / 5/
            //TextBox10.Text= avg;
            //if(avg>=90)


        }
    }
}