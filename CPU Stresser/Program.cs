using System;
using System.Threading;

namespace CPU_Stresser
{
    class Program
    {
        private static bool running = true;
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 1)
            {
                Console.Title = "C# CPU Stresser";
                Console.WriteLine("C# CPU Stresser");
                Console.Write("Enter ammount of threads [1 - 500]: ");
                string input = Console.ReadLine();
                try
                {
                    n = int.Parse(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                }
                if (n > 500)
                {
                    Console.WriteLine("Too many threads");
                    n = 0;
                }
            }
            Console.Write("Starting threads: ");
            Console.ForegroundColor = ConsoleColor.Red;
            ThreadStart ts = new ThreadStart(burn);
            for (int i = 0; i < n; i++)
            {
                Thread burnThread = new Thread(ts);
                burnThread.Start();
                Console.Write((i + 1) + " ");
            }
            Console.ResetColor();
            Console.WriteLine("\nAll threads started.");
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
            running = false;
        }

        private static void burn()
        {
            while (true)
            {
                if (!running) break;
            }
        }
    }
}