using System.Collections.Generic;
using American_Bowling_Score.Enums;

namespace American_Bowling_Score
{
    public class OpenFrame : Frame
    {

        public OpenFrame(List<int> throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int Score()
        {
            int score = 0;
            for(int pos= startingThrow; pos < (startingThrow+FrameSizeEnum.OpenFrame.GetHashCode()); pos++)
            {
                score += throws[pos];
            }
            //return throws[startingThrow] + throws[startingThrow + 1];
            return score;
        }

        override protected int FrameSize()
        {
            return FrameSizeEnum.OpenFrame.GetHashCode();
        }
    }
}