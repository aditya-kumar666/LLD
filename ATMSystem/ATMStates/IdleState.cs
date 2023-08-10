namespace ATMSystem.ATMStates
{
    public class IdleState : ATMState
    {
        public override void insertCard(ATM atm, Card card)
        {
            Console.WriteLine("Card is inserted");
            atm.setCurrentATMState(new HasCardState());

        }
    }
}
