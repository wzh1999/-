using System;
using System.Collections.Generic;
using System.Text;

using Model;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
  public  class PersonalUpdateDAL
    {
      public bool UpdateUser(LoginModel us)
      {
            string sql= string.Format(@"update UserInfo
                                        set UserName='{0}',Gender='{1}',Province='{2}',City='{3}',URL='{4}',Personal_note='{5}'
                                        where Accounts='{6}'",us.UserName,us.Gender,us.Province,us.City,us. URL,us.Personal_note,us.Accounts);
            return DBHelper.Update(sql);
        }

        public bool UpdateUserPwd(string pwd,string Accounts)
        {
            string sql = string.Format(@"update UserInfo
                                        set Pwd='{0}'
                                        where Accounts='{1}'", pwd, Accounts);
            return DBHelper.Update(sql);
        }

        public bool UpdateUserHead(string Head_portrait, string Accounts)
        {
            string sql = string.Format(@"update UserInfo
                                        set Head_portrait='{0}'
                                        where Accounts='{1}'", Head_portrait, Accounts);
            return DBHelper.Update(sql);
        }
    }
}
