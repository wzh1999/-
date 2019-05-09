using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using Model;
namespace ZhongChongWebUI
{
    public partial class people : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox1.Text = Request.Cookies["UserName"].Value;
        }
        //上一步
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //返回上一页面
            Response.Redirect("/return.aspx");
        }
        //保存草稿
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            string Phone = this.TextBox2.Text;
            string Province = this.DropDownList1.SelectedValue;
            string City = this.DropDownList2.SelectedValue;
            string UserName = this.TextBox1.Text;
            if (ReturnBLL.Insretin(Phone, Province, City, UserName))
            {
                ReturnModel rm = new ReturnModel();
                rm.Bank_Name = this.TextBox3.Text;
                rm.Bank_branch = this.TextBox4.Text;
                rm.Account_name = this.TextBox5.Text;
                rm.Bank_Number = this.TextBox6.Text;
                rm.Accounts = this.TextBox1.Text;
                if (ReturnBLL.InReturn(rm))
                {
                    this.Label2.Text = "保存成功！";
                }
                else
                {
                    this.Label2.Text = "保存失败！";
                }
            }
            else
            {
                this.Label2.Text = "保存失败！";
            }
        }
        //提交审核
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

            if (this.Label2.Text == "保存成功！")
            {
                DetailsModel dm = new DetailsModel();
                //筹集天数
                int day = (int)Session["day"];
                //发起时间
                dm.Release_date = DateTime.Now;
                //结束时间
                dm.Closing_date = DateTime.Now.AddDays(day);
                //喜欢人数
                dm.Like_number = 0;
                //众筹进度
                dm.Financing_state = "众筹中";
                //已筹集金额
                dm.Raised_amount = 0;
                //项目编号
                dm.ProjectID = (int)Session["ProjectID"];
                //筹集情况
                dm.Operation = "进行中";
                if (ReturnBLL.InProjectDetails(dm))
                {
                    Response.Redirect("/over.aspx");
                }
                else {
                    this.Label2.Text = "数据错误！";
                }
            }
            else {
                this.Label2.Text = "请先保存！";
            }
           
        }
    }
}