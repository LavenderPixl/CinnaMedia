using CinnaMedia.Models;
using CinnaMedia.Objects;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnaMedia.ViewModels
{
    public class EditMovieViewModel : ViewModelBase
    {
        #region Properties
        private string? descrip_Box;
        public string? Descrip_Box
        {
            get => descrip_Box;
            set => this.RaiseAndSetIfChanged(ref descrip_Box, value);
        }

        private string review_Box;
        public string Review_Box
        {
            get => review_Box;
            set => this.RaiseAndSetIfChanged(ref review_Box, value);
        }
        #endregion

        public void SaveAndGo()
        {

        }




        public void AddMovie(Movie movie)
        {
            if (DAL.Movies.Last() == null)
            {
                DAL.Movies.Add(new Movie(movie.Id, movie.Name, movie.PosterPath, movie.Review, movie.Description, movie.Rating));
            }
            else
            {
                DAL.Movies.Add(new Movie(movie.Id, movie.Name, movie.PosterPath, movie.Review, movie.Description, movie.Rating));
            }
        }
    }
}
