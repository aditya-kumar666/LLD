namespace ProxyDesignPattern
{
    public class EmployeeDaoProxy : EmployeeDao
    {
        EmployeeDao employeeDaoObj;
        public EmployeeDaoProxy()
        {
            employeeDaoObj = new EmployeeDaoImpl();
        }
        public void create(string client, EmployeeDo obj)
        {
            if (client.Equals("ADMIN"))
            {
                employeeDaoObj.create(client, obj);
                return;
            }
            throw new Exception("Access Denied");
        }

        public void delete(string client, int employeeId)
        {
            if (client.Equals("ADMIN"))
            {
                employeeDaoObj.delete(client, employeeId);
                return;
            }
            throw new Exception("Access Denied");
        }

        public EmployeeDo get(string client, int employeeId)
        {
            if (client.Equals("ADMIN") || client.Equals("USER"))
            {
                 return employeeDaoObj.get(client, employeeId);
            }
            throw new Exception("Access Denied");
        }
    }
}
