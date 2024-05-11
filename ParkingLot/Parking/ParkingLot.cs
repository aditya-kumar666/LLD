using ParkingLot.Admin;
using ParkingLot.Vehicles;

namespace ParkingLot.Parking
{
    public class ParkingLots
    {
        string plotId;
        List<Floor> floorList;
        List<EntryGate> entries;
        List<ExitGate> exits;
        Address address;
        ParkingStrategy pStrategy;

        public static ParkingLots INSTANCE = new ParkingLots();

        public ParkingLots()
        {
            plotId = new Guid().ToString();
            floorList = new();
            entries = new List<EntryGate>();
            exits = new List<ExitGate>();
        }

        public bool isParkingSpaceAvailable(VehicleType vt)
        {
            foreach(var fl in floorList)
            {
                return fl.canParkVehicle(vt);
            }
            return false;
        }

        public ParkingSpace findParkingSpace(Vehicle v)
        {
            foreach (var fl in floorList)
            {
                return fl.getSpace(v);
            }
            return null;
        }

        internal List<EntryGate> getEntries()
        {
            return entries;
        }

        internal List<ExitGate> getExits()
        {
            return exits;
        }

        internal List<Floor> getFloorList()
        {
            return floorList;
        }

        internal void setPStrategy(ParkingStrategy pStrategy)
        {
            this.pStrategy = pStrategy;
        }

        public ParkingStrategy getPStrategy()
        {
            return pStrategy;
        }

        public void setAddress(Address add)
        {
            address = add;
        }
    }
}
