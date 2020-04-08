using Captain.DB2NET.NPoco;
using System.Data.Common;
using System.Data.SqlClient;

namespace Captain.DB2NET.NPoco4SqlServer
{
    /// <summary>
    /// SqlServer
    /// </summary>
    public class SqlServerDb : Db
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static DbConnection GetConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlServerDb(string connectionString) : base(GetConnection(connectionString)) { }
    }
}
