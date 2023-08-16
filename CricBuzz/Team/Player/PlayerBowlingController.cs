using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBuzz.Team.Player
{
    public class PlayerBowlingController
    {
        Queue<PlayerDetails> bowlersList;
        Dictionary<PlayerDetails, int> bowlerVsOverCount;
        PlayerDetails currentBowler;

        public PlayerBowlingController(List<PlayerDetails> bowlers)
        {
            setBowlersList(bowlers);
        }

        private void setBowlersList(List<PlayerDetails> bowlersList)
        {
            this.bowlersList = new Queue<PlayerDetails>();
            bowlerVsOverCount = new();
            foreach (PlayerDetails bowler in bowlersList)
            {
                this.bowlersList.Enqueue(bowler);
                bowlerVsOverCount.Add(bowler, 0);
            }
        }

        public void getNextBowler(int maxOverCountPerBowler)
        {

            PlayerDetails playerDetails = bowlersList.Dequeue();
            if (bowlerVsOverCount[playerDetails] + 1 == maxOverCountPerBowler)
            {
                currentBowler = playerDetails;
            }
            else
            {
                currentBowler = playerDetails;
                bowlersList.Enqueue(playerDetails);
                bowlerVsOverCount.Add(playerDetails, bowlerVsOverCount[playerDetails] + 1);
            }
        }

        public PlayerDetails getCurrentBowler()
        {
            return currentBowler;
        }
    }
}
