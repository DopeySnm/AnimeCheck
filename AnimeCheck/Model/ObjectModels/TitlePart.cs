using System;
using Newtonsoft.Json;

namespace AnimeCheck.Model
{
    public class TitlePart
    {
        [JsonProperty] private int _id;

        [JsonProperty] private int _titleId;

        [JsonProperty] public string Name { get; set; }

        [JsonProperty] private int _episodesCount;

        [JsonProperty] private TimeSpan _episodeDuration;

        [JsonProperty] public Status Status;

        public TitlePart()
        {
        }

        public TitlePart(int id, int titleId, string name)
        {
            _titleId = titleId;
            Name = name;
            _id = id;
        }

        public TitlePart(int id, int titleId, string name, int episodesCount, TimeSpan episodeDuration, Status status)
        {
            _id = id;
            _titleId = titleId;
            Name = name;
            _episodesCount = episodesCount;
            _episodeDuration = episodeDuration;
            Status = status;

        }
    }
}