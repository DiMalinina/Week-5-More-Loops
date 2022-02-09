using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajala sisestada kasutajatunnus ja salasõna
            //kui kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolid kuvatatakse "Tere tulemast!"
            //muul konsoolis kuvatatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            Console.WriteLine("Siseta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma salasõna:");
            string userPassword = Console.ReadLine();

            // AND (&&) 

            //"admin" AND "andmin1234" --> true
            //"admin1" AND "andmin1234" --> false
            //"admin" AND "andmin12345" --> false
            //"admin1" AND "andmin123" --> false

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
