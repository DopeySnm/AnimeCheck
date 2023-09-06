using System.Collections.Generic;
using System.Linq;
using AnimeCheck.Model;


namespace AnimeCheck
{
    public class FindAnime
    {
        public List<Title> Run(string str)
        {
            return DataProcessing.TitleList.Where(title => title.Name.ToLower().Contains(str.ToLower())).ToList();
        }
    }
}