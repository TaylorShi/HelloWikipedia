using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia.WikiSearch.Model
{
    /// <summary>
    /// 搜索词条错误
    /// </summary>
    [System.Reflection.Obfuscation]
    public class WikiSearchError
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [JsonProperty("data")] 
        public string Data { get; set; }

        /// <summary>
        /// 报错模块
        /// </summary>
        [JsonProperty("module")] 
        public string Module { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("*")] 
        public string Text { get; set; }
    }
}
