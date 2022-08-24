using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wikipedia.Helper;
using Wikipedia.WikiSearch.Model;
using Wondershare.Extensions.AsyncTasks;
using Wondershare.Extensions.HttpTasks;

namespace Wikipedia
{
    public class WikiSearchService : IWikiSearchService
    {
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

        /// <summary>
        /// 搜索词条
        /// </summary>
        /// <param name="wikiSearchVo"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Search(WikiSearchVo wikiSearchVo)
        {
            if(wikiSearchVo == null)
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

            var args = new Dictionary<string, string>()
            {
                // 执行一次全文本搜索
                ["action"] = "query",
                ["list"] = "search",
                // 搜查关键词
                ["srsearch"] = searchString,
                // 返回结果格式
                ["format"] = "json",
                // 返回错误格式
                ["errorformat"] = "plaintext"
            };

            var wikiLang = wikiSearchVo.Language.GetStringValue();

            var task = new AsyncTask();
            task.Start();
            var apitask = new HttpTask<WikiSearchDto>(new RequestPara()
            {
                Url = "http://www.baidu.com",
                Method = HttpMethod.GET
            });
            if (task.ExecuteTask(apitask))
            {
                var taskResponse = apitask.Result as WikiSearchDto;
            }
            return true;
        }
    }
}
