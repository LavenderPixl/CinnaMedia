using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnaMedia.Objects
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PosterPath { get; set; }
        public string? Review { get; set; }
        public string? Description { get; set; }
        public int Rating { get; set; }
        
        //public Movie() { }
        public Movie(int id, string name, string posterPath, string? review, string? description, int rating)
        {
            Id = id;
            Name = name;
            PosterPath = PosterPathCheck(posterPath);
            Review = review;
            Description = description;
            Rating = rating;
        }
        private string PosterPathCheck(string posterPath)
        {
            if (string.IsNullOrEmpty(posterPath))
            {
                return "avares://CinnaMedia/Images/btn2.png";
            }
            return posterPath;
        }
    }
}
