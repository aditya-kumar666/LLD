namespace RateLimiting.TokenBucket
{
    internal class UserBucketCreator
    {
        Dictionary<int, TokenBucket> bucket;
        public UserBucketCreator(int id)
        {
            bucket = new Dictionary<int, TokenBucket>()
            {
                {id, new TokenBucket(10,10)}
            };
        }

        public void accessApplication(int id)
        {
            if (bucket.ContainsKey(id) && bucket[id].GrantAccess())
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " -> able to access the application");
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " -> Too many request, Please try after some time");
            }
        }
    }
}
