using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Model;
using BLL;

namespace ZhongChouWebUI
{
    public partial class BrowseUI : System.Web.UI.Page
    {

        DetailsModel dm = new DetailsModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.AspNetPager1.RecordCount = BrowseBLL.ByClassID();   
                this.RP_details.DataSource = BrowseBLL.SelectProductByPaging(AspNetPager1.PageSize, this.AspNetPager1.CurrentPageIndex - 1);
                this.RP_details.DataBind();
             
            }


        }
        //分页事件
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {

            this.AspNetPager1.RecordCount = BrowseBLL.ByClassID();   
            this.RP_details.DataSource = BrowseBLL.SelectProductByPaging(AspNetPager1.PageSize, this.AspNetPager1.CurrentPageIndex - 1);
            this.RP_details.DataBind();
        }
        //所有项目
        protected void suoyouxiangmu_Click(object sender, EventArgs e)
        {
            this.RP_details.DataSource = BrowseBLL.SelectDetails();
            this.DataBind();
        }
        //众筹中
        protected void zhongchouzhong_Click(object sender, EventArgs e)
        {
            this.RP_details.DataSource = BrowseBLL.ZhongChouZhong();
            this.DataBind();
        }
        //已成功
        protected void yichenggong_Click(object sender, EventArgs e)
        {
            this.RP_details.DataSource = BrowseBLL.YiChengGong();
            this.DataBind();
        }

        protected void dropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dropdown1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
        //下拉框显示加载页面
        protected void dropdown1_SelectedIndexChanged2(object sender, EventArgs e)
        {
            //获取下拉文本框中的值
            string zhi = this.dropdown1.SelectedValue.ToString();
            if (zhi == "默认排序")
            {
                this.RP_details.DataSource = BrowseBLL.SelectDetails();
                this.DataBind();
            }
            if (zhi == "最新上线")
            {
                this.RP_details.DataSource = BrowseBLL.ZuiXinshangxian();
                this.DataBind();
            }
            if (zhi == "最高目标金额")
            {
                this.RP_details.DataSource = BrowseBLL.MaxMoney();
                this.DataBind();
            }
            if (zhi == "最多喜欢人数")
            {
                this.RP_details.DataSource = BrowseBLL.MaxLove();
                this.DataBind();
            }
            if (zhi == "最多支持金额")
            {
                this.RP_details.DataSource = BrowseBLL.MaxZhichimoney();
                this.DataBind();
            }
            //从数据库中查询
            //绑定显示




        }
        //全部
        protected void btnquanbu_Click(object sender, EventArgs e)
        {
            this.RP_details.DataSource = BrowseBLL.SelectDetails();
            this.DataBind();
        }
        //科技
        protected void btnkeji_Click(object sender, EventArgs e)
        {
            string name = this.btnkeji.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //艺术
        protected void btnyishu_Click(object sender, EventArgs e)
        {
            string name = this.btnyishu.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //设计
        protected void btnsheji_Click(object sender, EventArgs e)
        {
            string name = this.btnsheji.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //音乐
        protected void btnyinyue_Click(object sender, EventArgs e)
        {
            string name = this.btnyinyue.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //影视
        protected void btnyingshi_Click(object sender, EventArgs e)
        {
            string name = this.btnyingshi.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //出版
        protected void btnchuban_Click(object sender, EventArgs e)
        {
            string name = this.btnchuban.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //动漫
        protected void btndongman_Click(object sender, EventArgs e)
        {
            string name = this.btndongman.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //公益
        protected void btngongyi_Click(object sender, EventArgs e)
        {
            string name = this.btngongyi.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //公开课
        protected void btngongkaike_Click(object sender, EventArgs e)
        {
            string name = this.btngongkaike.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //农业
        protected void btnnongye_Click(object sender, EventArgs e)
        {
            string name = this.btnnongye.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }
        //其他
        protected void btnqita_Click(object sender, EventArgs e)
        {
            string name = this.btnqita.Text;
            this.RP_details.DataSource = BrowseBLL.daohang(name);
            this.DataBind();
        }


        







    }
}