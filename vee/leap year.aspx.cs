using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class leap_year : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(TextBox1.Text);
            if ((n % 4 == 0 && n % 100 != 0) || n % 400 == 0)
                Label1.Text = "Leap year";
            else
                Label1.Text = "Not";
        }
    }
}