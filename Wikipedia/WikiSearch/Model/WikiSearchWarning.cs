using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia.WikiSearch.Model
{
    /// <summary>
    /// 搜索词条警告
    /// </summary>
    [System.Reflection.Obfuscation]
    public class WikiSearchWarning
    {
        /// <summary>
        /// 警告代码
        /// </summary>
        [JsonProperty("code")] 
        public string Code { get; set; }

        /// <summary>
        /// 警告模块
        /// </summary>
        [JsonProperty("module")] 
        public string Module { get; set; }

        /// <summary>
        /// 警告信息
        /// </summary>
        [JsonProperty("*")] 
        public string Text { get; set; }
    }
}
