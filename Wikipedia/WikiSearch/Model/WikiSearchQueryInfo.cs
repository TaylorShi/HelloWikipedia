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
    public class WikiSearchQueryInfo
    {
        /// <summary>
        /// 总结果数(含未显示的)
        /// </summary>
        [JsonProperty("totalhits")] 
        public int TotalHits;
    }
}
