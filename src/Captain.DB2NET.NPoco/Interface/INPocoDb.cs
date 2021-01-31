using System;

namespace Captain.DB2NET.NPoco
{
    /// <summary>
    /// 数据库操作类
    /// </summary>
    public interface INPocoDb : IDbQuery, IDbNonQuery, IDisposable
    {
    }
}
