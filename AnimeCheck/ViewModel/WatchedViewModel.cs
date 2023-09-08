﻿using AnimeCheck.Model;
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
    internal class WatchedViewModel : ViewModelBase // DependencyObject
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
                Items.Filter = FilterAnime;
            }
        }

        private ICollectionView items;

        public ICollectionView Items
        {
            get { return items; }
            set { Set(ref items, value); }
        }

        public static Title SelectedAnime { get; set; }

        public static TitlePart SelectedSeason { get; set; }

        //todo потом удалить TestData
        private List<Title> TestData()
        {
            TitlePart titlePartTest = new TitlePart(1, 1, "1 сезон");
            Title titleTest = new Title(1, "Тородора");
            titleTest.TitleParts.Add(titlePartTest);
            var title = new List<Title>() { titleTest };
            return title;
        }

        public WatchedViewModel()
        {
            //todo получаеть запоминаемый текст в поиске
            var storingValueInSearchString = "";
            //todo получать лист просмотренных аниме
            var anime = TestData();

            Items = CollectionViewSource.GetDefaultView(anime);
            Items.Filter = FilterAnime;
            DeleteAnimeCommand = new CommandDeleteAnime(Items);
            FilterText = storingValueInSearchString;
        }

        private bool FilterAnime(object obj)
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
