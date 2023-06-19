using Avalonia.Controls;
using CinnaMedia.ViewModels;

namespace CinnaMedia.Views
{
    public partial class SearchMenuView : UserControl
    {
        public SearchMenuView()
        {
            DataContext = new SearchMenuViewModel();
            InitializeComponent();
        }
    }
}
