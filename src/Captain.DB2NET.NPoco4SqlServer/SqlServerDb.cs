using Captain.DB2NET.NPoco;
using NPoco.DatabaseTypes;
using System.Data.SqlClient;

namespace Captain.DB2NET.NPoco4SqlServer
{
    /// <summary>
    /// sqlserver 操作类
    /// </summary>
    public class SqlServerDb : NPocoDb, ISqlServerDb
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlServerDb(string connectionString)
            : base(connectionString, new SqlServerDatabaseType(), SqlClientFactory.Instance) { }
    }
}
