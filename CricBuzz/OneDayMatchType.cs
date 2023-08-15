namespace CricBuzz
{
    public class OneDayMatchType : IMatchType
    {
        public int noOfOvers() {
            return 50;
        }

        public int maxOverCountBowlers()
        {
            return 10;
        }
    }
}
