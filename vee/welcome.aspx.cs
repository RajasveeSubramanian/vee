using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] s = TextBox1.Text.Split(' ');int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += Convert.ToInt32(s[i]);
                Label1.Text = Label1.Text+" "+ sum.ToString();
            }
            //Label1.Text = (sum + "! You are welcome");
        }
    }
}