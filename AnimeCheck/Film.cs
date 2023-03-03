using System;

namespace AnimeCheck
{
    public class Film : TitlePart
    {
        TimeSpan FilmDuration;

        public Film(string name, TimeSpan filmDuration) : base(name)
        {
            FilmDuration = filmDuration;
        }

    }
}