using BookMyShow.Enums;

namespace BookMyShow
{
    public class Theatre
    {
        int theatreId;
        string address;
        City city;
        List<Screen> screens = new();
        List<Show> shows = new();

        public int getTheatreId()
        {
            return theatreId;
        }

        public void setTheatreId(int theatreId)
        {
            this.theatreId = theatreId;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public List<Screen> getScreen()
        {
            return screens;
        }

        public void setScreen(List<Screen> screen)
        {
            this.screens = screen;
        }

        public List<Show> getShows()
        {
            return shows;
        }

        public void setShows(List<Show> shows)
        {
            this.shows = shows;
        }

        public City getCity()
        {
            return city;
        }

        public void setCity(City city)
        {
            this.city = city;
        }

    }
}
