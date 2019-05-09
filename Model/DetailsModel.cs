using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class DetailsModel
    {
        //项目详情表
        public int ProjectDetailID { get; set; }   //项目详情编号
        public DateTime Release_date { get; set; }  //开始筹集日期
        public DateTime  Closing_date { get; set; }   //结束筹集日期
        public int Like_number { get; set; }   //点赞数
        public string Financing_state { get; set; }  //众筹进度
        public double  Raised_amount { get; set; }   //筹集资金
        public string Operation { get; set; }   //筹集情况

        //项目信息表
        public int ProjectID { get; set; }    //项目编号
        public string Project_Name { get; set; } //项目名称
        public double Project_Money { get; set; }   //筹集金额
        public string Project_cover { get; set; }    //项目封面
        public string Project_Details { get; set; }     //项目细节
        public string Label { get; set; }   //标签-个人说明
        public string Project_brief { get; set; }   //项目简介
        public int Raise_day { get; set; }//筹集天数
        public string Project_Type { get; set; }//项目类型
        public string Project_Province { get; set; }//项目省份
        public string Projecr_City { get; set; }//项目城市
        public string Project_state { get; set; }//项目审核进度
        public string Video { get; set; }//视频链接
        public double  chouji { get; set; }//筹集百分比
        public int shengyutime { get; set; }//剩余天数

        public int shuliang { get; set; }//所有项目数量
//分页
     

















































































        ////评论表
        //public DateTime Topic_time { get; set; }    //评论时间
        //public string Topic_content { get; set; }   //评论内容
        //public int Topic_Num { get; set; }      //评论人数——使用count获取

        ////用户表
        //public string UserName { get; set; }    //用户名
        //public string Head_protrait { get; set; }   //用户头像
        //public string Address { get; set; }     //用户地址

        ////回报表
        //public int ReturnID { get; set; }
        //public int Return_time { get; set; }    //回报天数
        //public int Qualified_quota { get; set; }    //最大支持数
        //public double Support_amount { get; set; }     //支持数量
        //public string Return_content { get; set; }  //回报内容
        //public string Description_pic { get; set; }     //价格按钮图片

        ////支持表
        //public int Support_Num { get; set; }    //支持者人数
        //public string Accounts { get; set; }    //支持者
        //public int Support_Num2 { get; set; }   //数额不同的支持人数

        ////项目用户表
        //public string Pro_Accounts { get; set; }    //项目发起人

        //private double tiao;
        ////进度条
        //public int Zhi { get; set; }    //进度值

        //public double Tiao
        //{
        //    get
        //    {
        //        return tiao;
        //    }

        //    set
        //    {
        //        if (value >= 100)
        //        {
        //            tiao = 100;
        //        }
        //    }
        //}



    }
}
