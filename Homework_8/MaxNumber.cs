using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichIsBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Bigger is: {0}", MaxNumber(MaxNumber(a, b), c));
            Console.WriteLine();
        }
        private static int MaxNumber(int a, int b)
        {
            if (a > b)
                return a;
            else return b;
        }
    }
}