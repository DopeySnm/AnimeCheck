using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeCheck.Commands
{
    public class CommandOpenExpander : CommandBase
    {
        private ICollectionView items;
        public CommandOpenExpander(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            if (parameter is bool expanded)
            {
                parameter = (bool)parameter;
            }
            //todo MultiBinding
            //todo сделать удаление из репозитория
            //ViewedViewModel.SelectedAnime = null;
            items.Refresh();
        }
    }
}
