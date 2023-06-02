using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomLib
{
    public class Mainfracture
    {
        private static string theme;
        public static string Theme
        {
            get { return theme; }
            set { theme = value;
                var dict = new ResourceDictionary {Source = new Uri($"pack://application:,,,/CustomLib;component/Themes/{value}.xaml", UriKind.Absolute) };
                Application.Current.Resources.MergedDictionaries.RemoveAt(0);
                Application.Current.Resources.MergedDictionaries.Insert(0, dict);
            }

        }
    }
}
