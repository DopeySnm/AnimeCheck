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
            List<Title> titles = DataProcessing.TitleList.Where(x => x.WatchedParts.Count > 0).ToList();
            //foreach (var title in DataProcessing.TitleList)
            //{
            //    if (title.WatchedParts.Count > 0)
            //        titles.Add(title);
            //}
            AnimeList.ItemsSource = titles;
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                DataProcessing.TitleList.Remove((Title)btn.DataContext);
            }
            MainWindow_Loaded(sender,e);
        }
        private void Button_ClickSesons(object sender, RoutedEventArgs e)
        {

        }
    }
}
