using AnimeCheck.Model;
using System.ComponentModel;

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
            if (parameter is Title title)
            {
                title.Like();
            }
            items.Refresh();
        }
    }
}
