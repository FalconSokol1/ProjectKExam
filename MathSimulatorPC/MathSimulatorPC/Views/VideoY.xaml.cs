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
using System.Windows.Shapes;

namespace MathSimulatorPC.Views
{
    /// <summary>
    /// Логика взаимодействия для VideoY.xaml
    /// </summary>
    public partial class VideoY : Window
    {
        public VideoY()
        {
            InitializeComponent();
            string path = @"..\..\ress\y.mp4";
            media.Source = new Uri(path, UriKind.Relative);
            media.Play();
        }

        

        private void bt_close(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Close();
        }

        
    }
}
