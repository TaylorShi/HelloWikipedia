using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia.WikiSearch.Common
{
    [AttributeUsage(AttributeTargets.Enum)]
    internal class MultFlagValueAttribute : Attribute
    {
        public MultFlagValueAttribute()
        {
        }
    }
}
