namespace ATMSystem.AmountWithdrawal
{
    public class TwoThousandWithdrawProcessor : CashWithdrawProcessor
    {
        public TwoThousandWithdrawProcessor(CashWithdrawProcessor next) : base(next)
        {
            
        }

        public void withdraw(ATM atm, int remainingAmount)
        {

            int required = remainingAmount / 2000;
            int balance = remainingAmount % 2000;

            if (required <= atm.getNoOfTwoThousandNotes())
            {
                atm.deductTwoThousandNotes(required);
            }
            else if (required > atm.getNoOfTwoThousandNotes())
            {
                atm.deductTwoThousandNotes(atm.getNoOfTwoThousandNotes());
                balance = balance + (required - atm.getNoOfTwoThousandNotes()) * 2000;
            }

            if (balance != 0)
            {
                base.withdraw(atm, balance);
            }
        }

    }
}
