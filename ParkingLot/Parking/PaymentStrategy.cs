using ParkingLot.Vehicles;

namespace ParkingLot.Parking
{
    public abstract class PaymentStrategy
    {
        double bikeCharges;
        double carCharges;
        double truckCharges;

        public abstract double calculateCost(Ticket t);

        public double getChargeType(Vehicle v)
        {
            switch(v.getVType())
            {
                case VehicleType.CAR: return carCharges;
                case VehicleType.BIKE: return bikeCharges;
                case VehicleType.TRUCK: return truckCharges;
            }
            return 0.0; 
        }

        public void setBikeCharges(double bikeCharges)
        {
            this.bikeCharges = bikeCharges;
        }

        public void setCarCharges(double carCharges)
        {
            this.carCharges = carCharges;
        }

        public void setTruckCharges(double truckCharges)
        {
            this.truckCharges = truckCharges;
        }
    }
}
