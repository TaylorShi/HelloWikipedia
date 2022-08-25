using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia.WikiSearch.Model
{
    /// <summary>
    /// 搜索词条查询
    /// </summary>
    [System.Reflection.Obfuscation]
    public class WikiSearchQueryDto
    {
        /// <summary>
        /// 搜索结果相关信息
        /// </summary>
        [JsonProperty("searchinfo")] 
        public WikiSearchQueryInfo SearchInfo { get; set; }

        /// <summary>
        /// 接口返回的结果数组
        /// </summary>
        [JsonProperty("search")]
        public List<WikiSearchResultDto> SearchResults { get; set; } = new List<WikiSearchResultDto>();

        /// <summary>
        /// 设置结果集中的词条语言
        /// </summary>
        /// <param name="language"></param>
        internal void SetLanguage(string language)
        {
            if (!string.IsNullOrEmpty(language) && SearchResults != null && SearchResults.Count > 0)
            {
                foreach (var searchResult in SearchResults)
                {
                    searchResult.Language = language;
                }
            }
        }
    }
}
