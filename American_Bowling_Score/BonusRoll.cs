using System.Collections.Generic;
using American_Bowling_Score.Enums;

namespace American_Bowling_Score
{
    public class BonusRoll : Frame
    {

        public BonusRoll(List<int> throws, int firstThrow) : base(throws)
        {
            throws.Add(firstThrow);
        }

        override public int Score()
        {
            return FramePointEnum.BonusRoll.GetHashCode(); ;
        }

        override protected int FrameSize()
        {
            return FrameSizeEnum.BonusRoll.GetHashCode();
        }
    }
}