
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace DAL
{
    public class ProjectDAL
    {
        public static DataTable select()
        {
            string sql = string.Format("select top 4 * from ProjectInfo left join ProjectDetails on ProjectInfo.ProjectID=ProjectDetails.ProjectID");
            DataTable dt = DBHelper.Select(sql);
            //百分比
            dt.Columns.Add("nu");
            //剩余天数
            dt.Columns.Add("shu");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["nu"] = (double.Parse(dt.Rows[i]["Raised_amount"].ToString()) / double.Parse(dt.Rows[i]["Project_Money"].ToString()) * 100).ToString("F2");
                dt.Rows[i]["shu"] = DateTime.Parse(dt.Rows[i]["Closing_date"].ToString()).DayOfYear - DateTime.Now.DayOfYear;
            }
            return dt;
        }
        public static DataTable select2()
        {
            string sql = string.Format("select top 20 * from ProjectInfo left join ProjectDetails on ProjectInfo.ProjectID=ProjectDetails.ProjectID where ProjectInfo.ProjectID not in (1,2,3,4)");
            DataTable dt = DBHelper.Select(sql);
            //百分比
            dt.Columns.Add("nu");
            //剩余天数
            dt.Columns.Add("shu");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["nu"] = (double.Parse(dt.Rows[i]["Raised_amount"].ToString()) / double.Parse(dt.Rows[i]["Project_Money"].ToString()) * 100).ToString("F2");
                dt.Rows[i]["shu"] = DateTime.Parse(dt.Rows[i]["Closing_date"].ToString()).DayOfYear - DateTime.Now.DayOfYear;
                if (int.Parse(dt.Rows[i]["shu"].ToString()) <= 0)
                {
                    dt.Rows[i]["shu"] = 0;
                }
                //if (DateTime.Parse(dt.Rows[i]["Closing_date"].ToString()) >= DateTime.Now)
                //{
                //    dt.Rows[i]["shu"] = num;
                //    if (double.Parse(dt.Rows[i]["Project_Money"].ToString()) == double.Parse(dt.Rows[i]["Raised_amount"].ToString()))
                //    {
                //        //显示已完成
                //    }
                //    else
                //    {
                //        //显示已结束
                //    }
                //}
            }
            return dt;
        }
        public static DataTable select3()
        {
            string sql = string.Format("select * from ProjectInfo left join ProjectDetails on ProjectInfo.ProjectID=ProjectDetails.ProjectID where ProjectInfo.ProjectID not in (1,2,3,4)");
            DataTable dt = DBHelper.Select(sql);
            //百分比
            dt.Columns.Add("nu");
            //剩余天数
            dt.Columns.Add("shu");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["nu"] = (double.Parse(dt.Rows[i]["Raised_amount"].ToString()) / double.Parse(dt.Rows[i]["Project_Money"].ToString()) * 100).ToString("F2");
                dt.Rows[i]["shu"] = DateTime.Parse(dt.Rows[i]["Closing_date"].ToString()).DayOfYear - DateTime.Now.DayOfYear;
                if (int.Parse(dt.Rows[i]["shu"].ToString()) <= 0)
                {
                    dt.Rows[i]["shu"] = 0;
                }

            }
            return dt;
        }
    }
}
