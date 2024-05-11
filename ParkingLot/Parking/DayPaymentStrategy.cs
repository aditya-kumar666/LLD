namespace ParkingLot.Parking
{
    public class DayPaymentStrategy : PaymentStrategy
    {
        public DayPaymentStrategy()
        {
            this.setBikeCharges(100);
            this.setCarCharges(200);
            this.setTruckCharges(300);
        }

        public override double calculateCost(Ticket ticket)
        {
            DateTime entryTime = ticket.getEntryTime();
            DateTime exitTime = ticket.getExitTime();

            TimeSpan timeDifference = exitTime - entryTime;
            long days = (long)timeDifference.TotalDays;
            return days * getChargeType(ticket.getVehicle());
        }
    }
}
