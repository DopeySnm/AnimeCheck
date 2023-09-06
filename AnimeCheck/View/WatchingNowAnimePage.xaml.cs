using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для WatchingNowAnimePage.xaml
    /// </summary>
    public partial class WatchingNowAnimePage : Page
    {
        List<Anime> animeList;
        public WatchingNowAnimePage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {         
            animeList = new List<Anime>()
            {
                new Anime
                {
                    id = 1,
                    Name = "Атака Титанов",
                    Seasons = new List<Season>
                    {
                        new Season {Title = "1 Сезон" },
                        new Season {Title = "2 Сезон" }
                    }
                },
                new Anime
                {
                    id = 2,
                    Name = "Убийца Акаме",
                    Seasons = new List<Season>
                    {
                        new Season { Title="1 сезон" }
                    }
                },
                new Anime
                {
                    id = 3,
                    Name="Берсерк",
                    Seasons = new List<Season>
                    {
                        new Season {Title="Сериал 1997" },
                        new Season {Title="Берсер 2016(ну т.е. хуйня ебаная ненужная уёбищная)" }
                    }
                }
            };
            AnimeList.ItemsSource = animeList;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = (Anime)AnimeList.SelectedItem;
            animeList.RemoveAll(x => x.id == anime.id);
            AnimeList.Items.Refresh();
        }

        public class Anime
        {
            public int id { get; set; }
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
