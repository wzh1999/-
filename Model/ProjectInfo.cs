using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ProjectInfo
    {

        public ProjectInfo() { }

        public ProjectInfo(int projectID)
        {
            this.ProjectID = projectID;
        }
        public ProjectInfo(string operation, int projectID)
        {
            this.Operation = operation;
            this.ProjectID = projectID;
        }
        public ProjectInfo(string project_Name, string project_Money, int raise_day, string project_Type, string project_Province, string Project_City, string project_cover, string video, string project_brief, string project_Details, string label)
        {
            this.Project_Name = project_Name;
            this.Project_Money = project_Money;
            this.Raise_day = raise_day;
            this.Project_Type = project_Type;
            this.Project_Province = project_Province;
            this.Project_City = Project_City;
            this.Project_cover = project_cover;
            this.Video = video;
            this.Project_brief = project_brief;
            this.Project_Details = project_Details;
            this.Label = label;
        }
        public ProjectInfo(string project_Name, string project_Money, int raise_day, string project_Type, string project_Province, string Project_City, string project_cover, string video, string project_brief, string project_Details, string label,int projectID)
        {
            this.Project_Name = project_Name;
            this.Project_Money = project_Money;
            this.Raise_day = raise_day;
            this.Project_Type = project_Type;
            this.Project_Province = project_Province;
            this.Project_City = Project_City;
            this.Project_cover = project_cover;
            this.Video = video;
            this.Project_brief = project_brief;
            this.Project_Details = project_Details;
            this.Label = label;
            this.ProjectID = projectID;
        }

        //信息
        public int ProjectID { get; set; }  //项目ID
        public string Project_Name { get; set; }  //项目名称
        public string Project_Money { get; set; }   //项目所需金额
        public int Raise_day { get; set; }   //筹集需要的天数
        public string Project_Type { get; set; }  //项目类型
        public string Project_Province { get; set; }  //省份
        public string Project_City { get; set; }  //城市
        public string Project_cover { get; set; }  //项目图片
        public string Project_Details { get; set; }  //项目详情
        public string Label { get; set; }  //标签
        public string Project_state { get; set; }   //项目状态
        public string Project_brief { get; set; }  //简介
        public string Video { get; set; }  //视频


        //详情
        public int ProjectDetailID { get; set; }   //项目详情ID
        public string Release_date { get; set; }  //发起时间
        public string Closing_date { get; set; }   //截止时间
        public int Like_number { get; set; }   //喜欢人数
        public string Financing_state { get; set; }  //筹集状态
        public string Raised_amount { get; set; }   //已筹金额
        public string Operation { get; set; }   //项目操作状态
        public double chouji { get; set; }
        public string shengyutime { get; set; }
        public int Bfh
        {
            get
            {
                return bfh;
            }

            set
            {
                if (value >= 100)
                {
                    bfh = 100;
                }
                else
                {
                    bfh = value;
                }
            }
        }

        //其他
        private int bfh;
        public int Project_UserID { get; set; }
        public int sy_day { get; set; }
        public string Accounts { get; set; }
        public string Investment_state { get; set; }
    }
}
