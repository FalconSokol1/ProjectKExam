using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Lectures.xaml
    /// </summary>
    public partial class Lectures : Page
    {
       
        class Lecturess
        {
            public string NameLectures { get; set; }
            public string AboutLectures { get; set; }
            public string LinkImage { get; set; }

        }

        public Lectures()
        {
            InitializeComponent();


        List<Lecturess> list = new List<Lecturess>();
            list.Add(new Lecturess()
            {
                NameLectures = "Основы счёта",
                AboutLectures = "Научись считать быстрее!",
                LinkImage = Directory.GetCurrentDirectory() + @"/ress/ic_score.png"
            });
            list.Add(new Lecturess()
            {
                NameLectures = "Таблица умножения",
                AboutLectures = "Таблица поможет тебе!",
                LinkImage = @"/ress/ic_multiplication.png"
            });
            list.Add(new Lecturess()
            {
                NameLectures = "Уравнения",
                AboutLectures = "Пойми уравнения!",
                LinkImage = @"/ress/ic_equations.png"
            });
            list.Add(new Lecturess()
            {
                NameLectures = "Задачи",
                AboutLectures = "Как решать задачки быстрее!",
                LinkImage = @"/ress/ic_task.png"
            });

            lBox.ItemsSource = list;
            
        }

       
        
        private void lb_changed(object sender, SelectionChangedEventArgs e)
        {

            

            foreach (Lecturess lecturess in lBox.SelectedItems)
            {
                
                if (lecturess == lBox.Items[0])
                {
                    
                    VideoO videoo = new VideoO();
                    videoo.ShowDialog();
                   

                }
                
                if (lecturess == lBox.Items[1])
                {

                    Videoss videos = new Videoss();

                    videos.ShowDialog();
                    

                }

                if (lecturess == lBox.Items[2])
                {

                    VideoY videoy = new VideoY();
                    videoy.ShowDialog();
                    

                }
                if (lecturess == lBox.Items[3])
                {

                    MessageBox.Show("Временно недоступно", "Внимание!", MessageBoxButton.OK);
                }
            }
           
        }
    }

}
