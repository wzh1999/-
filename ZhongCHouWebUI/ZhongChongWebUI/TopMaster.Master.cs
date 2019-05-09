using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
namespace ZhongChouWebUI
{
    public partial class TopMaster : System.Web.UI.MasterPage
    {
    
        //用户名
        public static string username = "";
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Request.Cookies["UserName"] != null)
            {
                username = Request.Cookies["UserName"].Value;
                LoginModel userinfo = new LoginModel();
                userinfo.Accounts = Request.Cookies["UserName"].Value;
                this.Repeater1.DataSource = LoginBLL.Select_User_Head(userinfo);
                this.Repeater1.DataBind();
            }
        }
        //搜索按钮
        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = this.btninput.Text;
            if (text == null)
            {
                Response.Redirect("index.aspx");



            }
            else
            {
                List<DetailsModel> list = BrowseBLL.SelectDetailslike(text);
                Application["list"] = list;
                Response.Redirect("Search.aspx");
            }
        }
        //点击事件
        protected void Button2_Click(object sender, EventArgs e)
        {
              HttpCookie aCookie; 
 string cookieName; 
 int limit = Request.Cookies.Count; 
 for (int i = 0; i < limit; i++) 
 { 
 cookieName = Request.Cookies[i].Name; 
 aCookie = new HttpCookie(cookieName); 
 aCookie.Expires = DateTime.Now.AddDays(-1); 
 Response.Cookies.Add(aCookie); 
 }
 Response.Redirect("Index.aspx");
        }
    }
}