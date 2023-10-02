using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace AnimeCheck.Commands
{
    public class CommandDeleteTitlePart : CommandBase
    {
        private ICollectionView items;
        public CommandDeleteTitlePart(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            if (parameter is AdditionViewModel viewModel)
            {
                if (viewModel.SelectedParts != null)
                {
                    TitleRepo.DeletePart(viewModel.SelectedParts);
                    List<TitlePart> titles = viewModel.SelectedTitle.GetTitleParts();
                    items = CollectionViewSource.GetDefaultView(titles);
                    items.Refresh();
                }
            }
        }
    }
}
