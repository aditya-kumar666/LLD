using System.Collections.Concurrent;

namespace RateLimiting.SlidingWindow
{
    public class SlidingWindow : IRateLimiter
    {
        private ConcurrentQueue<long> slidingWindow;
        private int timeWindowInSeconds;
        private int bucketCapacity;

        public SlidingWindow(int timeWindowInSeconds, int bucketCapacity)
        {
            this.timeWindowInSeconds = timeWindowInSeconds;
            this.bucketCapacity = bucketCapacity;
            slidingWindow = new ConcurrentQueue<long>();
        }

        public bool GrantAccess()
        {
            long currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            CheckAndUpdateQueue(currentTime);

            if (slidingWindow.Count < bucketCapacity)
            {
                slidingWindow.Enqueue(currentTime);
                return true;
            }

            return false;
        }

        private void CheckAndUpdateQueue(long currentTime)
        {
            if (slidingWindow.IsEmpty)
                return;

            long reqOutOfWindowTimeStamp = 0;
            slidingWindow.TryPeek(out reqOutOfWindowTimeStamp);
            long calculatedTime = (currentTime - reqOutOfWindowTimeStamp) / 1000;

            while (calculatedTime >= timeWindowInSeconds)
            {
                slidingWindow.TryDequeue(out _);
                if (slidingWindow.IsEmpty)
                    break;
                //calculatedTime = (currentTime - slidingWindow.Peek()) / 1000;
            }
        }
    }
}
