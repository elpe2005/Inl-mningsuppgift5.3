using System;

namespace uppgift51
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "Vad heter Sveriges huvudstad?", "vilket spel är bättre Rust eller Ark?", "Vad är bästa vapnet i CS?", "Vad är Tysklands huvudstad?" };
            string[] svar = { "Stockholm".ToLower(), "Rust".ToLower(), "ak".ToUpper(), "Berlin".ToLower() };
            Console.WriteLine("Välj ett tal mellan 1-4, Det är olika frågor på varje");
            int val = int.Parse(Console.ReadLine());
            bool fel = true;

            switch (val)
            {
                case 1:
                    Console.WriteLine(frågor[0]);
                    string svar1 = Console.ReadLine();
                    if (svar1 == svar[0])
                    {
                        Console.WriteLine("Du har rätt");
                        fel = false;
                    }
                    break;
                case 2:
                    Console.WriteLine(frågor[1]);
                    string svar2 = Console.ReadLine();
                    if (svar2 == svar[1])
                    {
                        Console.WriteLine("Du har rätt");
                        fel = false;
                    }
                    break;
                case 3:
                    Console.WriteLine(frågor[2]);
                    string svar3 = Console.ReadLine();
                    if (svar3 == svar[2])
                    {
                        Console.WriteLine("Du har rätt");
                        fel = false;
                    }
                    break;
                case 4:
                    Console.WriteLine(frågor[3]);
                    string svar4 = Console.ReadLine();
                    if (svar4 == svar[3])
                    {
                        Console.WriteLine("Du har rätt");
                        fel = false;
                    }
                    break;
                default:
                    break;
            } 
            if (fel == true)
            {
                Console.WriteLine("Du har fel");
            }
        }
    }
}