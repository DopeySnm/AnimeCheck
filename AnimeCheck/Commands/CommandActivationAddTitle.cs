using AnimeCheck.ViewModel;
using System.Windows;

namespace AnimeCheck.Commands
{
    public class CommandActivationAddTitle : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is AdditionViewModel viewModel)
            {
                //viewModel.VisibilityAddTitlePart = Visibility.Hidden;
                viewModel.AddMode = true;
                viewModel.NewNameTitle = "";
                viewModel.SelectedTitle = null;
                viewModel.SelectedParts = null;
                viewModel.TitleParts = null;
            }
        }
    }
}
