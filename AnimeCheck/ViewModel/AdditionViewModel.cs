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
        public ICommand ExpandedAddTitlePartCommand { get; }

        public ICommand ActivationAddTitleCommand { get; }

        public ICommand DeleteTitleCommand { get; }

        public ICommand DeleteTitlePartCommand { get; }

        public ICommand AddTitleCommand { get; }

        public ICommand AddTitlePartCommand { get; }

        private ICollectionView titleParts;
        public ICollectionView TitleParts
        {
            get { return titleParts; }
            set { Set(ref titleParts, value); }
        }

        private ICollectionView title;
        public ICollectionView Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        public Title selectedTitle;
        public Title SelectedTitle
        {
            get { return selectedTitle; }
            set { Set(ref selectedTitle, value); }
        }

        public TitlePart selectedParts;
        public TitlePart SelectedParts
        {
            get { return selectedParts; }
            set { Set(ref selectedParts, value); }
        }

        private bool addMode;
        public bool AddMode
        {
            get { return addMode; }
            set { Set(ref addMode, value); }
        }

        private bool isExpandedAddTitlePart;
        public bool IsExpandedAddTitlePart
        {
            get { return isExpandedAddTitlePart; }
            set { Set(ref isExpandedAddTitlePart, value); }
        }

        private string newNameTitle;
        public string NewNameTitle
        {
            get { return newNameTitle; }
            set { Set(ref newNameTitle, value); }
        }

        private string newNameTitlePart;
        public string NewNameTitlePart
        {
            get { return newNameTitlePart; }
            set { Set(ref newNameTitlePart, value); }
        }

        private TimeSpan episodeDuration;
        public TimeSpan EpisodeDuration
        {
            get { return episodeDuration; }
            set { Set(ref episodeDuration, value); }
        }

        private int newEpisodesCount;
        public int NewEpisodesCount
        {
            get { return newEpisodesCount; }
            set { Set(ref newEpisodesCount, value); }
        }

        private Status status;
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
