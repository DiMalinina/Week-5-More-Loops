using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajala sisestada kasutajatunnus ja salasõna
            //kui kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolid kuvatatakse "Tere tulemast!"
            //muul konsoolis kuvatatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset.

            int i = 0;
            

            while (i < 3)
            {
                Console.WriteLine("Siseta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta oma salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. {3 - i} katset on jäänud.Proovi uuesti.");
                }
                Console.WriteLine("Kena päeva!");
            }

                
        }
    }
}
