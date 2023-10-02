using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnimeCheck.Model
{
    public class Title
    {
        [JsonProperty] public int ID { get; private set; }

        [JsonProperty] public string Name { get; private set; }

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
            ID = id;
            Name = name;
            _favorite = false;
            _titleParts = new List<TitlePart>();
        }

        public List<TitlePart> GetTitleParts()
        {
            return _titleParts;
        }

        public void Like()
        {
            _favorite = !_favorite;
        }

        public void AddPart(TitlePart part)
        {
            _titleParts.Add(part);
        }

        public void RemovePart(TitlePart part)
        {
            _titleParts.Remove(part);
        }
    }
}