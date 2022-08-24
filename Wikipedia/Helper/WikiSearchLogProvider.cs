using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wikipedia.Helper
{
    internal static class WikiSearchLogProvider
    {
        public static void Trace(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
