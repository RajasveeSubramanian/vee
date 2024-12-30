using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class _2_checkbox_loop : System.Web.UI.Page
    {
        int index = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = index.ToString();
            
            index = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = index.ToString();

        }

       
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox[] s = {CheckBox1,CheckBox2,CheckBox3,CheckBox4,CheckBox5,CheckBox6,CheckBox7,CheckBox8,CheckBox9};
            s[index%9].Checked = true;
            if (!(index % 9 == 0))
                s[index%9-1].Checked = false;
             else if ((index  == 8))
                s[8].Checked = true;

            else if (index % 9 == 0)
            {
                index = 0;
    
                TextBox1.Text = index.ToString();
                s[8].Checked = false;
            }

        }
    }
}