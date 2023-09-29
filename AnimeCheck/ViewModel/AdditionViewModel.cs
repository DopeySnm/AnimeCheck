using AnimeCheck.Model;
using System.Collections.Generic;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows;
using AnimeCheck.Commands;
using System;

namespace AnimeCheck.ViewModel
{
    public class AdditionViewModel : ViewModelBase
    {
        public ICommand ExpandedCommand { get { return new RelayCommand(() => IsExpanded = !IsExpanded); } }

        public ICommand ActivationAddTitleCommand { get; }

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

        public Visibility visibilityButtonAddTitle;
        public Visibility VisibilityButtonAddTitle
        {
            get { return visibilityButtonAddTitle; }
            set { Set(ref visibilityButtonAddTitle, value); }
        }

        public Visibility visibilityAddTitlePart;
        public Visibility VisibilityAddTitlePart
        {
            get { return visibilityAddTitlePart; }
            set { Set(ref visibilityAddTitlePart, value); }
        }

        public bool isEnabledNewNameTitle;
        public bool IsEnabledNewNameTitle
        {
            get { return isEnabledNewNameTitle; }
            set { Set(ref isEnabledNewNameTitle, value); }
        }

        private bool isExpanded;
        public bool IsExpanded
        {
            get { return isExpanded; }
            set { Set(ref isExpanded, value); }
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
            VisibilityButtonAddTitle = Visibility.Hidden;
            VisibilityAddTitlePart = Visibility.Visible;
            AddTitleCommand = new CommandAddTitle();
            ActivationAddTitleCommand = new CommandActivationAddTitle();
            AddTitlePartCommand = new CommandAddTitlePart();
        }
    }
}
