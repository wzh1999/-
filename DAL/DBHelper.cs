using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    class DBHelper
    {
        /// <summary>
        /// 连接数据库（数据库名称要改）
        /// </summary>
        public static SqlConnection conn = new SqlConnection
            ("Data Source=.;Initial Catalog=ZhongChouDB;User ID=sa;Password=123456");

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 增、删、改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool Update(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }
        /// <summary>
        /// 执行存储过程 进行增删改
        /// </summary>
        /// <param name="proName">存储过程名称</param>
        /// <param name="paras">存储过程参数</param>
        /// <returns>是否执行成功</returns>
        public static bool ExcuteProcedure(string proName, SqlParameter[] paras)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(proName, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
        /// <summary>
        /// 执行存储过程获得数据集
        /// </summary>
        /// <param name="proName">存储过程名</param>
        /// <param name="paras">存储过程参数(可变参数，可以是一个，也可以是多个)</param>
        /// <returns>DataTable数据集</returns>
        public static DataTable GetDataTableByProcedure(string proName, SqlParameter[] paras)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(proName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            for (int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //查询，DataSet
        public static DataTable GetDataTable(string sqlConstr)
        {
            conn.Open();
            DataTable Table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlConstr, conn);
            dap.Fill(Table);
            conn.Close();
            return Table;
        }

    }
}
