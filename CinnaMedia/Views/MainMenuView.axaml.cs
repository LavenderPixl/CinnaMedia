using Avalonia.Controls;
using CinnaMedia.ViewModels;

namespace CinnaMedia.Views
{
    public partial class MainMenuView : UserControl
    {
        public MainMenuView()
        {
            DataContext = new MainMenuViewModel();
            InitializeComponent();
        }
    }
}
