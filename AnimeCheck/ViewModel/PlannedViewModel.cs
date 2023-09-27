using AnimeCheck.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace AnimeCheck.ViewModel
{
    public class PlannedViewModel : ViewModelBase
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

        public PlannedViewModel()
        {
            List<Title> titles = TitleRepo.GetWithPlanned();
            Titles = CollectionViewSource.GetDefaultView(titles);
        }
    }
}
