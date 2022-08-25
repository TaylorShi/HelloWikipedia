using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wikipedia.WikiSearch.Enum;

namespace Wikipedia.WikiSearch.Model
{
    public class WikiSearchVo : IWikiSearchVo
    {
        /// <summary>
        /// 维基语言
        /// </summary>
        public WikiLanguage Language { get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 只在这些命名空间搜索，要指定所有值，请使用*，默认：0。
        /// </summary>
        public List<int> Namespaces { get; set; }

        /// <summary>
        /// 搜索结果分页大小默认值
        /// </summary>
        private int pageSize = 10;

        /// <summary>
        /// 搜索结果分页大小
        /// </summary>
        public int PageSize
        {
            get => pageSize;
            set
            {
                const int min = 1;
                const int max = 50;
                if (value < min || value > max)
                    throw new ArgumentOutOfRangeException(nameof(value), $"页面大小 {value} 超出范围. 合法的范围应该是 {min}-{max}");
                pageSize = value;
            }
        }

        /// <summary>
        /// 当更多结果可用时，使用这个继续。默认：0
        /// </summary>
        public int ResultOffset { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        public string RequestId { get; set; }
    }
}
