using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;

namespace ZhongChouWebUI
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void txt_Accounts_Load(object sender, EventArgs e)
        {

        }
        //登陆
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string Name = this.txt_zhanghao .Text;
            string Pwd = this.txt_mima .Text;
            LoginModel model = new LoginModel();
            model.UserName = Name;
            model.Pwd = Pwd;
            if (LoginBLL.UserLoginBLL(model))
            {
                //登录成功，传值
                HttpCookie cook = new HttpCookie("UserName", this.txt_zhanghao.Text);
                cook.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cook);
                Response.Redirect("Index.aspx");
            }
            else {
                this.Label3.Text = "用户名或密码错误！";
                this.txt_zhanghao.Text = null;
                this.txt_mima.Text = null;
            }


        }
    }
}