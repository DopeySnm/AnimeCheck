using System.Collections.Generic;

namespace AnimeCheck
{
    public class FindAnime
    {
        public List<Title> Run(string str)
        {
            List<Title> resList = new List<Title>();
            foreach (var title in DataProcessing.TitleList)
            {
                if (title.Name.ToLower().Contains(str.ToLower())) resList.Add(title);
            }

            return resList;
        }
    }
}