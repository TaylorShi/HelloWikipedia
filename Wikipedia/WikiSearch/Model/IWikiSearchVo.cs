using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wikipedia.WikiSearch.Enum;

namespace Wikipedia.WikiSearch.Model
{
    public interface IWikiSearchVo
    {
        WikiLanguage Language { get; set; }

        string Keyword { get; set; }
    }
}
