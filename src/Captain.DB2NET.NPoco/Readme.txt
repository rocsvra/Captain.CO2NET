注意：
1.NPocoDb实现了IDisposable接口，在垃圾回收的时候会调用Dispose的方法关闭数据库连接（采用services.AddScope注入）。
2.也暴露了连接Connection 和 Db两个属性，可以在特定情况下手动进行数据库操作。