﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable
{
    public class PrimeTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            while (n < 1)
            {
                Console.WriteLine("Please enter a number greater than or equal to 1");
                n = int.Parse(Console.ReadLine());
            }
        }

        //Method gets the first n prime numbers
        public static List<int> getPrimes(int n)
        {
            List<int> primeNos = new List<int>();
            primeNos.Add(2); //Adds 2 by default as this is the first prime
            return primeNos;
        }
    }
}
