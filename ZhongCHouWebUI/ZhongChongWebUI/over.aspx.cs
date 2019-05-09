using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZhongChongWebUI
{
    public partial class over : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //去看其他项目
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //跳转项目详情页
            Response.Redirect("/Index.aspx");
        }
    }
}