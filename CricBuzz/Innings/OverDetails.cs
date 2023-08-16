using CricBuzz.Team.Player;
using team = CricBuzz.Team;

namespace CricBuzz.Innings
{
    public class OverDetails
    {
        int overNumber;
        List<BallDetails> balls;
        int extraBallCount;
        public PlayerDetails bowledBy;

        public OverDetails(int overNumber, PlayerDetails bowledBy)
        {
            this.overNumber = overNumber;
            balls = new ();
            this.bowledBy = bowledBy;
        }

        public bool startOver(team.Team battingTeam, team.Team bowlingTeam, int runsToWin)
        {

            int ballCount = 1;
            while(ballCount<=6){
                BallDetails ball = new BallDetails(ballCount);
                ball.startBallDelivery(battingTeam, bowlingTeam, this);
                if(ball.ballType == BallType.NORMAL) {
                    balls.Add(ball);
                    ballCount++;
                    if(ball.wicket != null) {
                        battingTeam.chooseNextBatsMan();
                    }

                   if(runsToWin != -1 && battingTeam.getTotalRuns() >= runsToWin){
                       battingTeam.isWinner = true;
                       return true;
                   }
                }
                else
                {
                    extraBallCount++;
                }
            }

            return false;
        }

    }
}
