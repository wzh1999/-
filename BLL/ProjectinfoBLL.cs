using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class ProjectinfoBLL
    {
        public static bool Add(ProjectinfoModel p)
        {
            return ProjectinfoDAL.Add(p);
        }
    }
}
