namespace BankTokenSystem
{
    public class Token
    {
        public int TokenNumber { get; }
        public CustomerType CustomerType { get; }

        public Token(int tokenNumber, CustomerType customerType)
        {
            TokenNumber = tokenNumber;
            CustomerType = customerType;
        }

        public override string ToString() {
            return $"Token #{TokenNumber} ({CustomerType})";
        }
    }
}
