using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                TitleRepo.DeletePart(viewModel.SelectedSeason);
                List<TitlePart> titles = viewModel.SelectedAnime.GetTitleParts();
                items = CollectionViewSource.GetDefaultView(titles);
                items.Refresh();
            }
        }
    }
}
