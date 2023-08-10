namespace ATMSystem.ATMStates
{
    public class HasCardState : ATMState
    {
        public HasCardState()
        {
            Console.WriteLine("enter your card pin number");
        }

        public override void authenticatePin(ATM atm, Card card, int pin)
        {
            bool isCorrectPinEntered = card.isCorrectPin(pin);
            if (isCorrectPinEntered)
            {
                atm.setCurrentATMState(new SelectOperationState());
            }
            else {
                Console.WriteLine("Invalid PIN Number");
                exit(atm);
            }
        }

        public override void exit(ATM atm)
        {
            returnCard();
            atm.setCurrentATMState(new IdleState());
            Console.WriteLine("Exit happens");
        }

        public void returnCard()
        {
            Console.WriteLine("Please collect your card");
        }
    }
}
