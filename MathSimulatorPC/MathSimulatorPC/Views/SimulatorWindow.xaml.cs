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
    /// Логика взаимодействия для SimulatorWindow.xaml
    /// </summary>
    public partial class SimulatorWindow : Window
    {
        
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public static string LinkResult {get;set;}

       
        public SimulatorWindow()
        {
            InitializeComponent();

            
            
            AskQuestion(questionNumber);
            totalQuestions = 4;
            
        }

        

        private void CheckAnswerEvent(object sender, EventArgs e)
        {


            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Тест закончен!" + Environment.NewLine +
                    "У тебя " + score + " правильных ответом." + Environment.NewLine +
                    "Общий процент " + percentage + "%" + Environment.NewLine +
                    "Нажми окей, чтобы продолжить"
                    );
                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);
            }
            
            questionNumber++;
            AskQuestion(questionNumber);

        }
        private void AskQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    txbb.Text = "Сколько будет 2*6?";
                    firstB.Content = "14";
                    secondB.Content = "12";
                    thirdB.Content = "21";

                    correctAnswer = 2;

                    break;
                case 2:
                   

                    txbb.Text = "Сколько будет 4*5?";
                    firstB.Content = "30";
                    secondB.Content = "20";
                    thirdB.Content = "25";


                    correctAnswer = 2;

                    break;
                case 3:
                    

                    txbb.Text = "Сколько будет 9*22?";
                    firstB.Content = "214";
                    secondB.Content = "200";
                    thirdB.Content = "198";


                    correctAnswer = 3;

                    break;
                case 4:
                    txbb.Text = "Сколько будет 1 * 1?";
                    firstB.Content = "1";
                    secondB.Content = "10";
                    thirdB.Content = "11";


                    correctAnswer = 1;

                    break;

            }

        }

        private void close_bt(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
    }
}
