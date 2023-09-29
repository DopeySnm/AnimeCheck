using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AnimeCheck.Commands
{
    public class CommandAddTitle : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is AdditionViewModel viewModel)
            {
                viewModel.VisibilityButtonAddTitle = Visibility.Hidden;
                viewModel.VisibilityAddTitlePart = Visibility.Visible;
                viewModel.IsEnabledNewNameTitle = false;
                if (!viewModel.NewNameTitle.Equals(""))
                {
                    Title title = new Title(1, viewModel.NewNameTitle);
                    TitleRepo.AddTitle(title);
                    viewModel.Title.Refresh();
                }
            }
            //TODO Add title
        }
    }
}
