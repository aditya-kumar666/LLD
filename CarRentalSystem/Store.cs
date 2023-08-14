using CarRentalSystem.Product;
using System;

namespace CarRentalSystem
{
    public class Store
    {
        public int storeId;
        VehicleInventoryManagement inventoryManagement;
        Location storeLocation;
        List<Reservation> reservations = new List<Reservation>();

        public List<Vehicle> getVehicles(VehicleType vehicleType)
        {

            return inventoryManagement.GetVehicles();
        }


        //addVehicles, update vehicles, use inventory management to update those.


        public void setVehicles(List<Vehicle> vehicles)
        {
            inventoryManagement = new VehicleInventoryManagement(vehicles);
        }

        public Reservation createReservation(Vehicle vehicle, User user)
        {
            Reservation reservation = new Reservation();
            reservation.createReserve(user, vehicle);
            reservations.Add(reservation);
            return reservation;
        }

        public bool completeReservation(int reservationID)
        {

            //take out the reservation from the list and call complete the reservation method.
            return true;
        }

        //update reservation

    }
}
