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
            Console.Write("Please enter an array value: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    result += i;

            }
             Console.WriteLine("The sum of evens is: " + result);
        }
          
        }
    }
    
