using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class PersonalSelectBLL
    {
        public List<LoginModel> PersonalSelectedBLL(string Accounts)
        {
            PersonalSelectDAL isd = new PersonalSelectDAL();
            return isd.PersonalSelect(Accounts);
        }

        public List<Userager> Personalselectager()
        {
            PersonalSelectDAL isd = new PersonalSelectDAL();
            return isd.Personalselectager();
        }
    }
}
