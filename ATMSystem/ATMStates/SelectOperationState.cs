namespace ATMSystem.ATMStates
{
    public class SelectOperationState : ATMState
    {
        public SelectOperationState()
        {
            showOperations();
        }

        public override void selectOperation(ATM atmObject, Card card, TransactionType txnType)
        {

            switch (txnType)
            {

                case TransactionType.Cash_Withdrawal:
                    atmObject.setCurrentATMState(new CashWithdrawalState());
                    break;
                case TransactionType.Balance_Check:
                    atmObject.setCurrentATMState(new CheckBalanceState());
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Option");
                        exit(atmObject);
                        break;
                    }
            }
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

        private void showOperations()
        {
            Console.WriteLine("Please select the Operation");
            Console.WriteLine("Cash_Withdrawal");
            Console.WriteLine("Balance_Check");
        }

    }
}
