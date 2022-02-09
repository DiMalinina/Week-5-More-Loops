using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus oaleb kaks mängijat - aruti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //programm kuulutab võtjat
            //täringuid vasatakse kolm korda

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);
            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;
            int i = 0;

            while (i < 3)

            {
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                if (cpuRandom < userRandom)
                {
                    userScore++;
                }
                else
                {
                    cpuScore++;
                }
                cpuRandom = rnd.Next(1, 7);
                userRandom = rnd.Next(1, 7);

                i++;
                
            }
            if (userScore > cpuScore)
            {
                Console.WriteLine("User wins. Congratulations!");
            }
            else
            {
                Console.WriteLine("Computer wins.Congratulations!");
            }

            

        }
    }
}