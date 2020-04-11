using NPoco;
using System.Collections.Generic;

namespace Captain.DB2NET.NPoco
{
    /// <summary>
    /// 数据库接口
    /// </summary>
    public interface IDb
    {
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        int Execute(string sql, params object[] args);
        /// <summary>
        /// 批量执行sql
        /// </summary>
        /// <param name="sqls"></param>
        void ExcuteBatch(List<string> sqls);
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="poco"></param>
        /// <returns></returns>
        object Insert<T>(T poco);
        /// <summary>
        /// 巨量插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pocos"></param>
        void InsertBulk<T>(IEnumerable<T> pocos);
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        object Update(object poco);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        object Delete(object poco);
        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pocoOrPrimaryKey">实体或主键</param>
        /// <returns></returns>
        object Delete<T>(object pocoOrPrimaryKey);

        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        T SingleOrDefault<T>(string sql, params object[] args);
        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        T SingleOrDefaultById<T>(object primaryKey);
        /// <summary>
        /// 查询首条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        T First<T>(string sql, params object[] args);
        /// <summary>
        /// 查询首条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        T FirstOrDefault<T>(string sql, params object[] args);
        /// <summary>
        /// 数据查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        List<T> Fetch<T>();
        /// <summary>
        /// 数据查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>        
        /// <param name="args"></param>
        /// <returns></returns>
        List<T> Fetch<T>(string sql, params object[] args);
        /// <summary>
        /// 数据查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(string sql, params object[] args);
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pageIndex">第几页（从1开始）</param>
        /// <param name="pageSize"></param>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Page<T> Page<T>(int pageIndex, int pageSize, string sql, params object[] args);
        /// <summary>
        /// 实体是否存在
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        bool Exist<T>(object primaryKey);
    }
}
