using System.Windows;
using System.Windows.Input;

namespace AnimeCheck
{
    public partial class AddAnime : Window
    {
        public AddAnime()
        {
            InitializeComponent();
        }
        private void AddWatched_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddNowWatching_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddWillWatch_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void ComeBack(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Top = this.Top;
            mainWindow.Left = this.Left;
            mainWindow.Show();
            this.Hide();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}