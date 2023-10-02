using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace AnimeCheck.Commands
{
    public class CommandLike : CommandBase
    {
        private ICollectionView items;

        public CommandLike(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            if (parameter is ViewedViewModel viewedViewModel)
            {
                if (viewedViewModel.SelectedAnime != null)
                {
                    TitleRepo.Like(viewedViewModel.SelectedAnime);
                    List<Title> titles = TitleRepo.GetWithViewed();
                    viewedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    viewedViewModel.Titles.Refresh();
                }
            }
            if (parameter is WatchViewModel watchViewModel)
            {
                if (watchViewModel.SelectedAnime != null)
                {
                    TitleRepo.Like(watchViewModel.SelectedAnime);
                    List<Title> titles = TitleRepo.GetWithWatch();
                    watchViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    watchViewModel.Titles.Refresh();
                }
            }
            if (parameter is PlannedViewModel plannedViewModel)
            {
                if (plannedViewModel.SelectedAnime != null)
                {
                    TitleRepo.Like(plannedViewModel.SelectedAnime);
                    List<Title> titles = TitleRepo.GetWithPlanned();
                    plannedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    plannedViewModel.Titles.Refresh();
                }
            }
            //if (parameter is Title title)
            //{
            //    TitleRepo.Like(title);
            //}
            //items.Refresh();
        }
    }
}
