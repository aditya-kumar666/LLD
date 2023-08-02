namespace Snake_LadderGame
{
    internal class Dice
    {
        int diceCount;
        int min = 1;
        int max = 6;
        public Dice(int diceCount) {
            this.diceCount = diceCount;
        }

        public int rollDice()
        {
            int totalSum = 0;
            int diceUsed = 0;
            while (diceUsed < diceCount)
            {
                totalSum += new Random().Next(min, max+1);
                diceUsed++;
            }
            return totalSum;
        }
    }
}
