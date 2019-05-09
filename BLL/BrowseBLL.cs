using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
  public   class BrowseBLL
    {
     
        /// <summary>
        /// 项目详情页
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        public static List<DetailsModel> SelectDetails()
        {
            return BrowseDAL.SelectDetails();

        }
        /// <summary>
        ///返回四行
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        public static List<DetailsModel> REmen()
        {
            return BrowseDAL.REmen();
        }
      /// <summary>
      /// 众筹中
      /// </summary>
      /// <returns></returns>
        public static List<DetailsModel> ZhongChouZhong()
        {
            return BrowseDAL.ZhongChouZhong();
        }
         /// <summary>
        /// 已成功
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> YiChengGong()
        {
            return BrowseDAL.YiChengGong();
        }
         /// <summary>
        /// 最新上线
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> ZuiXinshangxian()
        {
            return BrowseDAL.ZuiXinshangxian();
        }
         /// <summary>
        /// 最高目标金额
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> MaxMoney()
        {
            return BrowseDAL.MaxMoney();
        }
        /// <summary>
        /// 最多喜欢人数
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> MaxLove()
        {
            return BrowseDAL.MaxLove();
        }
         /// <summary>
        /// 最多支持金额
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> MaxZhichimoney()
        {
            return BrowseDAL.MaxZhichimoney();
        }
        /// <summary>
        /// 科技、艺术、设计、音乐等导航
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> daohang(string name) {
            return BrowseDAL.daohang (name);
        }
        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public static List<DetailsModel> Shuliang()
        {
            return BrowseDAL.Shuliang();
        }

        /// <summary>
        /// 获取指定分类下的商品总个数（分页）
        /// </summary>
        /// <returns>个数</returns>
        public static int ByClassID()
        {
            return BrowseDAL.ByClassID();
        }

          /// <summary>
        /// 获取商品列表的分页数据
        /// </summary>
        /// <param name="pageSize">每页行数</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="ClassID">商品分类</param>
        /// <returns>商品数据集</returns>
        public static List<DatailsMode1> SelectProductByPaging(int pageSize, int pageIndex)
        {
            return BrowseDAL.SelectProductByPaging(pageSize, pageIndex);
        
        }
        /// <summary>
        /// 搜索框模糊查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<DetailsModel> SelectDetailslike(string name)
        {
            return BrowseDAL.SelectDetailslike(name);
        }



    }
}
