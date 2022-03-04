using LibParser;
using LibParser.MainMenuAddons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TlauncherParser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SearchAddon mainMenuParser = new SearchAddon();
            mainMenuParser.URL = "https://duckduckgo.com/?q=tlauncher.org+botania+1710&t=chromentp&atb=v1-1&ia=web";
            //mainMenuParser.Parse();
             

             
            //MinecraftVersions minecraftVersions = new MinecraftVersions();
            //minecraftVersions.Parse();
            //foreach (LibParser.Version item in minecraftVersions.versions)
            //{
            //    Console.WriteLine(item.version);
            //}
            // ((<a)([\s\S]*?)<\/a>)
            Console.ReadLine();
        }
    }
}
