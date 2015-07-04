using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOf3
{
    class Program
    {
        static void Main(string[] args)
          
        {
            for (int i = 0; i < 10 ; i++)
            {
                
                Console.WriteLine("Ënter 3 integers: ");
                Console.WriteLine();
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Result is: {0}", ParamNumbers(a, b, c));
                Console.WriteLine();
            }
 
            }     
        private static int ParamNumbers(int firstnum, int secondnum, int thirdnum)
        {

            {
                int result = (firstnum * secondnum) * thirdnum;
                return result;

            }


        }
    }
}