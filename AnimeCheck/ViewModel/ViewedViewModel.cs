using AnimeCheck.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using AnimeCheck.Commands;

namespace AnimeCheck.ViewModel
{
    public class ViewedViewModel : ViewModelBase
    {
        public ICommand DeleteAnimeCommand { get; }

        public ICommand AddToPlannedCommand { get; }

        public ICommand AddToWatchCommand { get; }

        public ICommand LikeCommand { get; }

        private string filterText;
        public string FilterText
        {
            get { return filterText; }
            set 
            { 
                Set(ref filterText, value);
                Titles.Filter = null;
                Titles.Filter = FilterNameAnime;
            }
        }

        private ICollectionView titles;
        public ICollectionView Titles
        {
            get { return titles; }
            set { Set(ref titles, value); }
        }

        public Title selectedAnime;
        public Title SelectedAnime 
        {
            get { return selectedAnime;}
            set { Set(ref selectedAnime, value); }
        }

        public TitlePart selectedSeason;
        public TitlePart SelectedSeason
        {
            get { return selectedSeason; }
            set { Set(ref selectedSeason, value); }
        }
        
        public ViewedViewModel()
        {
            //todo получаеть запоминаемый текст в поиске
            String storingValueInSearchString = "";
            //todo получать лист просмотренных аниме
            List<Title> anime = TitleRepo.GetWithViewed();

            Titles = CollectionViewSource.GetDefaultView(anime);
            Titles.Filter = FilterNameAnime;
            DeleteAnimeCommand = new CommandDeleteAnime(Titles);
            AddToPlannedCommand = new CommandAddToPlanned(Titles);
            AddToWatchCommand = new CommandAddToWatch(Titles);
            LikeCommand = new CommandLike(Titles);
            FilterText = storingValueInSearchString;
        }

        private bool FilterNameAnime(object obj)
        {
            bool result = true;
            Title current = obj as Title;
            if (!string.IsNullOrWhiteSpace(FilterText) && current != null && !ContainsCaseInsensitive(current.Name, FilterText))
            {
                result = false;
            }
            //todo устанавливать запоминаемый текст в поиске
            return result;
        }

        private bool ContainsCaseInsensitive(string source, string substring)
        {
            return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }
}
