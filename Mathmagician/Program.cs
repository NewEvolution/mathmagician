using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "> ";
            string splash = @"         ,/   *
      _,'/_   |
      `("")' ,'/
   _ _,-M-./ /
   \_\_\.   /    __  __       _   _                           _      _
     )"" |  (    |  \/  | __ _| |_| |__  _ __ ___   __ _  __ _(_) ___(_) __ _ _ __
  __/   M   \__ | |\/| |/ _` | __| '_ \| '_ ` _ \ / _` |/ _` | |/ __| |/ _` | '_ \
  \    /|\    / | |  | | (_| | |_| | | | | | | | | (_| | (_| | | (__| | (_| | | | |
   `--'|||`--'  |_|  |_|\__,_|\__|_| |_|_| |_| |_|\__,_|\__, |_|\___|_|\__,_|_| |_|
      ==^==                                             |___/";
            Console.WriteLine(splash);
            Console.WriteLine("What do you want me to do?");
            Console.Write(prompt);
            string[] valid_responses = new string[] { "natural numbers", "even numbers", "odd numbers", "fibonacci numbers", "prime numbers"};
            string response = Console.ReadLine().ToLower();
            if (valid_responses.Contains(response))
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                int length;
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    if (response == "natural numbers")
                    {
                        NaturalNumbers nats = new NaturalNumbers();
                        Console.WriteLine(nats.ToString(nats.GetSequence(length)));
                    }
                    if (response == "even numbers")
                    {
                        EvenNumbers even = new EvenNumbers();
                        Console.WriteLine(even.ToString(even.GetSequence(length)));
                    }
                    if (response == "odd numbers")
                    {
                        OddNumbers odd = new OddNumbers();
                        Console.WriteLine(odd.ToString(odd.GetSequence(length)));
                    }
                    if (response == "fibonacci numbers")
                    {
                        FibonacciNumbers fibonacci = new FibonacciNumbers();
                        Console.WriteLine(fibonacci.ToString(fibonacci.GetSequence(length)));
                    }
                    if (response == "prime numbers")
                    {
                        PrimeNumbers prime = new PrimeNumbers();
                        Console.WriteLine(prime.ToString(prime.GetSequence(length)));
                    }
                }
                else
                {
                    Console.WriteLine("Whoops!");
                }
            }
            else
            {
                Console.WriteLine("Nope! Do better next time.");
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
