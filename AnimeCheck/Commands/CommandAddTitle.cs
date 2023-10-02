using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Windows;

namespace AnimeCheck.Commands
{
    public class CommandAddTitle : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is AdditionViewModel viewModel)
            {
                viewModel.AddMode = false;
                //viewModel.VisibilityAddTitlePart = Visibility.Visible;
                if (!viewModel.NewNameTitle.Equals(""))
                {
                    var id = 1;
                    //todo Доделать генератор айдишников
                    var name = viewModel.NewNameTitle;
                    Title title = new Title(id, name);
                    TitleRepo.AddTitle(title);
                    viewModel.Title.Refresh();
                }
            }
        }
    }
}
