

using AnimeCheck.ViewModel;

namespace AnimeCheck.Commands
{
    public class CommandExpandedAddTitlePart : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is AdditionViewModel viewModel)
            {
                viewModel.IsExpandedAddTitlePart = !viewModel.IsExpandedAddTitlePart;
            }
        }
    }
}
