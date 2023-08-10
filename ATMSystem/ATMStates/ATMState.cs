namespace ATMSystem.ATMStates
{
    public abstract class ATMState
    {
        public virtual void insertCard(ATM atm, Card card)
        {
            Console.WriteLine("OOPS!! Something went wrong");
        }

        public virtual void authenticatePin(ATM atm, Card card, int pin)
        {
            Console.WriteLine("OOPS!! Something went wrong");
        }

        public virtual void selectOperation(ATM atm, Card card, TransactionType txnType)
        {
            Console.WriteLine("OOPS!! Something went wrong");
        }

        public virtual void cashWithdrawal(ATM atm, Card card, int withdrawAmount)
        {
            Console.WriteLine("OOPS!! Something went wrong");
        }

        public virtual void displayBalance(ATM atm, Card card)
        {
            Console.WriteLine("OOPS!! Something went wrong");
        }

        public virtual void returnCard()
        {
            Console.WriteLine("OOPS!! Something went wrong");
        }

        public virtual void exit(ATM atm)
        {
            Console.WriteLine("OOPS!! Something went wrong");
        }

    }
}
