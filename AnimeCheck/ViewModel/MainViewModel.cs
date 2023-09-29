using AnimeCheck.View;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnimeCheck.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private Page Home;
        private Page Planned;
        private Page Watch;
        private Page Viewed;
        private Page Addition;
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
        public ICommand OpenAddition
        {
            get
            {
                return new RelayCommand(() => CurPage = Addition);
            }
        }

        public MainViewModel()
        {
            Home = new HomePage();
            Planned = new PlannedPage();
            Watch = new WatchPage();
            Viewed = new ViewedPage();
            Addition = new AdditionPage();
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
            if (_CurPage.DataContext is PlannedViewModel plannedViewModel)
            {
                plannedViewModel.Titles.Refresh();
            }
        }
    }
}
