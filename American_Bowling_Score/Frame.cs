using System.Collections.Generic;

namespace American_Bowling_Score
{
    abstract public class Frame
    {
        protected List<int> throws;
        protected int startingThrow;

        public Frame(List<int> throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
        }

        abstract public int Score();
        abstract protected int FrameSize();

        protected int FirstBonusBall()
        {
            return throws[startingThrow + FrameSize()];
        }

        protected int SecondBonusBall()
        {
            return throws[startingThrow + FrameSize() + 1];
        }
    }
}