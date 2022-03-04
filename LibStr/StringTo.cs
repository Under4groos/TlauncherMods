using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibStr
{
    public static class StringTo
    {
        public static int To(this string str)
        {
            int i = 0;
            str = Regex.Match(str, "[0-9]+").Value;
            int.TryParse(str, out i);
            return i;
        }
        public static int ToTryParse(this string str)
        {
            int i = 0;
            int.TryParse(str, out i);
            return i;

        }
    }
}
