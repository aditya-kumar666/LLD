namespace BankTokenSystem
{
    public class TokenManager
    {
        private readonly Queue<Token> premiumQueue = new Queue<Token>();
        private readonly Queue<Token> regularQueue = new Queue<Token>();

        private int tokenCounter = 1;
        private readonly int premiumRatio;
        private readonly int regularRatio;

        private int premiumServed = 0;
        private int regularServed = 0;

        public TokenManager(int premiumRatio = 2, int regularRatio = 1)
        {
            this.premiumRatio = premiumRatio;
            this.regularRatio = regularRatio;
        }

        public Token GetToken(CustomerType customerType) { 
            var token = new Token(tokenCounter++, customerType);

            if (customerType == CustomerType.Premium) { 
                premiumQueue.Enqueue(token);
            }
            else
            {
                regularQueue.Enqueue(token);
            }

            Console.WriteLine($"Issued {token}");
            return token;
        }

        public Token? ScheduleCustomer() {
            int totalRatio = premiumRatio + regularRatio;

            if ((premiumServed * totalRatio) / premiumRatio <= (regularServed * totalRatio) / regularRatio)
            {
                // Try to serve a premium customer if possible
                if (premiumQueue.Count > 0)
                {
                    premiumServed++;
                    var token = premiumQueue.Dequeue();
                    Console.WriteLine($"Serving {token}");
                    return token;
                }
            }

            // Else serve regular if available
            if (regularQueue.Count > 0)
            {
                regularServed++;
                var token = regularQueue.Dequeue();
                Console.WriteLine($"Serving {token}");
                return token;
            }

            // If no regular, try premium again
            if (premiumQueue.Count > 0)
            {
                premiumServed++;
                var token = premiumQueue.Dequeue();
                Console.WriteLine($"Serving {token}");
                return token;
            }

            Console.WriteLine("No customers to serve.");
            return null;
        }
    }
}
