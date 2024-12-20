using System.Windows;
using System.Windows.Controls;
using AnimeCheck.Model;
using AnimeCheck.ViewModel;

namespace AnimeCheck.View
{
    public partial class ViewedPage : Page
    {
        public ViewedPage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            DataProcessing.ReadFile();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //DataContext = new ViewedViewModel();
        }

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            ViewedViewModel viewModel = DataContext as ViewedViewModel;
            
            if (e.NewValue is Title title)
            {
               viewModel.SelectedAnime = (Title)e.NewValue;
            }
            else if (e.NewValue is TitlePart titlePart)
            {
                viewModel.SelectedSeason = (TitlePart)e.NewValue;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MyExpander.IsExpanded = !MyExpander.IsExpanded;
        }
    }
}

