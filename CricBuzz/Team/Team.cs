using CricBuzz.Team.Player;

namespace CricBuzz.Team
{
    public class Team
    {
        public string teamName;
        public Queue<PlayerDetails> playing11;
        public List<PlayerDetails> bench;
        public PlayerBattingController battingController;
        public PlayerBowlingController bowlingController;
        public bool isWinner;

        public Team(String teamName, Queue<PlayerDetails> playing11, List<PlayerDetails> bench, List<PlayerDetails> bowlers)
        {
            this.teamName = teamName;
            this.playing11 = playing11;
            this.bench = bench;
            battingController = new PlayerBattingController(playing11);
            bowlingController = new PlayerBowlingController(bowlers);
        }

        public string getTeamName()
        {
            return teamName;
        }

        public void chooseNextBatsMan()
        {
            battingController.getNextPlayer();
        }

        public void chooseNextBowler(int maxOverCountPerBowler)
        {
            bowlingController.getNextBowler(maxOverCountPerBowler);
        }

        public PlayerDetails getStriker()
        {
            return battingController.getStriker();
        }

        public PlayerDetails getNonStriker()
        {
            return battingController.getNonStriker();
        }

        public void setStriker(PlayerDetails player)
        {
            battingController.setStriker(player);
        }

        public void setNonStriker(PlayerDetails player)
        {
            battingController.setNonStriker(player);
        }

        public PlayerDetails getCurrentBowler()
        {
            return bowlingController.getCurrentBowler();
        }

        public void printBattingScoreCard()
        {

            foreach (PlayerDetails playerDetails in playing11)
            {
                playerDetails.printBattingScoreCard();
            }
        }

        public void printBowlingScoreCard()
        {

            foreach (PlayerDetails playerDetails in playing11)
            {
                if (playerDetails.bowlingScoreCard.totalOversCount > 0)
                {
                    playerDetails.printBowlingScoreCard();
                }
            }
        }

        public int getTotalRuns()
        {
            int totalRun = 0;
            foreach (PlayerDetails player in  playing11)
            {

                totalRun += player.battingScoreCard.totalRuns;
            }
            return totalRun;
        }

    }
}
