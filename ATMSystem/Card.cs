namespace ATMSystem
{
    public class Card
    {
        int cardNo;
        int cvv;
        DateTime expiryDate;
        string holderName;
        static int PIN_NO = 112223;
        UserBankAccount bankAccount;

        public bool isCorrectPin(int pin)
        {
            if(pin == PIN_NO)
            {
                return true;
            }
            return false;
        }

        public int getBankBalance()
        {
            return bankAccount.balance;
        }

        public void deductBankBalance(int amount)
        {
            bankAccount.withdrawalBalance(amount);
        }

        public void setBankAccount(UserBankAccount bankAccount)
        {
               this.bankAccount = bankAccount;
        }
    }
}
