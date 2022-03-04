using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStr
{
    public static class MulReplace
    {
        public static string MNullReplace(this string str , string[] array_r)
        {
            foreach (string item in array_r)
            {
                str = str.Replace(item, "");
            }
            return str;
        }
    }
}
