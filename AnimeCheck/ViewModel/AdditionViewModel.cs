using AnimeCheck.Model;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using AnimeCheck.Commands;
using System;

namespace AnimeCheck.ViewModel
{
    public class AdditionViewModel : ViewModelBase
    {
        private ICollectionView titleParts;
        private ICollectionView title;
        public Title selectedTitle;
        public TitlePart selectedParts;
        private bool addMode;
        private bool isExpandedAddTitlePart;
        private string newNameTitle;
        private string newNameTitlePart;
        private TimeSpan episodeDuration;
        private int newEpisodesCount;
        private Status status;

        public ICommand ExpandedAddTitlePartCommand { get; }

        public ICommand ActivationAddTitleCommand { get; }

        public ICommand DeleteTitleCommand { get; }

        public ICommand DeleteTitlePartCommand { get; }

        public ICommand AddTitleCommand { get; }

        public ICommand AddTitlePartCommand { get; }

        public ICollectionView TitleParts
        {
            get { return titleParts; }
            set { Set(ref titleParts, value); }
        }

        public ICollectionView Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        public Title SelectedTitle
        {
            get { return selectedTitle; }
            set { Set(ref selectedTitle, value); }
        }
       
        public TitlePart SelectedParts
        {
            get { return selectedParts; }
            set { Set(ref selectedParts, value); }
        }

        public bool AddMode
        {
            get { return addMode; }
            set { Set(ref addMode, value); }
        }

        public bool IsExpandedAddTitlePart
        {
            get { return isExpandedAddTitlePart; }
            set { Set(ref isExpandedAddTitlePart, value); }
        }

        public string NewNameTitle
        {
            get { return newNameTitle; }
            set { Set(ref newNameTitle, value); }
        }
        
        public string NewNameTitlePart
        {
            get { return newNameTitlePart; }
            set { Set(ref newNameTitlePart, value); }
        }
        
        public TimeSpan EpisodeDuration
        {
            get { return episodeDuration; }
            set { Set(ref episodeDuration, value); }
        }

        public int NewEpisodesCount
        {
            get { return newEpisodesCount; }
            set { Set(ref newEpisodesCount, value); }
        }

        public Status Status
        {
            get { return status; }
            set { Set(ref status, value); }
        }

        public AdditionViewModel()
        {
            Title = CollectionViewSource.GetDefaultView(TitleRepo.Ttitles);
            AddMode = false;
            AddTitleCommand = new CommandAddTitle();
            ActivationAddTitleCommand = new CommandActivationAddTitle();
            AddTitlePartCommand = new CommandAddTitlePart();
            ExpandedAddTitlePartCommand = new CommandExpandedAddTitlePart();
            DeleteTitleCommand = new CommandDeleteTitle(Title);
            DeleteTitlePartCommand = new CommandDeleteTitlePart(Title);
        }
    }
}
