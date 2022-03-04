using LibStr;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibParser.MainMenuAddons
{
    public class MainMenuParser
    {
        //((<article )([\s\S]*?)<\/article>)
        public List<Addon> addons = new List<Addon>();
        public string URL
        {
            get; set;
        }
        public int MaxCountFrames
        {
            get; set;
        } = 0;
        public MainMenuParser(string ov_url = "")
        {
            URL = ov_url;

        }
        public void Parse()
        {
            if (URL == String.Empty)
                return;
            addons.Clear();
            MaxCountFrames = 0;
            HtmlDownload htmlDownload = new HtmlDownload();
            htmlDownload.Url = URL;
            htmlDownload.Download();

            СRegex.GetValues(htmlDownload.Content, "((<article class=\"b-anons clearfix\")([\\s\\S]*?)<\\/article>)", (str, count, i) =>
            {
                Addon addon = new Addon();
                СRegex.GetValues(str, "(href=\"[\\/\\w-]+.html\")", (addon_url, count2, i2) =>
                {
                    addon.URL = "https://tlauncher.org" + addon_url.MNullReplace(new string[] { "href=\"", "\"" });
                });
                СRegex.GetValues(str, "(<span>[\\w0-9 А-Яа-яё.';:+-,?/*&^%$#@!)(]+<\\/span>)", (addon_name, count2, i2) =>
                {
                    addon.Name = addon_name.MNullReplace(new string[] { "<span>", "</span>" });
                });

                СRegex.GetValues(str, "(src=\"https:\\/\\/tlauncher.org\\/images\\/[A-z0-9-]+.[\\w]+)", (addon_url_image, count2, i2) =>
                {
                    addon.url_image = addon_url_image.MNullReplace(new string[] { "src=\"", "\"" });
                });

                СRegex.GetValues(str, @"(<p>[\S\s]+?<\/p>)", (str2, count2, i2) =>
                {

                    СRegex.GetValues(str2, "((\\/>)|(\">))([А-я\\S\\s]+?)(<\\/p>)", (addon_description, count3, i3) =>
                    {
                        
                        int ccount_ = 0;
                        int count_len = 0;
                        foreach (string item in addon_description.MNullReplace(new string[] { "/>","<br" ,"</p>", "&nbsp;" }).Split(new char[] { ' ' }))
                        {
                            
                            if (count_len <= 1)
                                addon.Description += item.Trim() + " ";
                            if(ccount_ > 10)
                            {
                                addon.Description += "\n";
                                ccount_ = 0;
                                count_len++;
                            }
                            ccount_++;
                        }

                    });

                });
                addons.Add(addon);
            });
            // count frame
            СRegex.GetValues(htmlDownload.Content, @"(ru\/mods)((_2\/[0-9]+)|(-[0-9_]+\/[0-9]+))", (str, count, i) =>
            {

                // (ru\/mods)((_2\/)|(-[0-9_]+\/))
                int num = Regex.Replace(str, @"(ru\/mods)((_2\/)|(-[0-9_]+\/))", "").ToTryParse(); ;
                if (num > MaxCountFrames)
                    MaxCountFrames = num;

                //СRegex.GetValues(htmlDownload.Content, @"(ru\/mods)((_2\/[0-9]+)|(-[0-9_]+\/[0-9]+))", (str2, count2, i2) =>
                //{
                //    //int num = str2.MNullReplace(new string[] { "/mods_2/" })
                //    Console.WriteLine(str2);
                //    int num = Regex.Replace(str2, "([\\/\\w]mods_2\\/)|([\\/\\w]mods-[0-9_]+\\/)", "").ToTryParse(); ;

                //    if (num > MaxCountFrames)
                //        MaxCountFrames = num;


                //});


            });
        }

    }
}
