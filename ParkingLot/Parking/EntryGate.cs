
using ParkingLot.Vehicles;

namespace ParkingLot.Parking
{
    public class EntryGate
    {
        string gateId;
        public EntryGate(string gateId)
        {

            this.gateId = gateId;

        }

        public Ticket generateTicket(Vehicle v)
        {
            if(!ParkingLots.INSTANCE.isParkingSpaceAvailable(v.getVType())) { return null; }

            ParkingSpace pSpace = ParkingLots.INSTANCE.findParkingSpace(v);
            pSpace.parkVehicle(v);
            return new Ticket(v, pSpace);
        }
    }
}
