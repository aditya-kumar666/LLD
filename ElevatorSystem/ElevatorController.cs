namespace ElevatorSystem
{
    internal class ElevatorController
    {
        PriorityQueue<int, int> upMinPQ;
        PriorityQueue<int, int> downMaxPQ;
        public ElevatorCar elevatorCar;

        public ElevatorController(ElevatorCar eC)
        {
            elevatorCar = eC;
            upMinPQ = new PriorityQueue<int, int>();
            downMaxPQ = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        }

        public void submitExternalRequest(int floor, Direction dir)
        {
            if(dir == Direction.DOWN)
            {
                downMaxPQ.Enqueue(floor, floor);
            }
            else
            {
                upMinPQ.Enqueue(floor, floor);
            }
        }

        public void submitInternalRequest(int floor)
        {

        }

        public void controlElevator()
        {
            while (true)
            {

                if (elevatorCar.elevatorDirection == Direction.UP)
                {


                }
            }
        }

    }
}