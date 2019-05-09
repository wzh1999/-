using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using DAL;
namespace ZhongChongWebUI
{
    public partial class information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //下一步
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ProjectinfoModel p = new ProjectinfoModel();
            p.Project_Name = this.tbusername.Text;
            Session["username"] = this.tbusername.Text;
            p.Project_Money = decimal.Parse(this.tbusermoney.Text);
            //筹集天数
            p.Raise_day = int.Parse(this.tbuserdays.Text);
            Session["day"] = p.Raise_day;
            p.Project_Type = this.RadioButtonList1.SelectedItem.Text;
            p.Project_Province = this.DropDownList1.Text;
            p.Project_City = this.DropDownList2.Text;
            p.Project_cover = this.Label3.Text;
            p.Video = this.tbuservideo.Text;
            p.Project_brief = this.tbuserjianjie.Text;
            p.Project_Details = this.tbuserxiangqing.Text;
            p.Label = this.tbuserbiaoqiao.Text;
            if (ProjectinfoBLL.Add(p))
            {
                Response.Redirect("return.aspx");
            }
            else {
                Response.Write("<script>alert('添加失败')</script>");
            }

            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string Imgsrc = FileUpload1.FileName;
            this.Label3.Text = Imgsrc;
            FileUpload1.SaveAs(Server.MapPath(".")+"//images//"+Imgsrc);
            this.Image1.ImageUrl = "~/images/" + Imgsrc;
        }
    }
}