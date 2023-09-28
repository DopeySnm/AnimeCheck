using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AnimeCheck.Model
{
    public class FileExecutor : Executor
    {
        public List<Title> GetData()
        {
            
            if(!File.Exists("titles.json"))
            {
                using (File.Create("titles.json"))
                {
                }
            }
            String json = File.ReadAllText("titles.json");
            return JsonConvert.DeserializeObject<List<Title>>(json)?? new List<Title>();
        }

        public void SaveData(List<Title> titles)
        {
            String json = JsonConvert.SerializeObject(titles, Formatting.Indented);
            File.WriteAllText("titles.json",json);
        }
    }
}