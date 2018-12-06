using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nr = new Random();

            int val = nr.Next(0, 101); //Valoarea random aleasa de program//
            int gval = 0; //Valoarea care trebuie pusa de utilizator//
            bool correct = false;

            Console.WriteLine("Am ales un numar intre 0 si 100.");

            while (!correct)
            {
                Console.Write("Ghiceste numarul pe care l-am ales: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out gval))
                {
                    Console.WriteLine("Acesta nu este un numar.");
                    continue;
                }

                if (gval < val)
                {
                    Console.WriteLine("Numarul este mai mare.");
                }
                else if (gval > val)
                {
                    Console.WriteLine("Numarul este mai mic.");
                }
                else
                {
                    Console.WriteLine("Felicitari, ai ghicit numarul!");
                    correct = true;
                    continue;

                }
            }
        }
    }
}
