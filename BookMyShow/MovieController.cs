using BookMyShow.Enums;

namespace BookMyShow
{
    public class MovieController
    {
        Dictionary<City, List<Movie>> cityVsMovies;
        List<Movie> allMovies;

        public MovieController()
        {
            cityVsMovies = new();
            allMovies = new();
        }

        //ADD movie to a particular city, make use of cityVsMovies map
        public void addMovie(Movie movie, City city)
        {

            allMovies.Add(movie);

            List<Movie> movies = cityVsMovies.GetValueOrDefault(city, new ());
            movies.Add(movie);
            if (cityVsMovies.ContainsKey(city))
            {
                cityVsMovies[city].Add(movie);
            }
            else
                cityVsMovies.Add(city, new List<Movie>(movies));
        }


        public Movie getMovieByName(String movieName)
        {

            foreach (Movie movie in allMovies)
            {
                if ((movie.getMovieName()).Equals(movieName))
                {
                    return movie;
                }
            }
            return null;
        }


        public List<Movie> getMoviesByCity(City city)
        {
            return cityVsMovies[city];
        }
        //REMOVE movie from a particular city, make use of cityVsMovies map

        //UPDATE movie of a particular city, make use of cityVsMovies map

        //CRUD operation based on Movie ID, make use of allMovies list

    }
}
