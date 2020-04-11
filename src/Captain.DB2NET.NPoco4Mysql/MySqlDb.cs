using MySql.Data.MySqlClient;
using NPoco;
using System.Data;
using System.Data.Common;

namespace Captain.DB2NET.NPoco4Mysql
{
    /// <summary>
    /// mysql
    /// </summary>
    public class MySqlDb : Database, IMySqlDb
    {
        private readonly string _connectionString;

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static DbConnection GetConnection(string connectionString)
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接串</param>
        public MySqlDb(string connectionString) : base(GetConnection(connectionString))
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable ExecProcedure(string procName, MySqlParameter[] parameters = null)
        {
            DataTable tbl = null;
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(procName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                    tbl = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tbl);
                    connection.Close();
                }
            }
            return tbl;
        }
    }
}
