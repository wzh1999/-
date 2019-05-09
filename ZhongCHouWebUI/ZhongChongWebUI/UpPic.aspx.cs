using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
namespace ZhongChongWebUI
{
    public partial class UpPic : System.Web.UI.Page
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
        }
        //修改头像
        protected void btnchuan_Click(object sender, EventArgs e)
        {
             Accounts = Request.Cookies["userName"].Value;
            if (FileUpload1.HasFile)
            {
                string filename = FileUpload1.FileName;
                String fileFix = filename.Substring(filename.LastIndexOf('.') + 1).ToLower();
                if (fileFix != "png" && fileFix != "jpg" && fileFix != "jpeg" && fileFix != "gif")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('修改失败，请上传png、jpg、jpeg、gif图片类型！');</script> ");
                }
                else
                {
                    Accounts = Request.Cookies["userName"].Value;
                    PersonalUpdateBLL usup = new PersonalUpdateBLL();
                    FileUpload1.SaveAs(Server.MapPath(".") + "//images//" + filename);
                    this.Image1.ImageUrl = "~/images/" + filename;
                    if (usup.UpdateUserHead(filename, Accounts))
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('头像修改成功！');</script> ");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('头像修改失败！');</script> ");
                    }
                }
            }
        }

        }
    }