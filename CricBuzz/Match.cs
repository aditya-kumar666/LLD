using CricBuzz.Innings;
using System;
using team = CricBuzz.Team;

namespace CricBuzz
{
    public class Match
    {
        team.Team teamA;
        team.Team teamB;
        DateTime? matchDate;
        String venue;
        team.Team tossWinner;
        InningDetails[] innings;
        IMatchType matchType;

        public Match(team.Team teamA, team.Team teamB, DateTime? matchDate, String venue, IMatchType matchType)
        {

            this.teamA = teamA;
            this.teamB = teamB;
            this.matchDate = matchDate;
            this.venue = venue;
            this.matchType = matchType;
            innings = new InningDetails[2];
        }

        public void startMatch()
        {

            //1. Toss
            tossWinner = toss(teamA, teamB);

            //start The Inning, there are 2 innings in a match
            for (int inning = 1; inning <= 2; inning++)
            {

                InningDetails inningDetails;
                team.Team bowlingTeam;
                team.Team battingTeam;

                //assuming here that tossWinner batFirst
                if (inning == 1)
                {
                    battingTeam = tossWinner;
                    bowlingTeam = tossWinner.getTeamName().Equals(teamA.getTeamName()) ? teamB : teamA;
                    inningDetails = new InningDetails(battingTeam, bowlingTeam, matchType);
                    inningDetails.start(-1);

                }
                else
                {
                    bowlingTeam = tossWinner;
                    battingTeam = tossWinner.getTeamName().Equals(teamA.getTeamName()) ? teamB : teamA;
                    inningDetails = new InningDetails(battingTeam, bowlingTeam, matchType);
                    inningDetails.start(innings[0].getTotalRuns());
                    if (bowlingTeam.getTotalRuns() > battingTeam.getTotalRuns())
                    {
                        bowlingTeam.isWinner = true;
                    }
                }


                innings[inning - 1] = inningDetails;

                //print inning details
                Console.WriteLine();
                Console.WriteLine("INNING " + inning + " -- total Run: " + battingTeam.getTotalRuns());
                Console.WriteLine("---Batting ScoreCard : " + battingTeam.teamName + "---");

                battingTeam.printBattingScoreCard();

                Console.WriteLine();
                Console.WriteLine("---Bowling ScoreCard : " + bowlingTeam.teamName + "---");
                bowlingTeam.printBowlingScoreCard();

            }

            Console.WriteLine();
            if (teamA.isWinner)
            {
                Console.WriteLine("---WINNER---" + teamA.teamName);

            }
            else
            {
                Console.WriteLine("---WINNER---" + teamB.teamName);

            }

        }


        private team.Team toss(team.Team teamA, team.Team teamB)
        {
            //random function return value between 0 and 1
            if (new Random().Next() < 0.5)
            {
                return teamA;
            }
            else
            {
                return teamB;
            }
        }

    }
}
