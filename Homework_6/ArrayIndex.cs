using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array`s length: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length;)
            {

                Console.Write("Enter array`s element: ");
                arr[i] = int.Parse(Console.ReadLine());
                {
                    for (int index = 0; index < arr.Length; index++)
                        if (index == arr[i])
                           i = index - 1;
                    {
                        Console.WriteLine();
                        Console.WriteLine("The Index is: " + i);
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}
