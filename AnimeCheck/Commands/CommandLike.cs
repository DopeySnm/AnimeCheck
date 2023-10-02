using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Collections.Generic;
using System.Windows.Data;

namespace AnimeCheck.Commands
{
    public class CommandLike : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is ViewedViewModel viewedViewModel)
            {
                if (viewedViewModel.SelectedTitle != null)
                {
                    TitleRepo.Like(viewedViewModel.SelectedTitle);
                    List<Title> titles = TitleRepo.GetWithViewed();
                    viewedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    viewedViewModel.Titles.Refresh();
                }
            }
            if (parameter is WatchViewModel watchViewModel)
            {
                if (watchViewModel.SelectedTitle != null)
                {
                    TitleRepo.Like(watchViewModel.SelectedTitle);
                    List<Title> titles = TitleRepo.GetWithWatch();
                    watchViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    watchViewModel.Titles.Refresh();
                }
            }
            if (parameter is PlannedViewModel plannedViewModel)
            {
                if (plannedViewModel.SelectedTitle != null)
                {
                    TitleRepo.Like(plannedViewModel.SelectedTitle);
                    List<Title> titles = TitleRepo.GetWithPlanned();
                    plannedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    plannedViewModel.Titles.Refresh();
                }
            }
        }
    }
}
