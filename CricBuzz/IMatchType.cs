using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBuzz
{
    public interface IMatchType
    {
        public int noOfOvers();
        public int maxOverCountBowlers();
    }
}
