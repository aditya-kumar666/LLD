namespace ATMSystem.AmountWithdrawal
{
    public class OneHundredWithdrawProcessor : CashWithdrawProcessor
    {
        public OneHundredWithdrawProcessor(CashWithdrawProcessor next): base(next)
        {
            
        }

        public void withdraw(ATM atm, int remainingAmount)
        {

            int required = remainingAmount / 100;
            int balance = remainingAmount % 100;

            if (required <= atm.getNoOfOneHundredNotes())
            {
                atm.deductOneHundredNotes(required);
            }
            else if (required > atm.getNoOfOneHundredNotes())
            {
                atm.deductOneHundredNotes(atm.getNoOfOneHundredNotes());
                balance = balance + (required - atm.getNoOfOneHundredNotes()) * 100;
            }

            if (balance != 0)
            {
                Console.WriteLine("Something went wrong");
            }
        }

    }
}
