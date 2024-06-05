namespace ProxyDesignPattern
{
    public interface EmployeeDao
    {
        public void create(string client, EmployeeDo obj);
        public void delete(string client, int employeeId);
        public EmployeeDo get(string client, int employeeId);
    }
}
