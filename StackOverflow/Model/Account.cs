namespace StackOverflow.Model
{
    public class Account
    {
        string name;
        string email;

        public Account(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public string getName() { return name; }

        public string getEmail() { return email; }

        
        public override string ToString()
        {
            return "Account{" +
                    "name='" + name + '\'' +
                    ", email='" + email + '\'' +
                    '}';
        }
    }
}
