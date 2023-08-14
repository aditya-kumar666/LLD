using CarRentalSystem.Product;

namespace CarRentalSystem
{
    public class VehicleInventoryManagement
    {
        List<Vehicle> vehicles;
        public VehicleInventoryManagement(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
        }

        public List<Vehicle> GetVehicles()
        {     
            //filtering
            return vehicles;
        }

        public void setVehicles(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
        }
    }
}
