using System;

namespace TicTacToe
{
    internal class TicTacToeGame
    {
        LinkedList<Player> players;
        Board gameBoard;
        string winner = null;
        public TicTacToeGame()
        {
            players = new LinkedList<Player>();
            gameBoard = new Board(3);
            initializeGame();
        }
        public void initializeGame()
        {
            PlayingPieceX crossPiece = new PlayingPieceX();
            Player player1= new Player("player1", crossPiece);
            PlayingPieceO noughtPiece = new PlayingPieceO();
            Player player2 = new Player("player2", noughtPiece);
            players.AddLast(player1);
            players.AddLast(player2);
        }

        Player findPlayerTurn()
        {
            Player p = players.First();
            players.RemoveFirst();
            players.AddLast(p);
            return p;
        }

        public string startGame()
        {
            while(winner == null)
            {
                Player playerTurn = findPlayerTurn();

                gameBoard.printBoard();
                var freeSpaces = gameBoard.getFreeCells();
                if(freeSpaces.Count == 0)
                {
                    winner = "tie";
                }

                //read user input
                Console.Write("Player:" + playerTurn.name + " Enter row,column: ");
                string s = Console.ReadLine();
                string[] values = s.Split(',');
                int r = Convert.ToInt32(values[0]);
                int c = Convert.ToInt32(values[1]);

                //place the piece
                var pieceAddesSuccessfully = gameBoard.addPiece(r, c, playerTurn.getPlayingPiece());
                if (!pieceAddesSuccessfully)
                {
                    Console.WriteLine("Incorret position chosen, try again");
                    players.RemoveLast();
                    players.AddFirst(playerTurn);
                    continue;
                }

                if(isThereWinner(r,c, playerTurn.getPlayingPiece().pieceType))
                {
                    winner = playerTurn.name;
                }
            }
            return winner;
        }

        public bool isThereWinner(int row, int column, PieceType pieceType)
        {
            bool rowMatch = true;
            bool columnMatch = true;
            bool diagonalMatch = true;
            bool antiDiagonalMatch = true;

            //need to check in row
            for (int i = 0; i < gameBoard.size; i++)
            {
                if (gameBoard.board[row][i] == null || gameBoard.board[row][i].pieceType != pieceType)
                {
                    rowMatch = false;
                }
            }

            //need to check in column
            for (int i = 0; i < gameBoard.size; i++)
            {
                if (gameBoard.board[i][column] == null || gameBoard.board[i][column].pieceType != pieceType)
                {
                    columnMatch = false;
                }
            }

            //need to check diagonals
            for (int i = 0, j = 0; i < gameBoard.size; i++, j++)
            {
                if (gameBoard.board[i][j] == null || gameBoard.board[i][j].pieceType != pieceType)
                {
                    diagonalMatch = false;
                }
            }

            //need to check anti-diagonals
            for (int i = 0, j = gameBoard.size - 1; i < gameBoard.size; i++, j--)
            {
                if (gameBoard.board[i][j] == null || gameBoard.board[i][j].pieceType != pieceType)
                {
                    antiDiagonalMatch = false;
                }
            }

            return rowMatch || columnMatch || diagonalMatch || antiDiagonalMatch;
        }
    }
}
