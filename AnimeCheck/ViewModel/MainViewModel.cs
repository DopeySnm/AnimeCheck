using AnimeCheck.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using AnimeCheck.Model;
using System.Windows.Data;

namespace AnimeCheck.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private Page Home;
        private Page Planned;
        private Page Watch;
        private Page Viewed;
        private Page AddAnime;
        private Page _CurPage;
        
        public Page CurPage
        {
            get { return _CurPage; }
            set 
            {
                Set(ref _CurPage, value);
                UpdateTitles(_CurPage);
            }
        }
        public ICommand OpenHome
        {
            get
            {
                return new RelayCommand(() => CurPage = Home);
            }
        }
        public ICommand OpenPlanned
        {
            get
            {
                return new RelayCommand(() => CurPage = Planned);
            }
        }
        public ICommand OpenWatch
        {
            get
            {
                return new RelayCommand(() => CurPage = Watch);
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

        public MainViewModel()
        {
            Home = new HomePage();
            Planned = new PlannedPage();
            Watch = new WatchPage();
            Viewed = new ViewedPage();
            AddAnime = new AddAnimePage();
            _CurPage = new HomePage();
        }

        public void UpdateTitles(Page curPage)
        {
            if (_CurPage.DataContext is ViewedViewModel viewedViewModel)
            {
                viewedViewModel.Titles.Refresh();
            }
            if (_CurPage.DataContext is WatchViewModel watchViewModel)
            {
                watchViewModel.Titles.Refresh();
            }
            //if (_CurPage.DataContext is WatchNowViewModel viewModel)
            //{
            //    viewModel.Titles.Refresh();
            //}
        }
    }
}
