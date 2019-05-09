using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;

namespace BLL
{
  public  class PersonalAddBLL
    {
        public bool UsersInsertRecei(ReceivingInfo rec) {
            PersonalAddDAL uir = new PersonalAddDAL();
            return uir.UsersInsertRecei(rec);

        }
    }
}
