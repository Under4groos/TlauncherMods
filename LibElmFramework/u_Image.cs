using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LibElmFramework
{
    public class u_Image
    {
        BitmapImage bi = null;
        public string URL { get; set; }
        public u_Image(string url, int w = 100, int h = 100)
        {
            URL = url;
            if (URL == String.Empty)
                return;

            bi                      = new BitmapImage();
            bi.BeginInit();            
            bi.UriSource            = new Uri(URL, UriKind.Absolute);         
            bi.CacheOption          = BitmapCacheOption.OnLoad;
            bi.CreateOptions        = BitmapCreateOptions.IgnoreImageCache;
            bi.DecodePixelWidth     = w;
            bi.DecodePixelHeight    = h;
            bi.EndInit();

        }
        public BitmapImage GetImage()
        {
            return bi;
        }
    }
}
