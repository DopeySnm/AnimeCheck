using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using AnimeCheck.Commands;
using AnimeCheck.Model;

namespace AnimeCheck.ViewModel
{
    public class WatchViewModel : ViewModelBase
    {
        public ICommand AddToPlannedCommand { get; }

        public ICommand AddToViewedCommand { get; }

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

        public WatchViewModel() 
        {
            List<Title> titles = TitleRepo.GetWithWatch();
            Titles = CollectionViewSource.GetDefaultView(titles);
            AddToPlannedCommand = new CommandAddToPlanned(Titles);
            AddToViewedCommand = new CommandAddToViewed(Titles);
            LikeCommand = new CommandLike(Titles);
        }
    }
}