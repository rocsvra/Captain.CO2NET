using NPoco;
using System.Collections.Generic;

namespace Captain.DB2NET.NPoco
{
    /// <summary>
    /// NonQuery
    /// </summary>
    public partial class Db : IDb
    {
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public int Execute(string sql, params object[] args)
        {
            using (Conn)
            {
                Conn.Open();
                using (IDatabase db = new Database(Conn))
                {
                    return db.Execute(sql, args);
                }
            }
        }

        /// <summary>
        /// 批量执行sql
        /// </summary>
        /// <param name="sqls"></param>
        public void ExcuteBatch(List<string> sqls)
        {
            using (Conn)
            {
                Conn.Open();
                using (IDatabase db = new Database(Conn))
                {
                    db.BeginTransaction();
                    foreach (var sql in sqls)
                    {
                        db.Execute(sql);
                    }
                    db.CompleteTransaction();
                }
                Conn.Close();
            }
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="poco"></param>
        /// <returns></returns>
        public object Insert<T>(T poco)
        {
            using (Conn)
            {
                Conn.Open();
                using (IDatabase db = new Database(Conn))
                {
                    return db.Insert<T>(poco);
                }
            }
        }

        /// <summary>
        /// 巨量插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pocos"></param>
        public void InsertBulk<T>(IEnumerable<T> pocos)
        {
            using (Conn)
            {
                Conn.Open();
                using (IDatabase db = new Database(Conn))
                {
                    db.InsertBulk<T>(pocos);
                }
            }
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        public object Update(object poco)
        {
            using (Conn)
            {
                Conn.Open();
                using (IDatabase db = new Database(Conn))
                {
                    return db.Update(poco);
                }
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        public object Delete(object poco)
        {
            using (Conn)
            {
                Conn.Open();
                using (IDatabase db = new Database(Conn))
                {
                    return db.Delete(poco);
                }
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pocoOrPrimaryKey">实体或主键</param>
        /// <returns></returns>
        public object Delete<T>(object pocoOrPrimaryKey)
        {
            using (Conn)
            {
                Conn.Open();
                using (IDatabase db = new Database(Conn))
                {
                    return db.Delete(pocoOrPrimaryKey);
                }
            }
        }
    }
}
