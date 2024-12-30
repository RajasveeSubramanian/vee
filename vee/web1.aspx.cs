using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = Convert.ToInt32("34");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(TextBox1.Text);
            bool b = true;
            int i = 2;
            while (n/2>=i)
            {
                if(n%i==0)
                {
                    b = false;
                    break;
                }
                i++;
                
            }
            if (b)
                Label1.Text = $"{n} is Prime";
            else 
                Label1.Text = $"{n} is Not Prime";
        }

        
    }
}