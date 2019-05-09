using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ReceivingInfo
    {
        public int ReceivingID { get; set; }  //收件信息
        public int Zip_code { get; set; }   //邮编
        public string Receiving_Province { get; set; }  //省份
        public string Receiving_City { get; set; }   //城市
        public string Receiving_Phone { get; set; }   //收件人手机号码
        public string Receiving_Name { get; set; }   //收件人姓名
        public string Detailed_address { get; set; }  //详细地址
        public string Accounts { get; set; }  //账号
    }
}
