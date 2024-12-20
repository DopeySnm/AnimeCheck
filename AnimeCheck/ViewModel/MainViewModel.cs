﻿using AnimeCheck.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using AnimeCheck.Model;

namespace AnimeCheck.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private Page Home = new HomePage();
        private Page WillWatchAnime = new WillWatchAnimePage();
        private Page WatchingNowAnime = new WatchingNowAnimePage();
        private Page Viewed = new ViewedPage();
        private Page AddAnime = new AddAnimePage();
        private Page _CurPage = new HomePage();
        
        public Page CurPage
        {
            get { return _CurPage; }
            set { Set(ref _CurPage, value); }
        }
        public ICommand OpenHome
        {
            get
            {
                return new RelayCommand(() => CurPage = Home);
            }
        }
        public ICommand OpenWillWatchAnimePage
        {
            get
            {
                return new RelayCommand(() => CurPage = WillWatchAnime);
            }
        }
        public ICommand OpenWatchingNowAnime
        {
            get
            {
                return new RelayCommand(() => CurPage = WatchingNowAnime);
            }
        }
        public ICommand OpenViewed
        {
            get
            {
                return new RelayCommand(() => CurPage = Viewed);
            }
        }
        public ICommand OpenAddAnime
        {
            get
            {
                return new RelayCommand(() => CurPage = AddAnime);
            }
        }
    }
}
