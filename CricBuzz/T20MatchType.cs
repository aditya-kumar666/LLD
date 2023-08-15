using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBuzz
{
    public class T20MatchType : IMatchType
    {
        public int noOfOvers()
        {
            return 20;
        }

        public int maxOverCountBowlers()
        {
            return 5;
        }
    }
}
