using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
using LibramonyClass;
using Newtonsoft.Json;
using CustomLib;

namespace Libramony
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void CasualTbx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LightButton_Click(object sender, RoutedEventArgs e)
        {
            Mainfracture.Theme = "LightTheme";
        }

        private void DarkButton_Click(object sender, RoutedEventArgs e)
        {
            Mainfracture.Theme = "DarkTheme";
        }

        private void EngButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void RusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeserelializeButton_Click_1(object sender, RoutedEventArgs e)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show(Saver.Deserialize<string>($"{desktop}\\SerialTest.txt")); 

        }

        private void SerelializeButton_Click_1(object sender, RoutedEventArgs e)
        {
            Saver.Serialize(CasualTbx.Text);
        }
    }
}
