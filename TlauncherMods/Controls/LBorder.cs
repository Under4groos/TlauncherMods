using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TlauncherMods.Controls
{
    public class LBorder : Border
    {
        Label _label;
        public LBorder()
        {
            _label = new Label()
            {
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0),
                Padding = new Thickness(0),
            };
            this.Child = _label;
        }
        public Thickness LabelMargin
        {
            get { return _label.Margin; }
            set { _label.Margin = value; }
        }
        public HorizontalAlignment LabelHorizontal
        {
            get { return _label.HorizontalContentAlignment;}
            set { _label.HorizontalContentAlignment = value;}
        }
        public VerticalAlignment LabelVertical
        {
            get { return _label.VerticalContentAlignment; }
            set { _label.VerticalContentAlignment = value; }
        }
        public double FontSize
        {
            get
            {
                return _label.FontSize;
            }
            set
            {
                _label.FontSize = value;
            }
        }
        public object Content
        {
            get
            {
                return _label.Content;
            }
            set
            {
                _label.Content = value;
            }
        }
        public Style LabelStyle
        {
            get
            {
                return _label.Style;
            }
            set
            {
                _label.Style = value;
            }
        }

    }
}
