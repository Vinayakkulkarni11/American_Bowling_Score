using System;

namespace American_Bowling_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Game objGame;

            objGame = new Game();
            Console.WriteLine("Game 1 - All open frames with zero pins down");
            addFrames(objGame, 1, 10, 0, 0);
            Console.WriteLine("Game 1 - Score {0}",objGame.Score());
            Console.WriteLine();

            objGame = new Game();
            Console.WriteLine("Game 2 - All open frames with 5 pins down in each throw");
            addFrames(objGame, 1, 10, 5, 5);
            Console.WriteLine("Game 2 - Score {0}", objGame.Score());
            Console.WriteLine();

            objGame = new Game();
            Console.WriteLine("Game 3 - All strike frames and 10 pins down in both bonus rolls");
            addFrames(objGame, 3, 10);
            objGame.BonusRoll(10);
            objGame.BonusRoll(10);
            Console.WriteLine("Game 3 - Score {0}", objGame.Score());
            Console.WriteLine();

            objGame = new Game();
            Console.WriteLine("Game 4 - All spare frames and 10 pins down in a bonus roll");
            addFrames(objGame, 2, 10,3,7);
            objGame.BonusRoll(10);
            Console.WriteLine("Game 4 - Score {0}", objGame.Score());
            Console.WriteLine();

            Console.WriteLine("Thanks");

            Console.ReadLine();

        }

        internal static Game addFrames(Game objGame, int frameType, int count, int firstThrow=0, int secondThrow=0)
        {
            switch (frameType)
            {
                case 1:
                    for (int i = 0; i < count; i++)
                    {
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
