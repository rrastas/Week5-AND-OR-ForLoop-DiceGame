using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."            
            //kasutajal on kolm katset


            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta oma kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta oma salaõna:");
                string userPassword = Console.ReadLine();

                if(userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    i = 3;
                }

                else if (i < 2)
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti. Katseid jäänud {3-i}");
                }

                else
                {
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Katsed otsas. ");
                    i = 3;
                }
            }

            
        }
    }
}
