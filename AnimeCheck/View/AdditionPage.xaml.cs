using AnimeCheck.Model;
using AnimeCheck.ViewModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace AnimeCheck.View
{
    /// <summary>
    /// Логика взаимодействия для AddAnimePage.xaml
    /// </summary>
    public partial class AdditionPage : Page
    {
        public AdditionPage()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AdditionViewModel viewModel = DataContext as AdditionViewModel;
            var listView = e.OriginalSource as ListView;
            if (listView.SelectedItem is Title title)
            {
                viewModel.SelectedAnime = title;
                viewModel.NewNameTitle = title.Name;
                List<TitlePart> titlePart = title.GetTitleParts();
                viewModel.TitleParts = CollectionViewSource.GetDefaultView(titlePart);
                viewModel.VisibilityButtonAddTitle = Visibility.Hidden;
                viewModel.VisibilityAddTitlePart = Visibility.Visible;
                viewModel.IsEnabledNewNameTitle = false;
            }
        }
    }
}
