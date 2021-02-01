using AutoMapper;
using AutoMapper.Configuration;
using System.Collections.Generic;
using System.Linq;

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
            MapperConfigurationExpression experess = new MapperConfigurationExpression();
            experess.CreateMap(obj.GetType(), typeof(T));
            MapperConfiguration cfg = new MapperConfiguration(experess);
            return new Mapper(cfg).Map<T>(obj);
        }

        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static List<T> Map<T>(this IEnumerable<object> source)
        {
            MapperConfigurationExpression experess = new MapperConfigurationExpression();
            experess.CreateMap(source.First().GetType(), typeof(T));
            MapperConfiguration cfg = new MapperConfiguration(experess);
            return new Mapper(cfg).Map<List<T>>(source);
        }
    }
}
