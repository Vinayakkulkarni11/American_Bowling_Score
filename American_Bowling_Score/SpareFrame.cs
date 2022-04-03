using System.Collections.Generic;
using American_Bowling_Score.Enums;

namespace American_Bowling_Score
{
    public class SpareFrame : Frame
    {
        public SpareFrame(List<int> throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int Score()
        {
            return FramePointEnum.SpareFrame.GetHashCode() + FirstBonusBall(); ;
        }

        override protected int FrameSize()
        {
            return FrameSizeEnum.SpareFrame.GetHashCode();
        }
    }

}