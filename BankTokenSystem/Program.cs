using BankTokenSystem;

public class Program
{
    public static void Main()
    {
        var manager = new TokenManager(premiumRatio: 2, regularRatio: 1);

        manager.GetToken(CustomerType.Premium);
        manager.GetToken(CustomerType.Regular);
        manager.GetToken(CustomerType.Premium);
        manager.GetToken(CustomerType.Premium);
        manager.GetToken(CustomerType.Regular);

        for (int i = 0; i < 6; i++)
        {
            manager.ScheduleCustomer();
        }
    }
}
