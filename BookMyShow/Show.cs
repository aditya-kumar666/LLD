namespace BookMyShow
{
    public class Show
    {
        int showId;
        Movie movie;
        Screen screen;
        int showStartTime;
        List<int> bookedSeatIds = new ();

        public int getShowId()
        {
            return showId;
        }

        public void setShowId(int showId)
        {
            this.showId = showId;
        }

        public Movie getMovie()
        {
            return movie;
        }

        public void setMovie(Movie movie)
        {
            this.movie = movie;
        }

        public Screen getScreen()
        {
            return screen;
        }

        public void setScreen(Screen screen)
        {
            this.screen = screen;
        }

        public int getShowStartTime()
        {
            return showStartTime;
        }

        public void setShowStartTime(int showStartTime)
        {
            this.showStartTime = showStartTime;
        }

        public List<int> getBookedSeatIds()
        {
            return bookedSeatIds;
        }

        public void setBookedSeatIds(List<int> bookedSeatIds)
        {
            this.bookedSeatIds = bookedSeatIds;
        }

    }
}
