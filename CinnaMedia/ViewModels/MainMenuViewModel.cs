using CinnaMedia.Models;
using CinnaMedia.Objects;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnaMedia.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        public ObservableCollection<Movie> Movies { get; set; } = DAL.GetMovies();
        public MainMenuViewModel()
        {

        }

    }
}
