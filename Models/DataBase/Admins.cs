namespace Models
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class Admins
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        public int LoginID { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 用户性别
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 用户职级
        /// </summary>
        public string RankName { get; set; }
    }
}
