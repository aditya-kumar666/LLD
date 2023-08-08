namespace ElevatorSystem
{
    internal class Floor
    {
        int floorNo;
        ExternalDispatcher eD;

        public Floor(int floorNo)
        {
            this.floorNo = floorNo;
            this.eD = new ExternalDispatcher();
        }

        public void pressButton(Direction d)
        {
            eD.submitExternalRequest(floorNo, d);
        }
    }
}
