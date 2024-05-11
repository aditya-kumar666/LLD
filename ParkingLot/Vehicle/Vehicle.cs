namespace ParkingLot.Vehicles
{
    public class Vehicle
    {
        string regNum;
        VehicleType vType;

        public Vehicle(string regNum, VehicleType vType)
        {
            this.regNum = regNum;
            this.vType = vType;
        }

        public VehicleType getVType()
        {
            return vType;
        }
    }
}
