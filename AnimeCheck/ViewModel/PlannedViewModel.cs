using AnimeCheck.Commands;
using AnimeCheck.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;

namespace AnimeCheck.ViewModel
{
    public class PlannedViewModel : ViewModelBase
    {
        public ICommand AddToViewedCommand { get; }

        public ICommand AddToWatchCommand { get; }

        public ICommand LikeCommand { get; }

        private ICollectionView titles;
        public ICollectionView Titles
        {
            get { return titles; }
            set
            {
                Set(ref titles, value);
            }
        }

        public Title selectedAnime;
        public Title SelectedAnime
        {
            get { return selectedAnime; }
            set { Set(ref selectedAnime, value); }
        }

        public TitlePart selectedSeason;
        public TitlePart SelectedSeason
        {
            get { return selectedSeason; }
            set { Set(ref selectedSeason, value); }
        }

        public PlannedViewModel()
        {
            List<Title> titles = TitleRepo.GetWithPlanned();
            Titles = CollectionViewSource.GetDefaultView(titles);
            AddToViewedCommand = new CommandAddToViewed(Titles);
            AddToWatchCommand = new CommandAddToWatch(Titles);
            LikeCommand = new CommandLike(Titles);
        }
    }
}
