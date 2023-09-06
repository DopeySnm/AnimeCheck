using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeCheck.model
{
    internal class Anime
    {
        public int id { get; set; }

        public string Name { get; set; }

        public List<Season1> Seasons { get; set; }

        public Anime()
        {
            Seasons = new List<Season1>();
        }

        public static List<Anime> StaticAnime;

        public static List<Anime> GetAnime()
        {
            StaticAnime = new List<Anime>()
            {
                new Anime
                {
                    id = 1,
                    Name = "Атака Титанов",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title = "1 Сезон" },
                        new Season1 {Title = "2 Сезон" }
                    }
                },
                new Anime
                {
                    id = 2,
                    Name = "Убийца Акаме",
                    Seasons = new List<Season1>
                    {
                        new Season1 { Title="1 сезон" }
                    }
                },
                new Anime
                {
                    id = 3,
                    Name="Берсерк",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title="Сериал 1997" },
                        new Season1 {Title="Берсер 2016(ну т.е. хуйня ебаная ненужная уёбищная)" }
                    }
                },
                new Anime
                {
                    id = 4,
                    Name = "Атака Титанов",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title = "1 Сезон" },
                        new Season1 {Title = "2 Сезон" }
                    }
                },
                new Anime
                {
                    id = 5,
                    Name = "Убийца Акаме",
                    Seasons = new List<Season1>
                    {
                        new Season1 { Title="1 сезон" }
                    }
                },
                new Anime
                {
                    id = 6,
                    Name="Берсерк",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title="Сериал 1997" },
                        new Season1 {Title="Берсер 2016(ну т.е. хуйня ебаная ненужная уёбищная)" }
                    }
                },
                new Anime
                {
                    id = 7,
                    Name = "Атака Титанов",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title = "1 Сезон" },
                        new Season1 {Title = "2 Сезон" }
                    }
                },
                new Anime
                {
                    id = 8,
                    Name = "Убийца Акаме",
                    Seasons = new List<Season1>
                    {
                        new Season1 { Title="1 сезон" }
                    }
                },
                new Anime
                {
                    id = 9,
                    Name="Берсерк",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title="Сериал 1997" },
                        new Season1 {Title="Берсер 2016(ну т.е. хуйня ебаная ненужная уёбищная)" }
                    }
                }
                ,new Anime
                {
                    id = 10,
                    Name = "Атака Титанов",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title = "1 Сезон" },
                        new Season1 {Title = "2 Сезон" }
                    }
                },
                new Anime
                {
                    id = 11,
                    Name = "Убийца Акаме",
                    Seasons = new List<Season1>
                    {
                        new Season1 { Title="1 сезон" }
                    }
                },
                new Anime
                {
                    id = 12,
                    Name="Берсерк",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title="Сериал 1997" },
                        new Season1 {Title="Берсер 2016(ну т.е. хуйня ебаная ненужная уёбищная)" }
                    }
                },
                new Anime
                {
                    id = 13,
                    Name = "Атака Титанов",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title = "1 Сезон" },
                        new Season1 {Title = "2 Сезон" }
                    }
                },
                new Anime
                {
                    id = 14,
                    Name = "Убийца Акаме",
                    Seasons = new List<Season1>
                    {
                        new Season1 { Title="1 сезон" }
                    }
                },
                new Anime
                {
                    id = 15,
                    Name="Берсерк",
                    Seasons = new List<Season1>
                    {
                        new Season1 {Title="Сериал 1997" },
                        new Season1 {Title="Берсер 2016(ну т.е. хуйня ебаная ненужная уёбищная)" }
                    }
                }
            };
            return StaticAnime;
        }
    }
}
