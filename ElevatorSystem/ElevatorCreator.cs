namespace ElevatorSystem
{
    internal static class ElevatorCreator
    {
        public static List<ElevatorController> elevatorControllerList = new List<ElevatorController>();

        static ElevatorCreator()
        {
            ElevatorCar ec1 = new ElevatorCar();
            ec1.id = 1;
            ElevatorController c1 = new ElevatorController(ec1);

            ElevatorCar ec2 = new ElevatorCar();
            ec2.id = 2;
            ElevatorController c2 = new ElevatorController(ec2);

            elevatorControllerList.Add(c1);
            elevatorControllerList.Add(c2);
        }
    }
}