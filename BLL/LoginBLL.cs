using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL
{
    public class LoginBLL
    {
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="adminName"></param>
        /// <param name="adminPwd"></param>
        /// <returns></returns>
        public static bool UserLoginBLL(LoginModel model)
        {
            DataTable dt = LoginDAL.UserLogin (model);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 登陆传值
        /// </summary>
        /// <param name="adminName"></param>
        /// <param name="adminPwd"></param>
        /// <returns></returns>
        public static LoginModel UserLogin(LoginModel model)
        {
            DataTable dt = LoginDAL.UserLogin(model);
            LoginModel lm = new LoginModel();
            if (dt != null && dt.Rows.Count >= 1)
            {
                //账户
                lm.Accounts = dt.Rows[0]["Accounts"].ToString();
                //类型
                lm.User_Type = dt.Rows[0]["User_Type"].ToString();
                //用户名
                lm.UserName = dt.Rows[0]["UserName"].ToString();
                //密码
                lm.Pwd = dt.Rows[0]["Pwd"].ToString();
                //联系电话
                lm.Phone = dt.Rows[0]["Phone"].ToString();
                //性别
                lm.Gender = dt.Rows[0]["Gender"].ToString();
                //注册时间
                lm.Registration_time = DateTime.Parse(dt.Rows[0]["Registration_time"].ToString());
                //个性签名
                lm.Personal_note = dt.Rows[0]["Personal_note"].ToString();
                ///// 邮箱
                lm.URL = dt.Rows[0]["URL"].ToString();
                //头像图片
                lm.Head_portrait = dt.Rows[0]["Head_portrait"].ToString();
                //省份
                lm.Province = dt.Rows[0]["Province"].ToString();
                //市区
                lm.City = dt.Rows[0]["City"].ToString();
                //账户情况
                lm.User_state = dt.Rows[0]["User_state"].ToString();
            }
            return lm;

        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="loginDAL"></param>
        /// <returns></returns>
        public static bool RegisterBLL(Model.LoginModel model)
        {
            return LoginDAL.RegisterDAL(model);
        }

          /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="zi"></param>
        /// <returns></returns>
        public static DataTable Sousuo(string zi) {
            return LoginDAL.Sousuo(zi);
        }
          /// <summary>
        /// 登录后返回头像
        /// </summary>
        /// <returns></returns>
        public static List<LoginModel> Select_User_Head(LoginModel userinfo)
        {
            return LoginDAL.Select_User_Head(userinfo);
        }
        //判断用户是否存在
        public bool Selectloginname(string Accounts)
        {
            DAL.LoginDAL userdal = new LoginDAL();
            return userdal.Selectloginname(Accounts);
        }

    }
}
