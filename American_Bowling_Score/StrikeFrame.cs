using System.Collections.Generic;
using American_Bowling_Score.Enums;

namespace American_Bowling_Score
{
    public class StrikeFrame : Frame
    {

        public StrikeFrame(List<int> throws) : base(throws)
        {
            throws.Add(FramePointEnum.StrikeFrame.GetHashCode());
        }

        override public int Score()
        {
            return FramePointEnum.StrikeFrame.GetHashCode() + FirstBonusBall() + SecondBonusBall();
        }

        override protected int FrameSize()
        {
            return FrameSizeEnum.StrikeFrame.GetHashCode();
        }
    }
}