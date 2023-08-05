public class Program
{
    public static void Main(string[] args)
    {
        //var userBucketCreator = new RateLimiting.LeakyBucket.UserBucketCreator(1);
        //var tasks = new Task[12];
        //for (int i=0; i<12; i++)
        //{
        //    tasks[i] = Task.Run(() => userBucketCreator.accessApplication(1));
        //}
        //Task.WaitAll(tasks);

        //var tokenBucketCreator = new RateLimiting.TokenBucket.UserBucketCreator(1);
        //var tokentasks = new Task[12];
        //for (int i = 0; i < 12; i++)
        //{
        //    tokentasks[i] = Task.Run(() => tokenBucketCreator.accessApplication(1));
        //}
        //Task.WaitAll(tokentasks);

        var slidingBucketCreator = new RateLimiting.SlidingWindow.UserBucketCreator(1);
        var slidingtasks = new Task[12];
        for (int i = 0; i < 12; i++)
        {
            slidingtasks[i] = Task.Run(() => slidingBucketCreator.accessApplication(1));
        }
        Task.WaitAll(slidingtasks);
    }
}