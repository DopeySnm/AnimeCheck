using System;

namespace AnimeCheck
{
    public class Season : TitlePart
    { 
        int NumberEpisodes;
        TimeSpan EpisodeDuration = new TimeSpan(0, 24, 0);

        public Season(string name, int numberEpisodes) : base(name)
        {
            NumberEpisodes = numberEpisodes;
        }

        public Season(string name, int numberEpisodes, TimeSpan episodeDuration) : base(name)
        {
            NumberEpisodes = numberEpisodes;
            EpisodeDuration = episodeDuration;
        }
    }
}