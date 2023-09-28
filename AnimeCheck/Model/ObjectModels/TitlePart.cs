using System;
using Newtonsoft.Json;

namespace AnimeCheck.Model
{
    public class TitlePart
    {
        [JsonProperty] public int ID { get; private set; }

        [JsonProperty] public int TitleId { get; private set; }

        [JsonProperty] public string Name { get; private set; }

        [JsonProperty] public int EpisodesCount { get; private set; }

        [JsonProperty] public TimeSpan EpisodeDuration { get; private set; }

        [JsonProperty] public Status Status;

        public TitlePart(){}

        public TitlePart(int id, int titleId, string name)
        {
            TitleId = titleId;
            Name = name;
            ID = id;
        }

        public TitlePart(int id, int titleId, string name, int episodesCount, TimeSpan episodeDuration, Status status)
        {
            ID = id;
            TitleId = titleId;
            Name = name;
            EpisodesCount = episodesCount;
            EpisodeDuration = episodeDuration;
            Status = status;
        }

    }
}