using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Collections.Generic;
using System.Windows.Data;

namespace AnimeCheck.Commands
{
    public class CommandAddToPlanned : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is ViewedViewModel viewedViewModel)
            {
                if (viewedViewModel.SelectedPart != null)
                {
                    TitleRepo.SwichStatus(viewedViewModel.SelectedPart, Status.Planned);
                    List<Title> titles = TitleRepo.GetWithViewed();
                    viewedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    viewedViewModel.Titles.Refresh();
                }
            }
            if (parameter is WatchViewModel watchViewModel)
            {
                if (watchViewModel.SelectedPart != null)
                {
                    TitleRepo.SwichStatus(watchViewModel.SelectedPart, Status.Planned);
                    List<Title> titles = TitleRepo.GetWithWatch();
                    watchViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    watchViewModel.Titles.Refresh();
                }
            }
            if (parameter is PlannedViewModel plannedViewModel)
            {
                if (plannedViewModel.SelectedPart != null)
                {
                    TitleRepo.SwichStatus(plannedViewModel.SelectedPart, Status.Planned);
                    List<Title> titles = TitleRepo.GetWithPlanned();
                    plannedViewModel.Titles = CollectionViewSource.GetDefaultView(titles);
                    plannedViewModel.Titles.Refresh();
                }
            }
        }
    }
}
