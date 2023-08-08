namespace ElevatorSystem
{
    internal class Building
    {
        List<Floor> floors;
        public Building(List<Floor> floors)
        {
            this.floors = floors;
        }

        public void addFloor(Floor floor)
        {
            floors.Add(floor);
        }

        public void removeFloor(Floor floor) {
            floors.Remove(floor);
        }

        public List<Floor> getAllFloors()
        {
            return floors;
        }
    }
}
