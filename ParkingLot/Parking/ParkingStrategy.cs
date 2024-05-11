namespace ParkingLot.Parking
{
    public abstract class ParkingStrategy
    {
        public abstract ParkingSpace park(List<ParkingSpace> availableSpaces);
    }
}
