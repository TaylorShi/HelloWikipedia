using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia.WikiSearch.Model
{
    /// <summary>
    /// 搜索词条结果
    /// </summary>
    [System.Reflection.Obfuscation]
    public class WikiSearchResultDto
    {
        /// <summary>
        /// 上一次编辑时间
        /// </summary>
        [JsonProperty("timestamp")] 
        public DateTime LastEdited { get; set; }

        /// <summary>
        /// 词条命名空间，默认值0
        /// </summary>
        [JsonProperty("ns")]
        public int Namespace { get; set; }

        /// <summary>
        /// 词条页面ID
        /// </summary>
        [JsonProperty("pageid")] 
        public int PageId { get; set; }

        /// <summary>
        /// 词条预览
        /// </summary>
        [JsonProperty("snippet")]
        public string Preview { get; set; }

        /// <summary>
        /// 词条页面大小
        /// </summary>
        [JsonProperty("size")] 
        public int Size { get; set; }

        /// <summary>
        /// 词条标题
        /// </summary>
        [JsonProperty("title")] 
        public string Title { get; set; }

        /// <summary>
        /// 词条中有多少字数
        /// </summary>
        [JsonProperty("wordcount")] 
        public int WordCount { get; set; }

        /// <summary>
        /// 词条页面语言
        /// </summary>
        internal string Language { set; private get; }

        /// <summary>
        /// 词条地址
        /// </summary>
        public Uri PageUrl => new Uri($"https://{Language}.wikipedia.org/wiki/{Title}");

        /// <summary>
        /// 词条桌面端地址
        /// </summary>
        public Uri PageDesktopUrl => new Uri($"https://{Language}.wikipedia.org/?curid={PageId}");

        /// <summary>
        /// 词条移动端地址
        /// </summary>
        public Uri PageMobileUrl => new Uri($"https://{Language}.m.wikipedia.org/?curid={PageId}");
    }
}
