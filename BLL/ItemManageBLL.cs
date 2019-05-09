using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class ItemManageBLL
    {
        
        public bool UserProject_user(Project_User pru)
        {
            ItemManageDAL up = new ItemManageDAL();
            return up.UserProject_user(pru);
        }

        //有多少页
        public int UserProjects(string Accounts, string Investment_state)
        {
            ItemManageDAL up = new ItemManageDAL();
            return up.UserProjects(Accounts, Investment_state);
        }

        //分页查找的
        public List<ProjectInfo> UserProjectGoods(string Accounts, int pageSize, int pageIndex, string Investment_state)
        {
            ItemManageDAL up = new ItemManageDAL();
            return up.UserProjectGood(Accounts, pageSize, pageIndex, Investment_state);
        }

    }
}
