namespace ATMSystem.AmountWithdrawal
{
    public abstract class CashWithdrawProcessor
    {
        public CashWithdrawProcessor nextWithdrawProcessor;

        public CashWithdrawProcessor(CashWithdrawProcessor next)
        {
            this.nextWithdrawProcessor = next;
        }

        public void withdraw(ATM atm, int remainingAmount)
        {
            if(nextWithdrawProcessor != null)
            {
                nextWithdrawProcessor.withdraw(atm, remainingAmount);
            }
        }
    }
}
