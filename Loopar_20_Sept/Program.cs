using System.Diagnostics.Metrics;

namespace Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EttTillTio();
            //FemTillTretton();
            //FemtonTillSju();
            //Lösenord();
            Lösenord2();
        }

        static void EttTillTio()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void FemTillTretton()
        {
            for (int i = 5; i < 13; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void FemtonTillSju()
        {
            int counter = 16;
            while (counter-- > 7)
            {
                Console.WriteLine(counter);
            }
        }

        static void Lösenord()
        {
            string password = "abc123";
            string svar = "";
            int counter = 0;

            Console.WriteLine("Ange ditt lösenord: ");
            svar = Console.ReadLine();

            while (svar != password)
            {
                Console.WriteLine("Ange ditt lösenord: ");
                svar = Console.ReadLine();
                counter++;
                Console.WriteLine($"Password incorrect, this is your {counter} try out of 3");

                while (counter > 3)
                {
                    Console.WriteLine("Too many attempt!");
                    break;
                }
            }

            while (svar == password)
            {
                Console.WriteLine("Nice, you're now logged in!");
                break;
            }
        }

        static void Lösenord2()
        {
            int tries = 3;
            string password = "abc123";
            string input = "";
            while (tries > 0)
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine("Password correct");
                     // Avbryt körningen
                }
                else
                {
                    Console.WriteLine("Password incorrect");
                    tries--;
                }
                Console.WriteLine();
            }
            if (tries == 0)
            {
                Console.WriteLine("Too many attempts");
            }
            else
            {
                Console.WriteLine("Password correct");
            }
        }




    }
}