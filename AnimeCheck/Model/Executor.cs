using System.Collections.Generic;


namespace AnimeCheck.Model
{
    public interface Executor
    {
        List<Title> GetData();
        void SaveData(List<Title> titles);
    }

}