using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Project_User
    {
        public Project_User()
        { }

        public Project_User(int projectID, string accounts, string investment_state)
        {
            this.ProjectID = projectID;
            this.Accounts = accounts;
            this.Investment_state = investment_state;
        }

        public int Project_UserID { get; set; }  //项目用户ID
        public int ProjectID { get; set; }   //项目ID
        public string Accounts { get; set; }  //用户ID
        public string Investment_state { get; set; }   //项目和用户之前的关系
    }
}
