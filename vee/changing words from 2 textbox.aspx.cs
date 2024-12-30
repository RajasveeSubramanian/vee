using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class changing_words_from_2_textbox : System.Web.UI.Page
    {
        string gl = "",gl1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
             gl = TextBox1.Text;
            gl1=TextBox2.Text;
            TextBox2.Text = gl;
            TextBox1 .Text = gl1;



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            gl = TextBox1.Text;
            gl1 = TextBox2.Text;
            TextBox2.Text = gl;
            TextBox1.Text = gl1;
        }

    }
}