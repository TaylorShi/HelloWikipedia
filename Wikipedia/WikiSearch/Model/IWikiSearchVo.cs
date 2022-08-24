using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia.WikiSearch.Model
{
    public interface IWikiSearchVo
    {
        WikiLanguage Language { get; set; }

        string Keyword { get; set; }
    }
}
