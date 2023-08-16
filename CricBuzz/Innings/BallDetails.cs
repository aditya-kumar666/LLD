using CricBuzz.Team.Player;
using CricBuzz.Team;
using team = CricBuzz.Team;
using System;
using CricBuzz.ScoreUpdater;

namespace CricBuzz.Innings
{
    public class BallDetails
    {
        public int ballNumber;
        public BallType ballType;
        public RunType runType;
        public PlayerDetails playedBy;
        public PlayerDetails bowledBy;
        public Wicket wicket;
        List<IScoreUpdaterObserver> scoreUpdaterObserverList = new ();

        public BallDetails(int ballNumber)
        {
            this.ballNumber = ballNumber;
            scoreUpdaterObserverList.Add(new BowlingScoreUpdater());
            scoreUpdaterObserverList.Add(new BattingScoreUpdater());
        }

        public void startBallDelivery(team.Team battingTeam, team.Team bowlingTeam, OverDetails over)
        {

            playedBy = battingTeam.getStriker();
            this.bowledBy = over.bowledBy;
            //THROW BALL AND GET THE BALL TYPE, assuming here that ball type is always NORMAL
            ballType = BallType.NORMAL;

            //wicket or no wicket
            if (isWicketTaken())
            {
                runType = RunType.ZERO;
                //considering only BOLD
                wicket = new Wicket(WicketType.Bold, bowlingTeam.getCurrentBowler(), over, this);
                //making only striker out for now
                battingTeam.setStriker(null);
            }
            else
            {
                runType = getRunType();

                if (runType == RunType.ONE || runType == RunType.THREE)
                {
                    //swap striket and non striker
                    PlayerDetails temp = battingTeam.getStriker();
                    battingTeam.setStriker(battingTeam.getNonStriker());
                    battingTeam.setNonStriker(temp);
                }
            }

            //update player scoreboard
            notifyUpdaters(this);
        }

        private void notifyUpdaters(BallDetails ballDetails)
        {

            foreach (IScoreUpdaterObserver observer in scoreUpdaterObserverList)
            {
                observer.update(ballDetails);
            }
        }


        private bool isWicketTaken()
        {
            //random function return value between 0 and 1
            if (new Random().Next() < 0.2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private RunType getRunType()
        {

            double val = new Random().Next();
            if (val <= 0.2)
            {
                return RunType.ONE;
            }
            else if (val >= 0.3 && val <= 0.5)
            {
                return RunType.TWO;
            }
            else if (val >= 0.6 && val <= 0.8)
            {
                return RunType.FOUR;
            }
            else
            {
                return RunType.SIX;
            }
        }


    }
}
