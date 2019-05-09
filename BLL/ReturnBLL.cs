using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class ReturnBLL
    {
        public static DataTable Gettable()
        {
            return ReturnDAL.Gettable();
        }


            /// <summary>
        /// 项目信息添加
        /// </summary>
        /// <returns></returns>
        //public static bool InfomationDAL(DetailsModel model) {
        //    return ReturnDAL.InfomationDAL(model);
        //}

          /// <summary>
        /// 回报设置
        /// </summary>
        /// <returns></returns>
        public static bool Returnwebs(ReturnModel RM) {
            return ReturnDAL.Returnwebs(RM);
        
        }
        /// <summary>
        /// 查询项目ID
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int Selecteds(string name) {
            return ReturnDAL.Selecteds(name);     
        }
          /// <summary>
        /// 发起人信息添加修改
        /// </summary>
        /// <returns></returns>
        public static bool Insretin(string Phone, string Province, string City, string UserName) {
            return ReturnDAL.Insretin(Phone, Province, City, UserName);
        }
          /// <summary>
        /// 添加银行信息
        /// </summary>
        /// <returns></returns>
        public static bool InReturn(ReturnModel RM)
        {
            return ReturnDAL.InReturn(RM);
        }

          /// <summary>
        /// 添加ProjectDetails信息
        /// </summary>
        /// <returns></returns>
        public static bool InProjectDetails(DetailsModel dm)
        {
            return ReturnDAL.InProjectDetails(dm);
        }


    }
}
