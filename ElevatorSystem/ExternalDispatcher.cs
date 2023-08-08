namespace ElevatorSystem
{
    internal class ExternalDispatcher
    {
        List<ElevatorController> elevatorControllerList = ElevatorCreator.elevatorControllerList;
        public void submitExternalRequest(int floor, Direction direction)
        {
            //for simplicity, i am following even odd,
            foreach(var ec in elevatorControllerList)
            {
                int elevatorId = ec.elevatorCar.id;
                if(elevatorId % 2 == 1 && floor %2 == 1)
                {
                    ec.submitExternalRequest(floor , direction);
                }
                else if(elevatorId % 2 == 0 && floor %2 == 0) { 
                    //logic for odd floors
                }
            }
        }
    }
}
