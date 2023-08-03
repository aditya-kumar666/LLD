namespace TicTacToe
{
    internal class Board
    {
        public int size;
        public List<List<PlayingPiece>> board;

        public Board(int size)
        {
            this.size = size;
            board = new List<List<PlayingPiece>>();
            initializeCells(size);
        }

        public void initializeCells(int boardSize)
        {
            board = new List<List<PlayingPiece>>();

            for (int i = 0; i < boardSize; i++)
            {
                board.Add(new List<PlayingPiece>());
            }

            foreach (var list in board)
            {
                for (int i = 0; i < boardSize; i++)
                {
                    list.Add(null);
                }
            }
        }

        public bool addPiece(int r, int c, PlayingPiece piece)
        {
            if (board[r][c] != null) return false;
            board[r][c] = piece;
            return true;
        }

        public List<(int, int)> getFreeCells()
        {
            List<(int, int)> freeCells = new();

            for(int i = 0; i < size; i++)
            {
                for(int j= 0; j < size; j++)
                {
                    if (board[i][j] == null)
                    {
                        freeCells.Add(new(i, j));
                    }
                }
            }
            return freeCells;
        }

        public void printBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i][j] != null)
                    {
                        Console.Write(board[i][j].pieceType.ToString() + "   ");
                    }
                    else
                    {
                        Console.Write("    ");

                    }
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

    }
}
