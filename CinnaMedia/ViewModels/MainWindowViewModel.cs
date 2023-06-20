using CinnaMedia.Models;
using CinnaMedia.Objects;
using ReactiveUI;
using System.Linq;
using System.Reactive;
using System.Windows.Input;

namespace CinnaMedia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ReactiveCommand<string, Unit> ChangeViewCommand { get; }
        ViewModelBase content;
        Movie NewMovie;
        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public MainWindowViewModel()
        {
            ChangeViewCommand = ReactiveCommand.Create<string>(ChangeView);
            Content = new MainMenuViewModel();
        }

        public ViewModelBase[] openViews =
        {
            new SearchMenuViewModel(),
            new EditMovieViewModel(),
            new MovieInfoViewModel(),
            new MainMenuViewModel()
        };

        public void ChangeView(string i)
        {
            int.TryParse(i, out int viewId);
            Content = openViews[viewId];
        }
    }
}