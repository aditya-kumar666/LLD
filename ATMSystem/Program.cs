using ATMSystem;

public class Program
{
    ATM atm;
    User user;
    public static void Main(string[] args)
    {
        Program atmRoom = new Program();
        atmRoom.initialize();

        atmRoom.atm.printCurrentATMStatus();
        atmRoom.atm.getCurrentATMState().insertCard(atmRoom.atm, atmRoom.user.card);
        atmRoom.atm.getCurrentATMState().authenticatePin(atmRoom.atm, atmRoom.user.card, 112223);
        atmRoom.atm.getCurrentATMState().selectOperation(atmRoom.atm, atmRoom.user.card, TransactionType.Cash_Withdrawal);
        atmRoom.atm.getCurrentATMState().cashWithdrawal(atmRoom.atm, atmRoom.user.card, 2700);
        atmRoom.atm.printCurrentATMStatus();

    }

    void initialize()
    {
        atm = ATM.getATMObject();
        atm.setAtmBalance(3500, 1, 2, 5);
        this.user = createUser();
    }

    private User createUser()
    {

        User user = new User();
        user.setCard(createCard());
        return user;
    }

    private Card createCard()
    {

        Card card = new Card();
        card.setBankAccount(createBankAccount());
        return card;
    }

    private UserBankAccount createBankAccount()
    {
        UserBankAccount bankAccount = new UserBankAccount();
        bankAccount.balance = 3000;

        return bankAccount;

    }

}