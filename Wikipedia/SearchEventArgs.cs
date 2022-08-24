using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia
{
    public class SearchEventArgs : EventArgs
    {
        public SearchEventArgs(string keyword)
        {
            Keyword = keyword;
        }

        public string Keyword;
    }
}
