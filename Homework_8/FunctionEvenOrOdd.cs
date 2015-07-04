using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionEvenOrOdd
{
    class Program
    {
 
        static void Main(string[] args)
        {

            EvenOdd(2);
            EvenOdd(3);
            EvenOdd(42);
            EvenOdd(15);
            EvenOdd(7);
            Console.WriteLine();
        }

        private static int EvenOdd(int counter)
        {
            if (counter % 2 == 0)
                
            Console.WriteLine("The number is even");
            
            {
                if (counter % 2 == 1)
                    
                Console.WriteLine("The number is odd");
                return counter;
            }
        }
    }
}