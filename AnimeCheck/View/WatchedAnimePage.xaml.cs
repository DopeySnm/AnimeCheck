using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using Newtonsoft.Json.Linq;

namespace AnimeCheck.View
{
    public partial class WatchedAnimePage : Page
    {
        public WatchedAnimePage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            DataProcessing.ReadFile();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var anime = Anime.GetAnime();
            string storingValueInSearchString = "";
            DataContext = new AnimeViewModel(storingValueInSearchString, anime);
        }

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue is Anime anime)
            {
                AnimeViewModel.SelectedAnime = (Anime)e.NewValue;
            }
            else if (e.NewValue is Season1 season)
            {
                AnimeViewModel.SelectedSeason = (Season1)e.NewValue;
            }
        }
    }
}
