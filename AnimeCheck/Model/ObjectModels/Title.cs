using System.Collections.Generic;

namespace AnimeCheck.Model
{
    public class Title
    {
        private int _id;
        public string Name{ get; set;}
        private bool _favorite;

        public List<TitlePart> TitleParts { get; set; }
        public Title(int id, string name)
        {
            _id = id;
            Name = name;
            _favorite = false;
            TitleParts = new List<TitlePart>();
        }
    }
}