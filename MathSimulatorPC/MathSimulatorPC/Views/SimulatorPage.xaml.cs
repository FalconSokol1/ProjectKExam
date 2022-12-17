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

namespace MathSimulatorPC.Views
{
    /// <summary>
    /// Логика взаимодействия для SimulatorPage.xaml
    /// </summary>
    public partial class SimulatorPage : Page
    {
        public static string LinkPS { get; set; }
        public SimulatorPage()
        {
            InitializeComponent();
            List<Test> list = new List<Test>();
            list.Add(new Test()
            {
                NameTest = "Основы счёта",
                AboutTest = "Проверь навыки счёта!",
                LinkImage = @"/ress/ic_score.png"
            });
            list.Add(new Test()
            {
                NameTest = "Таблица умножения",
                AboutTest = "Докажи знания таблицы умножения!",
                LinkImage = @"/ress/ic_multiplication.png"
            });
            list.Add(new Test()
            {
                NameTest = "Уравнения",
                AboutTest = "Если усвоил уровнения, реши их самостаятельно",
                LinkImage = @"/ress/ic_equations.png"
            });
            list.Add(new Test()
            {
                NameTest = "Задачи",
                AboutTest = "Порешай задачки!",
                LinkImage = @"/ress/ic_task.png"
            });

            SBox.ItemsSource = list;

        }

        class Test
        {
            public string NameTest { get; set; }
            public string AboutTest { get; set; }
            public string LinkImage { get; set; }

        }



        private void SBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Test test in SBox.SelectedItems)
            {

                if (test == SBox.Items[0])
                {

                    OSWindow ow = new OSWindow();
            
                    ow.ShowDialog();


                }

                if (test == SBox.Items[1])
                {

                    SimulatorWindow sm = new SimulatorWindow();
                    
                    sm.ShowDialog();


                }

                if (test == SBox.Items[2])
                {

                    YRWindow yr = new YRWindow();

                    yr.ShowDialog();


                }
                if (test == SBox.Items[3])
                {

                    MessageBox.Show("Временно недоступно", "Внимание!", MessageBoxButton.OK);
                }
            }
        }
    }
}
