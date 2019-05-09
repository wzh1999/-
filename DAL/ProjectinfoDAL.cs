using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class ProjectinfoDAL
    {
        public static bool Add(ProjectinfoModel p)
        {
            string sql = string.Format(@"insert into ProjectInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')"
,p.Project_Name,p.Project_Money,p.Raise_day,p.Project_Type,p.Project_Province,p.Project_City,p.Project_cover,p.Project_Details,p.Label,"",p.Project_brief,p.Video);
            return DBHelper.Update(sql);
        }
    }
}
