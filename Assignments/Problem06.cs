using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    internal class Problem06
    {
        static bool isValidDate(int year, int month, int day) {
            if (day <1 ||day > 31 && month < 1 || month > 12) {
                return false;

            }
            if (year % 4 == 0) {

                if ((year % 100) == 0)
                {
                    if (year % 400 == 0 && month == 2 && day != 29)
                    {
                        return false;
                    }
                }
                else if (month == 2 && day != 29)
                {
                    return false;
                }
                

            
            }
            return true;
        }
        static void Main(string[] args)
        {

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());


            Console.WriteLine((isValidDate(year, month, day)));
        }
    }
}
