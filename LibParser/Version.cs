using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibParser
{
    public struct Version
    {

        /// <summary>
        /// Mods for Minecraft 1.9.4 ->  1.9.4
        /// </summary>
        public string version;
        /// <summary>
        /// Mods for Minecraft 1.9.4
        /// </summary>
        public string full_name;
        /// <summary>
        /// /en/mods-194_5/
        /// </summary>
        public string version_c;
        public override string ToString()
        {
            string str_nt_ = "\n  ";
            return $"{full_name}{str_nt_}{version}{str_nt_}{version_c}";
        }
    }
}
