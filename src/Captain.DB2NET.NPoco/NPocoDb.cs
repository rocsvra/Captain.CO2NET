using NPoco;
using System.Data.Common;

namespace Captain.DB2NET.NPoco
{
    public partial class NPocoDb
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        public DbConnection Connection;

        /// <summary>
        /// 数据库
        /// </summary>
        public IDatabase Db => new Database(Connection);

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connection"></param>
        public NPocoDb(DbConnection connection)
        {
            Connection = connection;
        }

        /// <summary>
        /// 回收处理
        /// </summary>
        public void Dispose()
        {
            if (Db != null)
            {
                Db.Dispose();
            }
        }
    }
}
