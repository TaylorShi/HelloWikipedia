using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Wikipedia.WikiSearch.Model
{
    /// <summary>
    /// 搜索词条结果
    /// </summary>
    [System.Reflection.Obfuscation]
    public class WikiSearchDto
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [JsonProperty("query")] 
        public WikiSearchQueryDto Query { get; set; } = new WikiSearchQueryDto();

        /// <summary>
        /// 追踪标识
        /// </summary>
        [JsonProperty("requestid")] 
        public string RequestId { get; set; }

        /// <summary>
        /// 提供服务方
        /// </summary>
        [JsonProperty("servedby")] 
        public string ServedBy { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [JsonProperty("curtimestamp")] 
        public DateTime? Timestamp;

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("errors")]
        public List<WikiSearchError> Errors { get; set; }

        /// <summary>
        /// 警告信息
        /// </summary>
        [JsonProperty("warnings")] 
        public List<WikiSearchWarning> Warnings { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        public bool IsSuccess => Errors == null && Warnings == null;

        /// <summary>
        /// 首个结果
        /// </summary>
        public WikiSearchResultDto FirstResultDto => Query.SearchResults.FirstOrDefault();
    }
}
