using System;
using System.Collections.Generic;

using System.Text;

using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PersonalSelectDAL
    {
        public List<LoginModel> PersonalSelect(string Accounts)
        {
            string sql = string.Format(@"select *  from UserInfo where Accounts='{0}' ", Accounts);
            DataTable dt = DBHelper.Select(sql);
            List<LoginModel> po = new List<LoginModel>();
            if (dt != null && dt.Rows.Count >= 1)
            {
                foreach (DataRow item in dt.Rows)
                {
                    LoginModel pr = new LoginModel();
                    pr.Accounts = item["Accounts"].ToString();
                    pr.User_Type = item["User_Type"].ToString();
                    pr.UserName = item["UserName"].ToString();
                    pr.Pwd = item["Pwd"].ToString();
                    pr.Phone = item["Phone"].ToString();
                    pr.Gender = item["Gender"].ToString();
                    pr.Registration_time = DateTime.Parse(item["Registration_time"].ToString());
                    pr.Personal_note = item["Personal_note"].ToString();
                    pr.URL = item["URL"].ToString();
                    pr.Head_portrait = item["Head_portrait"].ToString();
                    pr.Province = item["Province"].ToString();
                    pr.City = item["City"].ToString();
                    pr.User_state = item["User_state"].ToString();
                    po.Add(pr);
                }
                return po;
            }
            else
            {
                return null;
            }
        }
        public List<Userager> Personalselectager()
        {
            string sql = string.Format(@"select count(ProjectInfo.ProjectID) 项目总数,avg(ProjectDetails.Raised_amount) 筹集金额
                                        from ProjectInfo,ProjectDetails
                                        where ProjectInfo.ProjectID=ProjectDetails.ProjectID");
            DataTable dt = DBHelper.Select(sql);
            List<Userager> uag = new List<Userager>();
            foreach (DataRow item in dt.Rows)
            {
                Userager us = new Userager();
                us.zong = item["项目总数"].ToString();
                us.people = "6".ToString();
                us.money = double.Parse(item["筹集金额"].ToString());
                uag.Add(us);
            }
            return uag;
        }
    }
}
