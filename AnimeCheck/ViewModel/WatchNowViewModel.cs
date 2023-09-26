using System;
using System.Collections.Generic;
using AnimeCheck.Model;

namespace AnimeCheck.ViewModel
{
    public class WatchNowViewModel : ViewModelBase
    {

        public List<Title> Titles
        {
            get { return TitleRepo.GetWithWatch(); }
        }

        
        public WatchNowViewModel() {}
    }
}