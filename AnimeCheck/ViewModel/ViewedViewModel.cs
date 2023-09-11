using AnimeCheck.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using GalaSoft.MvvmLight.Command;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using AnimeCheck.Commands;
using System.Windows.Controls;

namespace AnimeCheck.ViewModel
{
    public class ViewedViewModel : ViewModelBase
    {
        public ICommand DeleteAnimeCommand { get; }

        private string filterText;
        public string FilterText
        {
            get { return filterText; }
            set 
            { 
                Set(ref filterText, value);
                Items.Filter = null;
                Items.Filter = FilterNameAnime;
            }
        }

        private ICollectionView items;
        public ICollectionView Items
        {
            get { return items; }
            set { Set(ref items, value); }
        }

        public static Title selectedAnime;
        public Title SelectedAnime 
        {
            get { return selectedAnime;}
            set { Set(ref selectedAnime, value); }
        }

        public static TitlePart SelectedSeason { get; set; }

        //todo потом удалить TestData
        private List<Title> TestData()
        {
            var title = new List<Title>()
            {
                new Title(1, "Наруто")
                {
                    TitleParts = new List<TitlePart>()
                    {
                        new TitlePart(1, 1, "1 Сезон"),
                        new TitlePart(2, 1, "2 Сезон")
                    }
                },
                new Title(2, "ДжоДжо") 
                { 
                    TitleParts = new List<TitlePart>()
                    {
                        new TitlePart(1, 2, "1 сезон"),
                        new TitlePart(2, 2, "2 сезон"),
                        new TitlePart(3, 2, "3 сезон"),
                        new TitlePart(4, 2, "4 сезон"),
                        new TitlePart(5, 2, "5 сезон"),
                        new TitlePart(6, 2, "6 сезон"),
                    }
                },
            };
            return title;
        }

        public ViewedViewModel()
        {
            //todo получаеть запоминаемый текст в поиске
            var storingValueInSearchString = "";
            //todo получать лист просмотренных аниме
            var anime = TestData();

            Items = CollectionViewSource.GetDefaultView(anime);
            Items.Filter = FilterNameAnime;
            DeleteAnimeCommand = new CommandDeleteAnime(Items);
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
            //todo устанавливать запоминаемый текст
            return result;
        }

        private bool ContainsCaseInsensitive(string source, string substring)
        {
            return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }
}
