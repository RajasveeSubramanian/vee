using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class BMI_calculation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double w=Convert.ToDouble(TextBox1.Text);
            double h = Convert.ToDouble(TextBox2.Text);
            double b = (w) / ((h * h)/10000);
            
            if(b<16)
                Label4.Text = b.ToString()+"Severe Thinness";
            else if (b >= 16 && b<17)
                Label4.Text = b.ToString() +"Moderate Thinness";
            else if (b >= 17 && b < 18.5)
                Label4.Text = b.ToString() + "Mild Thinness";
            else if (b >= 18.5 && b < 25)
                Label4.Text = b.ToString() + "Normal";
            else if (b >=25 && b < 30)
                Label4.Text = b.ToString() + "Overweight";
            else if (b >= 30 && b < 35)
                Label4.Text = b.ToString() + "Obese class I";
            else if (b >= 35 && b < 40)
                Label4.Text = b.ToString() + "Obese class II";
            else 
                Label4.Text = b.ToString() + "Obese class III";
        }
    }
}