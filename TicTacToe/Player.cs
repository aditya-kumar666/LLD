namespace TicTacToe
{
    internal class Player
    {
        public string name;
        public PlayingPiece playingPiece;
        public Player(string name, PlayingPiece piece)
        {
            this.name = name;
            this.playingPiece = piece;
        }

        public string getName()
        {
            return name;
        }
        public PlayingPiece getPlayingPiece()
        {
            return playingPiece;
        }
        public void setName(string name) { this.name = name.Trim(); }

        public void setPlayingPiece(PlayingPiece piece) {  this.playingPiece = piece; }
    }
}
