using Avalonia.Controls;
using CinnaMedia.ViewModels;

namespace CinnaMedia.Views
{
    public partial class EditMovieView : UserControl
    {
        public EditMovieView()
        {
            DataContext = new EditMovieViewModel();
            InitializeComponent();
        }
    }
}
