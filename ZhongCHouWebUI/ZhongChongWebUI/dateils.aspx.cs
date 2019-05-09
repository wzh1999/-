using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ZhongChongWebUI
{
    public partial class dateils : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = "《玩出来的产业—王志纲谈旅游》";
                this.DataList1.DataSource = BrowseBLL.SelectDetailslike(name);
                this.DataList1.DataBind();
            }
        }
    }
}