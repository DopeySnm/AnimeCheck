using AnimeCheck.Model;
using System;

namespace AnimeCheck.Service
{
    public class FilterHelper
    {
        public bool FilterSearch(object obj , string filterText)
        {
            bool result = true;
            Title current = obj as Title;
            if (!string.IsNullOrWhiteSpace(filterText) && current != null && !ContainsCaseInsensitive(current.Name, filterText))
            {
                result = false;
            }
            return result;
        }

        private bool ContainsCaseInsensitive(string source, string substring)
        {
            return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }
}
