using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class UNIQUE_ID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            string Fathers_Name = TextBox2.Text;
            string Gender=TextBox3.Text;
            string Course_Code=TextBox4.Text;
            Label2.Text= Name[0] + ""+Fathers_Name[0] + Gender[0] + Course_Code[0];
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}