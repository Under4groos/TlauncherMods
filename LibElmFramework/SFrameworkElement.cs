using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LibElmFramework
{
    public static class SFrameworkElement
    {
        public static void SetPos(this FrameworkElement frameworkElement , double x , double y)
        {
            frameworkElement.Margin = new Thickness(x,y,0,0);
        }
        public static Point GetPos(this FrameworkElement frameworkElement)
        {
            return new Point(frameworkElement.Margin.Left, frameworkElement.Margin.Top);
        }
        public static void SetSize(this FrameworkElement frameworkElement , double w , double h)
        {
            frameworkElement.Width = w;
            frameworkElement.Height = h;
        }
        public static Size GetSize(this FrameworkElement frameworkElement)
        {
            return new Size(frameworkElement.Width, frameworkElement.Height);
        }
        public static double GetAllW( this Grid g)
        {
            double w_m = 0;
            foreach (FrameworkElement item in g.Children)
            {
                w_m += item.Width;
            }

            return w_m;
        }

        public static void Add( this Grid g , UIElement uIElement)
        {
            if (uIElement == null)
                return;
            g.Children.Add(uIElement);
        }
    }
}
