using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ItemManageDAL
    {
        //用户喜欢的项目
        //用户的项目
        //********************************************
        public List<ProjectInfo> UserProjectGood(string Accounts, int pageSize, int pageIndex, string Investment_state)
        {
            string sql = string.Format(@"select top {0} usin.Accounts as Accounts,prus.Project_UserID as pru, prin.ProjectID,prin.Project_cover, prin.Project_Name,prde.Release_date,prde.Closing_date,prin.Project_Money,prde.Raised_amount,  prin.Project_state
                                        from UserInfo usin,ProjectInfo prin,ProjectDetails prde,Project_User prus
                                        where usin.Accounts=prus.Accounts and prus.ProjectID=prin.ProjectID and prin.ProjectID=prde.ProjectID and prde.ProjectID not in (
                                                                                                                                select top {1} prin.ProjectID
																																from UserInfo usin,ProjectInfo prin,ProjectDetails prde,Project_User prus
																																where usin.Accounts=prus.Accounts and prus.ProjectID=prin.ProjectID and prin.ProjectID=prde.ProjectID  and  usin.Accounts='{2}' and prus.Investment_state='{3}')
                                        and  usin.Accounts='{4}' and prus.Investment_state='{5}'",
                                        pageSize, pageIndex * pageSize, Accounts, Investment_state, Accounts, Investment_state);
            DataTable dt = DBHelper.Select(sql);
            //****************************************************************
            List<ProjectInfo> po = new List<ProjectInfo>();
            if (dt != null && dt.Rows.Count >= 1)
            {
                foreach (DataRow item in dt.Rows)
                {
                    ProjectInfo pr = new ProjectInfo();
                    pr.Project_UserID = int.Parse(item["pru"].ToString());
                    pr.Accounts = item["Accounts"].ToString();
                    pr.ProjectID = int.Parse(item["ProjectID"].ToString());
                    pr.Project_cover = item["Project_cover"].ToString();
                    pr.Project_Name = item["Project_Name"].ToString();
                    pr.Release_date = DateTime.Parse(item["Release_date"].ToString()).ToString("yyyy/MM/dd");
                    pr.Closing_date = DateTime.Parse(item["Closing_date"].ToString()).ToString("yyyy/MM/dd"); ;
                    pr.Project_Money = item["Project_Money"].ToString();
                    pr.Raised_amount = item["Raised_amount"].ToString();
                    pr.Project_state = item["Project_state"].ToString();
                    po.Add(pr);
                }
                return po;
            }
            else
            {
                return null;
            }
        }

        public bool UserProject_user(Project_User pru)
        {
            string sql = string.Format(@"delete Project_user 
                                    where Project_UserID='{0}'", pru.Project_UserID);
            return DBHelper.Update(sql);
        }

        public int UserProjects(string Accounts, string Investment_state)
        {
            string strsql = "";
            strsql = string.Format(@"select usin.Accounts as Accounts,prus.Project_UserID as pru, prin.ProjectID,prin.Project_cover, prin.Project_Name,prde.Release_date,prde.Closing_date,prin.Project_Money,prde.Raised_amount, prus.Investment_state
                                         from UserInfo usin,ProjectInfo prin,ProjectDetails prde,Project_User prus
                                         where usin.Accounts=prus.Accounts and prus.ProjectID=prin.ProjectID and prin.ProjectID=prde.ProjectID 
                                         and  usin.Accounts='{0}' and prus.Investment_state='{1}'", Accounts, Investment_state);
            int count = DBHelper.GetDataTable(strsql).Rows.Count;
            return count;

        }
    }
}
