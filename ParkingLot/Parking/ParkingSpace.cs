using ParkingLot.Vehicles;

namespace ParkingLot.Parking
{
    public abstract class ParkingSpace
    {
        string spaceId;
        ParkingSpaceType pType;
        Vehicle vehicle;
        bool isEmpty;

        public ParkingSpace(string sI, ParkingSpaceType type)
        {
            spaceId = sI;
            pType = type;
            isEmpty = true;
        }

        public void parkVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            isEmpty = false;
        }

        public void removeVehicle()
        {
            vehicle = null;
            isEmpty = true;
        }

        public ParkingSpaceType getPType() {
            return pType;
        }

        public bool getIsEmpty()
        {
            return isEmpty;
        }
    }
}
