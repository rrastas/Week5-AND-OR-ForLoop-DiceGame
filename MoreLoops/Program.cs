﻿using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."            

            //AND (&&)

            //AND -> "admin" AND "admin1234" --> true
            //AND -> "admin1" AND "admin1234" --> false
            //AND -> "admin" AND "admin12345" --> false
            //AND -> "admin1" AND "admin123" --> false

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }

        }
    }
}