using ProxyDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeDao obj = new EmployeeDaoProxy();
        obj.create("ADMIN", new EmployeeDo());
        Console.WriteLine("Operation successful");
    }
}