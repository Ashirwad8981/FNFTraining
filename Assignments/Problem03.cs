using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Problem03
    {

        static void finalResultShow(int n1, int n2, char c2) {



            if (c2 == '+')
            {
                Console.WriteLine($"Result is {n1+n2}");
            }
            else if (c2 == '-')
            {
                //return n1 - n2;
                //Console.WriteLine(n1 - n2);
                Console.WriteLine($"Result is {n1 - n2}");

            }
            else if (c2 == '*')
            {
                //return n1 * n2;
                //Console.WriteLine(n1 * n2);
                Console.WriteLine($"Result is {n1 * n2}");
            }
            else if (c2 == '/')
            {
                //return n1 / n2;
                // Console.WriteLine(n1 / n2);
                Console.WriteLine($"Result is {n1 / n2}");
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }

        }


        static void calculate() {

            Console.WriteLine("Enter first number");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operations(+,-,*,/) : ");
            char c2 = char.Parse(Console.ReadLine());
            finalResultShow(n1, n2, c2);
        }
        static void Main(string[] args)
        {
        Back:
            Console.WriteLine("Welcome to Calculator.Press Y to contiune and N for exit ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'y' || ch =='Y') {
                calculate();
                goto Back;
                }

        }
    }
}
