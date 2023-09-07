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
    internal class WatchedViewModel : ViewModelBase // DependencyObject
    {
        public ICommand DeleteAnimeCommand { get; }

        //public string FilterText
        //{
        //    get { return (string)GetValue(FilterTextProperty); }
        //    set { SetValue(FilterTextProperty, value); }
        //}

        //public static readonly DependencyProperty FilterTextProperty =
        //    DependencyProperty.Register("FilterText", typeof(string), typeof(AnimeViewModel), new PropertyMetadata("", FilterText_Chenge));

        //public ICollectionView Items
        //{
        //    get { return (ICollectionView)GetValue(ItemsProperty); }
        //    set { SetValue(ItemsProperty, value); }
        //}

        //public static readonly DependencyProperty ItemsProperty =
        //    DependencyProperty.Register("Items", typeof(ICollectionView), typeof(AnimeViewModel), new PropertyMetadata(null));

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


        public WatchedViewModel(string storingValueInSearchString, List<Title> anime)
        {
            Items = CollectionViewSource.GetDefaultView(anime);
            Items.Filter = FilterAnime;
            DeleteAnimeCommand = new CommandDeleteAnime(Items);
            FilterText = storingValueInSearchString;
        }

        //private static void FilterText_Chenge(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    var current = d as AnimeViewModel;
        //    if (current != null)
        //    {
        //        current.Items.Filter = null;
        //        current.Items.Filter = current.FilterAnime;
        //    }
        //}

        private bool FilterAnime(object obj)
        {
            Title current = obj as Title;
            if (!string.IsNullOrWhiteSpace(FilterText) && current != null && !ContainsCaseInsensitive(current.Name, FilterText))
            {
                return false;
            }
            return true;
        }

        private bool ContainsCaseInsensitive(string source, string substring)
        {
            return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }
}
