using System.Collections.Concurrent;

namespace RateLimiting.LeakyBucket
{
    internal class LeakyBucket : IRateLimiter
    {
        BlockingCollection<int> queue;
        public LeakyBucket(int capacity)
        {
            queue = new BlockingCollection<int>(new ConcurrentQueue<int>(), capacity);
        }

        public bool GrantAccess()
        {
            if(queue.Count < queue.BoundedCapacity)
            {
                queue.Add(1);
                return true;
            }
            return false;
        }
    }
}
