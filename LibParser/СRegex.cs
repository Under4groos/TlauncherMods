using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibParser
{
    public static class СRegex
    {
        public static void GetValues( string content , string pattern , Action<string , int , int> action)
        {
            int count_ = 0;
            MatchCollection mc = Regex.Matches(content, pattern);
            foreach (Match item in mc)
            {
                action(item.Value , mc.Count , count_);
                count_++;
            }
        }
    }
}
