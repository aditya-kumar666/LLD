using System;

namespace ParkingLot.Parking
{
    public class Payment
    {
        string paymentId;
        DateTime pTime;
        double amount;
        Ticket ticket;
        PaymentType pType;
        PaymentStrategy pStrategy;

    public Payment(double amount, Ticket ticket, PaymentStrategy pStrategy)
        {
            this.paymentId = new Guid().ToString();
            this.pTime = DateTime.Now;
            this.amount = amount;
            this.pStrategy = pStrategy;
            this.ticket = ticket;


        }
        public void makePayment(PaymentType pType)
        {
            this.pType = pType;
        }

        public double getAmount()
        {
            return amount;
        }
    }
}
