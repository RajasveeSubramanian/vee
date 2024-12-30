using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class reverse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TextBox1.Text);
            int m = n;
            int a = n;
            int sum = 0;
            int c = 0;
            while (n > 0)
            {
                c++;
                n /= 10;
            }
            while (m > 0)
            {
                sum += Convert.ToInt32( Math.Pow(Convert.ToDouble( m%10),Convert.ToDouble( c)));
                m /= 10;
            }
                
            Label1.Text = sum==a?"arm":"not";
        }
    }
}