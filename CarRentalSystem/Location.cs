namespace CarRentalSystem
{
    public class Location
    {
        String address;
        int pincode;
        String city;
        String state;
        String country;

        public Location(int pincode, string city, string state, string country)
        {
            this.pincode = pincode;
            this.city = city;
            this.state = state;
            this.country = country;
        }
    }
}
