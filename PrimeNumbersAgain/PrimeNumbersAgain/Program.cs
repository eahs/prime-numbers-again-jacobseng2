using System;
using System.Data;
using System.Diagnostics;

namespace PrimeNumbersAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, prime;
            Stopwatch timer = new Stopwatch();

            PrintBanner();
            n = GetNumber();

            timer.Start();
            prime = FindNthPrime(n);
            timer.Stop();
            
            
            Console.WriteLine($"\nToo easy.. {prime} is the nth prime when n is {n}. I found that answer in {timer.Elapsed.Seconds} seconds.");

            EvaluatePassingTime(timer.Elapsed.Seconds);
        }

        static int FindNthPrime(int n)
        {
            int primeCount = 1;
<<<<<<< HEAD
            int prime = 2;
            for (int i = 3;  primeCount < n; i = i + 2)
            {
                if (CheckPrime(i) == true)
                {
                    primeCount++;
                    prime = i;
                    //Console.WriteLine(i + " ");
                }
            }
            return prime;
        }

        static bool CheckPrime(int num)
        {
            if (num % 2 != 0)
            {
                for (int i = 3; i <= Math.Sqrt(num); i = i + 2)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
=======
            for (int i = 3;  primeCount <= n; i = i + 2)
            {
                int divCount = 0;
                for (int div = 2; div <= Math.Sqrt(i); div++)
                {
                    if (i % div == 0)
                    {
                        divCount++;
                    }
                }

                if (divCount == 0)
                {
                    primeCount++;
                }

                if (primeCount == n)
                {
                    return i;
                }
            }

            return 0;
>>>>>>> main
        }
        

        static int GetNumber()
        {
            int n = 0;
            while (true)
            {
                Console.Write("Which nth prime should I find?: ");
                
                string num = Console.ReadLine();
                if (Int32.TryParse(num, out n))
                {
                    return n;
                }

                Console.WriteLine($"{num} is not a valid number.  Please try again.\n");
            }
        }

        static void PrintBanner()
        {
            Console.WriteLine(".................................................");
            Console.WriteLine(".#####...#####...######..##...##..######...####..");
            Console.WriteLine(".##..##..##..##....##....###.###..##......##.....");
            Console.WriteLine(".#####...#####.....##....##.#.##..####.....####..");
            Console.WriteLine(".##......##..##....##....##...##..##..........##.");
            Console.WriteLine(".##......##..##..######..##...##..######...####..");
            Console.WriteLine(".................................................\n\n");
            Console.WriteLine("Nth Prime Solver O-Matic Online..\nGuaranteed to find primes up to 2 million in under 30 seconds!\n\n");
            
        }

        static void EvaluatePassingTime(int time)
        {
            Console.WriteLine("\n");
            Console.Write("Time Check: ");

            if (time <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pass");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }
}