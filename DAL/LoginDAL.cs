using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{

    public class LoginDAL
    {
        /// <summary>
        /// 登录
        /// </summary>
        public static DataTable UserLogin(LoginModel model)
        {
            string sql = string.Format("SELECT * from UserInfo where UserName='{0}' and Pwd='{1}'", model.UserName, model.Pwd);
            DataTable dt = DBHelper.Select(sql);
            return dt;
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="loginDAL"></param>
        /// <returns></returns>
        public static bool RegisterDAL(Model.LoginModel model)
        {
            string s = string.Format("select * from UserInfo where UserName='{0}' and Pwd='{1}'", model.UserName, model.Pwd);
            DataTable dt = DBHelper.Select(s);
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            else
            {
                string sql = string.Format("insert into UserInfo values('{0}','普通用户','{0}','{1}','','','{2}','','{3}','','','','使用')", model.UserName, model.Pwd, DateTime.Now, model.URL);
                return DBHelper.Update(sql);
            }


        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="zi"></param>
        /// <returns></returns>
        public static DataTable Sousuo(string zi)
        {
            string sql = string.Format(@"select s.Like_number 喜欢的人数,o.ProjectID 项目ID,o.Project_cover 封面路径,o.Project_Name 项目名称,o.Raise_day  筹集天数,
 o.Project_Money  预计筹集金额,s.Financing_state 筹集进度,s.Raised_amount  已经资 ,o.Project_Type  类别
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID AND Project_Name like '%{0}%'", zi);
            DataTable dt = DBHelper.Select(sql);
            return dt;

        }



        /// <summary>
        /// 登录后返回头像
        /// </summary>
        /// <returns></returns>
        public static List<LoginModel> Select_User_Head(LoginModel userinfo)
        {
            string sql = String.Format(@"select Head_portrait ,UserName
                                            from UserInfo
                                            where Accounts ='{0}'", userinfo.Accounts);
            DataTable dt = DBHelper.Select(sql);
            List<LoginModel> list = new List<LoginModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoginModel user = new LoginModel();
                user.Head_portrait = dt.Rows[i][0].ToString();
                user.UserName = dt.Rows[i][1].ToString();
                list.Add(user);
            }
            return list;
        }
        //判断用户是否存在
        public bool Selectloginname(string Accounts)
        {
            string sql = string.Format(@"select * from UserInfo where Accounts='{0}'", Accounts);
            DataTable dt = new DataTable();
            dt = DBHelper.Select(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
