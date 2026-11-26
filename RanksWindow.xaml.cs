using System.Windows;
namespace TokyoGhoulQuiz 
{ 
    public partial class RanksWindow : Window 
    {
        public RanksWindow()
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
        }

        private void Ccg_Click(object sender, RoutedEventArgs e)
        {
            new CcgWindow().Show();
            Close();
        }
    }
}
