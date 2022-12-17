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

namespace ISSNature
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string Video { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AboutApp ab = new AboutApp();
            ab.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Flora videos = new Flora();
            
            videos.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Animals videos = new Animals();
           
            videos.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Nature videos = new Nature();
          
            videos.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Закрыть приложение ?", "Выход", MessageBoxButton.YesNo);
            if (Result == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
