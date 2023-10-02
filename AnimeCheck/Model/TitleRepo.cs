using System.Collections.Generic;

namespace AnimeCheck.Model
{
    public static class TitleRepo
    {
        private static Executor _executor = new FileExecutor();
        public static List<Title> Ttitles = _executor.GetData();
        
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
            _executor.SaveData(Ttitles);
        }
        public static void DeleteTitle(Title title)
        {
            Ttitles.Remove(title);
            _executor.SaveData(Ttitles);
        }

        public static void AddPart(TitlePart part)
        {
            Ttitles.Find(title => title.ID == part.TitleId).AddPart(part);
            _executor.SaveData(Ttitles);
        }

        public static void DeletePart(TitlePart part)
        {
            Ttitles.Find(title => title.ID == part.TitleId).RemovePart(part);
            _executor.SaveData(Ttitles);
        }

        public static void SwichStatus(TitlePart part, Status status)
        {
            part.Status = status;
            _executor.SaveData(Ttitles);
        }

        public static void Like(Title title)
        {
            title.Like();
            _executor.SaveData(Ttitles);
        }
    }
}