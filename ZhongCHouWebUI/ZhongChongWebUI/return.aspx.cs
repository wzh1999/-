using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace ZhongChongWebUI.Scripts
{
    public partial class 回报 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView1.AutoGenerateColumns = false;
                this.GridView1.DataSource = ReturnBLL.Gettable();
                this.GridView1.DataBind();
            }
        }
        //保存
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ReturnModel RM = new ReturnModel();
            //支持金额
            RM.Support_amount = this.TextBox1.Text;
            //回报内容
            RM.Return_content = this.TextBox2.Text;
            //限定名额
            RM.Qualified_quota = int.Parse(this.TextBox3.Text);
            //运费
            RM.Freight = this.TextBox4.Text;
            //回报时间
            RM.Return_time = int.Parse(this.TextBox5.Text);
            //项目编号
            string name = (string)Session["username"];
            RM.ProjectID = ReturnBLL.Selecteds(name);
            Session["ProjectID"] = RM.ProjectID;
            if (ReturnBLL.Returnwebs(RM))
            {
                this.Label1.Text = "保存成功！";
            }
            else
            {
                this.Label1.Text = "保存失败！";
            }
        }
        //取消保存
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //提示：是否确定取消保存
            //清空所有表单数据
            this.TextBox1.Text = null;
            this.TextBox2.Text = null;
            this.TextBox3.Text = null;
            this.TextBox4.Text = null;
            this.TextBox5.Text = null;
         
        }
        //上一步
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            //回到上一页面
            Response.Redirect("/information.aspx");
        }
        //下一步
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if (this.Label1.Text == "保存成功！")
            {
                //跳转下一页面
                Response.Redirect("/people.aspx");
            }
            else
            {
                Response.Write("<script>alert('请先保存数据！')</script>");
            }

        }
    }
}