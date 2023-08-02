namespace Snake_LadderGame
{
    internal class Board
    {
        public List<List<Cell>> cells;
        public Board(int boardSize, int noOfSnakes, int noOfLadders)
        {
            initializeCells(boardSize);
            addSnakeAndLadder(cells, noOfSnakes, noOfLadders);
        }

        public void initializeCells(int boardSize)
        {
            cells = new List<List<Cell>>();

            for(int i=0; i<boardSize; i++)
            {
                cells.Add(new List<Cell>());
            }

            foreach (var list in cells) {
                for(int i=0; i<boardSize; i++)
                {
                    list.Add(new Cell());
                }
            }
        }

        public void addSnakeAndLadder(List<List<Cell>> cells, int noOfSnakes, int noOfLadders)
        {
            while (noOfSnakes > 0)
            {
                int snakeHead = new Random().Next(1, cells.Count * cells.Count);
                int snakeTail = new Random().Next(1, cells.Count * cells.Count);
                if(snakeHead <= snakeTail) { continue; }

                Jump snake = new Jump();
                snake.start = snakeHead;
                snake.end = snakeTail;

                Cell snakeCell = getCell(snakeHead);
                snakeCell.jump = snake;

                noOfSnakes--;
            }

            while (noOfLadders > 0)
            {
                int ladderStart = new Random().Next(1, cells.Count * cells.Count-1);
                int ladderEnd = new Random().Next(1, cells.Count * cells.Count-1);
                if(ladderStart >= ladderEnd) { continue; }

                Jump ladder = new Jump();
                ladder.start = ladderStart;
                ladder.end = ladderEnd;

                Cell ladderCell = getCell(ladderStart);
                ladderCell.jump = ladder;

                noOfLadders--;
            }
        }

        public Cell getCell(int playerPosition)
        {
            int r = playerPosition/cells.Count;
            int c = playerPosition%cells.Count;
            return cells[r][c];
        }
    }
}
