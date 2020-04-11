using MySql.Data.MySqlClient;
using NPoco;
using System.Data;

namespace Captain.DB2NET.NPoco4Mysql
{
    /// <summary>
    /// Mysql数据库接口
    /// </summary>
    public interface IMySqlDb : IDatabase
    {
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        DataTable ExecProcedure(string procName, MySqlParameter[] parameters = null);
    }
}
