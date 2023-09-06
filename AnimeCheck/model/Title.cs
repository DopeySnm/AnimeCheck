using System.Collections.Generic;

namespace AnimeCheck
{
    public class Title
    {
        public string Name{ get; set;}

        public List<TitlePart> WatchedParts { get; set;}
        public List<TitlePart> NowWatchingParts { get; set;}
        public List<TitlePart> WillWatchParts { get; set;}
        public bool Favourite;
        
        public bool Favorite;
        public Title(string name)
        {
            WatchedParts = new List<TitlePart>();
            NowWatchingParts = new List<TitlePart>();
            WillWatchParts = new List<TitlePart>();
            Name = name;
        }
        
        public static void MoveToWatched(Title title, TitlePart part)
        {
            if (!title.NowWatchingParts.Remove(part))
                title.WillWatchParts.Remove(part);
            title.WatchedParts.Add(part);
        }

        public static void MoveToNowWatching(Title title, TitlePart part)
        {
            if (!title.WillWatchParts.Remove(part))
                title.WatchedParts.Remove(part);
            title.NowWatchingParts.Add(part);
        }

        public static void MoveToWillWatch(Title title, TitlePart part)
        {
            if (!title.NowWatchingParts.Remove(part))
                title.WatchedParts.Remove(part);
            title.WillWatchParts.Add(part);
        }

    }
}