using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wikipedia.WikiSearch.Model;

namespace Wikipedia
{
    public interface IWikiSearchService
    {
        /// <summary>
        /// 转换语言
        /// </summary>
        /// <param name="viewLanguage"></param>
        /// <returns></returns>
        WikiLanguage ConvertLanguage(string viewLanguage);

        /// <summary>
        /// 搜索词条
        /// </summary>
        /// <param name="wikiSearchVo"></param>
        /// <returns></returns>
        bool Search(WikiSearchVo wikiSearchVo);
    }
}
