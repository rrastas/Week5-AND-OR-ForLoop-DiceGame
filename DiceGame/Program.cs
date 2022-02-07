using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontollib, kumb mängja viskas rohkem
            //mängija, kes viskab rohkem, ongi mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            int cpuScore = 0;
            int userScore = 0;


            for (int i = 0; i < 3; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja saab punkti.");
                    Console.WriteLine();
                    userScore = userScore + 1;
                }

                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti saab punkti.");
                    Console.WriteLine();
                    cpuScore = cpuScore + 1;
                }

                else
                {
                    Console.WriteLine("Viik!");
                    Console.WriteLine();
                }
            }
         
            //Mängu tulemus
            Console.WriteLine($"Kasutaja tulemus {userScore}, arvuti tulemus {cpuScore}");

            if (userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja võitis mängu. Palju õnne!");
            }

            else if (userScore < cpuScore)
            {
                Console.WriteLine("Mängu võitis arvuti.");
            }

            else
            {
                Console.WriteLine("Mäng jäi viiki.");
            }

        }
    }
}
