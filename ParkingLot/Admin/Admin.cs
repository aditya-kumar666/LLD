using ParkingLot.Parking;

namespace ParkingLot.Admin
{
    public class Admin
    {
        string id;
        LogInfo login;
        ContactInfo contact;

        public Admin() {
            id = Guid.NewGuid().ToString();
        }

        public void setParkingStrategy(ParkingStrategy pStrategy)
        {
            ParkingLots.INSTANCE.setPStrategy(pStrategy);
        }

        public void addFloor(Floor f)
        {
            ParkingLots.INSTANCE.getFloorList().Add(f);
        }

        public void addParkingSpace(Floor f, ParkingSpace p)
        {
            f.addParkingSpace(p);
        }

        public void addEntryGate(EntryGate entry)
        {
            ParkingLots.INSTANCE.getEntries().Add(entry);
        }
        public void addExitGate(ExitGate exit)
        {
            ParkingLots.INSTANCE.getExits().Add(exit);
        }
    }
}
