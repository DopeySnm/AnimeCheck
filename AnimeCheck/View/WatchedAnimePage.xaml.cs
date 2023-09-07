using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using Newtonsoft.Json.Linq;

namespace AnimeCheck.View
{
    public partial class WatchedAnimePage : Page
    {
        public WatchedAnimePage()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            DataProcessing.ReadFile();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TitlePart titlePartTest = new TitlePart(1, 1, "1 сезон");
            Title titleTest = new Title(1, "Тородора");
            titleTest.TitleParts.Add(titlePartTest);
            var title = new List<Title>() { titleTest };
            string storingValueInSearchString = "";
            DataContext = new WatchedViewModel(storingValueInSearchString, title);
        }

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue is Title title)
            {
                WatchedViewModel.SelectedAnime = (Title)e.NewValue;
            }
            else if (e.NewValue is TitlePart titlePart)
            {
                var item = (TreeViewItem)e.OriginalSource;
                if (item != null)
                {
                    ItemsControl parent = GetSelectedTreeViewItemParent(item);

                    TreeViewItem treeitem = parent as TreeViewItem;
                    string MyValue = treeitem.Header.ToString();
                }
                WatchedViewModel.SelectedSeason = (TitlePart)e.NewValue;
            }
        }
        public ItemsControl GetSelectedTreeViewItemParent(TreeViewItem item)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(item);
            while (!(parent is TreeViewItem || parent is TreeView))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            return parent as ItemsControl;
        }
    }
}
