using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using AnimeCheck.Model;

namespace AnimeCheck.ViewModel
{
    public class WatchViewModel : ViewModelBase
    {

        private ICollectionView titles;
        public ICollectionView Titles
        {
            get { return titles; }
            set 
            { 
                Set(ref titles, value);
            }
        }

        public WatchViewModel() 
        {
            List<Title> titles = TitleRepo.GetWithWatch();
            Titles = CollectionViewSource.GetDefaultView(titles);
        }
    }
}