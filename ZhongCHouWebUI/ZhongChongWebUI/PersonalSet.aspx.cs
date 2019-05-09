using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Xml;
namespace ZhongChouWebUI
{
    public partial class PersonalSet : System.Web.UI.Page
    {
        public static string Accounts = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["userName"] != null)
                {
                    Accounts = Request.Cookies["userName"].Value;
                }
                loads(Accounts);
                
            }
        }
        //加载信息
        void loads(string Accounts)
        {
            PersonalSelectBLL usb = new PersonalSelectBLL();
            this.Phone.Text = usb.PersonalSelectedBLL(Accounts)[0].Phone;
            this.UserName.Text = usb.PersonalSelectedBLL(Accounts)[0].UserName;
            string sex = usb.PersonalSelectedBLL(Accounts)[0].Gender.ToString().Trim();
            if (sex == "男")
            {
                this.RadioButton1.Checked = true;
            }
            else
            {
                this.RadioButton2.Checked = true;
            }

            this.URL.Text = usb.PersonalSelectedBLL(Accounts)[0].URL;
            this.Personal_note.Text = usb.PersonalSelectedBLL(Accounts)[0].Personal_note;
            //省市选择
            this.DropDownList1.DataSource = usb.PersonalSelectedBLL(Accounts);
            this.DropDownList1.DataTextField = "Province";
            this.DropDownList1.DataBind();
            this.DropDownList2.DataSource = usb.PersonalSelectedBLL(Accounts);
            this.DropDownList2.DataTextField = "City";
            this.DropDownList2.DataBind();
        }
        //修改个人信息
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Accounts = Request.Cookies["userName"].Value;
            LoginModel us = new LoginModel();
            us.UserName = this.UserName.Text;
            us.Gender = this.RadioButton1.Checked == true ? "男" : "女";
            us.Province = this.DropDownList1.Text;
            us.City = this.DropDownList2.Text;
            us.URL = this.URL.Text;
            us.Personal_note = this.Personal_note.Text;
            us.Accounts = Request.Cookies["userName"].Value;
            PersonalUpdateBLL uspudt = new PersonalUpdateBLL();
            if (uspudt.UpdateUsers(us))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('修改成功！')</script> ");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('修改失败！')</script> ");
            }
            loads(Accounts);
        }

        //修改密码
        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            Accounts = Request.Cookies["userName"].Value;
            PersonalSelectBLL usb = new PersonalSelectBLL();
            if (this.rdPhone.Text == usb.PersonalSelectedBLL(Accounts)[0].Phone)
            {
                PersonalUpdateBLL usup = new PersonalUpdateBLL();
                if (usup.UpdateUserspwd(this.rdPWD.Text, Accounts))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('修改成功！');</script> ");

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('修改失败！');</script> ");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('手机号码不正确！');</script> ");

            }
            loads(Accounts);
        }
    }
}