using Model;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZhongChongWebUI
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<DetailsModel> list = Application["list"] as List<DetailsModel>;
                this.DataList1.DataSource = list;
                this.DataList1.DataBind();
            }
          
        }
    }
}