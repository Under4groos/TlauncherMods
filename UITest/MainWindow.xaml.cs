using LibElmFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace UITest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 55; i++)
            {
                Grid grid = new Grid()
                {
                    Width = 200,
                    Height = 50,
                    Background = Brushes.Red,
                    VerticalAlignment = VerticalAlignment.Top,
                    HorizontalAlignment = HorizontalAlignment.Left,
                     
                };
                Border border = new Border()
                {
                    Width = grid.Width - 10,
                    Height = grid.Height - 10,
                    Background = Brushes.Green,
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,

                };
                grid.Children.Add(border);

                grid.SetPos(i * 25, 0);

                grid_items.Add(grid);
            }
            re_pos();



            this.SizeChanged += (o, e) =>
            {
                re_pos();
            };
        }
        public void re_pos( )
        {
            double w_grid = grid_items.Width;
            double h_grid = grid_items.Height;
            int line_ = 0;
            double w_m = 0;
             
            int count_ = 0;
            foreach (FrameworkElement item in grid_items.Children)
            {
                
                if(w_m > grid_items.ActualWidth - item.Width)
                {
                    line_ += 1;
                    w_m = 0;
                    count_ = 0;
                     
                }
                item.SetPos(count_ * (item.Width + 2 ), line_ * (item.Height + 2) );
                 

                w_m += item.Width;
 
                
                count_++;
            }
        }
    }
}
