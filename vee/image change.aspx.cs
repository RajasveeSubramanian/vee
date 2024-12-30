using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vee
{
    public partial class image_change : System.Web.UI.Page
    {
        static int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] img = { "https://images.news18.com/ibnlive/uploads/2021/09/namjoon.jpg", "https://i.pinimg.com/474x/99/87/5b/99875bafe7de1f6d53f1aabbb3d50617.jpg", "https://cf-img-a-in.tosshub.com/sites/visualstory/wp/2024/01/cropped-suga.jpg", "https://w0.peakpx.com/wallpaper/386/889/HD-wallpaper-j-hope-bts-jung-hoseok-hoseok-thumbnail.jpg", "https://akm-img-a-in.tosshub.com/indiatoday/images/story/202210/jimin-bts-_birthday-one_one.jpg?VersionId=L2czCFbbqe6527pVx_iVEReVnK0X4_YP", "https://i.pinimg.com/736x/d3/49/19/d34919ea5de8fbcc2ae0ae122a3d65dd.jpg", "https://i.pinimg.com/736x/7c/03/10/7c03108032a24bd2882f25d9aceb817f.jpg" };
            --i;
            if (i < 0)
                i = 0;
            Image1.ImageUrl = img[i%7];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] img = { "https://images.news18.com/ibnlive/uploads/2021/09/namjoon.jpg", "https://i.pinimg.com/474x/99/87/5b/99875bafe7de1f6d53f1aabbb3d50617.jpg", "https://cf-img-a-in.tosshub.com/sites/visualstory/wp/2024/01/cropped-suga.jpg", "https://w0.peakpx.com/wallpaper/386/889/HD-wallpaper-j-hope-bts-jung-hoseok-hoseok-thumbnail.jpg", "https://akm-img-a-in.tosshub.com/indiatoday/images/story/202210/jimin-bts-_birthday-one_one.jpg?VersionId=L2czCFbbqe6527pVx_iVEReVnK0X4_YP", "https://i.pinimg.com/736x/d3/49/19/d34919ea5de8fbcc2ae0ae122a3d65dd.jpg", "https://i.pinimg.com/736x/7c/03/10/7c03108032a24bd2882f25d9aceb817f.jpg" };
            i++;
            Image1.ImageUrl = img[i%7];

        }
    }
}