using System;
using AnimeCheck.Model;
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

namespace AnimeCheck.View
{
    /// <summary>
    /// Логика взаимодействия для WillWatchAnimePage.xaml
    /// </summary>
    public partial class WillWatchAnimePage : Page
    {
        public WillWatchAnimePage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<Title> titles = new List<Title>();
            //foreach (var title in DataProcessing.TitleList)
            //{
            //    if(title.WatchedParts.Count>0)
            //        titles.Add(title);
            //}
            List<Anime> animeList = new List<Anime>()
            {
                new Anime
                {
                    Name = "Атака Титанов",
                    Seasons = new List<Season>
                    {
                        new Season {Title = "1 Сезон" },
                        new Season {Title = "2 Сезон" }
                    }
                },
                new Anime
                {
                    Name = "Убийца Акаме",
                    Seasons = new List<Season>
                    {
                        new Season { Title="1 сезон" }
                    }
                },
                new Anime
                {
                    Name="Берсерк",
                    Seasons = new List<Season>
                    {
                        new Season {Title="Сериал 1997" },
                        new Season {Title="Берсер 2016(ну т.е. хуйня ебаная ненужная уёбищная)" }
                    }
                }
            };
            AnimeList.ItemsSource = titles;
        }
        public class Anime
        {
            public string Name { get; set; }
            public List<Season> Seasons { get; set; }
            public Anime()
            {
                Seasons = new List<Season>();
            }
        }
        public class Season
        {
            public string Title { get; set; }
        }
    }
}
