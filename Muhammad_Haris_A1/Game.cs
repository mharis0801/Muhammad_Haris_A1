using System;
using System.Collections.Generic;

namespace Muhammad_Haris_A1
{
    public class Game
    {
        public int Die1 { get; private set; }
        public int Die2 { get; private set; }
        public int TurnScore { get; private set; }
        public int OverallScore { get; private set; }
        public int PlayCount { get; private set; }
        List<int> Scores = new List<int>();
        


        public Game()
        {
            Roll();

            PlayCount = 0;
        }
        
        public void Roll()
        {
            Random DieNumGen = new Random();
            Die1 = DieNumGen.Next(1, 7);
            Die2 = DieNumGen.Next(1, 7);
            PlayCount++;

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

           

            OverallScore = TurnScore + OverallScore;
            Scores.Add(OverallScore);
            

            
            
        }
        public void Restart()
        {
            if (PlayCount == 10)
            {

                
                OverallScore = 0;
                PlayCount = 0;
            }
            else
                return;
        }
    }
}
