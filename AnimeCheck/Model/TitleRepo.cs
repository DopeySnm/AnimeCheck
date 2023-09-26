using System.Collections.Generic;

namespace AnimeCheck.Model
{
    public static class TitleRepo
    {
        private static Executor _executor = new FileExecutor();
        public static List<Title> Ttitles = _executor.GetTitles();
        
        public static List<Title> GetWithViewed()
        {
            return Ttitles.FindAll(title => title.Viewed.Count > 0);
        }
        public static List<Title> GetWithWatch()
        {
            return Ttitles.FindAll(title => title.Watch.Count > 0);;
        }
        public static List<Title> GetWithPlanned()
        {
            return Ttitles.FindAll(title => title.Planned.Count > 0);;
        }

        public static void AddTitle(Title title)
        {
            Ttitles.Add(title);
            _executor.SaveTitles(Ttitles);
        }
    }
}