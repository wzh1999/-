using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ReturnModel
    {
        //汇报编号
        public int ReturnID { get; set; }
        //限定额度
        public int Qualified_quota { get; set; }
        //众筹总额
        public string Support_amount { get; set; }
        //回报内容
        public string Return_content { get; set; }
        //邮费
        public string Freight { get; set; }
        //回报天数
        public int Return_time { get; set; }
        //项目编号
        public int ProjectID { get; set; }


        //真实姓名
        public string UserName { get; set; }
        //省
        public string Province { get; set; }
        //市
        public string City { get; set; }
        //电话
        public string Phone { get; set; }

        //银行名称
        public string Bank_Name { get; set; }
        //开户支行
        public string Bank_branch { get; set; }
        //开户名称
        public string Account_name { get; set; }
        //银行账号
        public string Bank_Number { get; set; }
        //账户
        public string Accounts { get; set; }




    }
}
