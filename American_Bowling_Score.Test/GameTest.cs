using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace American_Bowling_Score.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void AllOpenWithZero()
        {
            Game objGame = new Game();
            addFrames(objGame,1, 10, 0, 0);
            Assert.AreEqual(0, objGame.Score());
        }

        [TestMethod]
        public void AllOpenwithFive()
        {
            Game objGame = new Game();
            addFrames(objGame,1, 10, 5, 5);
            Assert.AreEqual(100, objGame.Score());
        }

        [TestMethod]
        public void Spare_One()
        {
            Game objGame = new Game();
            objGame.Spare(3, 7);
            objGame.OpenFrame(6, 2);
            addFrames(objGame,1, 8, 0, 0);
            Assert.AreEqual(24, objGame.Score());
        }

        [TestMethod]
        public void Spare_Two()
        {
            Game objGame = new Game();
            objGame.Spare(3, 7);
            objGame.OpenFrame(5, 2);
            addFrames(objGame,1, 8, 0, 0);
            Assert.AreEqual(22, objGame.Score());
        }

        [TestMethod]
        public void Spare_at_End()
        {
            Game objGame = new Game();
            addFrames(objGame,1, 9, 0, 0);
            objGame.Spare(4,6);
            objGame.BonusRoll(4);            
            Assert.AreEqual(14, objGame.Score());
        }


        [TestMethod]
        public void Strike_First()
        {
            Game objGame = new Game();
            objGame.Strike();
            objGame.OpenFrame(5, 2);
            addFrames(objGame,1, 8, 0, 0);
            Assert.AreEqual(24, objGame.Score());
        }

        [TestMethod]
        public void Strike_at_End()
        {
            Game objGame = new Game();
            addFrames(objGame,1, 9, 0, 0);
            objGame.Strike();
            objGame.BonusRoll(4);
            objGame.BonusRoll(3);
            Assert.AreEqual(17, objGame.Score());
        }

        [TestMethod]
        public void AllStrike()
        {
            Game objGame = new Game();
            addFrames(objGame, 3, 10);
            objGame.BonusRoll(10);
            objGame.BonusRoll(10);
            Assert.AreEqual(300, objGame.Score());
        }

        [TestMethod]
        public void AlternateStrikeSpare()
        {
            Game objGame = new Game();
            for(int i=0;i<5;i++)
            {
                objGame.Strike();
                objGame.Spare(7,3);
            }
            objGame.BonusRoll(10);
            Assert.AreEqual(200, objGame.Score());
        }


        internal Game addFrames(Game objGame,int frameType, int count,int firstThrow=0,int secondThrow=0)
        {
            switch(frameType)
            { 
                case 1:
                     for (int i = 0; i < count; i++) {
                         objGame.OpenFrame(firstThrow, secondThrow);
                     };
                    break;
                case 2:
                    for (int i = 0; i < count; i++)
                    {
                        objGame.Spare(firstThrow, secondThrow);
                    };
                    break;
                case 3:
                    for (int i = 0; i < count; i++)
                    {
                        objGame.Strike();
                    };
                    break;

            }
            return objGame;
        }
    }
}
