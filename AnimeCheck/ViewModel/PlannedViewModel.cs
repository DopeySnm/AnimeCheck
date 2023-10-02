using AnimeCheck.Commands;
using AnimeCheck.Model;
using AnimeCheck.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;

namespace AnimeCheck.ViewModel
{
    public class PlannedViewModel : ViewModelBase
    {
        private string filterText;
        private ICollectionView titles;
        public Title selectedTitle;
        public TitlePart selectedPart;

        public ICommand AddToViewedCommand { get; }

        public ICommand AddToWatchCommand { get; }

        public ICommand LikeCommand { get; }

        public string FilterText
        {
            get { return filterText; }
            set
            {
                Set(ref filterText, value);
                Titles.Filter = null;
                Titles.Filter = FilterNameAnime;
            }
        }

        public ICollectionView Titles
        {
            get { return titles; }
            set
            {
                Set(ref titles, value);
            }
        }
        
        public Title SelectedTitle
        {
            get { return selectedTitle; }
            set { Set(ref selectedTitle, value); }
        }
        
        public TitlePart SelectedPart
        {
            get { return selectedPart; }
            set { Set(ref selectedPart, value); }
        }

        public PlannedViewModel()
        {
            List<Title> titles = TitleRepo.GetWithPlanned();
            Titles = CollectionViewSource.GetDefaultView(titles);
            Titles.Filter = FilterNameAnime;
            AddToViewedCommand = new CommandAddToViewed();
            AddToWatchCommand = new CommandAddToWatch();
            LikeCommand = new CommandLike();
        }

        private bool FilterNameAnime(object obj)
        {
            FilterHelper filterHelper = new FilterHelper();
            return filterHelper.FilterSearch(obj, FilterText);
        }
    }
}
