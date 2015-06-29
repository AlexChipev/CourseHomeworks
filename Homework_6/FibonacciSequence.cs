using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която попълва числата на Фибоначи в масив. Потребител въвежда колко да е голям масива.

            Console.Write("Enter array`s length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];

               Console.WriteLine(array[i]);
                }    
        }
      
    }
}
