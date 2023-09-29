using AnimeCheck.Model;
using System.ComponentModel;

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
            if (parameter is TitlePart titlePart)
            {
                titlePart.Status = Status.Viewed;
                TitleRepo.SwichStatus(titlePart, Status.Viewed);
            }
            items.Refresh();
        }
    }
}
