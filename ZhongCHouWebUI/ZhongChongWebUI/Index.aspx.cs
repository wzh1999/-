using BLL;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZhongChouWebUI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DataList1.DataSource = BrowseBLL.SelectDetails();
                this.DataList1.DataBind();
                //this.DataList1.DataSource = ProjectBLL.select();
                //this.DataList1.DataBind();
                //需要判断
                this.DataList2.DataSource = ProjectBLL.select2();            
                this.ImageButton3.Visible = false;
                this.DataList2.DataBind();


                //string name = Request.QueryString["name"];
                //this.DataList1.DataSource = BrowseBLL.daohang(name);
                //this.DataList1.DataBind();
            }

        }

        protected void DataList1_Load(object sender, EventArgs e)
        {

        }
        //public void cx()
        //{
        //    string name = Request.QueryString["name"];
        //    this.DataList1.DataSource = BrowseBLL.daohang(name);
        //    this.DataList1.DataBind();
        //}
        //public void cx1_Click(string name)
        //{
        //    name = Request.QueryString["name"];
        //    this.DataList1.DataSource = BrowseBLL.daohang(name);
        //    this.DataList1.DataBind();
        //}
        //科技
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton1.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //艺术
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton2.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //设计
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton3.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //音乐
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton4.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //影视
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton5.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //出版
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton6.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //动漫
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton7.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //公益
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton8.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //公开课
        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton9.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //农业
        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton10.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //苏州站
        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton11.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //其他
        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            string name = this.LinkButton12.Text;
            this.DataList1.DataSource = BrowseBLL.daohang(name);
            this.DataList1.DataBind();
        }
        //查看更多项目
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //查看更多项目
            this.DataList2.DataSource = ProjectBLL.select3();
            this.ImageButton2.Visible = false;
            this.ImageButton3.Visible = true;
            this.DataList2.DataBind();

        }
        //收起更多项目
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            this.DataList2.DataSource = ProjectBLL.select2();
            this.ImageButton3.Visible = false;
            this.ImageButton2.Visible = true;
            this.DataList2.DataBind();
        }

    }
}