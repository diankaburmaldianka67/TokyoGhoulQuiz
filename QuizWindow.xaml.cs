using System.Windows;
namespace TokyoGhoulQuiz
{
    public partial class QuizWindow : Window
    {

        private int number = 0;
        private int score = 0;

        private string[] questions =
        {
            "Ты обнаружила у себя кагуне. Что будешь делать?",
            "Какое место ты выберешь для укрытия?",
            "Кто из персонажей тебе ближе по характеру?",
            "Что ты сделаешь, если CCG начнёт охоту на тебя?",
            "Какую кагуне ты хотела бы получить?"
        };

        private string[,] answers =
        {
            { "Попытаюсь избавиться от него", "Буду изучать свои способности", "Научусь использовать его в бою" },
            { "Обычную квартиру", "Кафе Anteiku", "Заброшенное здание" },
            { "Хиде", "Канэки", "Ризэ" },
            { "Попробую скрыться", "Найду союзников", "Дам им отпор" },
            { "Укаку", "Бикаку", "Ринкаку" }
        };

        public QuizWindow()
        {
            InitializeComponent();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            QuestionNumberText.Text = "ВОПРОС №" + (number + 1);
            QuestionText.Text = questions[number];

            Answer1.Content = answers[number, 0];
            Answer2.Content = answers[number, 1];
            Answer3.Content = answers[number, 2];

            Answer1.IsChecked = false;
            Answer2.IsChecked = false;
            Answer3.IsChecked = false;

            AnswersPanel.Visibility = Visibility.Visible;
            ResultText.Text = "";
            SubmitButton.Content = "ОТВЕТИТЬ";
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (number == questions.Length)
            {
                number = 0;
                score = 0;
                ShowQuestion();
                return;
            }

            if (Answer1.IsChecked != true &&
                Answer2.IsChecked != true &&
                Answer3.IsChecked != true)
            {
                ResultText.Text = "Сначала выбери вариант ответа.";
                return;
            }

            if (Answer1.IsChecked == true)
            {
                score += 1;
            }
                

            if (Answer2.IsChecked == true)
            {
                score += 2;
            }
                

            if (Answer3.IsChecked == true)
            {
                score += 3;
            }
                

            number++;

            if (number < questions.Length)
            {
                ShowQuestion();
            }
            else
            {
                QuestionNumberText.Text = "ТЕСТ ЗАВЕРШЁН";
                QuestionText.Text = "Твоя сущность раскрыта!";
                AnswersPanel.Visibility = Visibility.Collapsed;

                if (score <= 7)
                {
                    ResultText.Text = "Ты ближе к человеку. Пока что...";
                }    
                    
                else if (score <= 11)
                {
                    ResultText.Text = "Ты полугуль! ";
                }
                   
                else
                {
                    ResultText.Text = "Ты настоящий гуль! ";
                }
                    

                SubmitButton.Content = "ПРОЙТИ ЕЩЁ РАЗ";
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void Quiz_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Ranks_Click(object sender, RoutedEventArgs e)
        {
            new RanksWindow().Show();
            Close();
        }

        private void Ccg_Click(object sender, RoutedEventArgs e)
        {
            new CcgWindow().Show();
            Close();
        }
    }
}