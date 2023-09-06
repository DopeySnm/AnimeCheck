using System;

namespace AnimeCheck.Model
{
    public class TitlePart
    {
        private int _id;
        private int _titleId;
        public string Name {get; set;}
        private int _episodesCount;
        private TimeSpan _episodeDuration;
        private Status _status;
        protected TitlePart(int titleId, string name, int episodesCount, TimeSpan episodeDuration, Status status, int id)
        {
            _titleId = titleId;
            Name = name;
            _episodesCount = episodesCount;
            _episodeDuration = episodeDuration;
            _status = status;
            _id = id;
        }
    }
}