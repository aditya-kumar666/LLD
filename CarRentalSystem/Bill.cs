namespace CarRentalSystem
{
    public class Bill
    {
        Reservation reservation;
        double totalBillAmount;
        bool isBillPaid;

        public Bill(Reservation reservation)
        {
            this.reservation = reservation;
            this.totalBillAmount = computeBillAmount();
            isBillPaid = false;
        }

        double computeBillAmount() {
            return 100.0;
        }
    }
}
