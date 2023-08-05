using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiting.LeakyBucket
{
    internal class UserBucketCreator
    {
        Dictionary<int, LeakyBucket> bucket;

        public UserBucketCreator(int id)
        {
            bucket = new()
            {
                { id, new LeakyBucket(10) }
            };
        }

        public void accessApplication(int id)
        {
            if(bucket.ContainsKey(id) && bucket[id].GrantAccess())
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
