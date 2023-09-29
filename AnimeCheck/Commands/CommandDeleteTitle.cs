using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace AnimeCheck.Commands
{
    public class CommandDeleteTitle : CommandBase
    {
        private ICollectionView items;
        public CommandDeleteTitle(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            if (parameter is Title title)
            {
                TitleRepo.DeleteTitle(title);
                List<Title> titles = TitleRepo.Ttitles;
                items = CollectionViewSource.GetDefaultView(titles);
                items.Refresh();
            }
        }
    }
}
