﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeCheck.Commands
{
    public class CommandAddToPlanned : CommandBase
    {
        private ICollectionView items;

        public CommandAddToPlanned(ICollectionView items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            
        }
    }
}
