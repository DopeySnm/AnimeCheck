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
    public class CommandAddTitlePart : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (parameter is AdditionViewModel viewModel)
            {
                if (viewModel.NewNameTitlePart.Equals("")) return;
                if (viewModel.SelectedAnime == null) return;
                viewModel.IsExpanded = false;
                var id = 1;
                //todo Доделать генератор айдишников
                var idTitle = viewModel.SelectedAnime.ID;
                var name = viewModel.NewNameTitlePart;
                var episodesCount = viewModel.NewEpisodesCount;
                var episodeDuration = viewModel.EpisodeDuration;
                var status = viewModel.Status; 
                TitlePart titlePart = new TitlePart(id, idTitle, name, episodesCount, episodeDuration, status);
                TitleRepo.AddPart(titlePart);
                viewModel.TitleParts.Refresh();
            }
        }
    }
}
