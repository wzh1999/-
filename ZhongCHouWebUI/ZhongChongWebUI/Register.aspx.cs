using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using Model;
using System.Net.Mail;
using System.Text;

namespace ZhongChouWebUI
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //注册
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //获取用户名
            string name = this.txt_accounts.Text;
            //获取密码
            string pwd = this.txt_pwd.Text;
            //获取确认密码
            string repwd = this.txt_repwd.Text;
            //获取邮箱
            string youxiang = this.txt_youxiang.Text;
            //获取验证码
            string yanzheng = this.TextBox1.Text;
            LoginModel model = new LoginModel();
            Session["UserName"] = name;
            model.UserName = name;
            model.Pwd = pwd;
            model.URL = youxiang;
            model.Registration_time = DateTime.Now;
            if (repwd == pwd && name != "" && pwd != "" && repwd != "" && youxiang != "" && yanzheng!="")
            {
                if (this.check.Checked == true)
                {
                    if (this.TextBox1.Text == InputVerificationCode)
                    {
                        if (LoginBLL.RegisterBLL(model))
                        {
                            Response.Redirect("/Login.aspx");
                        }
                        else
                        {
                            this.Label1.Text = "您已经注册过了!请直接登录";
                            this.txt_accounts.Text = null;
                            this.txt_pwd.Text = null;
                            this.txt_repwd.Text = null;
                            this.txt_youxiang.Text = null;
                            this.TextBox1.Text = null;
                        }
                    }
                    else {
                        this.Label1.Text = "验证码错误！";
                    }
                   
                }
                else {
                    this.Label1.Text = "请阅读并同意众筹网的《服务协议》！";
                }
               
            }
            else
            {
                this.Label1.Text = "输入注册信息存在错误！";
            }

            



        }
        //MVC验证码获取
        //保存验证码
        public static string InputVerificationCode = "";
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            try
            {
               
          
                //随机数0~10产生六位验证码
                Random random = new Random();
                for (int i = 0; i < 6; i++)
                {
                    InputVerificationCode += random.Next(10).ToString();
                }
                //设置发送方的邮件信息，例如使用网易的smtp
                string smtpServer = "smtp.qq.com";//SMTP服务器
                string mailFrom = "jfblackbird@foxmail.com";//登录用户名
                string userpassword = "ltzmudrssqzfhihe";//登录密码


                //邮件服务设置
                SmtpClient smtpClient = new SmtpClient();
                //指定电子邮件发送方式；
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                //指定SMTP服务器
                smtpClient.Host = smtpServer;
                //用户名和密码
                smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userpassword);

                //发送邮件设置
                //发送人和收件人
                MailMessage mailMessage = new MailMessage(mailFrom, this.txt_youxiang.Text);
                //邮件主题
                mailMessage.Subject = "众筹网";
                //邮件内容
                mailMessage.Body = "尊敬的用户您好！您正在操作注册众筹网账号，验证码为：" + InputVerificationCode + "。如果不是本人操作，请勿泄露验证码！";
                //正文编码
                mailMessage.BodyEncoding = Encoding.UTF8;
                //设置为HTML格式
                mailMessage.IsBodyHtml = true;
                //设置优先级
                mailMessage.Priority = MailPriority.Low;
                //发送邮件
                smtpClient.Send(mailMessage);
            

            }
            catch (SmtpException ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                this.txt_accounts.Text = null;
                this.txt_pwd.Text = null;
                this.txt_repwd.Text = null;
                this.txt_youxiang.Text = null;
                this.TextBox1.Text = null;
            }
        }
    }
}