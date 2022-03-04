using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibParser
{
    public class HtmlDownload
    {
        public string Url { get; set; }
        public string Content { get; set; } = "null";
        public void Download()
        {
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                client.Headers["User-Agent"] = "Mozilla/5.0";
                client.DownloadProgressChanged += (o, e) =>
                {
                    Console.WriteLine(e.ProgressPercentage.ToString());
                };

                Content = client.DownloadString(Url);
            }
        }
        public void Save(string path)
        {
            File.WriteAllText(path, Content);
        }

    }
}
