using System.Collections.Generic;

namespace AnimeCheck.Model
{
    public class Title
    {
        private int _id;
        public string Name{ get; set;}
        private bool _favorite;
        public Title(string name)
        {
            Name = name;
            _favorite = false;
        }
    }
}