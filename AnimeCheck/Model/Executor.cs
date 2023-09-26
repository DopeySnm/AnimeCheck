using System.Collections.Generic;


namespace AnimeCheck.Model
{
    public interface Executor
    {
        List<Title> GetTitles();
        void SaveTitles(List<Title> titles);
    }

}