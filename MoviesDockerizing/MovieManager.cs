using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDockerizing
{
    public class MovieManager
    {
        private List<Movie> movies;

        public MovieManager()
        {
            movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieByTitle(string title)
        {
            return movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
