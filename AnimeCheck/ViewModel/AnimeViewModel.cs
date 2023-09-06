using AnimeCheck.model;
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

namespace AnimeCheck.ViewModel
{
    internal class AnimeViewModel : DependencyObject
    {
        public ICommand DeleteAnimeCommand { get; }

        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(AnimeViewModel), new PropertyMetadata("", FilterText_Chenge));

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(AnimeViewModel), new PropertyMetadata(null));


        public static Anime SelectedAnime { get; set; }

        public static Season1 SelectedSeason { get; set; }

        public AnimeViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Anime.GetAnime());
            Items.Filter = FilterAnime;
            DeleteAnimeCommand = new CommandDeleteAnime(Items);
        }

        private static void FilterText_Chenge(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as AnimeViewModel;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterAnime;
            }
        }

        private bool FilterAnime(object obj)
        {
            Anime current = obj as Anime;
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
