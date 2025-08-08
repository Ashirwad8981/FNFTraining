using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Problem07
    {
        static bool checkPrime(int x){

            for (int i = 2; i < x; i++) {

                if (x % i == 0) {
                    return false;
                }

         
            } 
            
         return true;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int x = int.Parse(Console.ReadLine());
            if (checkPrime(x)) {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("Not a prime");
            }
        }
    }
}
