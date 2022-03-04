using System;

namespace LibParser
{
    public class SearchAddon
    {
        public string URL
        {
            get; set;
        }
        public SearchAddon()
        {

        }

        public void Parse()
        {

            if (URL == string.Empty)
                return;
            HtmlDownload htmlDownload = new HtmlDownload();
            htmlDownload.Url = URL;
            htmlDownload.Download();
            Console.WriteLine(htmlDownload.Content);
            // (<a class=)(\"gs-image\"[\s\S]+?<\/a>) // 1
            СRegex.GetValues(htmlDownload.Content, "(<div class=)(\"result__body[\\S\\s ]+?<\\/div><\\/div>)", (str, count, i) =>
            {
                Console.WriteLine(str);

            });
        }
    }
}
