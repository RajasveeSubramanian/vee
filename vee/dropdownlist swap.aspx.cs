using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class task : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
         string s= DropDownList2.Text;
            if (s == "black")
                DropDownList1.SelectedIndex = 0;
          else if(s =="green")
                 DropDownList1.SelectedIndex = 1;
            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList1.Text;
            if (s == "black")
                DropDownList2.SelectedIndex = 0;
            else if (s == "green")
                DropDownList2.SelectedIndex = 1;
        }
    }
}