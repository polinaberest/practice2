using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse
{
    static class Extensions
    {
        public static long forGB = 1073741824;
        public static long forMB = 1048576;

        public static long ConvertSize(string initSize)
        {
            long transformedSize = 0;
            if (initSize.Contains("GB"))
            {
                transformedSize = long.Parse(initSize.Substring(0, initSize.IndexOf("GB"))) * forGB;
            }
            else if (initSize.Contains("MB"))
            {
                transformedSize = long.Parse(initSize.Substring(0, initSize.IndexOf("MB"))) * forMB;
            }
            else if (initSize.Contains("B"))
            {
                transformedSize = long.Parse(initSize.Substring(0, initSize.IndexOf("B")));
            }
            return transformedSize;
        }

    }
}
