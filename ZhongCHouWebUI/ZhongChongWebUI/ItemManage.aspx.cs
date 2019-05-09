using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using ZhongChongWebUI;
namespace ZhongChouWebUI
{
    public partial class ItemManage : System.Web.UI.Page
    {
        string Accounts = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ///检测是否有用户登录
                if (Request.Cookies["userName"] != null)
                {
                    Accounts = Request.Cookies["userName"].Value;
                }
                ///个人设置页查看项目状态
                if (Request.QueryString["Investment_state"] == null)
                {
                    conut(Accounts, "支持的");
                }
                else if (Request.QueryString["Investment_state"] != null)
                {
                    string selectname = Request.QueryString["Investment_state"];
                    Session["Investment_state"] = Request.QueryString["Investment_state"];
                    conut(Accounts, selectname);
                }

                loads(Accounts);
            }
        }
        void loads(string Accounts)
        {
            PersonalSelectBLL usb = new PersonalSelectBLL();
            this.Head_portrait.ImageUrl = "~/images/" + usb.PersonalSelectedBLL(Accounts)[0].Head_portrait;
            this.UserName.Text = usb.PersonalSelectedBLL(Accounts)[0].UserName;
            this.Registration_time.Text = usb.PersonalSelectedBLL(Accounts)[0].Registration_time.ToString();
            this.Province_City.Text = usb.PersonalSelectedBLL(Accounts)[0].Province + " " + usb.PersonalSelectedBLL(Accounts)[0].City;
            this.Personal_note.Text = usb.PersonalSelectedBLL(Accounts)[0].Personal_note;
        }
        void conut(string Accounts, string Investment_state)
        {
            ItemManageBLL upb = new ItemManageBLL();
            this.anp_project.RecordCount = upb.UserProjects(Accounts, Investment_state);
            this.rpProductInfo.DataSource = upb.UserProjectGoods(Accounts, this.anp_project.PageSize, anp_project.CurrentPageIndex - 1, Investment_state);
            this.rpProductInfo.DataBind();
        }

        protected void rp_zixun_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            if (e.CommandName == "del")
            {
                Project_User pry = new Project_User();
                pry.Project_UserID = int.Parse(e.CommandArgument.ToString());
                ItemManageBLL upb = new ItemManageBLL();
                if (upb.UserProject_user(pry))
                {
                    Response.Write("<script>alert('删除成功');</script>");
                    if (Request.QueryString["Investment_state"] == null)
                    {
                        conut(Accounts, "支持的");
                    }
                    else if (Request.QueryString["Investment_state"] != null)
                    {
                        string selectname = Request.QueryString["Investment_state"];
                        Session["Investment_state"] = Request.QueryString["Investment_state"];
                        conut(Accounts, selectname);
                    }
                }
                else
                {
                    Response.Write("<script>alert('删除失败');</script>");
                    if (Request.QueryString["Investment_state"] == null)
                    {
                        conut(Accounts, "支持的");
                    }
                    else if (Request.QueryString["Investment_state"] != null)
                    {
                        string selectname = Request.QueryString["Investment_state"];
                        Session["Investment_state"] = Request.QueryString["Investment_state"];
                        conut(Accounts, selectname);
                    }
                }

            }
            //if (e.CommandName == "bianj")
            //{
            //    //************************************如果是用户发起的才能进行编辑
            //    if (Request.QueryString["Investment_state"] == "发起的")
            //    {
            //        Zd.Project_Xz = 2;
            //        Zd.ProjectID = int.Parse(e.CommandArgument.ToString());
            //        Response.Redirect("information.aspx");
            //    }

            //}
        }
        //分页
        protected void anp_project_PageChanged(object sender, EventArgs e)
        {
            if (Request.QueryString["Investment_state"] == null)
            {
                conut(Accounts, "支持的");
            }
            else if (Request.QueryString["Investment_state"] != null)
            {
                string selectname = Request.QueryString["Investment_state"];
                conut(Accounts, selectname);
            }
        }

    }
}