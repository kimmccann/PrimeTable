using System;
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
            getPrimes(n);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        //Method gets the first n prime numbers
        public static List<int> getPrimes(int n)
        {
            List<int> primeNos = new List<int>();
            primeNos.Add(2); //Adds 2 by default as this is the first prime
            bool isPrimeNo = true;

            int next = 3;

            while (primeNos.Count < n)
            {
                int squareRoot = (int)Math.Sqrt(next);
                //Loop checks if our number if prime by checking if it's divisable by every prime number we've already found
                for (int i = 0; (int)primeNos[i] <= squareRoot; i++)
                {
                    isPrimeNo = true;
                    if ((next % primeNos[i]) == 0)
                    {
                        isPrimeNo = false;
                        break;
                    }
                }
                if (isPrimeNo == true)
                {
                    primeNos.Add(next);
                }
                next = next + 2;  //We do not need to check any even number as they'll all not be prime
            }
            return primeNos;
        }
    }
}
