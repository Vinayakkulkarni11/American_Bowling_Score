using System.Collections.Generic;

namespace American_Bowling_Score
{
    public class Game
    {
        List<int> throws;
        List<Frame> frames;

        public Game()
        {
            throws = new List<int>();
            frames = new List<Frame>();
        }

        public void OpenFrame(int firstThrow, int secondThrow)
        {
            frames.Add(new OpenFrame(throws, firstThrow, secondThrow));
        }

        public void Spare(int firstThrow, int secondThrow)
        {
            frames.Add(new SpareFrame(throws, firstThrow, secondThrow));
        }

        public void Strike()
        {
            frames.Add(new StrikeFrame(throws));
        }

        public void BonusRoll(int roll)
        {
            frames.Add(new BonusRoll(throws, roll));
        }

        public int Score()
        {
            int total = 0;
            foreach (Frame frame in frames)
                total += frame.Score();
            return total;
        }
    }
}