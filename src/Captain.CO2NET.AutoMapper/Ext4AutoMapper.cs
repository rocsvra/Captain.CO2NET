using AutoMapper;
using AutoMapper.Configuration;
using System.Linq;
using System.Collections.Generic;

namespace Captain.CO2NET.AutoMapper
{
    /// <summary>
    /// AutoMapper扩展类
    /// </summary>
    public static class Ext4AutoMapper
    {
        /// <summary>
        ///  类型映射
        /// </summary>
        public static T Map<T>(this object obj)
        {
            if (obj == null)
            {
                return default(T);
            }
            var cfg = new MapperConfigurationExpression();
            cfg.CreateMap(obj.GetType(), typeof(T));
            Mapper.Initialize(cfg);
            return Mapper.Map<T>(obj);
        }
        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static List<T> Map<T>(this IEnumerable<object> source)
        {
            var cfg = new MapperConfigurationExpression();
            cfg.CreateMap(source.First().GetType(), typeof(T));
            Mapper.Initialize(cfg);
            return Mapper.Map<List<T>>(source);
        }
    }
}
