namespace RateLimiting.TokenBucket
{
    public class TokenBucket : IRateLimiter
    {
        private int bucketCapacity;
        private int refreshRate;
        private int currentCapacity;
        private long lastUpdatedTime;

        public TokenBucket(int bucketCapacity, int refreshRate)
        {
            this.bucketCapacity = bucketCapacity;
            this.refreshRate = refreshRate;
            currentCapacity = bucketCapacity;
            lastUpdatedTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public bool GrantAccess()
        {
            RefreshBucket();
            int updatedCapacity = Interlocked.Decrement(ref currentCapacity);
            if (updatedCapacity >= 0)
            {
                return true;
            }
            Interlocked.Increment(ref currentCapacity); // Rollback the decrement
            return false;
        }

        void RefreshBucket()
        {
            long currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            int additionalToken = (int)((currentTime - lastUpdatedTime) / 1000 * refreshRate);
            Console.WriteLine("currentTime:"+ currentTime+ " lastUpdatedTime:"+ lastUpdatedTime + " additionalToken:" +additionalToken);
            int currCapacity = Math.Min(Interlocked.Add(ref currentCapacity, additionalToken), bucketCapacity);
            Interlocked.Exchange(ref currentCapacity, currCapacity);
            Interlocked.Exchange(ref lastUpdatedTime, currentTime);
        }
    }
}
