using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibParser
{
    public struct Addon
    {
        public string Name;
        public string url_image;
        public string Description;
        public string Type;
        public string URL;

        
        public override string ToString()
        {
            string str_nt_ = "\n  ";
            return $"{Name}{str_nt_}{url_image}{str_nt_}{URL}{str_nt_}";
        }
    }
}
