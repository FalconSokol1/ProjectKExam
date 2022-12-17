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
    /// Логика взаимодействия для YRWindow.xaml
    /// </summary>
    public partial class YRWindow : Window
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public YRWindow()
        {
            InitializeComponent();
            askQuestionn(questionNumber);
            totalQuestions = 4;
        }

        private void checkAnswerEventn(object sender, EventArgs e)
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
                    "У тебя " + score + " правильных ответоD." + Environment.NewLine +
                    "Общий процент " + percentage + "%" + Environment.NewLine +
                    "Нажми окей, чтобы продолжить"
                    );
                score = 0;
                questionNumber = 0;
                askQuestionn(questionNumber);

            }
            MessageBox.Show("Рестарт!");
            questionNumber++;
            askQuestionn(questionNumber);

        }
        private void askQuestionn(int qnum)
        {

            switch (qnum)
            {
                case 1:


                    txbb.Text = "Выбери правильный ответ: 3+Y=5";
                    firstB.Content = "Y = 2";
                    secondB.Content = "Y = 3";
                    thirdB.Content = "Y = 1";

                    correctAnswer = 1;

                    break;
                case 2:


                    txbb.Text = "Выбери правильный ответ: X+10=12";
                    firstB.Content = "X=22";
                    secondB.Content = "X=12";
                    thirdB.Content = "X=2";


                    correctAnswer = 3;

                    break;
                case 3:


                    txbb.Text = "Выбери правильный ответ: X-3=4";
                    firstB.Content = "X=8";
                    secondB.Content = "X=7";
                    thirdB.Content = "X=2";


                    correctAnswer = 2;

                    break;
                case 4:

                    txbb.Text = "Выбери правильный ответ: 15-Y=15";
                    firstB.Content = "Y=1";
                    secondB.Content = "Y=2";
                    thirdB.Content = "Y=0";


                    correctAnswer = 2;

                    break;

            }

        }

        private void close_bt(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
