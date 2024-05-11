namespace ParkingLot.Parking
{
    public class ExitGate
    {
        string gateId;
        public ExitGate(string gateId)
        {
            this.gateId = gateId;
        }

        public Payment makePayment(PaymentType pType, PaymentStrategy pStrategy, Ticket ticket)
        {
            ticket.setExitTime(DateTime.Now);
            double cost = pStrategy.calculateCost(ticket);

            Payment p = new Payment(cost, ticket, pStrategy);
            p.makePayment(pType);
            ticket.setActive(false);

            freeParkingSpace(ticket.getParkingSpace());
            return p;
        }
        void freeParkingSpace(ParkingSpace pSpace)
        {
            pSpace.removeVehicle();
        }
    }
}
