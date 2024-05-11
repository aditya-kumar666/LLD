using ParkingLot.Vehicles;

namespace ParkingLot.Parking
{
    public class Floor
    {
        string floorId;
        Dictionary<ParkingSpaceType, List<ParkingSpace>> pSpaces = new ();

        public Floor(string floorId)
        {
            this.floorId = floorId;
            pSpaces.Add(ParkingSpaceType.BikeParking, new List<ParkingSpace>());
            pSpaces.Add(ParkingSpaceType.CarParking, new List<ParkingSpace>());
            pSpaces.Add(ParkingSpaceType.TruckParking, new List<ParkingSpace>());

        }

        public void addParkingSpace(ParkingSpace p)
        {
            pSpaces[p.getPType()].Add(p);
        }
        public void removeParkingSpace(ParkingSpace p)
        {
            pSpaces[p.getPType()].Remove(p);
        }
        public bool canParkVehicle(VehicleType vType)
        {
            foreach (ParkingSpace p in pSpaces[getSpaceTypeForVehicle(vType).Value])
            {
                if (p.getIsEmpty())
                    return true;
            }
            return false;
        }
        private ParkingSpaceType? getSpaceTypeForVehicle(VehicleType vType)
        {
            switch (vType)
            {
                case VehicleType.CAR:
                    return ParkingSpaceType.CarParking;
                case VehicleType.BIKE:
                    return ParkingSpaceType.BikeParking;
                case VehicleType.TRUCK:
                    return ParkingSpaceType.TruckParking;
                default: return null;
            }
        }
        public ParkingSpace getSpace(Vehicle v)
        {
            List<ParkingSpace> availableSpaces = new List<ParkingSpace>();
            foreach (ParkingSpace p in pSpaces[getSpaceTypeForVehicle(v.getVType()).Value])
                if (p.getIsEmpty())
                    availableSpaces.Add(p);
            return ParkingLots.INSTANCE.getPStrategy().park(availableSpaces);


        }

        internal Dictionary<ParkingSpaceType, List<ParkingSpace>> getSpaces()
        {
            return pSpaces;
        }
    }
}
