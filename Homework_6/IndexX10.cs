using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexX10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
 
            for (int index = 0; index < n; index++)
            {

                array[index] = 10 * index;

                Console.WriteLine("The result is {0}", array[index]);
            }

        }
    }
}