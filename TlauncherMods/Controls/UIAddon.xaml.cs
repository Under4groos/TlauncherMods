using LibElmFramework;
using LibParser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TlauncherMods.Controls
{
    /// <summary>
    /// Логика взаимодействия для UIAddon.xaml
    /// </summary>
    public partial class UIAddon : UserControl
    {
        
        public UIAddon()
        {
            InitializeComponent();
        }
        public string URL
        {
            get;set;
        }
        public string AddonName
        {
            get
            {
                return name_addon.Content as string;
            }
            set
            {
                name_addon.Content = value;
            }
        }
      
        public string image_url
        {
            get
            {
                return "";
            }
            set
            {
                string url_image = value;
                try
                {
                     
                    
                    
                    image.Source = new u_Image(url_image , 30,30).GetImage();
                   
                    image.Stretch = Stretch.UniformToFill;
                   
                }
                catch (Exception e)
                {

                    Console.WriteLine($"{url_image} {e.Message}");
                }
                
            }
        }
        public string AddonDescription
        {
            get 
            { 
                return description_addon.Content as string;
            }
            set
            {
                description_addon.Content = value;
            }
        }
        public string url_download
        {
            get;set;
        }
        public string GetDownloadLink()
        {
            HtmlDownload htmlDownload = new HtmlDownload();
            htmlDownload.Url = URL;
            htmlDownload.Download();


            // https://tlauncher.org/download/15796

            return Regex.Match(htmlDownload.Content, @"(https:\/\/tlauncher.org\/download\/[0-9]+)").Value;
        }
        private void LBorder_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (url_download != string.Empty)
            {
                
                Process.Start(GetDownloadLink());
            }
                
        }
    }
}
