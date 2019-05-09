using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class ProjectBLL
    {
        public static DataTable select()
        {

            return ProjectDAL.select();
        }
        public static DataTable select2()
        {
            return ProjectDAL.select2();
        }
        public static DataTable select3()
        {
            return ProjectDAL.select3();
        }
    }
}
