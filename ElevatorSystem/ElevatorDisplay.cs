namespace ElevatorSystem
{
    public class ElevatorDisplay
    {
        int floor;
        Direction direction;
        public void setDisplay(int fl, Direction dr)
        {
            floor = fl;
            direction = dr;
        }

        public void showDisplay()
        {
            Console.WriteLine(floor);
            Console.WriteLine(direction);
        }
    }
}
