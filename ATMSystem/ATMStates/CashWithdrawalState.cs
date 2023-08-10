using ATMSystem.AmountWithdrawal;

namespace ATMSystem.ATMStates
{
    public class CashWithdrawalState : ATMState
    {
        public CashWithdrawalState()
        {
            Console.WriteLine("Please enter the Withdrawal Amount");
        }

        public override void cashWithdrawal(ATM atmObject, Card card, int withdrawalAmountRequest)
        {

            if (atmObject.getATMBalance() < withdrawalAmountRequest)
            {
                Console.WriteLine("Insufficient fund in the ATM Machine");
                exit(atmObject);
            }
            else if (card.getBankBalance() < withdrawalAmountRequest)
            {
                Console.WriteLine("Insufficient fund in the your Bank Account");
                exit(atmObject);
            }
            else
            {

                card.deductBankBalance(withdrawalAmountRequest);
                atmObject.deductATMBalance(withdrawalAmountRequest);

                //using chain of responsibility for this logic, how many 2k Rs notes, how many 500 Rs notes etc, has to be withdrawal
                CashWithdrawProcessor withdrawProcessor =
                        new TwoThousandWithdrawProcessor(new FiveHundredWithdrawProcessor(new OneHundredWithdrawProcessor(null)));

                withdrawProcessor.withdraw(atmObject, withdrawalAmountRequest);
                exit(atmObject);
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

    }
}
