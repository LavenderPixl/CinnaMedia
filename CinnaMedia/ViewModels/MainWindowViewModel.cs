using ReactiveUI;
using System.Reactive;
using System.Windows.Input;

namespace CinnaMedia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;
        public ReactiveCommand<string, Unit> ChangeViewCommand { get; }
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