using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZhongChongWebUI
{
    public partial class launch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //发起项目
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Request.Cookies["UserName"] != null && this.CheckBox1.Checked == true)
            {
            Response.Redirect("information.aspx");
            }
            else if (Request.Cookies["UserName"] != null && this.CheckBox1.Checked != true)
            {
                Response.Write("<script>alert('请阅读并同意众筹网的服务协议')</script>");
            }
            else if (Request.Cookies["UserName"] == null && this.CheckBox1.Checked == true)
            {
                Response.Write("<script>alert('登录后才可发起项目')</script>");
            }
            else if (Request.Cookies["UserName"] == null && this.CheckBox1.Checked != true)
            {
                Response.Write("<script>alert('请登录并阅读且同意众筹网的服务协议')</script>");
            }
          
        }
    }
}