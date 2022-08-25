using System;
using System.Collections.Generic;
using Wikipedia.Helper;
using Wikipedia.WikiSearch.Model;
using SnowSpace.Extensions.AsyncTasks;
using SnowSpace.Extensions.HttpTasks;
using Wikipedia.WikiSearch.Enum;

namespace Wikipedia
{
    public class WikiSearchService : IWikiSearchService
    {
        private static string WikiGetPath => "https://{0}.wikipedia.org/w/api.php?{1}";

        public WikiSearchDto SearchResult { get; set; } = new WikiSearchDto();

        /// <summary>
        /// 转换语言
        /// </summary>
        /// <param name="viewLanguage"></param>
        /// <returns></returns>
        public WikiLanguage ConvertLanguage(string viewLanguage)
        {
            WikiLanguage wikiLanguage;
            switch (viewLanguage)
            {
                case "CHS":
                case "CHT":
                    wikiLanguage = WikiLanguage.Chinese;
                    break;
                case "NLD":
                    wikiLanguage = WikiLanguage.Dutch;
                    break;
                case "FRA":
                    wikiLanguage = WikiLanguage.French;
                    break;
                case "DEU":
                    wikiLanguage = WikiLanguage.German;
                    break;
                case "ITA":
                    wikiLanguage = WikiLanguage.Italian;
                    break;
                case "JPN":
                    wikiLanguage = WikiLanguage.Japanese;
                    break;
                case "KOR":
                    wikiLanguage = WikiLanguage.Korean;
                    break;
                case "PTG":
                    wikiLanguage = WikiLanguage.Portuguese;
                    break;
                case "RUS":
                    wikiLanguage = WikiLanguage.Russian;
                    break;
                case "ESP":
                    wikiLanguage = WikiLanguage.Spanish;
                    break;
                case "ENG":
                default:
                    wikiLanguage = WikiLanguage.English;
                    break;
            }

            return wikiLanguage;
        }

        public AsyncTask Search(WikiSearchVo wikiSearchVo)
        {
            return AsyncTask.NewTask(Search, wikiSearchVo);
        }

        /// <summary>
        /// 搜索词条
        /// </summary>
        /// <param name="wikiSearchVo"></param>
        /// <returns></returns>
        private bool Search(AsyncTask task, WikiSearchVo wikiSearchVo)
        {
            if (wikiSearchVo == null)
            {
                WikiSearchLogProvider.Trace("入参对象非法");
                return false;
            }

            var searchString = wikiSearchVo.Keyword;
            if (string.IsNullOrEmpty(searchString))
            {
                WikiSearchLogProvider.Trace("搜索词不能为空");
                return false;
            }

            var queryParams = new Dictionary<string, string>()
            {
                // 执行一次全文本搜索
                ["action"] = "query",
                ["list"] = "search",
                // 搜查关键词
                // https://www.mediawiki.org/w/api.php?action=help&modules=query%2Bsearch
                ["srsearch"] = searchString,
                // 返回结果格式
                ["format"] = "json",
                // 返回结果格式
                // https://www.mediawiki.org/wiki/API:JSON_version_2/zh
                ["formatversion"] = "2",    
                // 返回错误格式
                ["errorformat"] = "plaintext"
            };

            var wikiLang = wikiSearchVo.Language.GetStringValue();
            var url = string.Format(WikiGetPath, wikiLang, UrlHelper.CreateQueryString(queryParams));

            SearchResult = new WikiSearchDto();

            var apitask = new HttpTask<WikiSearchDto>(new RequestPara()
            {
                Url = url,
                Method = HttpMethod.GET
            });
            if (task.ExecuteTask(apitask))
            {
                var wikiSearchDto = apitask.Result as WikiSearchDto;
                if (wikiSearchDto != null && wikiSearchDto.IsSuccess && wikiSearchDto.FirstResultDto != null)
                {
                    wikiSearchDto.Query.SetLanguage(wikiLang);
                    SearchResult = wikiSearchDto;
                    return true;
                } 
            }

            return false;
        }
    }
}
