namespace Snake_LadderGame
{
    internal class Player
    {
        public string id;
        public int currentPosition;

        public Player(string id, int cp) {
            this.id = id;
            currentPosition = cp;
        }
    }
}
