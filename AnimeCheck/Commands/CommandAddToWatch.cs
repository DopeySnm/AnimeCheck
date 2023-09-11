using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeCheck.Commands
{
    public class CommandAddToWatch : CommandBase
    {
        private ICollectionView items;

        public CommandAddToWatch(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {

            items.Refresh();
        }
    }
}
