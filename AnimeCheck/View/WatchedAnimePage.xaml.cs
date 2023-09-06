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
using AnimeCheck.model;
using AnimeCheck.ViewModel;

namespace AnimeCheck.View
{
    public partial class WatchedAnimePage : Page
    {
        List<Anime> animeList;
        public WatchedAnimePage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            DataProcessing.ReadFile();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AnimeViewModel();
            //animeList = Anime.GetAnime();
            //AnimeList.ItemsSource = animeList;
        }

        //Click="btnDelete_Click"
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Anime anime = (Anime)AnimeList.SelectedItem;
            if (AnimeList.SelectedItem is Anime anime)
            {
                animeList.RemoveAll(x => x.id == anime.id);
            }
            else if (AnimeList.SelectedItem is Season season)
            {
                foreach (var item in animeList)
                {
                    for (int i = 0; i < item.Seasons.Count; i++)
                    {
                        if (item.Seasons[i].Equals(season))
                        {
                            item.Seasons.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
            AnimeList.Items.Refresh();
        }
        private void btnLike_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = (Anime)AnimeList.SelectedItem;
            

            AnimeList.Items.Refresh();
        }
        private void btnAddInWatchied_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = (Anime)AnimeList.SelectedItem;


            AnimeList.Items.Refresh();
        }
        private void btnAddInWatchingNow_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = (Anime)AnimeList.SelectedItem;


            AnimeList.Items.Refresh();
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
