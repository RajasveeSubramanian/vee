using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class id_creation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "",l="";
                char v=' ';

            if (RadioButton1.Checked)
                v = RadioButton1.Text[0];
            else if(RadioButton2.Checked)  
                v = RadioButton2.Text[0];
            else if(RadioButton3.Checked)
                v = RadioButton3.Text[0];

            l=DropDownList1.Text;
            s = (TextBox1.Text[0] + "" + TextBox2.Text[0] +v+TextBox3.Text[0] + TextBox4.Text[0] + TextBox5.Text[0] +l+TextBox6.Text[0]);
            Label10.Text = s;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked=false;
            DropDownList1.SelectedIndex=0;
            Label10.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}