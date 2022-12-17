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
using MathSimulatorPC.Views;


namespace MathSimulatorPC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Lectures lcP = new Lectures();
            Fr.Navigate(lcP);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Закрыть приложение ?", "Выход", MessageBoxButton.YesNo);
            if (Result == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AboutProgramm abP = new AboutProgramm();
            Fr.Navigate(abP);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Временно недоступно", "Внимание!", MessageBoxButton.OK);
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SimulatorPage smP = new SimulatorPage();
            Fr.Navigate(smP);
        }
    }
}
