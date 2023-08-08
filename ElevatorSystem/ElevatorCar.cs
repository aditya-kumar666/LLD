using System;

namespace ElevatorSystem
{
    public class ElevatorCar
    {
        public int id;
        public ElevatorDisplay display;
        public InternalButton internalButton;
        public ElevatorStatus elevatorState;
        public int currentFloor;
        public Direction elevatorDirection;
        public ElevatorDoor elevatorDoor;

        public ElevatorCar()
        {
            display = new ElevatorDisplay();
            internalButton = new InternalButton();
            elevatorState = ElevatorStatus.idle;
            currentFloor = 0;
            elevatorDirection = Direction.UP;
            elevatorDoor = new ElevatorDoor();
        }

        public void showDisplay()
        {
            display.showDisplay();
        }

        public void pressButton(int destination)
        {
            internalButton.pressButton(destination, this);
        }

        public void setDisplay()
        {
            this.display.setDisplay(currentFloor, elevatorDirection);
        }

        public bool moveElevator(Direction dir, int destinationFloor)
        {
            int startFloor = currentFloor;
            if (dir == Direction.UP)
            {
                for (int i = startFloor; i <= destinationFloor; i++)
                {

                    this.currentFloor = startFloor;
                    setDisplay();
                    showDisplay();
                    if (i == destinationFloor)
                    {
                        return true;
                    }
                }
            }

            if (dir == Direction.DOWN)
            {
                for (int i = startFloor; i >= destinationFloor; i--)
                {

                    this.currentFloor = startFloor;
                    setDisplay();
                    showDisplay();
                    if (i == destinationFloor)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}