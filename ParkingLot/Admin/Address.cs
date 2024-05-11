
namespace ParkingLot.Admin
{
    public class Address
    {
        string addressLine1;
        string addressLine2;
        string city;
        string state;
        string country;
        string pinCode;

        public void setAddressLine1(string ad1)
        {
            this.addressLine1 = ad1;
        }

        internal void setCity(string v)
        {
            this.city = v;
        }

        internal void setCountry(string v)
        {
            this.state = v;
        }

        internal void setPinCode(string v)
        {
            country = v;
        }

        internal void setState(string v)
        {
            pinCode = v;
        }
    }
}
