namespace CarRentalSystem.Product
{
    public class Vehicle
    {
        int vehicleId;
        int vehicleNo;
        VehicleType vehicleType;
        string companyName;
        string modelName;
        int kmDriven;
        int dailyRentalCost;
        int hourlyRentalCost;
        int noOfSeat;
        Status status;


        //getters and setters


        public int getVehicleID()
        {
            return vehicleId;
        }

        public void setVehicleID(int vehicleID)
        {
            this.vehicleId = vehicleID;
        }

        public int getVehicleNumber()
        {
            return vehicleNo;
        }

        public void setVehicleNumber(int vehicleNumber)
        {
            this.vehicleNo = vehicleNumber;
        }

        public VehicleType getVehicleType()
        {
            return vehicleType;
        }

        public void setVehicleType(VehicleType vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public String getCompanyName()
        {
            return companyName;
        }

        public void setCompanyName(String companyName)
        {
            this.companyName = companyName;
        }

        public String getModelName()
        {
            return modelName;
        }

        public void setModelName(String modelName)
        {
            this.modelName = modelName;
        }

        public int getKmDriven()
        {
            return kmDriven;
        }

        public void setKmDriven(int kmDriven)
        {
            this.kmDriven = kmDriven;
        }

        public int getDailyRentalCost()
        {
            return dailyRentalCost;
        }

        public void setDailyRentalCost(int dailyRentalCost)
        {
            this.dailyRentalCost = dailyRentalCost;
        }

        public int getHourlyRentalCost()
        {
            return hourlyRentalCost;
        }

        public void setHourlyRentalCost(int hourlyRentalCost)
        {
            this.hourlyRentalCost = hourlyRentalCost;
        }

        public int getNoOfSeat()
        {
            return noOfSeat;
        }

        public void setNoOfSeat(int noOfSeat)
        {
            this.noOfSeat = noOfSeat;
        }

        public Status getStatus()
        {
            return status;
        }

        public void setStatus(Status status)
        {
            this.status = status;
        }

    }
}
