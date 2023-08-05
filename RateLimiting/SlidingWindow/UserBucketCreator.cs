namespace RateLimiting.SlidingWindow
{
    internal class UserBucketCreator
    {
        Dictionary<int, SlidingWindow> bucket;
        public UserBucketCreator(int id)
        {
            bucket = new Dictionary<int, SlidingWindow>()
            {
                {id, new SlidingWindow(1,5)}
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
