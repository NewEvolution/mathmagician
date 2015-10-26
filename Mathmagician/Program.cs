﻿using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "> ";
            Console.WriteLine("What do you want me to do?");
            Console.Write(prompt);
            string[] valid_responses = new string[] { "natural numbers", "even numbers", "odd numbers", "fibonacci numbers", "prime numbers"};
            string response = Console.ReadLine().ToLower();
            if (valid_responses.Contains(response))
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                BigInteger length;
                bool parsed = BigInteger.TryParse(response_length, out length);
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
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
