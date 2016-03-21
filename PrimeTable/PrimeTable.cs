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
            List<int> primeNos = getPrimes(n);
            List<int> result = multiplicationTable(primeNos);
            formatOutput(primeNos, result, n);
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

        //This method takes our list of primes and multiplies them all by each other
        public static List<int> multiplicationTable(List<int> primes)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = 0; j < primes.Count; j++)
                {
                    int temp = primes[i] * primes[j];
                    result.Add(temp);
                }
            }
            return result;
        }

        //This method formats our data into a tabular form as expected and outputs it to the console
        public static void formatOutput(List<int> primeNos, List<int> multResult, int n)
        {
            String primeRow = string.Join("\t |", primeNos.ToArray()); //formatting our prime numbers so that they have a space and | to create the table format
            Console.WriteLine("| \t |" + primeRow + "\t |"); //Printing our top line of prime numbers with the empty space in the left hand corner
        }
    }
}
