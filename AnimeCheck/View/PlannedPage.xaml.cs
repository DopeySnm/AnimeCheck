using System;
using AnimeCheck.Model;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimeCheck.ViewModel;

namespace AnimeCheck.View
{
    /// <summary>
    /// Логика взаимодействия для WillWatchAnimePage.xaml
    /// </summary>
    public partial class PlannedPage : Page
    {
        public PlannedPage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            PlannedViewModel viewModel = DataContext as PlannedViewModel;

            if (e.NewValue is Title title)
            {
                viewModel.SelectedAnime = (Title)e.NewValue;
            }
            else if (e.NewValue is TitlePart titlePart)
            {
                viewModel.SelectedSeason = (TitlePart)e.NewValue;
            }
        }
    }
}
