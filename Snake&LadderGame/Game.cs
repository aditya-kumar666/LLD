namespace Snake_LadderGame
{
    internal class Game
    {
        Board board;
        Dice dice;
        Player winner;
        LinkedList<Player> players = new LinkedList<Player>();

        public Game()
        {
            initializeGame();
        }

        void initializeGame()
        {
            board = new Board(10,5,4);
            dice = new Dice(1);
            winner = null;
            addPlayers();
        }

        void addPlayers()
        {
            Player pl1 = new Player("p1", 0);
            Player pl2 = new Player("p2", 0);
            players.AddLast(pl1);
            players.AddLast(pl2);
        }

        Player findPlayerTurn()
        {
            Player p = players.First();
            players.RemoveFirst();
            players.AddLast(p);
            return p;
        }

        int jumpCheck(int playerPosition)
        {
            if(playerPosition > board.cells.Count * board.cells.Count-1)
            {
                return playerPosition;
            }

            Cell cell = board.getCell(playerPosition);
            if(cell.jump != null && cell.jump.start == playerPosition)
            {
                string jumpBy = (cell.jump.start < cell.jump.end) ? "ladder" : "snake";
                Console.WriteLine("jump done by: " + jumpBy);
                playerPosition = cell.jump.end;
            }
            return playerPosition;
        }

        public void startGame()
        {
            while(winner == null)
            {
                Player p = findPlayerTurn();
                Console.WriteLine("player turn is:" + p.id + " current position is: " + p.currentPosition);

                int diceNo = dice.rollDice();

                p.currentPosition += diceNo;
                p.currentPosition = jumpCheck(p.currentPosition);
                Console.WriteLine("player turn is:" + p.id + " new Position is: " + p.currentPosition);

                if (p.currentPosition > board.cells.Count * board.cells.Count-1)
                {
                    winner = p;
                }
            }
            Console.WriteLine("WINNER IS:" + winner.id);
        }
    }
}
