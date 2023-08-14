using CarRentalSystem.Product;

namespace CarRentalSystem
{
    public class Reservation
    {
        public int reservationId;
        User user;
        Vehicle vehicle;
        ReservationType reservationType;
        ReservationStatus reservationStatus;

        public int createReserve(User user, Vehicle vehicle)
        {
            reservationId = 12232;
            this.user = user;
            this.vehicle = vehicle;
            reservationType = ReservationType.Daily;
            reservationStatus = ReservationStatus.SCHEDULED;

            return reservationId;

        }

        // CRUD operations
    }
}
