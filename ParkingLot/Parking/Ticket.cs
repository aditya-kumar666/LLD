using ParkingLot.Vehicles;
using System;

namespace ParkingLot.Parking
{
    public class Ticket
    {
        string ticketId;
        DateTime entryTime;
        Vehicle vehicle;
        ParkingSpace pSpaceAssigned;
        bool isActive;
        DateTime exitTime;
        public Ticket(Vehicle v, ParkingSpace pSpace) {
            this.ticketId = new Guid().ToString();
            this.entryTime = DateTime.Now;
            this.isActive = true;
            this.vehicle = v;
            this.pSpaceAssigned = pSpace;
        }

        public DateTime getEntryTime() { return entryTime; }

        public Vehicle getVehicle() { return vehicle;}
        public DateTime getExitTime() {  return exitTime; }

        internal void setExitTime(DateTime now)
        {
            exitTime = now;
        }

        internal void setCharges(double cost)
        {
            throw new NotImplementedException();
        }

        internal void setActive(bool v)
        {
            isActive = v;
        }

        internal ParkingSpace getParkingSpace()
        {
            return pSpaceAssigned;
        }
    }
}
