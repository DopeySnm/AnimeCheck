using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace AnimeCheck
{
    public static class DataProcessing
    {
        public static List<Title> TitleList = new List<Title>();

        public static void ReadFile()
        {
            var dateFromFile = File.ReadAllText(@"..\..\Titles.json");
            TitleList = !string.IsNullOrEmpty(dateFromFile)
                ? JsonConvert.DeserializeObject<Title[]>(dateFromFile).ToList()
                : null;
        }

        public static void WriteFile()
        {
            File.WriteAllText(@"..\..\Titles.json", JsonConvert.SerializeObject(TitleList));
        }
    }
}