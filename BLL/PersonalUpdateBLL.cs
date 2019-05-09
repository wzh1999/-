using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
namespace BLL
{
   public class PersonalUpdateBLL
    {
       public bool UpdateUsers(LoginModel us)
       {
            PersonalUpdateDAL usup = new PersonalUpdateDAL();
            return usup.UpdateUser(us);
        }

        public bool UpdateUserspwd(string pwd,string Accounts)
        {
            PersonalUpdateDAL usup = new PersonalUpdateDAL();
            return usup.UpdateUserPwd(pwd, Accounts);
        }


        public bool UpdateUserHead(string Head_portrait, string Accounts)
        {
            PersonalUpdateDAL usup = new PersonalUpdateDAL();
            return usup.UpdateUserHead(Head_portrait, Accounts);
        }
    }
}
