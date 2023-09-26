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
    public class CommandDeleteAnime : CommandBase
    {
        private ICollectionView items;
        public CommandDeleteAnime(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            //todo MultiBinding
            //todo сделать удаление из репозитория
            items.Refresh();
        }
    }
}
