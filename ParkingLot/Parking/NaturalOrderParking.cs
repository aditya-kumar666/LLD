namespace ParkingLot.Parking
{
    public class NaturalOrderParking : ParkingStrategy
    {
        public override ParkingSpace park(List<ParkingSpace> availableSpaces)
        {
            return availableSpaces[0];
        }
    }
}
