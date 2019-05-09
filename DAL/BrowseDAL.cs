using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BrowseDAL
    {
        /// <summary>
        /// 项目详情页
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        public static List<DetailsModel> SelectDetails()
        {
            string sql = string.Format(@"select s.Like_number,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount,s.Closing_date ,s.Release_date  
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID ");

            DataTable dt = DBHelper.Select(sql);

            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                   double  nu = DM.Raised_amount /DM.Project_Money * 100;
                   DM.chouji =double.Parse ( nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                   //结束日期
                    DM.Closing_date = DateTime .Parse ( item["Closing_date"].ToString ());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数      
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;  
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }


        }
        /// <summary>
        ///返回除1234所有（显示绑定值要改）
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        public static List<DetailsModel> REmen()
        {
            string sql = string.Format(@" select  s.Like_number,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount,s.Closing_date ,s.Release_date  
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID and o.ProjectID not in (1,2,3,4) ");

            DataTable dt = DBHelper.Select(sql);

            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数      
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }


        }
        /// <summary>
        /// 众筹中
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> ZhongChouZhong()
        {
            string sql = string.Format(@"select s.Like_number,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount,s.Closing_date ,s.Release_date  
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID and Financing_state='众筹中' ");

            DataTable dt = DBHelper.Select(sql);

            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }


        }
        /// <summary>
        /// 已成功
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> YiChengGong()
        {
            string sql = string.Format(@"select s.Like_number,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount,s.Closing_date ,s.Release_date  
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID and Financing_state='已完成' ");

            DataTable dt = DBHelper.Select(sql);

            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = 0;
                    if (DM.Project_Money == DM.Raised_amount)
                    {
                        DM.Financing_state = "已完成";
                    }
                    else
                    {
                        DM.Financing_state = "已结束";
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }

        }


        //-----------------------------------显示下拉列表-------------------------------------
        /// <summary>
        /// 最新上线
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> ZuiXinshangxian()
        {
            //获取当前日期
            DateTime now = DateTime.Now;
            //最近日期比当前日期小7天显示
            DateTime nowtime = DateTime.Now.AddDays(-7);
            //到数据库比较，
            string sql = string.Format(@" select s.Like_number ,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount , s.Closing_date ,s.Release_date  
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID and s.Release_date<='{0}'and Release_date>='{1}'", now, nowtime);
            DataTable dt = DBHelper.Select(sql);
            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 最高目标金额
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> MaxMoney()
        {
            string sql = string.Format(@" select s.Like_number ,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount  , s.Closing_date 
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID order by Project_Money desc");
            DataTable dt = DBHelper.Select(sql);
            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 最多喜欢人数
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> MaxLove()
        {
            string sql = string.Format(@"select s.Like_number ,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount,  s.Closing_date   
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID order by Like_number desc ");
            DataTable dt = DBHelper.Select(sql);
            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 最多支持金额
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> MaxZhichimoney()
        {
            string sql = string.Format(@"select s.Like_number ,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount , s.Closing_date   
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID order by Raised_amount desc ");
            DataTable dt = DBHelper.Select(sql);
            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 科技、艺术、设计、音乐等导航
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> daohang(string name) {
            string sql = string.Format(@"select s.Like_number ,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount , s.Closing_date ,s.Release_date,  o.Project_Type 
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID and  o.Project_Type='{0}'",name);
            DataTable dt = DBHelper.Select(sql);
            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }
        
        }

        /// <summary>
        /// 数量和数据
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> Shuliang()
        {
            string sql = string.Format(@"select s.Like_number,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount,s.Closing_date ,s.Release_date  
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID ");
            DataTable dt = DBHelper.Select(sql);
            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                      //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (DM.Project_Money == DM.Raised_amount)
                        {
                            DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                        DM.shuliang = dt.Rows.Count;
                    }
                  list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取指定分类下的商品总个数（分页）
        /// </summary>
        /// <returns>个数</returns>
        public static int ByClassID()
        {
            string sql = string.Format("select COUNT(*)  from ProjectInfo ");
            DataTable dt = DBHelper.Select(sql);
            if (dt != null)
            {
                return int.Parse(dt.Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// 获取商品列表的分页数据
        /// </summary>
        /// <param name="pageSize">每页行数</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="ClassID">商品分类</param>
        /// <returns>商品数据集</returns>
        public static List<DatailsMode1> SelectProductByPaging(int pageSize, int pageIndex)
        {
            SqlParameter[] paras = new SqlParameter[] 
            { 
                 new SqlParameter("@pagesize",pageSize),
                 new SqlParameter("@pageindex",pageIndex),           
            };


            DataTable dt = DBHelper.GetDataTableByProcedure("chaxun", paras);
            List<DatailsMode1> list = new List<DatailsMode1>();
            if (dt != null && dt.Rows.Count >= 1)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DatailsMode1 DM = new DatailsMode1();         
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    if (DM.Closing_date <= DateTime.Now)
                    {
                        DM.shengyutime = 0;
                        if (  DM.Project_Money ==DM.Raised_amount)
                        {
                                DM.Financing_state = "已完成";
                        }
                        else
                        {
                            DM.Financing_state = "已结束";
                        }
                       
                    }
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }

        }
        /// <summary>
        /// 搜索框模糊查询
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> SelectDetailslike(string name)
        {
            string sql = string.Format(@"select s.Like_number,o.ProjectID ,o.Project_cover ,o.Project_Name ,o.Raise_day  ,
 o.Project_Money  ,s.Financing_state ,s.Raised_amount,s.Closing_date ,s.Release_date  
 from ProjectDetails s  ,ProjectInfo  o where s.ProjectID =o.ProjectID and o.Project_Name like '%{0}%' ", name);

            DataTable dt = DBHelper.Select(sql);

            List<DetailsModel> list = new List<DetailsModel>();
            if (dt.Rows.Count > 0 && dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    DetailsModel DM = new DetailsModel();
                    //点赞数
                    DM.Like_number = int.Parse(item["Like_number"].ToString());
                    //封面路径
                    DM.Project_cover = item["Project_cover"].ToString();
                    //项目名称
                    DM.Project_Name = item["Project_Name"].ToString();
                    //目标筹集天数
                    DM.Raise_day = int.Parse(item["Raise_day"].ToString());
                    //预计筹集金额
                    DM.Project_Money = double.Parse(item["Project_Money"].ToString());
                    //筹集进度
                    DM.Financing_state = item["Financing_state"].ToString();
                    //已获得经资
                    DM.Raised_amount = double.Parse(item["Raised_amount"].ToString());
                    //项目ID
                    DM.ProjectID = int.Parse(item["ProjectID"].ToString());
                    //筹集百分比
                    double nu = DM.Raised_amount / DM.Project_Money * 100;
                    DM.chouji = double.Parse(nu.ToString("F2"));
                    //DM.chouji = (int)DM.Raised_amount / (int)DM.Project_Money * 100;
                    //结束日期
                    DM.Closing_date = DateTime.Parse(item["Closing_date"].ToString());
                    //DM.Release_date = DateTime.Parse(item["Release_date"].ToString());
                    //剩余天数
                    DM.shengyutime = DM.Closing_date.DayOfYear - DateTime.Now.DayOfYear;
                    list.Add(DM);
                }
                return list;
            }
            else
            {
                return null;
            }


        }
    }
}
