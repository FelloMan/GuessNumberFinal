using System;

namespace GuessNumberFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer.Kan du gissa vilket ? Du får fem försök.");
            Random random = new Random();
            int number = random.Next(1, 20);
            int attempts = 0;
            int Lastattempts = -1;
            bool run = true;

            while (run)
            {
                Console.WriteLine("Välj en siffra mellan 1-20");
                int gissning = int.Parse(Console.ReadLine());
                {
                    if (gissning < number)

                        if (attempts < 4)
                        {
                            int tries = number;
                            while (tries == Lastattempts)
                            {
                                tries = number;
                            }
                            attempts++;

                        }
                        else
                        {
                            Console.WriteLine("Tyvärr inga försök kvar");
                            Console.ReadLine();
                            System.Environment.Exit(1);
                        }
                }

                if (gissning < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt");
                    run = true;
                }
                else if (gissning > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt");
                    run = true;
                }
                else
                {
                    run = false;
                    Console.WriteLine("Woho! Du gjorde det!");
                }
            }
        }
    }
}