using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace AnimeCheck.Commands
{
    internal class CommandAddToViewed : CommandBase
    {
        private ICollectionView items;

        public CommandAddToViewed(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            if (parameter is ViewedViewModel viewedViewModel)
            {
                TitleRepo.SwichStatus(viewedViewModel.SelectedSeason, Status.Viewed);
                List<Title> titles = TitleRepo.GetWithViewed();
                viewedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                viewedViewModel.Titles.Refresh();
            }
            if (parameter is WatchViewModel watchViewModel)
            {
                TitleRepo.SwichStatus(watchViewModel.SelectedSeason, Status.Viewed);
                List<Title> titles = TitleRepo.GetWithWatch();
                watchViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                watchViewModel.Titles.Refresh();
            }
            if (parameter is PlannedViewModel plannedViewModel)
            {
                TitleRepo.SwichStatus(plannedViewModel.SelectedSeason, Status.Viewed);
                List<Title> titles = TitleRepo.GetWithPlanned();
                plannedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                plannedViewModel.Titles.Refresh();
            }
            //if (parameter is TitlePart titlePart)
            //{
            //    titlePart.Status = Status.Viewed;
            //    TitleRepo.SwichStatus(titlePart, Status.Viewed);
            //}
            //items.Refresh();
        }
    }
}
