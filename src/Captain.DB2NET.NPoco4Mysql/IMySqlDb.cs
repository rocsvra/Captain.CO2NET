using Captain.DB2NET.NPoco;
using MySql.Data.MySqlClient;
using System.Data;

namespace Captain.DB2NET.NPoco4Mysql
{
    /// <summary>
    /// MySql数据库操作类
    /// </summary>
    public interface IMySqlDb : INPocoDb
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
