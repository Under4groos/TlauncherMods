using LibParser;
using LibParser.MainMenuAddons;
using Sbkeyboard;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TlauncherMods.Controls;

namespace TlauncherMods
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MinecraftVersions minecraftVersions = new MinecraftVersions();
        MainMenuParser mainMenuParser = new MainMenuParser();
        ThreadTimer timerTick;
        int CUR_FRAME = 1;
        string CUR_URL;
        int cou = 0;
        public MainWindow()
        {
            InitializeComponent();
            timerTick = new ThreadTimer(this);
            #region WinDragMove WBControl WindowBlureffect
            new WinDragMove(this, this);
            new WinResize(this).RightDown(resizeborder);
            new WBControl(this, bclose, ACTIONS.CLOSE);
            new WBControl(this, bmax, ACTIONS.SIZE_max);
            new WBControl(this, bmin, ACTIONS.SIZE_min);
            this.Loaded += (o, e) =>
            {
                //new WindowBlureffect(this, WindowBlureffect.AccentState.ACCENT_ENABLE_BLURBEHIND);
            };
            #endregion


            minecraftVersions.Parse();
            foreach (LibParser.Version item in minecraftVersions.versions)
            {
                Label label = new Label()
                {
                    Content = item.version,
                    Foreground = Brushes.White,
                    FontSize = 15,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = Padding = new Thickness(0, 0, 0, 0),
                };
                label.MouseLeftButtonDown += (o, e) =>
                {
                    CUR_URL = mainMenuParser.URL = item.version_c;
                    
                    UpdateMainMenu();
                    max_count_frame.Content = mainMenuParser.MaxCountFrames;
                    cur_frame.Content = CUR_FRAME = 1;
                };
                list_versions.Items.Add(label);
            }

            if (minecraftVersions.versions.Count > 0)
            {
                CUR_URL = mainMenuParser.URL = minecraftVersions.versions[0].version_c;
                 
                UpdateMainMenu();
                max_count_frame.Content = mainMenuParser.MaxCountFrames;
                cur_frame.Content = CUR_FRAME = 1;
            }
            
            timerTick.Tick += (o, e) =>
            {
               
                if (mainMenuParser.addons.Count > 0 && cou <= mainMenuParser.addons.Count-1)
                {

                    LibParser.Addon item = mainMenuParser.addons[cou];
                    UIAddon uIAddon = new UIAddon();
                    uIAddon.URL = item.URL;
                    uIAddon.image_url = item.url_image;
                    uIAddon.AddonName = item.Name;
                    uIAddon.AddonDescription = item.Description;
                    list_addons.Items.Add(uIAddon);

                    cou++;
                    max_count_frame.Content = mainMenuParser.MaxCountFrames;

                }
                

               
            };
            timerTick.TickTime = 100;
            timerTick.Status = false;
            timerTick.initialize();


            // https://tlauncher.org/download/1181




        }
        public void UpdateMainMenu()
        {
            list_addons.Items.Clear();
            
            new Thread(() =>
            {
                mainMenuParser.Parse();
                
                timerTick.Status = false;
                cou = 0;
                //foreach (LibParser.Addon item in mainMenuParser.addons)
                //{
                //    this.Dispatcher.BeginInvoke((ThreadStart)delegate ()
                //    {
                //        //UIAddon uIAddon = new UIAddon();
                //        //uIAddon.url_download = item.GetDownloadLink();
                //        //uIAddon.image_url = item.url_image;
                //        //uIAddon.AddonName = item.Name;
                //        //uIAddon.AddonDescription = item.Description;
                //        //list_addons.Items.Add(uIAddon);


                //    }, new object[] { });
                //}
            }).Start();



        }

        private void LBorder_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CUR_FRAME--;
            if (CUR_FRAME < 1)
                CUR_FRAME = 1;
            mainMenuParser.URL = CUR_URL + CUR_FRAME + "/";
            
            UpdateMainMenu();
            max_count_frame.Content = mainMenuParser.MaxCountFrames;
            cur_frame.Content = CUR_FRAME;

        }

        private void LBorder_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            CUR_FRAME++;
            if (CUR_FRAME > mainMenuParser.MaxCountFrames)
                CUR_FRAME = mainMenuParser.MaxCountFrames;
            mainMenuParser.URL = CUR_URL + CUR_FRAME + "/";
             
            UpdateMainMenu();
            max_count_frame.Content = mainMenuParser.MaxCountFrames;
            cur_frame.Content = CUR_FRAME;
             
        }

        private void LBorder_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {

            // https://tlauncher.org/search/?q=botania%201.7.10
            tx_search.Text = tx_search.Text.Trim();
            if (tx_search.Text == string.Empty)
                return;
            string url_search_ = "https://tlauncher.org/search/?q=" + tx_search.Text.Replace(" ", "%");

            //HtmlDownload htmlDownload = new HtmlDownload();
            //htmlDownload.Url = url_search_;
            //htmlDownload.Download();

            // htmlDownload.Content

        }
    }
}
