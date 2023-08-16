namespace CricBuzz.Team.Player
{
    public class PlayerBattingController
    {
        Queue<PlayerDetails> yetToPlay;
        PlayerDetails striker;
        PlayerDetails nonStriker;

        public PlayerBattingController(Queue<PlayerDetails> playing11)
        {
            yetToPlay = new Queue<PlayerDetails>();
            foreach (PlayerDetails player in playing11)
            {
                yetToPlay.Enqueue(player);
            }
        }

        public void getNextPlayer()
        {
            if (yetToPlay.Count == 0)
            {
                throw new Exception();
            }
            if(striker == null)
            {
                striker = yetToPlay.Dequeue();
            }
            if(nonStriker == null)
            {
                nonStriker = yetToPlay.Dequeue();
            }
        }

        public PlayerDetails getStriker()
        {
            return striker;
        }

        public PlayerDetails getNonStriker()
        {
            return nonStriker;
        }

        public void setNonStriker(PlayerDetails playerDetails)
        {
            nonStriker = playerDetails;
        }

        public void setStriker(PlayerDetails playerDetails)
        {
            striker = playerDetails;
        }
    }
}
