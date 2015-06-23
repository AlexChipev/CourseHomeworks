using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            int curent_number = 1;

            do
            {
                int result1 = curent_number++;
                if (result1 % 7 == 0)
                {
                    Console.WriteLine("Even devided per 7: " + result1);
                    Console.WriteLine();
                    {
                        int result2 = curent_number++;
                        if (result2 % 11 == 0)
                        Console.WriteLine("Even devided per 11: " + result2);
                        Console.WriteLine();
                    }
                }
            } while (curent_number <= 100);
        }
    }
}
