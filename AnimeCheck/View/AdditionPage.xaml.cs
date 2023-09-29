using System.Text.RegularExpressions;
using System.Windows.Controls;
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
    }
}
