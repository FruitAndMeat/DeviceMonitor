using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class SQLHelper
    {
        //从App.config文件中取出连接字符串
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        /// <summary>
        /// 执行增删改操作，并返回受影响的行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parameters">SQL参数数组</param>
        /// <returns>受影响的行数</returns>
        public static int Update(string sql,SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (parameters!=null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog("执行DAL.SQLHelper.Update方法出现错误，错误日志:"+ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行单一结果查询，如查询人数总和之类
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parameters">SQL参数数组</param>
        /// <returns></returns>
        public static object GetSingleResult(string sql,SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (parameters!=null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行DAL.SQLHelper.GetSingleResult方法出现错误，错误信息：" + ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        


        /// <summary>
        /// 执行结果集查询，里面有多张表
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parameters">SQL参数数组</param>
        /// <returns></returns>
        public  static DataSet GetDataSet(string sql, SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行DAL.SQLHelper.GetDataSet方法出现错误，错误信息：" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// 启用事务提交多条带参数的SQL语句
        /// </summary>
        /// <param name="mainSql">主表SQL</param>
        /// <param name="mainParam">主表对应的参数</param>
        /// <param name="detailSql">明细表SQL语句</param>
        /// <param name="detailParam">明细表对应的参数</param>
        /// <returns>返回事务是否成功</returns>
        public static bool UpdateByTran(string mainSql, SqlParameter[] mainParam, string detailSql, List<SqlParameter[]> detailParam)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();//开启事务
                if (mainSql != null && mainSql.Length != 0)
                {
                    cmd.CommandText = mainSql;
                    cmd.Parameters.AddRange(mainParam);
                    cmd.ExecuteNonQuery();
                }
                foreach (SqlParameter[] param in detailParam)
                {
                    cmd.CommandText = detailSql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//回滚事务
                }   
                //将异常信息写入日志 
                string errorInfo = "调用UpdateByTran(string mainSql,  SqlParameter[] mainParam,string detailSql ,List <SqlParameter []>detailParam)方法时发生错误，具体信息：" + ex.Message;
                LogHelper.WriteLog(errorInfo);
                throw ex;
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;//清空事务
                }
                conn.Close();
            }
        }


        /// <summary>
        /// 启用事务提交多条不带参数的SQL语句
        /// </summary>
        /// <param name="sqlList">SQL语句List集合</param>
        /// <returns>执行结果，成功为True,失败为False</returns>
        public static bool UpdateByTran(string sql, List<SqlParameter[]> sqlParameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();//开启数据库事务。
                foreach (SqlParameter[] parameter in sqlParameters)
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(parameter);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction!=null)
                {
                    cmd.Transaction.Rollback();//捕捉异常就回滚事务
                }
                string errorInfo = "调用UpdateByTran(string sql, List<SqlParameter[]> sqlParameters)方法时发生错误，具体信息：" + ex.Message;
                LogHelper.WriteLog(errorInfo);
                throw ex;
            }
            finally
            {
                if (cmd.Transaction!=null)
                {
                    cmd.Transaction = null;//执行完清空事务
                }
                conn.Close();
            }
        }
    }
}
