using System.Collections.Generic;

namespace Captain.DB2NET.NPoco
{
    /// <summary>
    /// NonQuery
    /// </summary>
    public partial class NPocoDb : INPocoDb
    {
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, params object[] args)
        {
            using (Db)
            {
                return Db.Execute(sql, args);
            }
        }

        /// <summary>
        /// 批量执行sql
        /// </summary>
        /// <param name="sqls"></param>
        public void ExecuteNonQuery(IEnumerable<string> sqls)
        {
            using (Db)
            {
                Db.BeginTransaction();
                foreach (var sql in sqls)
                {
                    Db.Execute(sql);
                }
                Db.CompleteTransaction();
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
            using (Db)
            {
                return Db.Insert<T>(poco);
            }
        }

        /// <summary>
        /// 插入(批量)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pocos"></param>
        public void InsertBatch<T>(IEnumerable<T> pocos)
        {
            using (Db)
            {
                Db.InsertBatch<T>(pocos);
            }
        }

        /// <summary>
        /// 巨量插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pocos"></param>
        public void InsertBulk<T>(IEnumerable<T> pocos)
        {
            using (Db)
            {
                Db.InsertBulk<T>(pocos);
            }
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        public object Update(object poco)
        {
            using (Db)
            {
                return Db.Update(poco);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        public object Delete(object poco)
        {
            using (Db)
            {
                return Db.Delete(poco);
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
            using (Db)
            {
                return Db.Delete(pocoOrPrimaryKey);
            }
        }
    }
}
