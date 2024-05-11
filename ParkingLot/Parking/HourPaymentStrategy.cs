namespace ParkingLot.Parking
{
    public class HourPaymentStrategy : PaymentStrategy
    {
        public HourPaymentStrategy()
        {
            setBikeCharges(10);
            setCarCharges(20);
            setTruckCharges(30);
        }

        public override double calculateCost(Ticket ticket)
        {
            DateTime entryTime = ticket.getEntryTime();
            DateTime exitTime = ticket.getExitTime();

            TimeSpan timeDifference = exitTime - entryTime;
            long hours = (long)timeDifference.TotalHours;
            return hours * getChargeType(ticket.getVehicle());
        }
    }
}
