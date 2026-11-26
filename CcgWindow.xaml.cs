using System.Windows;
namespace TokyoGhoulQuiz
{
        public partial class CcgWindow : Window
        {
            public CcgWindow()
            {
                InitializeComponent();
            }

            private void Home_Click(object sender, RoutedEventArgs e)
            {
                new MainWindow().Show();
                Close();
            }

            private void Quiz_Click(object sender, RoutedEventArgs e)
            {
                new QuizWindow().Show();
                Close();
            }

            private void Ranks_Click(object sender, RoutedEventArgs e)
            {
                new RanksWindow().Show();
                Close();
            }

            private void Ccg_Click(object sender, RoutedEventArgs e)
            {
            }
        }
    }