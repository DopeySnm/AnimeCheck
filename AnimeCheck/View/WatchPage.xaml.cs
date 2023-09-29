﻿using System.Windows;
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

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            WatchViewModel viewModel = DataContext as WatchViewModel;

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