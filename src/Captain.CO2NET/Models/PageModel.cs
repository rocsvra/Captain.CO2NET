using System.Collections.Generic;

namespace Captain.CO2NET.Models
{
    /// <summary>
    /// 分页数据
    /// </summary>
    public class PageModel<T> where T : class
    {
        /// <summary>
        /// 当前页偏移量
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 数据集合
        /// </summary>
        public IEnumerable<T> Items { get; set; }
    }
}
