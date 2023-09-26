using System.Collections.Generic;

namespace AnimeCheck.Model
{
    public class TitleRepo
    {
        private Executor _executor;
        private List<Title> _titles;

        public TitleRepo(Executor executor)
        {
            _executor = executor;
            _titles = _executor.GetTitles();
        }
    }
}