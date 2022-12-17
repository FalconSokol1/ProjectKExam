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
    /// Логика взаимодействия для OSWindow.xaml
    /// </summary>
    public partial class OSWindow : Window
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public OSWindow()
        {
            InitializeComponent();
            askQuestionnn(questionNumber);
            totalQuestions = 4; 
        }

        private void checkAnswerEventnn(object sender, EventArgs e)
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
                askQuestionnn(questionNumber);

            }
            MessageBox.Show("Рестарт!");
            questionNumber++;
            askQuestionnn(questionNumber);

        }
        private void askQuestionnn(int qnum)
        {

            switch (qnum)
            {
                case 1:


                    txbb.Text = "Сколько будет 2+12?";
                    firstB.Content = "14";
                    secondB.Content = "10";
                    thirdB.Content = "15";

                    correctAnswer = 1;

                    break;
                case 2:


                    txbb.Text = "Сколько будет 5+5+2?";
                    firstB.Content = "10";
                    secondB.Content = "12";
                    thirdB.Content = "14";


                    correctAnswer = 2;

                    break;
                case 3:


                    txbb.Text = "Сколько будет 14+6?";
                    firstB.Content = "22";
                    secondB.Content = "23";
                    thirdB.Content = "20";


                    correctAnswer = 3;

                    break;
                case 4:

                    txbb.Text = "Сколько будет 11+11-2?";
                    firstB.Content = "20";
                    secondB.Content = "14";
                    thirdB.Content = "22";


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
