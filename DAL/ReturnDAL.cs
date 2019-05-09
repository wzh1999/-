using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Model;
namespace DAL
{
    public class ReturnDAL
    {
        public static DataTable Gettable()
        {
            string sql = "select * from [Return]";
            return DBHelper.Select(sql);
        }
        /// <summary>
        /// 项目信息添加
        /// </summary>
        /// <returns></returns>
        //public static bool InfomationDAL(DetailsModel model) {
        //    string sql = string.Format(@"insert into ProjectInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",model.Project_Name ,
        //        model.Project_Money, model.Raise_day, model.Project_Type, model.Project_Province, model.Projecr_City, model.Project_cover, model.Project_Details, model.Label, model.Project_brief, model.Video);
        //   return  DBHelper.Update(sql);



        //}
        /// <summary>
        /// 回报设置
        /// </summary>
        /// <returns></returns>
        public static bool Returnwebs(ReturnModel RM) {
            string sql = string.Format(@"insert into [Return] values('{0}','look1.png','{1}','{2}','{3}','{4}','{5}')", RM.Qualified_quota, RM.Support_amount, RM.Return_content, RM.Freight, RM.Return_time, RM.ProjectID);
            return DBHelper.Update(sql);
        }
        /// <summary>
        /// 查询项目ID
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int Selecteds(string name) {
            string sql = string.Format("select ProjectID from ProjectInfo where Project_Name='{0}'", name);
            DataTable dt=DBHelper.Select(sql);
            return  (int)dt.Rows[0][0] ;   
        }
        /// <summary>
        /// 发起人信息添加修改
        /// </summary>
        /// <returns></returns>
        public static bool Insretin(string Phone,string Province,string City,string UserName) {
            string sql = string.Format(@"update UserInfo set Phone='{0}',Province='{1}',City='{2}' where UserName='{3}'", Phone, Province, City, UserName);
        return DBHelper.Update(sql);  
        }
        /// <summary>
        /// 添加银行信息
        /// </summary>
        /// <returns></returns>
        public static bool InReturn(ReturnModel RM)
        {
            string sql = string.Format(@"insert into BankInfo values('{0}','{1}','{2}','{3}','{4}')", RM.Bank_Name, RM.Bank_branch, RM.Account_name, RM.Bank_Number, RM.Accounts);
            return DBHelper.Update(sql);
        }

        /// <summary>
        /// 添加ProjectDetails信息
        /// </summary>
        /// <returns></returns>
        public static bool InProjectDetails(DetailsModel dm)
        {
            string sql = string.Format(@"insert into ProjectDetails values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", dm.Release_date, dm.Closing_date, dm.Like_number, dm.Financing_state, dm.Raised_amount, dm.ProjectID, dm.Operation);
            return DBHelper.Update(sql);
        }



    }
}
