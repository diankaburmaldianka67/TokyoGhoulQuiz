using System.Windows;
namespace TokyoGhoulQuiz
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
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
            new CcgWindow().Show();
            Close();
        }
    }
}