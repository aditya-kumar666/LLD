using CarRentalSystem.Product;
using CarRentalSystem;

public class Program
{
    public static void Main(string[] args)
    {

        List<User> users = addUsers();
        List<Vehicle> vehicles = addVehicles();
        List<Store> stores = addStores(vehicles);

        VehicleRentalSystem rentalSystem = new VehicleRentalSystem(stores, users);
        //0. User comes
        User user = users[0];
        //1. user search store based on location
        Location loc = new Location(403012, "Bangalore", "Karnataka", "India");
        Store store = rentalSystem.getStore(loc);

        //2. get All vehicles you are interested in (based upon different filters)
        List<Vehicle> storeVehicles = store.getVehicles(VehicleType.Car);

        //3.reserving the particular vehicle
        Reservation reservation = store.createReservation(storeVehicles.FirstOrDefault(), users.FirstOrDefault());

        //4. generate the bill
        Bill bill = new Bill(reservation);

        //5. make payment
        Payment payment = new Payment();
        payment.payBill(bill);

        //6. trip completed, submit the vehicle and close the reservation
        store.completeReservation(reservation.reservationId);
    }

    public static List<Vehicle> addVehicles()
    {

        List<Vehicle> vehicles = new();

        Vehicle vehicle1 = new Car();
        vehicle1.setVehicleID(1);
        vehicle1.setVehicleType(VehicleType.Car);

        Vehicle vehicle2 = new Car();
        vehicle1.setVehicleID(2);
        vehicle1.setVehicleType(VehicleType.Car);

        vehicles.Add(vehicle1);
        vehicles.Add(vehicle2);

        return vehicles;
    }

    public static List<User> addUsers()
    {

        List<User> users = new();
        User user1 = new User();
        user1.setUserId(1);

        users.Add(user1);
        return users;
    }

    public static List<Store> addStores(List<Vehicle> vehicles)
    {

        List<Store> stores = new();
        Store store1 = new Store();
        store1.storeId = 1;
        store1.setVehicles(vehicles);

        stores.Add(store1);
        return stores;
    }


}