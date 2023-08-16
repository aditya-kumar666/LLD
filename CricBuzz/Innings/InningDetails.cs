using CricBuzz.Team.Player;
using System;
using team = CricBuzz.Team;
namespace CricBuzz.Innings
{
    public class InningDetails
    {
        team.Team battingTeam;
        team.Team bowlingTeam;
        IMatchType matchType;
        List<OverDetails> overs;

        public InningDetails(team.Team battingTeam, team.Team bowlingTeam, IMatchType matchType)
        {
            this.battingTeam = battingTeam;
            this.bowlingTeam = bowlingTeam;
            this.matchType = matchType;
            overs = new ();
        }

        public void start(int runsToWin)
        {
            battingTeam.chooseNextBatsMan();
            int noOfOvers = matchType.noOfOvers();
            for (int overNumber = 1; overNumber <= noOfOvers; overNumber++)
            {

                //chooseBowler
                bowlingTeam.chooseNextBowler(matchType.maxOverCountBowlers());

                OverDetails over = new OverDetails(overNumber, bowlingTeam.getCurrentBowler());
                overs.Add(over);
                try
                {
                    bool won = over.startOver(battingTeam, bowlingTeam, runsToWin);
                    if (won == true)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    break;
                }

                //swap striket and non striker
                PlayerDetails temp = battingTeam.getStriker();
                battingTeam.setStriker(battingTeam.getNonStriker());
                battingTeam.setNonStriker(temp);
            }

        }

        public int getTotalRuns()
        {
            return battingTeam.getTotalRuns();
        }

    }
}
