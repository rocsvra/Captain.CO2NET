using System.Data.Common;

namespace Captain.DB2NET.NPoco
{
    public partial class Db : IDb
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        public DbConnection Conn { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connection"></param>
        public Db(DbConnection connection)
        {
            Conn = connection;
        }
    }
}
