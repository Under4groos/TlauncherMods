using LibStr;
using System;
using System.Collections.Generic;

namespace LibParser
{
    public class MinecraftVersions
    {
        public string URL
        {
            get;private set;
        }
        public List<Version> versions = new List<Version>();
        public MinecraftVersions(string ov_url = "https://tlauncher.org/ru/mods_2/")
        {
            URL = ov_url;
            
        }
        public void Parse()
        {
            if (URL == string.Empty)
                return;
            HtmlDownload htmlDownload = new HtmlDownload();
            htmlDownload.Url = URL;
            htmlDownload.Download();
            //"((<a href=\"\\/[\\w]+\\/mods-[0-9]+_[0-9]+\\/\" title)([\\s\\S]*?)<\\/a>)"
            // (<a href=\")([\/\w-]+\/mods[\/\w-]+\") (title=\")([\wА-я 0-9.]+\">)(<span>[0-9.]+<\/span><\/a>)
            СRegex.GetValues(htmlDownload.Content, "(<a href=\")([\\/\\w-]+\\/mods[\\/\\w-]+\") (title=\")([\\wА-я 0-9.]+\">)(<span>[0-9.]+<\\/span><\\/a>)", (str, count, i) =>
            {
                Version version = new Version();


                #region Mods for Minecraft -.-.-
                СRegex.GetValues(str, "(title=\"[\\w 0-9.]+\")", (str2, count2, i2) =>
                {
                    version.full_name = str2.MNullReplace(new string[] { "title=", "\"" });
                });
                #endregion

                #region >-.-.-< or >1.15.2<
                СRegex.GetValues(str, "(>[0-9.]+<)", (str2, count2, i2) =>
                {
                    version.version = str2.MNullReplace(new string[] { "<", ">" });
                });
                #endregion
                СRegex.GetValues(str, "(href=\"[\\/\\w-]+\")", (str2, count2, i2) =>
                {
                    version.version_c = "https://tlauncher.org" + str2.MNullReplace(new string[] { "href=\"", "\"" });
                });
                versions.Add(version);
            });
        }

    }
}
