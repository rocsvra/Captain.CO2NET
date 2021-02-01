using NPoco;
using System.Collections.Generic;

namespace Captain.DB2NET.NPoco
{
    /// <summary>
    /// Query
    /// </summary>
    public partial class NPocoDb
    {
        private DbConnection conn;

        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public T SingleOrDefault<T>(string sql, params object[] args)
        {
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.SingleOrDefault<T>(sql, args);
                }
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
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.SingleOrDefaultById<T>(primaryKey);
                }
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
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.First<T>(sql, args);
                }
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
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.FirstOrDefault<T>(sql, args);
                }
            }
        }

        /// <summary>
        /// 数据查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> Fetch<T>()
        {
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.Fetch<T>();
                }
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
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.Fetch<T>(sql, args);
                }
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
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.Query<T>(sql, args);
                }
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
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.Page<T>(pageIndex, pageSize, sql, args);
                }
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
            using (conn)
            {
                conn.Open();
                using (IDatabase db = new Database(conn))
                {
                    return db.Exists<T>(primaryKey);
                }
            }
        }
    }
}
