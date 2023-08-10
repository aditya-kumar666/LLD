namespace ATMSystem.ATMStates
{
    public class CheckBalanceState : ATMState
    {
        public CheckBalanceState()
        {
            
        }

        public override void displayBalance(ATM atm, Card card)
        {
            Console.WriteLine("Your Balance is: " + card.getBankBalance());
            exit(atm);
        }

        
        public override void exit(ATM atmObject)
        {
            returnCard();
            atmObject.setCurrentATMState(new IdleState());
            Console.WriteLine("Exit happens");
        }

        
        public override void returnCard()
        {
            Console.WriteLine("Please collect your card");
        }

    }
}
