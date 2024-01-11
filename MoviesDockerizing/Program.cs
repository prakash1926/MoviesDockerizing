using MoviesDockerizing;

class Program
{
    static void Main()
    {
        MovieManager movieManager = new MovieManager();

        // Add some sample movies
        movieManager.AddMovie(new Movie { Title = "Love Today", Year = 2022 });
        movieManager.AddMovie(new Movie { Title = "Mark Antony", Year = 2023 });
        movieManager.AddMovie(new Movie { Title = "Leo", Year = 2023 });

        // Retrieve all movies
        List<Movie> allMovies = movieManager.GetAllMovies();
        Console.WriteLine("All Movies:");
        foreach (var movie in allMovies)
        {
            Console.WriteLine($"{movie.Title} ({movie.Year})");
        }

        // Retrieve a movie by title
        string searchTitle = "Leo";
        Movie foundMovie = movieManager.GetMovieByTitle(searchTitle);

        if (foundMovie != null)
        {
            Console.WriteLine($"Movie found: {foundMovie.Title} ({foundMovie.Year})");
        }
        else
        {
            Console.WriteLine($"Movie with title '{searchTitle}' not found.");
        }
    }
}
