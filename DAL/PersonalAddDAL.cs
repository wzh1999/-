using System;
using System.Collections.Generic;
using System.Text;

using Model;

namespace DAL
{
  public  class PersonalAddDAL
    {
        public bool UsersInsertRecei(ReceivingInfo rec) {
            string sql = string.Format(@"insert ReceivingInfo(Zip_code,Receiving_Province,Receiving_City,Receiving_Phone,Receiving_Name,Detailed_address,Accounts)
                                        values ({0},'{1}','{2}','{3}','{4}','{5}','{6}')"
                                           ,rec.Zip_code,rec.Receiving_Province,rec.Receiving_City,rec.Receiving_Phone,rec.Receiving_Name, rec.Detailed_address,rec.Accounts);
            return DBHelper.Update(sql);
        }
    }
}
