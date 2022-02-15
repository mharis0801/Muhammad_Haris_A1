using System;
namespace Muhammad_Haris_A1
{
    public class Game
    {
        public int Die1 { get; private set; }
        public int Die2 { get; private set; }
        public int TurnScore { get; private set; }
        public int OverallScore { get; private set; }
        public int PlayCount { get; private set; } = 0;


        public Game()
        {
        }
        
        public void Roll()
        {
            Random DieNumGen = new Random();
            Die1 = DieNumGen.Next(0, 7);
            Die2 = DieNumGen.Next(0, 7);

            if (Die1 == 6 & Die2 == 6)
            {
                TurnScore = 100;
            }
            else if (Die1 == Die2)
            {
                TurnScore = Die1 * 10;
            }
            else
                TurnScore = 0;

            OverallScore += TurnScore;
            PlayCount++;
        }
    }
}
