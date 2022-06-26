using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdminServices
    {
        /// <summary>
        /// 根据输入登录账号和密码进行登录验证
        /// </summary>
        /// <param name="objAdmin">封装好的登录对象</param>
        /// <returns>返回的完整登录对象</returns>
        public Admins AdminLogin(Admins objAdmin)
        {
            string sql = $"select LoginID,LoginPwd,LoginName,Gender,RankRemark " +
                "from Admins inner join Ranks on Ranks.RankID = Admins.RankID " +
                "where LoginID = @LoginID and LoginPwd = @LoginPwd";
            SqlParameter[] parameters = {
                new SqlParameter("@LoginID",objAdmin.LoginID),
                new SqlParameter("@LoginPwd",objAdmin.LoginPwd)
            };
            DataSet ds = SQLHelper.GetDataSet(sql, parameters);
            if (ds!=null&&ds.Tables.Count>0&&ds.Tables[0].Rows.Count>0)
            {
                objAdmin.LoginID = Convert.ToInt32(ds.Tables[0].Rows[0]["LoginID"]);
                objAdmin.LoginName = ds.Tables[0].Rows[0]["LoginName"].ToString();
                objAdmin.LoginPwd = ds.Tables[0].Rows[0]["LoginPwd"].ToString();
                objAdmin.Gender = ds.Tables[0].Rows[0]["Gender"].ToString();
                objAdmin.RankName = ds.Tables[0].Rows[0]["RankRemark"].ToString();
                return objAdmin;
            }
            else { return null; }
            
        }
    }
}
