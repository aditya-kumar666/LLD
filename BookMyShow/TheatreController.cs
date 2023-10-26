using BookMyShow.Enums;

namespace BookMyShow
{
    public class TheatreController
    {
        Dictionary<City, List<Theatre>> cityVsTheatre;
        List<Theatre> allTheatre;

        public TheatreController()
        {
            cityVsTheatre = new();
            allTheatre = new();
        }

        public void addTheatre(Theatre theatre, City city)
        {

            allTheatre.Add(theatre);

            List<Theatre> theatres = cityVsTheatre.GetValueOrDefault(city, new ());
            theatres.Add(theatre);
            if (cityVsTheatre.ContainsKey(city))
            {
                cityVsTheatre[city].Add(theatre);
            }
            cityVsTheatre.Add(city, theatres);
        }


        public Dictionary<Theatre, List<Show>> getAllShow(Movie movie, City city)
        {

            //get all the theater of this city

            Dictionary<Theatre, List<Show>> theatreVsShows = new ();

            List<Theatre> theatres = cityVsTheatre[city];

            //filter the theatres which run this movie

            foreach (Theatre theatre in theatres)
            {

                List<Show> givenMovieShows = new ();
                List<Show> shows = theatre.getShows();

                foreach (Show show in shows)
                {
                    if (show.getMovie().getMovieId() == movie.getMovieId())
                    {
                        givenMovieShows.Add(show);
                    }
                }
                if (givenMovieShows.Count != 0)
                {
                    theatreVsShows.Add(theatre, givenMovieShows);
                }
            }

            return theatreVsShows;
        }

    }
}
