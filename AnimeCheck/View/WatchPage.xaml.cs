using System.Windows;
using System.Windows.Controls;
using AnimeCheck.Model;
using System.ComponentModel;
using AnimeCheck.ViewModel;

namespace AnimeCheck.View
{
    /// <summary>
    /// Логика взаимодействия для WatchingNowAnimePage.xaml
    /// </summary>
    public partial class WatchPage : Page
    {
        
        public WatchPage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e) 
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
