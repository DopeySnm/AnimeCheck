using AnimeCheck.model;
using AnimeCheck.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeCheck.Commands
{
    internal class CommandDeleteAnime : CommandBase
    {
        private ICollectionView items;

        public CommandDeleteAnime(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            Anime.StaticAnime.Remove(AnimeViewModel.SelectedAnime);
            AnimeViewModel.SelectedAnime = null;
            items.Refresh();
        }
    }
}
