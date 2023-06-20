using CinnaMedia.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnaMedia.Models
{
    public static class DAL
    {
        private static ObservableCollection<Movie> movies = new();
        public static ObservableCollection<Movie> Movies { get; set; } = MovieDatabase();

        public static ObservableCollection<Movie> GetMovies()
        {
            movies.Clear();
            foreach (Movie movie in Movies)
            {
                movies.Add(movie);
            }
            return movies;
        }

        public static ObservableCollection<Movie> MovieDatabase()
        {
            Movies = new ObservableCollection<Movie>
            {
                //new Movie(0, "Spiderman - Far From Home", "avares://CinnaMedia/Images/SpidermanFFH.jpg" , null, null, 10),
            };
            return Movies;

        }

        //public void UpdateMovieDataBase(Movie movie)
        //{
            //Movies.Add(new Movie(movie.Id, movie.Name, movie.PosterPath, movie.Review, movie.Description, movie.Rating));
        //}

    }
}
