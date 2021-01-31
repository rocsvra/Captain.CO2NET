using NPoco;
using System.Collections.Generic;

namespace Captain.DB2NET.NPoco
{
    /// <summary>
    /// Query
    /// </summary>
    public partial class NPocoDb
    {
        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public T SingleOrDefault<T>(string sql, params object[] args)
        {
            using (Db)
            {
                return Db.SingleOrDefault<T>(sql, args);
            }
        }

        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public T SingleOrDefaultById<T>(object primaryKey)
        {
            using (Db)
            {
                return Db.SingleOrDefaultById<T>(primaryKey);
            }
        }

        /// <summary>
        /// 查询首条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public T First<T>(string sql, params object[] args)
        {
            using (Db)
            {
                return Db.First<T>(sql, args);
            }
        }

        /// <summary>
        /// 查询首条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public T FirstOrDefault<T>(string sql, params object[] args)
        {
            using (Db)
            {
                return Db.FirstOrDefault<T>(sql, args);
            }
        }

        /// <summary>
        /// 数据查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> Fetch<T>()
        {
            using (Db)
            {
                return Db.Fetch<T>();
            }
        }

        /// <summary>
        /// 数据查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>        
        /// <param name="args"></param>
        /// <returns></returns>
        public List<T> Fetch<T>(string sql, params object[] args)
        {
            using (Db)
            {
                return Db.Fetch<T>(sql, args);
            }
        }

        /// <summary>
        /// 数据查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string sql, params object[] args)
        {
            using (Db)
            {
                return Db.Query<T>(sql, args);
            }
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pageIndex">第几页（从1开始）</param>
        /// <param name="pageSize"></param>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Page<T> Page<T>(int pageIndex, int pageSize, string sql, params object[] args)
        {
            using (Db)
            {
                return Db.Page<T>(pageIndex, pageSize, sql, args);
            }
        }

        /// <summary>
        /// 实体是否存在
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public bool Exist<T>(object primaryKey)
        {
            using (Db)
            {
                return Db.Exists<T>(primaryKey);                
            }
        }
    }
}
