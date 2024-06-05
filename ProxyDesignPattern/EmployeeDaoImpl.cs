namespace ProxyDesignPattern
{
    public class EmployeeDaoImpl : EmployeeDao
    {
        public void create(string client, EmployeeDo obj)
        {
            Console.WriteLine("Created new row in employee table");
        }

        public void delete(string client, int employeeId)
        {
            Console.WriteLine("deleted row with employeeID " + employeeId);
        }

        public EmployeeDo get(string client, int employeeId)
        {
            Console.WriteLine("fetching date from db");
            return new EmployeeDo();
        }
    }
}
