using System;

namespace OrOperator
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

            // OR (||) 

            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //"admin1" != "admin" || "admin1234" != "admin1234" --> true || false --> true
            //"admin" != "admin" || "admin123" != "admin1234" --> false || true --> true
            //"admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
            //"admin" != "admin" || "admin1234" != "admin1234" --> false || false --> false
        }
    }
}
