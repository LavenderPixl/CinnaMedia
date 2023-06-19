using Avalonia.Controls;
using CinnaMedia.ViewModels;

namespace CinnaMedia.Views
{
    public partial class MovieInfoView : UserControl
    {
        public MovieInfoView()
        {
            DataContext = new MovieInfoViewModel();

            InitializeComponent();
        }
    }
}
