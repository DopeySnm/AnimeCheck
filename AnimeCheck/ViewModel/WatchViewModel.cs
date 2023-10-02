using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using AnimeCheck.Commands;
using AnimeCheck.Model;
using AnimeCheck.Service;

namespace AnimeCheck.ViewModel
{
    public class WatchViewModel : ViewModelBase
    {
        private string filterText;
        private ICollectionView titles;
        public Title selectedTitle;
        public TitlePart selectedPart;

        public ICommand AddToPlannedCommand { get; }

        public ICommand AddToViewedCommand { get; }

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

        public WatchViewModel() 
        {
            List<Title> titles = TitleRepo.GetWithWatch();
            Titles = CollectionViewSource.GetDefaultView(titles);
            Titles.Filter = FilterNameAnime;
            AddToPlannedCommand = new CommandAddToPlanned();
            AddToViewedCommand = new CommandAddToViewed();
            LikeCommand = new CommandLike();
        }

        private bool FilterNameAnime(object obj)
        {
            FilterHelper filterHelper = new FilterHelper();
            return filterHelper.FilterSearch(obj, FilterText);
        }
    }
}