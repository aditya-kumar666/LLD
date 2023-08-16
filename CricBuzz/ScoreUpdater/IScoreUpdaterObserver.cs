using CricBuzz.Innings;

namespace CricBuzz.ScoreUpdater
{
    public interface IScoreUpdaterObserver
    {
        public void update(BallDetails ballDetails);
    }
}
