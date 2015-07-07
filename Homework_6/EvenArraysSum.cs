using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvens
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[3, 3]
           {
               {4,5,8},
               {12,56,7},
               {3,24,9}
           };
            int result = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)

                        result = i + j;
                    Console.WriteLine(result);
                }
            }
        }
    }

}