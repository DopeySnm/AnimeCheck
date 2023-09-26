using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnimeCheck.Model
{
    public class Title
    {
        [JsonProperty] private int _id;

        [JsonProperty] public string Name { get; set; }

        [JsonProperty] private bool _favorite;

        [JsonProperty] private List<TitlePart> _titleParts;

        [JsonIgnore]
        public List<TitlePart> Viewed
        {
            get { return _titleParts.FindAll(part => part.Status == Status.Viewed); }
        }

        [JsonIgnore]
        public List<TitlePart> Watch
        {
            get { return _titleParts.FindAll(part => part.Status == Status.Watch); }
        }

        [JsonIgnore]
        public List<TitlePart> Planned
        {
            get { return _titleParts.FindAll(part => part.Status == Status.Planned); }
        }

        public Title()
        {
        }

        public Title(int id, string name)
        {
            _id = id;
            Name = name;
            _favorite = false;
            _titleParts = new List<TitlePart>();
        }

        public Title(int id, string name, List<TitlePart> parts)
        {
            _id = id;
            Name = name;
            _favorite = false;
            _titleParts = parts;
        }

        public void Like()
        {
            _favorite = !_favorite;
        }

        public void AddPart(TitlePart part)
        {
            _titleParts.Add(part);
        }
    }
}